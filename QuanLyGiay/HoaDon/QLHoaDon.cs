using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
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
    public partial class QLHoaDon : UserControl
    {
        public DTO_DangNhap dtoDangNhap { get; set; }
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        public QLHoaDon()
        {
            InitializeComponent();
            taoCollView();
            loadDataHonDon();
            loadDataSapXepCombobox();
        }
        public void taoCollView()
        {
            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;
        }
        public void loadDataHonDon()
        {
            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewHoaDon().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());

                lvwHoaDon.Items.Add(item);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String maHoaDon = "MHD" + (busHoaDon.getMaxID() + 1);
            DTO_HoaDon dtoHoaDon = new DTO_HoaDon(maHoaDon, "MVN01", "", 0);
            if (busHoaDon.addHoaDon(dtoHoaDon))
            {
                Tool_ThemHoaDon toolThemHoaDon = new Tool_ThemHoaDon(maHoaDon);
                toolThemHoaDon.ShowDialog();
                if (toolThemHoaDon.isClickTao)
                {
                    loadDataHonDon();
                }
                return;
            }
            MessageBox.Show("Lỗi phần mềm!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwHoaDon.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwHoaDon.SelectedItems[0];
                    if (busChiTietHoaDon.deleteChiTietHoaDon(item.SubItems[1].Text))
                    {
                        if (busHoaDon.deleteHoaDon(item.SubItems[1].Text))
                        {
                            String thongBao = "Xóa thành công!";
                            TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                            tBThemSuaXoa.ShowDialog();
                            loadDataHonDon();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi phần mềm!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm!");
                    }
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lvwHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwHoaDon.SelectedItems[0];
                Tool_XemChiTiet toolXemChiTiet = new Tool_XemChiTiet(item.SubItems[1].Text, item.SubItems[3].Text);
                toolXemChiTiet.ShowDialog();
            }
        }
        public void loadDataSapXepCombobox()
        {
            Dictionary<string, string> sapXeps = new Dictionary<string, string>();
            sapXeps.Add("", "Mặc định");
            sapXeps.Add("ORDER BY date DESC", "Đơn mới nhất");
            sapXeps.Add("ORDER BY date ASC", "Đon cũ nhất");

            cbbSapXep.DataSource = new BindingSource(sapXeps, null);
            cbbSapXep.DisplayMember = "Value";
            cbbSapXep.ValueMember = "Key";
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbbSapXep.SelectedItem).Key;
            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewSapXep(value).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());

                lvwHoaDon.Items.Add(item);
            }
        }
        private void btnLocMot_Click(object sender, EventArgs e)
        {
            String[] dateTime = dtpLocMot.Value.ToString().Split(" ");
            String[] date = dateTime[0].Split("/");
            String dateMain = date[1] + "-" + date[0] + "-" + date[2];
            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewByDate(dateMain).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());

                lvwHoaDon.Items.Add(item);
            }
        }

        private void btnLocHai_Click(object sender, EventArgs e)
        {
            String[] dateTime1 = dtpLocHaiFrom.Value.ToString().Split(" ");
            String[] date1 = dateTime1[0].Split("/");
            String dateFrom = date1[1] + "-" + date1[0] + "-" + date1[2];

            String[] dateTime2 = dtpLocHaiTo.Value.ToString().Split(" ");
            String[] date2 = dateTime2[0].Split("/");
            String dateTo = date2[1] + "-" + date2[0] + "-" + date2[2];

            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewDateToDate(dateFrom, dateTo).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());

                lvwHoaDon.Items.Add(item);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String maHoaDon = txbMaHoaDon.Text.ToUpper();
            lvwHoaDon.Clear();
            lvwHoaDon.Columns.Add("STT", 40);
            lvwHoaDon.Columns.Add("Mã hóa đơn", 100);
            lvwHoaDon.Columns.Add("Tên nhân viên", 150);
            lvwHoaDon.Columns.Add("Tên khách hàng", 150);
            lvwHoaDon.Columns.Add("Ngày lập đơn", 120);
            lvwHoaDon.Columns.Add("Đơn giá (VND)", 140);

            lvwHoaDon.FullRowSelect = true;
            lvwHoaDon.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewByMaHoaDon(maHoaDon).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());

                lvwHoaDon.Items.Add(item);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataHonDon();
        }
    }
}
