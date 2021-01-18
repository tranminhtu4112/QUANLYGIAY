using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.HoaDon
{
    public partial class Tool_XemChiTiet : Form
    {
        int mov, movX, movY;
        private BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        public String maHoaDon { set; get; }
        public String tenKhachHang { set; get; }
        public Tool_XemChiTiet()
        {
            InitializeComponent();
        }
        public Tool_XemChiTiet(String maHoaDon, String tenKhachHang)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.tenKhachHang = tenKhachHang;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadDataChiTIetHoaDon()
        {
            lvwSanPhamMua.Clear();
            lvwSanPhamMua.Columns.Add("Hình ảnh", 100);
            lvwSanPhamMua.Columns.Add("STT", 40);
            lvwSanPhamMua.Columns.Add("Mã", 60);
            lvwSanPhamMua.Columns.Add("Tên", 100);
            lvwSanPhamMua.Columns.Add("Số lượng", 60);
            lvwSanPhamMua.Columns.Add("Khuyến mãi", 80);
            lvwSanPhamMua.Columns.Add("Giá gốc", 100);
            lvwSanPhamMua.Columns.Add("Giá khuyến mãi", 100);

            lvwSanPhamMua.FullRowSelect = true;
            lvwSanPhamMua.View = View.Details;
            int stt = 0;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(90, 90);
            float tongCong = 0f;

            foreach (DataRow row in busChiTietHoaDon.getViewChiTietHoaDonByMaHoaDon(this.maHoaDon).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[6].ToString());
                tongCong += float.Parse(row[6].ToString());
                MemoryStream memoryStream = new MemoryStream((Byte[])row[0]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwSanPhamMua.SmallImageList = imgList;
                item.ImageIndex = stt - 1;

                lvwSanPhamMua.Items.Add(item);
            }
            lblMaHoaDon.Text = this.maHoaDon;
            lblTenKhachHang.Text = this.tenKhachHang;
            lblTongCong.Text = tongCong.ToString() + "  (VND)";
        }
        private void Tool_XemChiTiet_Load(object sender, EventArgs e)
        {
            loadDataChiTIetHoaDon();
        }

        private void Tool_XemChiTiet_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_XemChiTiet_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_XemChiTiet_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
