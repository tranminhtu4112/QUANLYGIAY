using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
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
        public bool addThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            return dalThuongHieu.addThuongHieu(dtoThuongHieu);
        }
        public bool editThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            return dalThuongHieu.editThuongHieu(dtoThuongHieu);
        }
        public bool deleteThuongHieu(String maThuongHieu)
        {
            return dalThuongHieu.deleteThuongHieu(maThuongHieu);
        }
    }
}
