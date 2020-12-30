using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_GioiTinh
    {
        private DAL_GioiTInh dalGioiTinh = new DAL_GioiTInh();
        public DataTable getAllGioiTinh()
        {
            return dalGioiTinh.getAllGioiTinh();
        }
        public bool addGioiTinh(DTO_GioiTinh dtoGioiTinh)
        {
            return dalGioiTinh.addGioiTinh(dtoGioiTinh);
        }
        public bool editGioiTinh(DTO_GioiTinh dtoGioiTinh)
        {
            return dalGioiTinh.editGioiTinh(dtoGioiTinh);
        }
        public bool deleteGioiTinh(String maGioiTinh)
        {
            return dalGioiTinh.deleteGioiTinh(maGioiTinh);
        }
    }
}
