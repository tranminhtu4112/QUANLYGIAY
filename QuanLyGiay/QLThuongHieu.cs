using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay
{
    public partial class QLThuongHieu : UserControl
    {
        BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        public QLThuongHieu()
        {
            InitializeComponent();
            loadDatathuongHieu();
        }
        public void loadDatathuongHieu()
        {
            lvwThuongHieu.Clear();
            lvwThuongHieu.Columns.Add("Hình ảnh", 60);
            lvwThuongHieu.Columns.Add("STT", 60);
            lvwThuongHieu.Columns.Add("Mã Thương hiệu", 60);
            lvwThuongHieu.Columns.Add("Tên Thương hiệu", 60);
            lvwThuongHieu.Columns.Add("Mô tả", 60);

            lvwThuongHieu.FullRowSelect = true;
            lvwThuongHieu.View = View.Details;
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);

            foreach (DataRow row in busThuongHieu.getAllThuongHieu().Rows)
            {
                if(row[4] == null)
                {
                    MemoryStream memoryStream = new MemoryStream((Byte[])row[4]);
                    Image img = Image.FromStream(memoryStream);
                    imgs.Images.Add(img);
                }
            }

            int stt = 0;
            lvwThuongHieu.SmallImageList = imgs;
            foreach (DataRow row in busThuongHieu.getAllThuongHieu().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.ImageIndex = stt - 1;
                lvwThuongHieu.Items.Add(item);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
