using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class TBThemSuaXoa : Form
    {
        int mov, movX, movY;
        public TBThemSuaXoa()
        {
            InitializeComponent();
        }
        public TBThemSuaXoa(String thongBao)
        {
            InitializeComponent();
            lblThongBao.Text = thongBao;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBThem_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void TBThem_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void TBThem_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
