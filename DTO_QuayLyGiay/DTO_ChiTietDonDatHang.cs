using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_ChiTietDonDatHang
    {
        public String maDonDatHang { get; set; }
        public String maGiay { get; set; }
        public int soLuong { get; set; }
        public float gia { get; set; }

        public DTO_ChiTietDonDatHang()
        {

        }
        public DTO_ChiTietDonDatHang(String maDonDatHang, String maGia, int soLuong, float gia)
        {
            this.maDonDatHang = maDonDatHang;
            this.maGiay = maGia;
            this.soLuong = soLuong;
            this.gia = gia;
        }
    }
}
