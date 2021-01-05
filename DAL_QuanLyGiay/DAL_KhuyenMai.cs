using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace DAL_QuanLyGiay
{
    public class DAL_KhuyenMai
    {
        private SqlConnection conn;
        private DAL_Common dalCommon = new DAL_Common();
        public DataTable getAllKhuyenMai()
        {
            String SQLSelect = "SELECT * FROM KHUYENMAI";
            return dalCommon.getSelect(SQLSelect);
        }

        public bool addKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            String SQLInsert = "INSERT INTO KHUYENMAI (MAKHUYENMAI, TENSUKIEN, PHANTRAMGIAMGIA) " +
                        "VALUES(@MAKHUYENMAI, @TENSUKIEN, @PHANTRAMGIAMGIA)";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLInsert, conn);
                sqlCommand.Parameters.AddWithValue("MAKHUYENMAI", dtoKhuyenMai.maKhuyenMai);
                sqlCommand.Parameters.AddWithValue("TENSUKIEN", dtoKhuyenMai.tenSuKien);
                sqlCommand.Parameters.AddWithValue("PHANTRAMGIAMGIA", dtoKhuyenMai.phanTramGiamGia);
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
        public bool editKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            String SQLUpdate = "UPDATE KHUYENMAI " +
                                "SET TENSUKIEN = @TENSUKIEN, PHANTRAMGIAMGIA = @PHANTRAMGIAMGIA " +
                                "WHERE MAKHUYENMAI = @MAKHUYENMAI";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLUpdate, conn);
                sqlCommand.Parameters.AddWithValue("MAKHUYENMAI", dtoKhuyenMai.maKhuyenMai);
                sqlCommand.Parameters.AddWithValue("TENSUKIEN", dtoKhuyenMai.tenSuKien);
                sqlCommand.Parameters.AddWithValue("PHANTRAMGIAMGIA", dtoKhuyenMai.phanTramGiamGia);
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
        public bool deleteKhuyenMai(String maKhuyenMai)
        {
            String SQLDelete = "DELETE FROM KHUYENMAI WHERE MAKHUYENMAI = @MAKHUYENMAI";
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQLDelete, conn);
                sqlCommand.Parameters.AddWithValue("MAKHUYENMAI", maKhuyenMai);
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
        public float GetPhanTramGiamGia(String maKhuyenMai)
        {
            String SQLSelect = "SELECT KHUYENMAI.PHANTRAMGIAMGIA " +
                                "FROM KHUYENMAI WHERE KHUYENMAI.MAKHUYENMAI = " + maKhuyenMai;

            DataTable tablePhamTramGiamGia = dalCommon.getSelect(SQLSelect);

            return float.Parse(tablePhamTramGiamGia.Rows[0][0].ToString());
        }
    }
}
