using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_ThuongHieu
    {
        private SqlConnection conn;
        DAL_Common dalCommon = new DAL_Common();
        public DataTable getAllThuongHieu()
        {
            String SQLSelect = "SELECT * FROM THUONGHIEU";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getAllThuongHieu(String sqlGetAll)
        {
            return dalCommon.getSelect(sqlGetAll);
        }
        public bool addThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            String SQLInsert = "INSERT INTO THUONGHIEU (MATHUONGHIEU, TENTHUONGHIEU, MOTA, HINHANH) " +
                        "VALUES(@MATHUONGHIEU, @TENTHUONGHIEU, @MOTA, @HINHANH)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MATHUONGHIEU", dtoThuongHieu.maThuongHieu);
                sqlCommand.Parameters.AddWithValue("TENTHUONGHIEU", dtoThuongHieu.tenThuongHieu);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoThuongHieu.moTa);
                sqlCommand.Parameters.AddWithValue("HINHANH", dtoThuongHieu.hinhAnh);
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
        public bool editThuongHieu(DTO_ThuongHieu dtoThuongHieu)
        {
            String SQLUpdate = "UPDATE THUONGHIEU " +
                                "SET TENTHUONGHIEU = @TENTHUONGHIEU, MOTA = @MOTA, HINHANH = @HINHANH " +
                                "WHERE MATHUONGHIEU = @MATHUONGHIEU";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLUpdate, conn);
                sqlCommand.Parameters.AddWithValue("TENTHUONGHIEU", dtoThuongHieu.tenThuongHieu);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoThuongHieu.moTa);
                sqlCommand.Parameters.AddWithValue("HINHANH", dtoThuongHieu.hinhAnh);
                sqlCommand.Parameters.AddWithValue("MATHUONGHIEU", dtoThuongHieu.maThuongHieu);
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
        public bool deleteThuongHieu(String maThuongHieu)
        {
            String SQLDelete = "DELETE FROM THUONGHIEU WHERE MATHUONGHIEU = @MATHUONGHIEU";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MATHUONGHIEU", maThuongHieu);
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
