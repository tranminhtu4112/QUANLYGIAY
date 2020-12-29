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

namespace GUI_QuanLyGiay.ThuongHieu
{
    public partial class Tool_ThemThuongHieu : Form
    {
        int mov, movX, movY;
        public Tool_ThemThuongHieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_ThemThuongHieu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_ThemThuongHieu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
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
        private void Tool_ThemThuongHieu_Load(object sender, EventArgs e)
        {
            txbMaThuongHieu.Focus();
        }

        private void Tool_ThemThuongHieu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        public Object checkAndReturnThuongHieu()
        {
            if (txbMaThuongHieu.Text == "")
                return "Mã thương hiệu không được trống!";
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
    }
}
