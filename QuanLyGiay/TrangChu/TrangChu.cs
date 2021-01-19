using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class TrangChu : UserControl
    {
        private BUS_Giay busGiay = new BUS_Giay();
        public TrangChu()
        {
            InitializeComponent();
            loadDataGiay();
        }
        public void loadDataGiay()
        {
            lvwSanPhamTrangChu.Clear();

            lvwSanPhamTrangChu.View = View.LargeIcon;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(180, 220);

            int stt = 0;
            foreach (DataRow row in busGiay.getViewTrangChu().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(row[1].ToString() + " - " + row[3].ToString() + " VND");

                MemoryStream memoryStream = new MemoryStream((Byte[])row[2]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwSanPhamTrangChu.LargeImageList = imgList;
                item.ImageIndex = stt - 1;
                lvwSanPhamTrangChu.Items.Add(item);
            }
            lblTongSanPham.Text = stt.ToString() + " sản phẩm";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGiay();
        }
    }
}
