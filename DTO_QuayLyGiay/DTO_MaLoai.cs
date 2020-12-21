using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_MaLoai
    {
        private int id { get; set; }
        private String maLoai { get; set; }
        private String tenLoai { get; set; }
        private String moTa { get; set; }
        public DTO_MaLoai()
        {

        }
        public DTO_MaLoai(int id, String maLoai, String tenLoai, String moTa)
        {
            this.id = id;
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.moTa = moTa;
        }
    }
}
