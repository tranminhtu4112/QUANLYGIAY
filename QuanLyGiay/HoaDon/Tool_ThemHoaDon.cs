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

namespace GUI_QuanLyGiay.HoaDon
{
    public partial class Tool_ThemHoaDon : Form
    {
        int mov, movX, movY;
        public String maHoaDon { set; get; }
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        private BUS_Giay busGiay = new BUS_Giay();
        public bool isClickTao { set; get; }
        public Tool_ThemHoaDon()
        {
            InitializeComponent();
            taoCollView();
            this.isClickTao = false;
        }
        public Tool_ThemHoaDon(String maHoaDon)
        {
            InitializeComponent();
            taoCollView();
            this.maHoaDon = maHoaDon;
            this.isClickTao = false;
        }
        public void resetGiayChiTietHoaDon()
        {
            DataTable dt = busChiTietHoaDon.getMaGiayandSoLuongByMaHoaDon(this.maHoaDon);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int soLuong = int.Parse(row[2].ToString()) + int.Parse(row[1].ToString());
                    busGiay.UpdateSoLuong(row[0].ToString(), soLuong);
                }
            }
                busChiTietHoaDon.deleteChiTietHoaDon(txbMaHoaDon.Text);
                busHoaDon.deleteHoaDon(txbMaHoaDon.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resetGiayChiTietHoaDon();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetGiayChiTietHoaDon();
            this.Close();
        }

        private void Tool_ThemHoaDon_Load(object sender, EventArgs e)
        {
            txbMaHoaDon.Text = this.maHoaDon;
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

            foreach (DataRow row in busChiTietHoaDon.getViewChiTietHoaDonByMaHoaDon(this.maHoaDon).Rows)
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
            Tool_ChonSanPham tooChonSanPham = new Tool_ChonSanPham(maHoaDon);
            tooChonSanPham.ShowDialog();
            loadDataChiTIetHoaDon();
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
                    DataTable dt = busChiTietHoaDon.get2SoLuongbyMaHoaDonandMaGiay(this.maHoaDon, item.SubItems[2].Text.ToString());
                    foreach (DataRow row in dt.Rows)
                    {
                        int soLuong = int.Parse(row[0].ToString()) + int.Parse(row[1].ToString());
                        busGiay.UpdateSoLuong(item.SubItems[2].Text.ToString(), soLuong);
                    }

                    if (busChiTietHoaDon.deleteChiTietHoaDon(this.maHoaDon, item.SubItems[2].Text.ToString()))
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
                DataTable dt = busChiTietHoaDon.getMaGiayandSoLuongByMaHoaDon(this.maHoaDon);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        soLuongConlai = int.Parse(row[2].ToString());
                    }
                }
                int soLuongToiDa = soLuongNhapCu + soLuongConlai;
                Tool_NhapSoLuong toolNhapSoLuong = new Tool_NhapSoLuong(this.maHoaDon, maGiay, soLuongToiDa, soLuongNhapCu, phanTramGiamGia, gia);
                toolNhapSoLuong.ShowDialog();
                if (toolNhapSoLuong.isClickThem)
                {
                    loadDataChiTIetHoaDon();
                }
            }
        }
        public Object checkAndReturnHoaDon()
        {
            if (lvwSanPhamMua.Items.Count == 0)
                return "Không có sản phẩm để tạo hóa đơn!";
            if (txbTenKhachHang.Text == "")
                return "Tên khách hàng không được trống!";

            String maHoaDon = txbMaHoaDon.Text;
            String tenKhachHang = txbTenKhachHang.Text;
            String[] giaString = lblTongCong.Text.ToString().Split(" ");
            float gia = float.Parse(giaString[0]);
            return new DTO_HoaDon(maHoaDon, "MNV01", tenKhachHang, gia);
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnHoaDon();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busHoaDon.updateHoaDon((DTO_HoaDon)obj))
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

        private void Tool_ThemHoaDon_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Tool_ThemHoaDon_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_ThemHoaDon_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
