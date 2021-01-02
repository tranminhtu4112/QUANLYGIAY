using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.SanPham
{
    public partial class Tool_ThemGiay : Form
    {
        public bool isClickThem { set; get; }
        int mov, movX, movY;
        private BUS_Giay busGiay = new BUS_Giay();
        private BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        private BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        private BUS_KhuyenMai busKhuyenMai = new BUS_KhuyenMai();
        public Tool_ThemGiay()
        {
            InitializeComponent();
            LoadAllCombobox();
            this.isClickThem = false;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = openFileDialog.FileName;
                    Image m = Image.FromFile(fileName); /// bitmap(fileName)
                    ptbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptbHinh.Image = m;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Định dạng không đúng!");
            }
        }
        public void LoadAllCombobox()
        {
            loadGioiTinh();
            loadThuongHieu();
            loadKhuyenMai();
        }
        public void loadGioiTinh()
        {
            List<DTO_GioiTinh> gioiTinhs = new List<DTO_GioiTinh>();
            foreach (DataRow row in busGioiTinh.getAllGioiTinh().Rows)
            {
                DTO_GioiTinh gt = new DTO_GioiTinh();
                gt.maGioiTinh = row["MAGIOITINH"].ToString();
                gt.tenGioiTinh = row["TENGIOITINH"].ToString();
                gioiTinhs.Add(gt);
            }
            cbbGioiTinh.DataSource = gioiTinhs;
            cbbGioiTinh.DisplayMember = "tenGioiTinh";
        }
        public void loadThuongHieu()
        {
            List<DTO_ThuongHieu> thuongHieus = new List<DTO_ThuongHieu>();
            foreach (DataRow row in busThuongHieu.getAllThuongHieu().Rows)
            {
                DTO_ThuongHieu th = new DTO_ThuongHieu();
                th.maThuongHieu = row["MATHUONGHIEU"].ToString();
                th.tenThuongHieu = row["TENTHUONGHIEU"].ToString();
                thuongHieus.Add(th);
            }
            cbbThuongHieu.DataSource = thuongHieus;
            cbbThuongHieu.DisplayMember = "tenThuongHieu";
            
            
        }
        public void loadKhuyenMai()
        {
            List<DTO_KhuyenMai> khuyenMais = new List<DTO_KhuyenMai>();
            foreach (DataRow row in busKhuyenMai.getAllKhuyenMai().Rows)
            {
                DTO_KhuyenMai km = new DTO_KhuyenMai();
                km.maKhuyenMai = row["MAKHUYENMAI"].ToString();
                km.tenSuKien = row["TENSUKIEN"].ToString() +"  -"+row["PHANTRAMGIAMGIA"].ToString() + "%";
                khuyenMais.Add(km);
            }
            cbbKhuyenMai.DataSource = khuyenMais;
            cbbKhuyenMai.DisplayMember = "tenSuKien";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Object checkAndReturnGiay()
        {
            if (txbMaGiay.Text == "")
                return "Mã giày không được trống!";
            if (txbTenGiay.Text == "")
                return "Tên giày không được trống!";
            if (txbMoTa.Text == "")
                return "Mô tả không được trống!";
            if (txbSoLuong.Text == "")
                return "Số lượng không được trống!";
            if (ptbHinh.Image == null)
                return "Ảnh không được trống!";

            DTO_Giay giay = new DTO_Giay();
            giay.maGiay = txbMaGiay.Text;
            giay.TenGiay = txbTenGiay.Text;
            giay.moTa = txbMoTa.Text;
            try
            {
                giay.soLuong = int.Parse(txbSoLuong.Text);
            }
            catch (Exception)
            {

                return "Số lượng phải là số!";
            }
            giay.maGioiTinh = ((DTO_GioiTinh)cbbGioiTinh.SelectedItem).maGioiTinh;
            giay.maThuongHieu = ((DTO_ThuongHieu)cbbThuongHieu.SelectedItem).maThuongHieu;
            giay.maKhuyenMai = ((DTO_KhuyenMai)cbbKhuyenMai.SelectedItem).maKhuyenMai;

            MemoryStream stream = new MemoryStream();
            ptbHinh.Image.Save(stream, ImageFormat.Png);
            byte[] hinhAnh = stream.ToArray();

            giay.hinhAnh = hinhAnh;
            try
            {
                giay.gia = float.Parse(txbGia.Text);
            }
            catch (Exception)
            {
                return "Giá phải là số!";
            }
            return giay;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnGiay();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busGiay.addGiay((DTO_Giay)obj))
            {
                String thongBao = "Thêm mới thành công!";
                TBThemSuaXoa tBThem = new TBThemSuaXoa(thongBao);
                this.Close();
                tBThem.ShowDialog();
                this.isClickThem = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }

        private void Tool_ThemGiay_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_ThemGiay_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_ThemGiay_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
