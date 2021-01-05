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
    public partial class Tool_ThemHoaDon : Form
    {
        public String maHoaDon { set; get; }
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        public Tool_ThemHoaDon()
        {
            InitializeComponent();
            taoCollView();
           
        }
        public Tool_ThemHoaDon(String maHoaDon)
        {
            InitializeComponent();
            taoCollView();
            this.maHoaDon = maHoaDon;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!busHoaDon.deleteHoaDon(txbMaHoaDon.Text))
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!busHoaDon.deleteHoaDon(txbMaHoaDon.Text))
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
            this.Close();
        }

        private void Tool_ThemHoaDon_Load(object sender, EventArgs e)
        {
            txbMaHoaDon.Text = this.maHoaDon;
        }
        public void taoCollView()
        {
            lvwSanPhamMua.Clear();
            lvwSanPhamMua.Columns.Add("Hình ảnh", 90);
            lvwSanPhamMua.Columns.Add("STT", 40);
            lvwSanPhamMua.Columns.Add("Tên", 90);
            lvwSanPhamMua.Columns.Add("Số lượng", 60);
            lvwSanPhamMua.Columns.Add("Khuyến mãi", 80);
            lvwSanPhamMua.Columns.Add("Giá gốc", 100);
            lvwSanPhamMua.Columns.Add("Giá khuyến mãi", 100);

            lvwSanPhamMua.FullRowSelect = true;
            lvwSanPhamMua.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(100, 100);
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            String maHoaDon = txbMaHoaDon.Text;
            Tool_ChonSanPham tooChonSanPham = new Tool_ChonSanPham(maHoaDon);
            tooChonSanPham.ShowDialog();
            if (tooChonSanPham.isClickThoat)
            {

            }
        }
    }
}
