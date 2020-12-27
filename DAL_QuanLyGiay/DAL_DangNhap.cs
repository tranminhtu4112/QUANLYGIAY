﻿using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_DangNhap
    {
        private SqlConnection conn = new DBConnection().getConnection();
        public DataTable getSelectUser(DTO_DangNhap dTO_DangNhap) // Lấy user trả về datatable
        {
            String sqlSelect = "SELECT TOP 1 * FROM NHANVIEN WHERE " +
                                "USERNAME = @username AND PASSWORD = @password";
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, conn);
                sqlCommand.Parameters.AddWithValue("username", dTO_DangNhap.userName);
                sqlCommand.Parameters.AddWithValue("password", dTO_DangNhap.password);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                conn.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }
    }
}
