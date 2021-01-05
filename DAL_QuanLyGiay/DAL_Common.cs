using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_Common
    {
        private SqlConnection conn;
        public DataTable getSelect(String sqlSelect)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter(sqlSelect, conn);
                db.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }
        public bool thucThiSql(String sql)
        {
            try
            {
                conn = new DBConnection().getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
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
