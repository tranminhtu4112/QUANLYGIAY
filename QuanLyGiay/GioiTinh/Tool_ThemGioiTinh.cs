using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.GioiTinh
{
    public partial class Tool_ThemGioiTinh : Form
    {
        BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        public bool isClickThem { set; get; }
        int mov, movX, movY;
        public Tool_ThemGioiTinh()
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
        private void Tool_ThemGioiTinh_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Tool_ThemGioiTinh_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        
        private void Tool_ThemGioiTinh_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        public Object checkAndReturnGioiTinh()
        {
            if (txbMaGioiTinh.Text == "")
                return "Mã giới tính không được trống!";
            if (txbTenGioiTinh.Text == "")
                return "Tên giới tính không được trống!";

            String maGioiTinh = txbMaGioiTinh.Text;
            String TenGioiTinh = txbTenGioiTinh.Text;
            String moTa = txbMoTa.Text;

            return new DTO_GioiTinh(maGioiTinh, TenGioiTinh, moTa);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnGioiTinh();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busGioiTinh.addGioiTinh((DTO_GioiTinh)obj))
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
