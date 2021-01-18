using BUS_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.DonDatHang
{
    public partial class Tool_CapNhapTrangThai : Form
    {
        int mov, movX, movY;
        private BUS_DonDatHang busDonDatHang = new BUS_DonDatHang();
        public String maDonDatHang { set; get; }
        public String tenTrangThai { set; get; }
        public bool isClickLuu { set; get; }
        public Tool_CapNhapTrangThai()
        {
            InitializeComponent();
        }
        public Tool_CapNhapTrangThai(String maDonDatHang, String tenTrangThai)
        {
            this.maDonDatHang = maDonDatHang;
            this.tenTrangThai = tenTrangThai;
            this.isClickLuu = false;
            InitializeComponent();
            loadDataTrangThaiCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadDataTrangThaiCombobox()
        {
            Dictionary<string, string> trangThais = new Dictionary<string, string>();
            trangThais.Add("1", "Đang giao");
            trangThais.Add("2", "Đã giao");
            trangThais.Add("3", "Đã hủy");

            cbbTrangThai.DataSource = new BindingSource(trangThais, null);
            cbbTrangThai.DisplayMember = "Value";
            cbbTrangThai.ValueMember = "Key";
        }

        private void Tool_CapNhapTrangThai_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_CapNhapTrangThai_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_CapNhapTrangThai_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Tool_CapNhapTrangThai_Load(object sender, EventArgs e)
        {
            txbMaDonDatHang.Text = this.maDonDatHang;
            txbTrangThaiCu.Text = this.tenTrangThai;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maTrangThai = int.Parse(((KeyValuePair<string, string>)cbbTrangThai.SelectedItem).Key);
            String maDonDatHang = txbMaDonDatHang.Text;
            if(busDonDatHang.updateTrangThai(maDonDatHang, maTrangThai))
            {
                this.isClickLuu = true;
                this.Close();
                String mes = "Cập nhập thành công!";
                TBThemSuaXoa tb = new TBThemSuaXoa(mes);
                tb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }
    }
}
