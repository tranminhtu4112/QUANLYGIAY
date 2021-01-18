using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using GUI_QuanLyGiay;

namespace QuanLyGiay
{
    public partial class FormMain : Form
    {
        int mov, movX, movY;
        public DTO_DangNhap dtoDangNhap { set; get; }
        public FormMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            trangChu1.BringToFront();
        }
        public FormMain(DTO_DangNhap dtoDangNhap)
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            trangChu1.BringToFront();
            this.dtoDangNhap = dtoDangNhap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            trangChu1.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            qlSanPham1.BringToFront();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void btnQLThuongHieu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnQLThuongHieu.Height;
            SidePanel.Top = btnQLThuongHieu.Top;
            qlThuongHieu1.BringToFront();
        }

        private void btnQLGioiTinh_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnQLGioiTinh.Height;
            SidePanel.Top = btnQLGioiTinh.Top;
            qlGioiTinh1.BringToFront();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnKhuyenMai.Height;
            SidePanel.Top = btnKhuyenMai.Top;
            qlKhuyenMai1.BringToFront();
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDonDatHang.Height;
            SidePanel.Top = btnDonDatHang.Top;
            qlDonDatHang1.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHoaDon.Height;
            SidePanel.Top = btnHoaDon.Top;
            qlHoaDon1.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThongKe.Height;
            SidePanel.Top = btnThongKe.Top;
            qlThongKe1.BringToFront();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            String[] name = this.dtoDangNhap.tenNhanVien.ToString().Split(" ");
            txbChaoNhanVien.Text = name[name.Length - 1].ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.dtoDangNhap = null;
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void qlKhuyenMai1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
