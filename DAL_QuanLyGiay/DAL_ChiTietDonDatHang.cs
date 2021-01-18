using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_ChiTietDonDatHang
    {
        private SqlConnection conn;
        DAL_Common dalCommon = new DAL_Common();
        public bool deleteChiTietHoaDon(String maDonDatHang)
        {
            String SQLDelete = "DELETE FROM CHITIETDONDATHANG WHERE MADONDATHANG = @MADONDATHANG";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MADONDATHANG", maDonDatHang);
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
        public bool addChiTietDonDatHang(DTO_ChiTietDonDatHang dtoChiTietDonDatHang)
        {
            String SQLInsert = "INSERT INTO CHITIETDONDATHANG(MADONDATHANG, MAGIAY, SOLUONG, GIA) " +
            "VALUES(@MADONDATHANG, @MAGIAY, @SOLUONG, @GIA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MADONDATHANG", dtoChiTietDonDatHang.maDonDatHang);
                sqlCommand.Parameters.AddWithValue("MAGIAY", dtoChiTietDonDatHang.maGiay);
                sqlCommand.Parameters.AddWithValue("SOLUONG", dtoChiTietDonDatHang.soLuong);
                sqlCommand.Parameters.AddWithValue("GIA", dtoChiTietDonDatHang.gia);
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
        public DataTable getViewChiTietDonDatHangByMaDonDatHang(String maDonDatHang)
        {
            String SQLSelect = "SELECT GIAY.HINHANH, GIAY.MAGIAY, GIAY.TENGIAY, CHITIETDONDATHANG.SOLUONG, KHUYENMAI.PHANTRAMGIAMGIA, GIAY.GIA, CHITIETDONDATHANG.GIA " +
                                "FROM GIAY, KHUYENMAI, CHITIETDONDATHANG " +
                                "WHERE GIAY.MAGIAY = CHITIETDONDATHANG.MAGIAY " +
                                "AND KHUYENMAI.MAKHUYENMAI = GIAY.MAKHUYENMAI " +
                                "AND CHITIETDONDATHANG.MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool deleteChiTietDonDatHang(String maDonDatHang, String maGiay)
        {
            String SQLDelete = "DELETE FROM CHITIETDONDATHANG WHERE MADONDATHANG = @MADONDATHANG AND MAGIAY = @MAGIAY";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MADONDATHANG", maDonDatHang);
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
    }
}
