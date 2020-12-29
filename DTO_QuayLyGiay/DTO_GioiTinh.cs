using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_GioiTinh
    {
        public String maGioiTinh { get; set; }
        public String tenGioiTinh { get; set; }
        public String moTa { get; set; }
        public DTO_GioiTinh()
        {

        }
        public DTO_GioiTinh(String maGioiTinh, String tenGioiTinh, String moTa)
        {
            this.maGioiTinh = maGioiTinh;
            this.tenGioiTinh = tenGioiTinh;
            this.moTa = moTa;
        }
    }
}
