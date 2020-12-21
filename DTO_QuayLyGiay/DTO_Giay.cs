using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_Giay
    {
        public int id { get; set; }
        public String ma { get; set; }
        public String maLoai { get; set; }
        public String ten { get; set; }
        public int gioiTinh { get; set; }
        public String moTa { get; set; }
        public byte[] hinhAnh { get; set; }
        public float gia { get; set; }
        public DTO_Giay()
        {

        }
        public DTO_Giay(String ma, String maLoai, String ten, int gioiTinh, 
            String moTa, byte[] hinhAnh, float gia)
        {
            this.ma = ma;
            this.maLoai = maLoai;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.gia = gia;
        }
    }
}
