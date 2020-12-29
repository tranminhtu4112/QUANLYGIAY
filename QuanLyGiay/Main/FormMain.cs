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
        public FormMain()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            trangChu1.BringToFront();
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
