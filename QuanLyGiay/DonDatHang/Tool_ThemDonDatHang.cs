using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.DonDatHang
{
    public partial class Tool_ThemDonDatHang : Form
    {
        int mov, movX, movY;
        private BUS_ChiTietDonDatHang busChiTietDonDatHang = new BUS_ChiTietDonDatHang();
        private BUS_DonDatHang busDonDatHang = new BUS_DonDatHang();
        private BUS_Giay busGiay = new BUS_Giay();

        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        public String maDonDatHang { set; get; }
        public bool isClickTao { set; get; }
        public Tool_ThemDonDatHang()
        {
            InitializeComponent();
            this.isClickTao = false;
        }
        public Tool_ThemDonDatHang(String maDonDatHang)
        {
            InitializeComponent();
            this.isClickTao = false;
            this.maDonDatHang = maDonDatHang;
        }
        public void resetGiayChiTietDonDatHang()
        {
            DataTable dt = busChiTietDonDatHang.getMaGiayandSoLuongByMaDonDatHang(this.maDonDatHang);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int soLuong = int.Parse(row[2].ToString()) + int.Parse(row[1].ToString());
                    busGiay.UpdateSoLuong(row[0].ToString(), soLuong);
                }
            }
                busChiTietDonDatHang.delelteChiTietDonDatHang(txbMaHoaDon.Text);
                busDonDatHang.deleteDonDatHang(txbMaHoaDon.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resetGiayChiTietDonDatHang();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetGiayChiTietDonDatHang();
            this.Close();
        }
        public void taoCollView()
        {
            lvwSanPhamMua.Clear();
            lvwSanPhamMua.Columns.Add("Hình ảnh", 100);
            lvwSanPhamMua.Columns.Add("STT", 40);
            lvwSanPhamMua.Columns.Add("Mã", 60);
            lvwSanPhamMua.Columns.Add("Tên", 100);
            lvwSanPhamMua.Columns.Add("Số lượng", 60);
            lvwSanPhamMua.Columns.Add("Khuyến mãi", 80);
            lvwSanPhamMua.Columns.Add("Giá gốc", 100);
            lvwSanPhamMua.Columns.Add("Giá khuyến mãi", 100);

            lvwSanPhamMua.FullRowSelect = true;
            lvwSanPhamMua.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(90, 90);
        }
        public void loadDataChiTIetHoaDon()
        {
            lvwSanPhamMua.Clear();
            lvwSanPhamMua.Columns.Add("Hình ảnh", 100);
            lvwSanPhamMua.Columns.Add("STT", 40);
            lvwSanPhamMua.Columns.Add("Mã", 60);
            lvwSanPhamMua.Columns.Add("Tên", 100);
            lvwSanPhamMua.Columns.Add("Số lượng", 60);
            lvwSanPhamMua.Columns.Add("Khuyến mãi", 80);
            lvwSanPhamMua.Columns.Add("Giá gốc", 100);
            lvwSanPhamMua.Columns.Add("Giá khuyến mãi", 100);

            lvwSanPhamMua.FullRowSelect = true;
            lvwSanPhamMua.View = View.Details;
            int stt = 0;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(90, 90);
            float tongCong = 0f;

            foreach (DataRow row in busChiTietDonDatHang.getViewChiTietDonDatHangByMaDonDatHang(this.maDonDatHang).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[6].ToString());
                tongCong += float.Parse(row[6].ToString());
                MemoryStream memoryStream = new MemoryStream((Byte[])row[0]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwSanPhamMua.SmallImageList = imgList;
                item.ImageIndex = stt - 1;

                lvwSanPhamMua.Items.Add(item);
            }
            lblTongCong.Text = tongCong.ToString() + "  (VND)";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String maHoaDon = txbMaHoaDon.Text;
            Tool_ChonDatSanPham toolChonDatSanPham = new Tool_ChonDatSanPham(maHoaDon);
            toolChonDatSanPham.ShowDialog();
            loadDataChiTIetHoaDon();
        }

        private void Tool_ThemDonDatHang_Load(object sender, EventArgs e)
        {
            txbMaHoaDon.Text = this.maDonDatHang;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwSanPhamMua.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwSanPhamMua.SelectedItems[0];
                    DataTable dt = busChiTietDonDatHang.get2SoLuongbyMaHoaDonandMaGiay(this.maDonDatHang, item.SubItems[2].Text.ToString());
                    foreach (DataRow row in dt.Rows)
                    {
                        int soLuong = int.Parse(row[0].ToString()) + int.Parse(row[1].ToString());
                        busGiay.UpdateSoLuong(item.SubItems[2].Text.ToString(), soLuong);
                    }

                    if (busChiTietDonDatHang.deleteChiTietDonDatHang(this.maDonDatHang, item.SubItems[2].Text.ToString()))
                    {
                        String thongBao = "Xóa thành công!";
                        TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                        tBThemSuaXoa.ShowDialog();
                        loadDataChiTIetHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm!");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwSanPhamMua.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwSanPhamMua.SelectedItems[0];
                String maGiay = item.SubItems[2].Text.ToString();
                int soLuongNhapCu = int.Parse(item.SubItems[4].Text.ToString());
                float phanTramGiamGia = float.Parse(item.SubItems[5].Text.ToString());
                String[] giaString = item.SubItems[6].Text.ToString().Split(" ");
                float gia = float.Parse(giaString[0]);
                int soLuongConlai = 0;
                DataTable dt = busChiTietDonDatHang.getMaGiayandSoLuongByMaHoaDon(this.maDonDatHang);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        soLuongConlai = int.Parse(row[2].ToString());
                    }
                }
                int soLuongToiDa = soLuongNhapCu + soLuongConlai;
                Tool_NhapSoLuongDatHang toolNhapSoLuongDatHang = new Tool_NhapSoLuongDatHang(this.maDonDatHang, maGiay, soLuongToiDa, soLuongNhapCu, phanTramGiamGia, gia);
                toolNhapSoLuongDatHang.ShowDialog();
                if (toolNhapSoLuongDatHang.isClickThem)
                {
                    loadDataChiTIetHoaDon();
                }
            }
        }
        public Object checkAndReturnDonDatHang()
        {
            if (lvwSanPhamMua.Items.Count == 0)
                return "Không có sản phẩm để tạo hóa đơn!";
            if (txbTenKhachHang.Text == "")
                return "Tên khách hàng không được trống!";
            if (txbSoDienThoai.Text == "")
                return "Số điện thoại không được trống!";
            if (txbDiaChi.Text == "")
                return "Địa chỉ không được trống!"; 

            String maHoaDon = txbMaHoaDon.Text;
            String tenKhachHang = txbTenKhachHang.Text;
            String[] giaString = lblTongCong.Text.ToString().Split(" ");
            float gia = float.Parse(giaString[0]);
            String soDienThoai = txbSoDienThoai.Text;
            String diaChiGiao = txbDiaChi.Text;
            String[] dateTime = dtpNgayGiao.Value.ToString().Split(" ");
            String[] date = dateTime[0].Split("/");
            String dateMain = date[1] + "-" + date[0] + "-" + date[2];

            return new DTO_DonDatHang(maHoaDon, "MNV01", tenKhachHang, soDienThoai, diaChiGiao, dateMain, gia, 1);
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnDonDatHang();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busDonDatHang.updateDonDatHang((DTO_DonDatHang)obj))
            {
                String thongBao = "Thêm mới thành công!";
                TBThemSuaXoa tBThem = new TBThemSuaXoa(thongBao);
                this.Close();
                tBThem.ShowDialog();
                this.isClickTao = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }

        private void Tool_ThemDonDatHang_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_ThemDonDatHang_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_ThemDonDatHang_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
