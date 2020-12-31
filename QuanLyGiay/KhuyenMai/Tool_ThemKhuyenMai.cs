using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.KhuyenMai
{
    public partial class Tool_ThemKhuyenMai : Form
    {
        BUS_KhuyenMai busKhuyenMai = new BUS_KhuyenMai();
        public bool isClickThem { set; get; }
        int mov, movX, movY;
        public Tool_ThemKhuyenMai()
        {
            InitializeComponent();
            this.isClickThem = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_ThemKhuyenMai_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Tool_ThemKhuyenMai_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void Tool_ThemKhuyenMai_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        public Object checkAndReturnKhuyenMai()
        {
            if (txbMaKhuyenMai.Text == "")
                return "Mã khuyến mãi không được trống!";
            if (txbTenSuKien.Text == "")
                return "Tên sự kiện không được trống!";
            if (txbPhanTramGiamGia.Text == "")
                return "Phần trăm khuyến mãi không được trống!";
            String maKhuyenMai = txbMaKhuyenMai.Text;
            String tenSuKien = txbTenSuKien.Text;
            float phanTramKhuyenMai = 0;
            try
            {
                phanTramKhuyenMai = float.Parse(txbPhanTramGiamGia.Text);
            }
            catch
            {
                return "Phần trăm khuyến mãi phải là số!";
            }
            

            return new DTO_KhuyenMai(maKhuyenMai, tenSuKien, phanTramKhuyenMai);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnKhuyenMai();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busKhuyenMai.addKhuyenMai((DTO_KhuyenMai)obj))
            {
                String thongBao = "Thêm mới thành công!";
                this.Close();
                TBThemSuaXoa tBThem = new TBThemSuaXoa(thongBao);
                tBThem.ShowDialog();
                this.isClickThem = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }
    }
}
