using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.HoaDon
{
    public partial class QLHoaDon : UserControl
    {
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           String maHoaDon = "MHD" + busHoaDon.getMaxID();
            DTO_HoaDon dtoHoaDon = new DTO_HoaDon(maHoaDon, "", "", 0);
            if (busHoaDon.addHoaDon(dtoHoaDon))
            {
                Tool_ThemHoaDon toolThemHoaDon = new Tool_ThemHoaDon(maHoaDon);
                toolThemHoaDon.Show();
                return;
            }
            MessageBox.Show("Lỗi phần mềm!");
        }
    }
}
