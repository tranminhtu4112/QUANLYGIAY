using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_DonDatHang
    {
        private SqlConnection conn;
        public bool addDonDatHang(DTO_DonDatHang dtoDonDatHang)
        {
            String SQLInsert = "INSERT INTO DONDATHANG(MADONDATHANG, MANHANVIEN, TENKHACHHANG" +
                ", SODIENTHOAI, DIACHIGIAO, NGAYLAPDON, NGAYGIAODON, GIA, MATRANGTHAI) " +
                "VALUES(@MADONDATHANG, @MANHANVIEN, @TENKHACHHANG, @SODIENTHOAI, @DIACHIGIAO" +
                ", @NGAYLAPDON, @NGAYGIAODON, @GIA, @MATRANGTHAI)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MADONDATHANG", dtoDonDatHang.maDonDatHang);
                sqlCommand.Parameters.AddWithValue("MANHANVIEN", dtoDonDatHang.maNhanVien);
                sqlCommand.Parameters.AddWithValue("TENKHACHHANG", dtoDonDatHang.tenKhachHang);
                sqlCommand.Parameters.AddWithValue("SODIENTHOAI", dtoDonDatHang.soDienThoai);
                sqlCommand.Parameters.AddWithValue("DIACHIGIAO", dtoDonDatHang.diaChiGiao);
                sqlCommand.Parameters.AddWithValue("NGAYLAPDON", dtoDonDatHang.ngayLapDon);
                sqlCommand.Parameters.AddWithValue("NGAYGIAODON", dtoDonDatHang.ngayGiaoDon);
                sqlCommand.Parameters.AddWithValue("GIA", dtoDonDatHang.gia);
                sqlCommand.Parameters.AddWithValue("MATRANGTHAI", dtoDonDatHang.maTrangThai);
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
        public bool deleteDonDatHang(String maDonDatHang)
        {
            String SQLDelete = "DELETE FROM DONDATHANG WHERE MADONDATHANG = @MADONDATHANG";
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
        public bool updateDonDatHang(DTO_DonDatHang dtoDonDatHang)
        {
            String SQLUpdate = "UPDATE DONDATHANG SET TENKHACHHANG = @TENKHACHHANG, SODIENTHOAI = @SODIENTHOAI, DIACHIGIAO = @DIACHIGIAO, " +
                      "NGAYGIAODON = @NGAYGIAODON, GIA = @GIA, MATRANGTHAI = @MATRANGTHAI " +
                      "WHERE MADONDATHANG = @MADONDATHANG";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLUpdate, conn);
                sqlCommand.Parameters.AddWithValue("TENKHACHHANG", dtoDonDatHang.tenKhachHang);
                sqlCommand.Parameters.AddWithValue("SODIENTHOAI", dtoDonDatHang.soDienThoai);
                sqlCommand.Parameters.AddWithValue("DIACHIGIAO", dtoDonDatHang.diaChiGiao);
                sqlCommand.Parameters.AddWithValue("NGAYGIAODON", dtoDonDatHang.ngayGiaoDon);
                sqlCommand.Parameters.AddWithValue("GIA", dtoDonDatHang.gia);
                sqlCommand.Parameters.AddWithValue("MATRANGTHAI", dtoDonDatHang.maTrangThai);
                sqlCommand.Parameters.AddWithValue("MADONDATHANG", dtoDonDatHang.maDonDatHang);
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
