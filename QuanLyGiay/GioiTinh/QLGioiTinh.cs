using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.GioiTinh
{
    public partial class QLGioiTinh : UserControl
    {
        BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        public QLGioiTinh()
        {
            InitializeComponent();
            loadDataGioiTinh();
        }

        public void loadDataGioiTinh()
        {
            lvwGioiTinh.Clear();
            lvwGioiTinh.Columns.Add("STT", 100);
            lvwGioiTinh.Columns.Add("Mã giới tính", 100);
            lvwGioiTinh.Columns.Add("Tên giới tính", 100);
            lvwGioiTinh.Columns.Add("mô tả", 100);
            lvwGioiTinh.FullRowSelect = true;
            lvwGioiTinh.View = View.Details;
            int stt = 0;
            foreach (DataRow row in busGioiTinh.getAllGioiTinh().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                lvwGioiTinh.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Tool_ThemGioiTinh toolThemGioiTinh = new Tool_ThemGioiTinh();
            toolThemGioiTinh.ShowDialog();
            if (toolThemGioiTinh.isClickThem)
            {
                loadDataGioiTinh();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwGioiTinh.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwGioiTinh.SelectedItems[0];
                DTO_GioiTinh dtoGioiTinh = new DTO_GioiTinh();
                dtoGioiTinh.maGioiTinh = item.SubItems[1].Text;
                dtoGioiTinh.tenGioiTinh = item.SubItems[2].Text;
                dtoGioiTinh.moTa = item.SubItems[3].Text;

                Tool_SuaGioiTinh toolSuaGioiTinh = new Tool_SuaGioiTinh(dtoGioiTinh);
                toolSuaGioiTinh.ShowDialog();
                if (toolSuaGioiTinh.isClickSua)
                {
                    loadDataGioiTinh();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwGioiTinh.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwGioiTinh.SelectedItems[0];
                    if (busGioiTinh.deleteGioiTinh(item.SubItems[1].Text))
                    {
                        String thongBao = "Xóa thành công!";
                        TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                        tBThemSuaXoa.ShowDialog();
                        loadDataGioiTinh();
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
