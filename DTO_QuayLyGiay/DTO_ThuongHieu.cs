using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_ThuongHieu
    {
        public String maThuongHieu { get; set; }
        public String tenThuongHieu { get; set; }
        public String moTa { get; set; }
        public byte[] hinhAnh { get; set; }

        public DTO_ThuongHieu()
        {

        }
        public DTO_ThuongHieu(String maThuongHieu, String tenThuongHieu, String moTa, byte[] hinhAnh)
        {
            this.maThuongHieu = maThuongHieu;
            this.tenThuongHieu = tenThuongHieu;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
        }
        public DTO_ThuongHieu(String maThuongHieu, String tenThuongHieu)
        {
            this.maThuongHieu = maThuongHieu;
            this.tenThuongHieu = tenThuongHieu;
        }
    }
}
