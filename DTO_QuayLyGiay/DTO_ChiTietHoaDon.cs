using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_ChiTietHoaDon
    {
        public String maHoaDon { get; set; }
        public String maGiay { get; set; }
        public int soLuong { get; set; }
        public float gia { get; set; }

        public DTO_ChiTietHoaDon()
        {

        }
        public DTO_ChiTietHoaDon(String maHoaDon, String maGia, int soLuong, float gia)
        {
            this.maHoaDon = maHoaDon;
            this.maGiay = maGia;
            this.soLuong = soLuong;
            this.gia = gia;
        }
    }
}
