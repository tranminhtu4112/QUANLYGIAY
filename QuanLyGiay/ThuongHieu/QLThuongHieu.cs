using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using GUI_QuanLyGiay.ThuongHieu;
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
            lvwThuongHieu.Columns.Add("Hình ảnh", 110);
            lvwThuongHieu.Columns.Add("STT", 70);
            lvwThuongHieu.Columns.Add("Mã Thương hiệu", 150);
            lvwThuongHieu.Columns.Add("Tên Thương hiệu", 200);
            lvwThuongHieu.Columns.Add("Mô tả", 200);

            lvwThuongHieu.FullRowSelect = true;
            lvwThuongHieu.View = View.Details;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(100, 100);

            int stt = 0;
            foreach (DataRow row in busThuongHieu.getAllThuongHieu().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());

                MemoryStream memoryStream = new MemoryStream((Byte[])row[4]);
                Image img = Image.FromStream(memoryStream);
                imgList.Images.Add(img);
                lvwThuongHieu.SmallImageList = imgList;
                item.ImageIndex = stt - 1;

                lvwThuongHieu.Items.Add(item);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDatathuongHieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwThuongHieu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwThuongHieu.SelectedItems[0];
                DTO_ThuongHieu dtoThuongHieu = new DTO_ThuongHieu();
                dtoThuongHieu.maThuongHieu = item.SubItems[2].Text;
                dtoThuongHieu.tenThuongHieu = item.SubItems[3].Text;
                dtoThuongHieu.moTa = item.SubItems[4].Text;

                Tool_SuaThuongHieu toolSuaThuongHieu = new Tool_SuaThuongHieu(dtoThuongHieu);
                toolSuaThuongHieu.ShowDialog();
                if (toolSuaThuongHieu.isClickSua)
                {
                    loadDatathuongHieu();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Tool_ThemThuongHieu toolThemThuongHieu = new Tool_ThemThuongHieu();
            toolThemThuongHieu.ShowDialog();
            if (toolThemThuongHieu.isClickThem)
            {
                loadDatathuongHieu();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwThuongHieu.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwThuongHieu.SelectedItems[0];
                    if (busThuongHieu.deleteThuongHieu(item.SubItems[2].Text))
                    {
                        String thongBao = "Xóa thành công!";
                        TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                        tBThemSuaXoa.ShowDialog();
                        loadDatathuongHieu();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm!");
                    }
                }
            }
        }
    }
}
