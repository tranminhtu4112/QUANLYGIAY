using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DBConnection
    {
        String SQLConnect = @"Data Source=VAIO\SQLEXPRESS;Initial Catalog=QUANLYGIAY;Integrated Security=True";
    
        public SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(SQLConnect);
            return conn;
        }
    }
}
