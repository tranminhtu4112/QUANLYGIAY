using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.ThongKe
{
    public partial class QLThongKe : UserControl
    {
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_DonDatHang busDonDatHang = new BUS_DonDatHang();
        public QLThongKe()
        {
            InitializeComponent();
            rbtNgay.Checked = true;
            loadDataLoaiCombobox();
            taoCollView();
        }

        private void rbtNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = true;
            dtpThang.Enabled = false;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            lblDen.Enabled = false;
        }

        private void rbtThang_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = false;
            dtpThang.Enabled = true;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            lblDen.Enabled = false;
        }

        private void rbtTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = false;
            dtpThang.Enabled = false;
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            lblDen.Enabled = true;
        }
        public void taoCollView()
        {
            lvwThongKe.Clear();
            lvwThongKe.Columns.Add("STT", 90);
            lvwThongKe.Columns.Add("Mã đơn", 200);
            lvwThongKe.Columns.Add("Ngày lập đơn", 200);
            lvwThongKe.Columns.Add("Đơn giá (VND)", 200);
            lvwThongKe.FullRowSelect = true;
            lvwThongKe.View = View.Details;
        }
        public void loadDataLoaiCombobox()
        {
            Dictionary<string, string> loais = new Dictionary<string, string>();
            loais.Add("HOADON", "Hóa đơn");
            loais.Add("DONDATHANG", "Đơn đặt hàng");
            cbbLoai.DataSource = new BindingSource(loais, null);
            cbbLoai.DisplayMember = "Value";
            cbbLoai.ValueMember = "Key";
        }
        public String dateToString(String dateString)
        {
            String[] dateTime = dateString.Split(" ");
            String[] dates = dateTime[0].Split("/");
            return dates[1] + "-" + dates[0] + "-" + dates[2];
        }
        public void thongKeHoaDon(String whereSelect)
        {
            lvwThongKe.Clear();
            lvwThongKe.Columns.Add("STT", 90);
            lvwThongKe.Columns.Add("Mã đơn", 200);
            lvwThongKe.Columns.Add("Ngày lập đơn", 200);
            lvwThongKe.Columns.Add("Đơn giá (VND)", 200);
            lvwThongKe.FullRowSelect = true;
            lvwThongKe.View = View.Details;
            float TongDonGia = 0;
            int stt = 0;
            foreach (DataRow row in busHoaDon.getViewThongKe(whereSelect).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());

                lvwThongKe.Items.Add(item);
                TongDonGia += float.Parse(row[2].ToString());
            }
            ListViewItem itemDonGia = new ListViewItem("");
            itemDonGia.SubItems.Add("");
            itemDonGia.SubItems.Add("Tổng cộng:");
            itemDonGia.SubItems.Add(TongDonGia.ToString());
            lvwThongKe.Items.Add(itemDonGia);
        }
        public void thongKeDonDatHang(String whereSelect)
        {
            lvwThongKe.Clear();
            lvwThongKe.Columns.Add("STT", 90);
            lvwThongKe.Columns.Add("Mã đơn", 200);
            lvwThongKe.Columns.Add("Ngày lập đơn", 200);
            lvwThongKe.Columns.Add("Đơn giá (VND)", 200);
            lvwThongKe.FullRowSelect = true;
            lvwThongKe.View = View.Details;
            float TongDonGia = 0;
            int stt = 0;
            foreach (DataRow row in busDonDatHang.getViewThongKe(whereSelect).Rows)
            {
                stt++;
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());

                lvwThongKe.Items.Add(item);
                TongDonGia += float.Parse(row[2].ToString());
            }
            ListViewItem itemDonGia = new ListViewItem("");
            itemDonGia.SubItems.Add("");
            itemDonGia.SubItems.Add("Tổng cộng:");
            itemDonGia.SubItems.Add(TongDonGia.ToString());
            lvwThongKe.Items.Add(itemDonGia);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbbLoai.SelectedItem).Key;
            String whereSelect;
            if (rbtNgay.Checked)
            {
                String date = dateToString(dtpNgay.Value.ToString());
                whereSelect = "NGAYLAPDON = '" + date + "'";
            }
            else if (rbtThang.Checked)
            {
                String[] dates = dateToString(dtpThang.Value.ToString()).Split("-");
                String date = dates[2] + "-" + dates[0] + "%";
                whereSelect = "NGAYLAPDON LIKE '" + date + "'";
            }
            else
            {
                String dateFrom = dateToString(dtpFrom.Value.ToString());
                String dateTo = dateToString(dtpTo.Value.ToString());
                whereSelect = "NGAYLAPDON >= '" + dateFrom + "'" + " AND NGAYLAPDON <= '" + dateTo + "'";
            }
            if (value.Equals("HOADON"))
            {
                thongKeHoaDon(whereSelect);
            }
            else
            {
                thongKeDonDatHang(whereSelect);
            }
        }
    }
}
