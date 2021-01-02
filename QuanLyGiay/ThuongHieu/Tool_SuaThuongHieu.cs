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

namespace GUI_QuanLyGiay
{

    public partial class Tool_SuaThuongHieu : Form
    {
        public BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        int mov, movX, movY;
        public DTO_ThuongHieu dtoThuongHieu { get; set; }
        public bool isClickSua { get; set; }
        
        public Tool_SuaThuongHieu()
        {
            InitializeComponent();
        }
        public Tool_SuaThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            InitializeComponent();
            this.dtoThuongHieu = dtoThuongHieu;
            this.isClickSua = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_SuaThuongHieu_Load(object sender, EventArgs e)
        {
            txbMaThuongHieu.Text = this.dtoThuongHieu.maThuongHieu;
            txbTenThuongHieu.Text = this.dtoThuongHieu.tenThuongHieu;
            txbMoTa.Text = this.dtoThuongHieu.moTa;
        }
        public Object checkAndReturnThuongHieu()
        {
            if (txbTenThuongHieu.Text == "")
                return "Tên thương hiệu không được trống!";
            if (ptbHinh.Image == null)
                return "Ảnh không được trống!";

            String maThuongHieu = txbMaThuongHieu.Text;
            String tenThuongHieu = txbTenThuongHieu.Text;
            String moTa = txbMoTa.Text;

            MemoryStream stream = new MemoryStream();
            ptbHinh.Image.Save(stream, ImageFormat.Png);
            byte[] hinhAnh = stream.ToArray();

            return new DTO_ThuongHieu(maThuongHieu, tenThuongHieu, moTa, hinhAnh);
        }
        private void btnLuuMoi_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnThuongHieu();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busThuongHieu.editThuongHieu((DTO_ThuongHieu)obj))
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
        private void Tool_SuaThuongHieu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_SuaThuongHieu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Tool_SuaThuongHieu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
