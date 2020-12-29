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
        public DataTable getAllGiay()
        {
            String SQLSelectAll = "SELECT * FROM GIAY";
            return new DAL_Common().getSelect(SQLSelectAll);
        }
        public DataTable getAllInfoGiay()
        {
            String SQLSelectAll = "SELECT GIAY.ID, GIAY.MA, LOAIGIAY.TENLOAI, GIAY.TEN, GIOITINH.TENGIOITINH AS 'GIOITINH', GIAY.MOTA, GIAY.HINHANH, GIAY.GIA "
                    + "FROM GIAY , GIOITINH , LOAIGIAY "
                    + "WHERE GIAY.GIOITINHGIAY = GIOITINH.ID AND GIAY.MALOAI = LOAIGIAY.MALOAI";
            return new DAL_Common().getSelect(SQLSelectAll);
        }
        /*public void AddGiay(DTO_Giay giay)
        {
            String sqlInsert = "INSERT INTO GIAY (MA, MALOAI, TEN, GIOITINHGIAY, MOTA, HINHANH, GIA) " +
                                "VALUES(@MA, @MALOAI, @TEN, @GIOITINHGIAY, @MOTA, @HINHANH, @GIA)";
            conn.Open();
            SqlCommand command = new SqlCommand(sqlInsert, conn);
            command.Parameters.AddWithValue("MA", giay.ma);
            command.Parameters.AddWithValue("MALOAI", giay.maLoai);
            command.Parameters.AddWithValue("TEN", giay.ten);
            command.Parameters.AddWithValue("GIOITINHGIAY", giay.gioiTinh);
            command.Parameters.AddWithValue("MOTA", giay.moTa);
            command.Parameters.AddWithValue("HINHANH", giay.hinhAnh);
            command.Parameters.AddWithValue("GIA", giay.gia);
            command.ExecuteNonQuery();
            conn.Close();
        }*/
    }
}
