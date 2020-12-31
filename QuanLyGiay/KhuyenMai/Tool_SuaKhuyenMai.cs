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
    public partial class Tool_SuaKhuyenMai : Form
    {
        int mov, movX, movY;
        private BUS_KhuyenMai busKhuyenMai = new BUS_KhuyenMai();
        private DTO_KhuyenMai dtoKhuyenMai;
        public bool isClickSua { set; get; }
        public Tool_SuaKhuyenMai()
        {
            InitializeComponent();
        }
        public Tool_SuaKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            InitializeComponent();
            this.dtoKhuyenMai = dtoKhuyenMai;
            this.isClickSua = false;
        }
        public Object checkAndReturnKhuyenMai()
        {
            if (txbTenSuKien.Text == "")
                return "Tên sự kiện không được trống!";
            if (txbPhanTramGiamGia.Text == "")
                return "Phần trăm khuyến mãi không được trống!";
            String maKhuyenMai = txbMaKhuyenMai.Text;
            String tenSuKien = txbTenSuKien.Text;
            float phanTramKhuyenMai = 0;
            try
            {
                phanTramKhuyenMai = float.Parse(txbPhanTramGiamGia.Text);
            }
            catch
            {
                return "Phần trăm khuyến mãi phải là số!";
            }
            return new DTO_KhuyenMai(maKhuyenMai, tenSuKien, phanTramKhuyenMai);
        }

        private void Tool_SuaKhuyenMai_Load(object sender, EventArgs e)
        {
            txbMaKhuyenMai.Text = this.dtoKhuyenMai.maKhuyenMai;
            txbTenSuKien.Text = this.dtoKhuyenMai.tenSuKien;
            txbPhanTramGiamGia.Text = this.dtoKhuyenMai.phanTramGiamGia.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Object obj = checkAndReturnKhuyenMai();
            if (obj is String)
            {
                MessageBox.Show(obj.ToString());
                return;
            }
            if (busKhuyenMai.editKhuyenMai((DTO_KhuyenMai)obj))
            {
                String thongBao = "Sửa mới thành công!";
                this.Close();
                TBThemSuaXoa tBSua = new TBThemSuaXoa(thongBao);
                tBSua.ShowDialog();
                this.isClickSua = true;
            }
            else
            {
                MessageBox.Show("Lỗi phần mềm!");
            }
        }

        private void Tool_SuaKhuyenMai_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_SuaKhuyenMai_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_SuaKhuyenMai_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
