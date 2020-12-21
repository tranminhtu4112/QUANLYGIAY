using DAL_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_MaLoai
    {
        DAL_MaLoai dalMaLoai = new DAL_MaLoai();
        public DataTable getAllMaLoai()
        {
            return dalMaLoai.getAllMaLoai();
        }
        public DataTable getAllTenMaLoai()
        {
            return dalMaLoai.getAllTenMaLoai();
        }
    }
}
