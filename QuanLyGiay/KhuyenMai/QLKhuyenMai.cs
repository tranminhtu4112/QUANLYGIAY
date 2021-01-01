using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.KhuyenMai
{
    public partial class QLKhuyenMai : UserControl
    {
      //  BUS_KhuyenMai busKhuyenMai = new BUS_KhuyenMai();
        public QLKhuyenMai()
        {
            InitializeComponent();
         //   loadDataKhuyenMai();
        }
       /* public void loadDataKhuyenMai()
        {
            lvwKhuyenMai.Clear();
            lvwKhuyenMai.Columns.Add("STT", 100);
            lvwKhuyenMai.Columns.Add("Mã khuyến mãi", 100);
            lvwKhuyenMai.Columns.Add("Tên sự kiện", 100);
            lvwKhuyenMai.Columns.Add("Phần trăm giảm giá", 100);
            lvwKhuyenMai.FullRowSelect = true;
            lvwKhuyenMai.View = View.Details;
            int stt = 0;
            foreach (DataRow row in busKhuyenMai.getAllKhuyenMai().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                lvwKhuyenMai.Items.Add(item);
            }
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*Tool_ThemKhuyenMai toolThemKhuyenMai = new Tool_ThemKhuyenMai();
            toolThemKhuyenMai.ShowDialog();
            if (toolThemKhuyenMai.isClickThem)
            {
                loadDataKhuyenMai();
            }*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {/*
            if (lvwKhuyenMai.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwKhuyenMai.SelectedItems[0];
                    if (busKhuyenMai.deleteKhuyenMai(item.SubItems[1].Text))
                    {
                        String thongBao = "Xóa thành công!";
                        TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                        tBThemSuaXoa.ShowDialog();
                        loadDataKhuyenMai();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm!");
                    }
                }
            }*/
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
           /* if (lvwKhuyenMai.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwKhuyenMai.SelectedItems[0];
                DTO_KhuyenMai dtoKhuyenMai = new DTO_KhuyenMai();
                dtoKhuyenMai.maKhuyenMai = item.SubItems[1].Text;
                dtoKhuyenMai.tenSuKien = item.SubItems[2].Text;
                dtoKhuyenMai.phanTramGiamGia = float.Parse(item.SubItems[3].Text);

                Tool_SuaKhuyenMai toolSuaKhuyenMai = new Tool_SuaKhuyenMai(dtoKhuyenMai);
                toolSuaKhuyenMai.ShowDialog();
                if (toolSuaKhuyenMai.isClickSua)
                {
                    loadDataKhuyenMai();
                }
            }*/
        }
    }
}
