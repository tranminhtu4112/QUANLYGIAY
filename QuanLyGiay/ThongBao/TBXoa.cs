using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class TBXoa : Form
    {
        public bool isClickXoa { set; get; }
        int mov, movX, movY;
        public TBXoa()
        {
            InitializeComponent();
            this.isClickXoa = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.isClickXoa = true;
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
