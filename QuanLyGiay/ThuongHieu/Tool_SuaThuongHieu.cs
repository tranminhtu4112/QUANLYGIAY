using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{

    public partial class Tool_SuaThuongHieu : Form
    {
        int mov, movX, movY;
        public DTO_ThuongHieu dtoThuongHieu { get; set; }
        public Tool_SuaThuongHieu()
        {
            InitializeComponent();
        }
        public Tool_SuaThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            InitializeComponent();
            this.dtoThuongHieu = dtoThuongHieu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_SuaThuongHieu_Load(object sender, EventArgs e)
        {
            txbMaThuongHieu.Text = dtoThuongHieu.maThuongHieu;
            txbTenThuongHieu.Text = dtoThuongHieu.tenThuongHieu;
            txbMoTa.Text = dtoThuongHieu.moTa;
        }

        private void Tool_SuaThuongHieu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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
