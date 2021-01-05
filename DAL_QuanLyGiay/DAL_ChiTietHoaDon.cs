using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_ChiTietHoaDon
    {
        private SqlConnection conn;
        DAL_Common dalCommon = new DAL_Common();

        public bool addChiTietHoaDon(DTO_ChiTietHoaDon dtoChiTietHoaDon)
        {
            String SQLInsert = "INSERT INTO CHITIETHOADON(CHITIETHOADON.MAHOADON, CHITIETHOADON.MAGIAY, CHITIETHOADON.SOLUONG, CHITIETHOADON.GIA) " +
            "VALUES(@MAHOADON, @MAGIAY, @SOLUONG, @GIA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAHOADON", dtoChiTietHoaDon.maHoaDon);
                sqlCommand.Parameters.AddWithValue("MAGIAY", dtoChiTietHoaDon.maGiay);
                sqlCommand.Parameters.AddWithValue("SOLUONG", dtoChiTietHoaDon.soLuong);
                sqlCommand.Parameters.AddWithValue("GIA", dtoChiTietHoaDon.gia);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
    }
}
