using BUS_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLyGiay.DonDatHang
{
    public partial class Tool_NhapSoLuongDatHang : Form
    {
        int mov, movX, movY;
        private BUS_ChiTietDonDatHang busChiTietDonDatHang = new BUS_ChiTietDonDatHang();
        private BUS_Giay busGiay = new BUS_Giay();
        public bool isClickThem { get; set; }
        public String maGiay { get; set; }
        public String maHoaDon { get; set; }
        public int soLuong { get; set; }
        public float phanTramGiamGia { get; set; }
        public float gia { get; set; }
        public int soLuongNhapCu { get; set; }
        public bool checkFormSua { get; set; }
        public Tool_NhapSoLuongDatHang()
        {
            InitializeComponent();
            isClickThem = false;
        }
        public Tool_NhapSoLuongDatHang(String maGiay, int soLuong, String maHoaDon, float phanTramGiamGia, float gia)
        {
            InitializeComponent();
            this.maGiay = maGiay;
            this.soLuong = soLuong;
            this.maHoaDon = maHoaDon;
            this.phanTramGiamGia = phanTramGiamGia;
            this.gia = gia;
            isClickThem = false;
        }
        public Tool_NhapSoLuongDatHang(String maHoaDon, String maGiay, int soLuong, int SoLuongNhapCu, float phanTramGiamGia, float gia)
        {
            InitializeComponent();
            this.maGiay = maGiay;
            this.soLuong = soLuong;
            this.maHoaDon = maHoaDon;
            this.soLuongNhapCu = SoLuongNhapCu;
            this.phanTramGiamGia = phanTramGiamGia;
            this.gia = gia;
            isClickThem = false;
            checkFormSua = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tool_NhapSoLuongDatHang_Load(object sender, EventArgs e)
        {
            lblSoLuongToiDa.Text = this.soLuong.ToString();
            txbMaGiay.Text = this.maGiay;
            txbSoLuong.Text = this.soLuongNhapCu.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int checkNum = 0;
            try
            {
                checkNum = int.Parse(txbSoLuong.Text);
                if (checkNum <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                    return;
                }
                if (checkNum > int.Parse(lblSoLuongToiDa.Text))
                {
                    MessageBox.Show("Số lượng không đủ!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }
            if (!this.checkFormSua)
            {
                DTO_ChiTietDonDatHang dtoChiTietDonDatHang = new DTO_ChiTietDonDatHang();
                dtoChiTietDonDatHang.maDonDatHang = this.maHoaDon;
                dtoChiTietDonDatHang.maGiay = this.maGiay;
                dtoChiTietDonDatHang.soLuong = checkNum;
                dtoChiTietDonDatHang.gia = checkNum * (this.gia - (this.gia * (this.phanTramGiamGia / 100)));
                if (busChiTietDonDatHang.addChiTietDonDatHang(dtoChiTietDonDatHang))
                {
                    isClickThem = true;
                    busGiay.UpdateSoLuong(this.maGiay, this.soLuong - checkNum);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sản phẩm này đã được chọn từ trước!");
                }
            }
            else// form sua so luong
            {
                int soLuongNhapMoi = int.Parse(txbSoLuong.Text.ToString());
                if (busGiay.UpdateSoLuong(this.maGiay, this.soLuong - soLuongNhapMoi))
                {
                    float giaMoi = soLuongNhapMoi * (this.gia - (this.gia * (this.phanTramGiamGia / 100)));
                    if (busChiTietDonDatHang.UpdateSoLuongAndGia(this.maHoaDon, this.maGiay, soLuongNhapMoi, giaMoi))
                    {
                        this.isClickThem = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi phần mềm");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi phần mềm");
                }
            }
        }

        private void Tool_NhapSoLuongDatHang_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Tool_NhapSoLuongDatHang_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Tool_NhapSoLuongDatHang_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
