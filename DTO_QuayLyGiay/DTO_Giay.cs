using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_Giay
    {
        public String maGiay { get; set; }
        public String TenGiay { get; set; }
        public String maGioiTinh { get; set; }
        public String maThuongHieu { get; set; }
        public String moTa { get; set; }
        public byte[] hinhAnh { get; set; }
        public String maKhuyenMai { get; set; }
        public int soLuong { get; set; }
        public float gia { get; set; }
        public DTO_Giay()
        {

        }
        public DTO_Giay(String maGiay, String TenGiay, String maGioiTinh, String maThuongHieu, 
                        String moTa, byte[] hinhAnh, String maKhuyenMai, int soLuong, float gia)
        {
            this.maGiay = maGiay;
            this.TenGiay = TenGiay;
            this.maGioiTinh = maGioiTinh;
            this.maThuongHieu = maThuongHieu;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.maKhuyenMai = maKhuyenMai;
            this.soLuong = soLuong;
            this.gia = gia;
        }
    }
}
