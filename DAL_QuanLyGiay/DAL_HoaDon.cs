using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_HoaDon
    {
        private SqlConnection conn;
        DAL_Common dalCommon = new DAL_Common();

        public bool addHoaDon(DTO_HoaDon dtoHoaDon)
        {
            String SQLInsert = "INSERT INTO HOADON(HOADON.MAHOADON, HOADON.MANHANVIEN, HOADON.TENKHACHHANG, HOADON.NGAYLAPDON, HOADON.GIA) " +
            "VALUES(@MAHOADON, @MANHANVIEN, @TENKHACHHANG, @NGAYLAPDON, @GIA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAHOADON", dtoHoaDon.maHoaDon);
                sqlCommand.Parameters.AddWithValue("MANHANVIEN", dtoHoaDon.maNhanVien);
                sqlCommand.Parameters.AddWithValue("TENKHACHHANG", dtoHoaDon.tenKhachHang);
                sqlCommand.Parameters.AddWithValue("NGAYLAPDON", dtoHoaDon.ngayLapDon);
                sqlCommand.Parameters.AddWithValue("GIA", dtoHoaDon.gia);
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
        public bool deleteHoaDon(String maHoaDon)
        {
            String SQLDelete = "DELETE FROM HOADON WHERE MAHOADON = @MAHOADON";
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
        public bool updateHoaDon(DTO_HoaDon dtoHoaDon)
        {
            String SQLUpdate = "UPDATE HOADON SET MANHANVIEN = @MANHANVIEN, TENKHACHHANG = @TENKHACHHANG, " +
                "GIA = @GIA WHERE MAHOADON = @MAHOADON";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLUpdate, conn);
                sqlCommand.Parameters.AddWithValue("MANHANVIEN", dtoHoaDon.maNhanVien);
                sqlCommand.Parameters.AddWithValue("TENKHACHHANG", dtoHoaDon.tenKhachHang);
                sqlCommand.Parameters.AddWithValue("GIA", dtoHoaDon.gia);
                sqlCommand.Parameters.AddWithValue("MAHOADON", dtoHoaDon.maHoaDon);
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
