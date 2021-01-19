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
    public partial class Tool_SuaGiay : Form
    {
        public BUS_Giay busGiay = new BUS_Giay();
        public BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        public BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        public BUS_KhuyenMai busKhuyenMai = new BUS_KhuyenMai();
        int mov, movX, movY;
        public DTO_Giay dtoGiay { get; set; }
        public DTO_GioiTinh dtoGioiTinh { get; set; }
        public DTO_ThuongHieu dtoThuongHieu { get; set; }
        public DTO_KhuyenMai dtoKhuyenMai { get; set; }
        public bool isClickSua { get; set; }
        public Tool_SuaGiay()
        {
            InitializeComponent();
        }
        public Tool_SuaGiay(DTO_Giay dtoGiay, DTO_GioiTinh dtoGioiTinh, DTO_ThuongHieu dtoThuongHieu, DTO_KhuyenMai dtoKhuyenMai)
        {
            InitializeComponent();
            this.dtoGiay = dtoGiay;
            this.dtoGioiTinh = dtoGioiTinh;
            this.dtoThuongHieu = dtoThuongHieu;
            this.dtoKhuyenMai = dtoKhuyenMai;
            isClickSua = false;
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
                km.tenSuKien = row["TENSUKIEN"].ToString() + "  -" + row["PHANTRAMGIAMGIA"].ToString() + "%";
                khuyenMais.Add(km);
            }
            cbbKhuyenMai.DataSource = khuyenMais;
            cbbKhuyenMai.DisplayMember = "tenSuKien";
        }
        public void loadImage()
        {
            DataTable dtImg = busGiay.getGiayByMaGiay(txbMaGiay.Text);
            MemoryStream memoryStream = new MemoryStream((Byte[])dtImg.Rows[0][6]);
            Image img = Image.FromStream(memoryStream);
            ptbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbHinh.Image = img;
        }
        private void Tool_SuaGiay_Load(object sender, EventArgs e)
        {
            txbMaGiay.Text = this.dtoGiay.maGiay;
            txbTenGiay.Text = this.dtoGiay.TenGiay;
            txbMoTa.Text = this.dtoGiay.moTa;
            txbSoLuong.Text = this.dtoGiay.soLuong.ToString();
            txbGia.Text = this.dtoGiay.gia.ToString();
            LoadAllCombobox();
            loadImage();
        }
        public Object checkAndReturnGiay()
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuMoi_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnGiay();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busGiay.editGiay((DTO_Giay)obj))
            {
                String thongBao = "Sửa mới thành công!";
                TBThemSuaXoa tBSua = new TBThemSuaXoa(thongBao);
                tBSua.ShowDialog();
                this.Close();
                this.isClickSua = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
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

        private void Tool_SuaGiay_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_SuaGiay_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_SuaGiay_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
