using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class DangNhap : Form
    {
        int mov, movX, movY;
        BUS_DangNhap busDangNhap = new BUS_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txbUserName.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.WhiteSmoke;
            txbPassword.ForeColor = Color.WhiteSmoke;
            
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
            txbPassword.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(128, 0, 255);
            txbPassword.ForeColor = Color.FromArgb(128, 0, 255);
            panel2.BackColor = Color.WhiteSmoke;
            txbUserName.ForeColor = Color.WhiteSmoke;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DTO_DangNhap dTO_DangNhap = new DTO_DangNhap();
            dTO_DangNhap.userName = txbUserName.Text;
            dTO_DangNhap.password = txbPassword.Text;
            dTO_DangNhap = busDangNhap.getUser(dTO_DangNhap);
            if (dTO_DangNhap != null)
            {
                FormMain formMain = new FormMain(dTO_DangNhap);
                formMain.ShowDialog();
            }
            else
            {
                lblLoiDangNhap.Text = "Tài khoản hoặc mật khẩu không đung!";
            }
        }
        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if(lblLoiDangNhap.Text.Length != 0)
            {
                lblLoiDangNhap.Text = "";
            }
        }
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            if (lblLoiDangNhap.Text.Length != 0)
            {
                lblLoiDangNhap.Text = "";
            }
        }

        private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void DangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void DangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
