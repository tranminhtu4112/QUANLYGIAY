using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using GUI_QuanLyGiay.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.DonDatHang
{
    public partial class QLDonDatHang : UserControl
    {
        private BUS_DonDatHang busDonDatHang = new BUS_DonDatHang();
        private BUS_ChiTietDonDatHang bUSChiTietDonDatHang = new BUS_ChiTietDonDatHang();
        public QLDonDatHang()
        {
            InitializeComponent();
            taoCollView();
            loadDataDonDatHang();
            loadDataSapXepCombobox();
            loadDataTrangThaiCombobox();
        }
        public void taoCollView()
        {
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 30);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 120);
            lvwDonDatHang.Columns.Add("Ngày lập", 30);
            lvwDonDatHang.Columns.Add("Ngày giao", 30);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 60);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;
        }
        public void loadDataDonDatHang()
        {
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewDonDatHang().Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String maĐonHang = "MDDH" + (busDonDatHang.getMaxID() + 1);
            DTO_DonDatHang dtoDonDatHang = new DTO_DonDatHang(maĐonHang, "MVN01", "", "", "", "", 0, 1);
            if (busDonDatHang.addDonDatHang(dtoDonDatHang))
            {
                Tool_ThemDonDatHang toolThemDonDatHang = new Tool_ThemDonDatHang(maĐonHang);
                toolThemDonDatHang.ShowDialog();
                if (toolThemDonDatHang.isClickTao)
                {
                    loadDataDonDatHang();
                }
                return;

            }
            MessageBox.Show("Lỗi phần mềm!");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDonDatHang.SelectedItems.Count > 0)
            {
                TBXoa tbXoa = new TBXoa();
                tbXoa.ShowDialog();
                if (tbXoa.isClickXoa)
                {
                    ListViewItem item = lvwDonDatHang.SelectedItems[0];
                    if (bUSChiTietDonDatHang.delelteChiTietDonDatHang(item.SubItems[1].Text))
                    {
                        if (busDonDatHang.deleteDonDatHang(item.SubItems[1].Text))
                        {
                            String thongBao = "Xóa thành công!";
                            TBThemSuaXoa tBThemSuaXoa = new TBThemSuaXoa(thongBao);
                            tBThemSuaXoa.ShowDialog();
                            loadDataDonDatHang();
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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataDonDatHang();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lvwDonDatHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDonDatHang.SelectedItems[0];
                Tool_XemChiTietDonDatHang toolXemChiTietDonDatHang = new Tool_XemChiTietDonDatHang(item.SubItems[1].Text, item.SubItems[2].Text);
                toolXemChiTietDonDatHang.ShowDialog();
            }
        }
        public void loadDataSapXepCombobox()
        {
            Dictionary<string, string> sapXeps = new Dictionary<string, string>();
            sapXeps.Add("", "Mặc định");
            sapXeps.Add("ORDER BY DONDATHANG.NGAYLAPDON DESC", "Đơn mới nhất");
            sapXeps.Add("ORDER BY DONDATHANG.NGAYLAPDON ASC", "Đon cũ nhất");

            cbbSapXep.DataSource = new BindingSource(sapXeps, null);
            cbbSapXep.DisplayMember = "Value";
            cbbSapXep.ValueMember = "Key";
        }
        public void loadDataTrangThaiCombobox()
        {
            Dictionary<string, string> sapXeps = new Dictionary<string, string>();
            sapXeps.Add("", "Tất cả");
            sapXeps.Add("AND TRANGTHAI.MATRANGTHAI = 1", "Đang giao");
            sapXeps.Add("AND TRANGTHAI.MATRANGTHAI = 2", "Đã giao");
            sapXeps.Add("AND TRANGTHAI.MATRANGTHAI = 3", "Đã hủy");


            cbbTrangThai.DataSource = new BindingSource(sapXeps, null);
            cbbTrangThai.DisplayMember = "Value";
            cbbTrangThai.ValueMember = "Key";
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbbSapXep.SelectedItem).Key;
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewSapXep(value).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String maDonDatHang = txbMaDonDatHang.Text.ToUpper();
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewByMaDonDatHang(maDonDatHang).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
            }
        }

        private void btnLocMot_Click(object sender, EventArgs e)
        {
            String[] dateTime = dtpLocMot.Value.ToString().Split(" ");
            String[] date = dateTime[0].Split("/");
            String dateMain = date[1] + "-" + date[0] + "-" + date[2];

            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewByDate(dateMain).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbbTrangThai.SelectedItem).Key;
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewByTrangThai(value).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
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
            lvwDonDatHang.Clear();
            lvwDonDatHang.Columns.Add("STT", 40);
            lvwDonDatHang.Columns.Add("Mã đơn", 100);
            lvwDonDatHang.Columns.Add("Tên khách hàng", 140);
            lvwDonDatHang.Columns.Add("Ngày lập", 100);
            lvwDonDatHang.Columns.Add("Ngày giao", 100);
            lvwDonDatHang.Columns.Add("Đơn giá (VND)", 130);
            lvwDonDatHang.Columns.Add("Trạng thái", 100);

            lvwDonDatHang.FullRowSelect = true;
            lvwDonDatHang.View = View.Details;

            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewDateToDate(dateFrom, dateTo).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                lvwDonDatHang.Items.Add(item);
            }
        }
        private void btnCapNhapTrangThai_Click(object sender, EventArgs e)
        {
            if (lvwDonDatHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDonDatHang.SelectedItems[0];
                Tool_CapNhapTrangThai toolCapNhapTrangThai = new Tool_CapNhapTrangThai(item.SubItems[1].Text, item.SubItems[6].Text);
                toolCapNhapTrangThai.ShowDialog();
                if (toolCapNhapTrangThai.isClickLuu)
                {
                    loadDataDonDatHang();
                }
            }
        }
    }
}
