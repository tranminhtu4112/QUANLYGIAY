using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_GioiTInh
    {
        private SqlConnection conn;
        private DAL_Common dalCommon = new DAL_Common();
        private DAL_ThuongHieu dalThuongHieu = new DAL_ThuongHieu();
        public DataTable getAllGioiTinh()
        {
            String SQLSelect = "SELECT * FROM GIOITINH";
            return dalCommon.getSelect(SQLSelect);
        }

        public bool addGioiTinh(DTO_GioiTinh dtoGioiTinh)
        {
            String SQLInsert = "INSERT INTO GIOITINH (MAGIOITINH, TENGIOITINH, MOTA) " +
                        "VALUES(@MAGIOITINH, @TENGIOITINH, @MOTA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAGIOITINH", dtoGioiTinh.maGioiTinh);
                sqlCommand.Parameters.AddWithValue("TENGIOITINH", dtoGioiTinh.tenGioiTinh);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoGioiTinh.moTa);
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
        public bool editGioiTinh(DTO_GioiTinh dtoGioiTinh)
        {
            String SQLUpdate = "UPDATE GIOITINH " +
                                "SET TENGIOITINH = @TENGIOITINH, MOTA = @MOTA " +
                                "WHERE MAGIOITINH = @MAGIOITINH";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLUpdate, conn);
                sqlCommand.Parameters.AddWithValue("TENGIOITINH", dtoGioiTinh.tenGioiTinh);
                sqlCommand.Parameters.AddWithValue("MOTA", dtoGioiTinh.moTa);
                sqlCommand.Parameters.AddWithValue("MAGIOITINH", dtoGioiTinh.maGioiTinh);
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
        public bool deleteGioiTinh(String maGioiTinh)
        {
            String SQLDelete = "DELETE FROM GIOITINH WHERE MAGIOITINH = @MAGIOITINH";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MAGIOITINH", maGioiTinh);
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
