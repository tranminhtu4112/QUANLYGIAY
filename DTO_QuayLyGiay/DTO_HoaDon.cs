using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_HoaDon
    {
        public String maHoaDon { get; set; }
        public String maNhanVien { get; set; }
        public String tenKhachHang { get; set; }
        public String ngayLapDon { get; set; }
        public float gia { get; set; }
        public DTO_HoaDon()
        {
            this.ngayLapDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
        }
        public DTO_HoaDon(String maHoaDon, String maNhanVien, String tenKhachHang, float gia)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.tenKhachHang = tenKhachHang;
            this.ngayLapDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
            this.gia = gia;
        }
    }
}
