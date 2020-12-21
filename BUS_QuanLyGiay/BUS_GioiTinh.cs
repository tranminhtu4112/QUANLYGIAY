using DAL_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_GioiTinh
    {
        private DAL_GioiTInh dalGIoiTinh = new DAL_GioiTInh();
        public DataTable getAllGioiTinh()
        {
            return dalGIoiTinh.getAllGioiTinh();
        }
    }
}
