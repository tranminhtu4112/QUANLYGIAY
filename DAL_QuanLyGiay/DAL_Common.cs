using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_Common
    {
        private SqlConnection conn = new DBConnection().getConnection();
        public DataTable getSelect(String sqlSelect)
        {
            DataTable dataTable = new DataTable();
            try
            {
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
    }
}
