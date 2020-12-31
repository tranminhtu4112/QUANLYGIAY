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
        private SqlConnection conn = new DBConnection().getConnection();
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
   "HINHANH=@HINHANH,MAKHUYENMAI=@MAKHUYENMAI,SOLUONG=@SOLUONG,GIA=@GIA" +
                                "WHERE MAGIAY = @MAGIAY";
            try
            {
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
    }
}
