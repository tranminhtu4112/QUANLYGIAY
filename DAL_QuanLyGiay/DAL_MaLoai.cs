using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_MaLoai
    {
        private SqlConnection conn = new DBConnection().getConnection();
        public DataTable getAllMaLoai()
        {
            String sqlSelect = "SELECT * FROM LOAIGIAY";
            return new DAL_Common().getSelect(sqlSelect);
        }
        public DataTable getAllTenMaLoai()
        {
            String sqlSelect = "SELECT MALOAI FROM LOAIGIAY";
            return new DAL_Common().getSelect(sqlSelect);
        }
    }
}
