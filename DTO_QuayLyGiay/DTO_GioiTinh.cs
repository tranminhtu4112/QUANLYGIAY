using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_GioiTinh
    {
        public int id { get; set; }
        public String tenGioiTinh { get; set; }
        public DTO_GioiTinh()
        {

        }
        public DTO_GioiTinh(String tenGioiTinh)
        {
            this.tenGioiTinh = tenGioiTinh;
        }
    }
}
