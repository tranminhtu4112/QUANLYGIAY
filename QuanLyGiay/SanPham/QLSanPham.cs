using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class QLSanPham : UserControl
    {
       
        public QLSanPham()
        {
            InitializeComponent();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBXoa tBXoa = new TBXoa();
            tBXoa.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TBThem tBThem = new TBThem();
            tBThem.ShowDialog();
        }
    }
}
