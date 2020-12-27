using DAL_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_ThuongHieu
    {
        DAL_ThuongHieu dalThuongHieu = new DAL_ThuongHieu();
        public DataTable getAllThuongHieu()
        {
            return dalThuongHieu.getAllThuongHieu();
        }
    }
}
