using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_KhuyenMai
    {
        public String maKhuyenMai { get; set; }
        public String tenSuKien { get; set; }
        public float phanTramGiamGia { get; set; }
        public DTO_KhuyenMai()
        {

        }
        public DTO_KhuyenMai(String maKhuyenMai, String tenSuKien, float phanTramGiamGia)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenSuKien = tenSuKien;
            this.phanTramGiamGia = phanTramGiamGia;
        }
    }
}
