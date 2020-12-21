using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuayLyGiay;

namespace QuanLyGiay
{
    public partial class DanhSachGiay : Form
    {
        private BUS_Giay busGiay = new BUS_Giay();
        private BUS_MaLoai busMaLoai = new BUS_MaLoai();
        private BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        public DanhSachGiay()
        {
            InitializeComponent();
            loadDataGiay();
            loadDataMaLoai();
            loadDataGioiTinh();
        }
        public void loadDataGiay()
        {
            dgvDanhSach.DataSource = busGiay.getAllGiay();
        }
        public void loadDataMaLoai()
        {
            foreach (DataRow row in busMaLoai.getAllMaLoai().Rows)
            {
                cbbMaLoai.Items.Add(row[1].ToString());
            }
        }
        public void loadDataGioiTinh()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            cbbGioiTinhGiay.DisplayMember = "Value";
            cbbGioiTinhGiay.ValueMember = "Key";
            foreach (DataRow row in busGioiTinh.getAllGioiTinh().Rows)
            {
                comboSource.Add(row[0].ToString(), row[1].ToString());
            }
            cbbGioiTinhGiay.DataSource = new BindingSource(comboSource, null);
        }
        public Object checkAndReturnGiay()
        {
            if (txbMa.Text == "")
                return "Mã không được trống!";
            if (cbbMaLoai.Text == "")
                return "Mã loại không được trống!";
            if (txbTen.Text == "")
                return "Tên không được trống!";
            if (cbbGioiTinhGiay.Text == "")
                return "Giới tính giày không được trống!";
            if (txbMota.Text == "")
                return "Mô tả không được trống!";
            if (txbGia.Text == "")
                return "Giá không được trống!";
            String ma = txbMa.Text.ToString();
            String maLoai = cbbMaLoai.Text.ToString();
            String ten = txbTen.Text.ToString();
            int gioiTinh = int.Parse(((KeyValuePair<string, string>)cbbGioiTinhGiay.SelectedItem).Key);
            String moTa = txbMota.Text.ToString();
            byte[] hinhAnh = null;
            float gia = float.Parse(txbGia.Text);
            return new DTO_Giay(ma, maLoai, ten, gioiTinh, moTa, hinhAnh, gia);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkAndReturnGiay() is String)
                    MessageBox.Show(checkAndReturnGiay().ToString());
                else
                    busGiay.AddGiay((DTO_Giay)checkAndReturnGiay());
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Lỗi Phầm mềm!");
            }
            finally
            {
                loadDataGiay();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
        }
    }
}
