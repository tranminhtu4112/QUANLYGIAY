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
    public partial class Tool_SuaGioiTinh : Form
    {
        private BUS_GioiTinh busGioiTinh = new BUS_GioiTinh();
        private DTO_GioiTinh dtoGioiTinh;
        public bool isClickSua { set; get; }
        public Tool_SuaGioiTinh()
        {
            InitializeComponent();
        }
        public Tool_SuaGioiTinh(DTO_GioiTinh dtoGioiTinh)
        {
            InitializeComponent();
            this.dtoGioiTinh = dtoGioiTinh;
            this.isClickSua = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Object checkAndReturnGioiTinh()
        {
            if (txbTenGioiTinh.Text == "")
                return "Tên giới tính không được trống!";

            String maGioiTinh = txbMaGioiTinh.Text;
            String TenGioiTinh = txbTenGioiTinh.Text;
            String moTa = txbMoTa.Text;

            return new DTO_GioiTinh(maGioiTinh, TenGioiTinh, moTa);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnGioiTinh();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busGioiTinh.editGioiTinh((DTO_GioiTinh)obj))
            {
                String thongBao = "Sửa mới thành công!";
                this.Close();
                TBThemSuaXoa tBSua= new TBThemSuaXoa(thongBao);
                tBSua.ShowDialog();
                this.isClickSua = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }

        private void Tool_SuaGioiTinh_Load(object sender, EventArgs e)
        {
            txbMaGioiTinh.Text = this.dtoGioiTinh.maGioiTinh;
            txbTenGioiTinh.Text = this.dtoGioiTinh.tenGioiTinh;
            txbMoTa.Text = this.dtoGioiTinh.moTa;
        }
    }
}
