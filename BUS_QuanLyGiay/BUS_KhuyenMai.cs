using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL_QuanLyGiay;
using DTO_QuayLyGiay;

namespace BUS_QuanLyGiay
{
    public class BUS_KhuyenMai
    {
        private DAL_KhuyenMai dalKhuyenMai = new DAL_KhuyenMai();
        public DataTable getAllKhuyenMai()
        {
            return dalKhuyenMai.getAllKhuyenMai();
        }
        public bool addKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            return dalKhuyenMai.addKhuyenMai(dtoKhuyenMai);
        }
        public bool editKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            return dalKhuyenMai.editKhuyenMai(dtoKhuyenMai);
        }
        public bool deleteKhuyenMai(String maKhuyenMai)
        {
            return dalKhuyenMai.deleteKhuyenMai(maKhuyenMai);
        }
    }
}
