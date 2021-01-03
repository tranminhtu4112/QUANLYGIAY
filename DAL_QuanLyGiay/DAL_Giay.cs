using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DTO_QuayLyGiay;

namespace DAL_QuanLyGiay
{
    public class DAL_Giay
    {
        private SqlConnection conn;
        private DAL_Common dalCommon = new DAL_Common();
        public DataTable getAllGiay()
        {
            String SQLSelect = "SELECT * FROM GIAY";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool addGiay(DTO_Giay dtoGiay)
        {
            String SQLInsert = "INSERT INTO GIAY " +
                "(MAGIAY, TENGIAY, MAGIOITINH, MATHUONGHIEU, MOTA, HINHANH, MAKHUYENMAI, SOLUONG, GIA) " +
        "VALUES(@MAGIAY, @TENGIAY, @MAGIOITINH, @MATHUONGHIEU, @MOTA, @HINHANH, @MAKHUYENMAI, @SOLUONG, @GIA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAGIAY", dtoGiay.maGiay);
                sqlCommand.Parameters.AddWithValue("TENGIAY", dtoGiay.TenGiay);
                sqlCommand.Parameters.AddWithValue("MAGIOITINH", dtoGiay.maGioiTinh);
                sqlCommand.Parameters.AddWithValue("MATHUONGHIEU", dtoGiay.maThuongHieu);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoGiay.moTa);
                sqlCommand.Parameters.AddWithValue("HINHANH", dtoGiay.hinhAnh);
                sqlCommand.Parameters.AddWithValue("MAKHUYENMAI", dtoGiay.maKhuyenMai);
                sqlCommand.Parameters.AddWithValue("SOLUONG", dtoGiay.soLuong);
                sqlCommand.Parameters.AddWithValue("GIA", dtoGiay.gia);
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
        public bool editGiay(DTO_Giay dtoGiay)
        {
            String SQLInsert = "UPDATE GIAY " +
   "SET TENGIAY=@TENGIAY,MAGIOITINH=@MAGIOITINH,MATHUONGHIEU=@MATHUONGHIEU,MOTA=@MOTA, " +
   "HINHANH=@HINHANH,MAKHUYENMAI=@MAKHUYENMAI,SOLUONG=@SOLUONG,GIA=@GIA " +
                                "WHERE MAGIAY = @MAGIAY";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAGIAY", dtoGiay.maGiay);
                sqlCommand.Parameters.AddWithValue("TENGIAY", dtoGiay.TenGiay);
                sqlCommand.Parameters.AddWithValue("MAGIOITINH", dtoGiay.maGioiTinh);
                sqlCommand.Parameters.AddWithValue("MATHUONGHIEU", dtoGiay.maThuongHieu);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoGiay.moTa);
                sqlCommand.Parameters.AddWithValue("HINHANH", dtoGiay.hinhAnh);
                sqlCommand.Parameters.AddWithValue("MAKHUYENMAI", dtoGiay.maKhuyenMai);
                sqlCommand.Parameters.AddWithValue("SOLUONG", dtoGiay.soLuong);
                sqlCommand.Parameters.AddWithValue("GIA", dtoGiay.gia);
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
        public bool deleteGiay(String maGiay)
        {
            String SQLDelete = "DELETE FROM GIAY WHERE MAGIAY = @MAGIAY";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
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
        public DataTable getViewDetailGiay()
        {
            String SQLSelect = "SELECT GIAY.MAGIAY,GIAY.TENGIAY,GIOITINH.TENGIOITINH,THUONGHIEU.TENTHUONGHIEU,GIAY.MOTA,GIAY.HINHANH," +
                                "KHUYENMAI.PHANTRAMGIAMGIA,GIAY.SOLUONG,GIAY.GIA " +
                                "FROM GIAY,GIOITINH,THUONGHIEU,KHUYENMAI " +
                                "WHERE GIAY.MAGIOITINH = GIOITINH.MAGIOITINH AND GIAY.MATHUONGHIEU = THUONGHIEU.MATHUONGHIEU " +
                                "AND GIAY.MAKHUYENMAI = KHUYENMAI.MAKHUYENMAI";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getSapXepTheo(String StringOrderBy)
        {
            String SQLSort = "SELECT GIAY.MAGIAY,GIAY.TENGIAY,GIOITINH.TENGIOITINH,THUONGHIEU.TENTHUONGHIEU,GIAY.MOTA,GIAY.HINHANH," +
                                "KHUYENMAI.PHANTRAMGIAMGIA,GIAY.SOLUONG,GIAY.GIA " +
                                "FROM GIAY,GIOITINH,THUONGHIEU,KHUYENMAI " +
                                "WHERE GIAY.MAGIOITINH = GIOITINH.MAGIOITINH AND GIAY.MATHUONGHIEU = THUONGHIEU.MATHUONGHIEU " +
                                "AND GIAY.MAKHUYENMAI = KHUYENMAI.MAKHUYENMAI " +
                                "ORDER BY " + StringOrderBy;

            return dalCommon.getSelect(SQLSort);
        }
    }
}
