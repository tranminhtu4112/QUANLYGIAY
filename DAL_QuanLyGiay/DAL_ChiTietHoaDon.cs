using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
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
        public bool deleteChiTietHoaDon(String maHoaDon)
        {
            String SQLDelete = "DELETE FROM CHITIETHOADON WHERE MAHOADON = @MAHOADON";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MAHOADON", maHoaDon);
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
        public bool deleteChiTietHoaDon(String maHoaDon, String maGiay)
        {
            String SQLDelete = "DELETE FROM CHITIETHOADON WHERE MAHOADON = @MAHOADON AND MAGIAY = @MAGIAY";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MAHOADON", maHoaDon);
                sqlCommand.Parameters.AddWithValue("MAGIAY", maGiay);
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
        public DataTable getViewChiTietHoaDonByMaHoaDon(String maHoaDon)
        {
            String SQLSelect = "SELECT GIAY.HINHANH, GIAY.MAGIAY, GIAY.TENGIAY, CHITIETHOADON.SOLUONG, KHUYENMAI.PHANTRAMGIAMGIA, GIAY.GIA, CHITIETHOADON.GIA " +
                                "FROM GIAY, KHUYENMAI, CHITIETHOADON " +
                                "WHERE GIAY.MAGIAY = CHITIETHOADON.MAGIAY " +
                                "AND KHUYENMAI.MAKHUYENMAI = GIAY.MAKHUYENMAI " +
                                "AND CHITIETHOADON.MAHOADON = '" + maHoaDon + "'";
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
