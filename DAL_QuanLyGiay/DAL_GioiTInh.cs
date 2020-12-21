using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_GioiTInh
    {
        private DAL_Common dalCommon = new DAL_Common();
        public DataTable getAllGioiTinh()
        {
            String SQLSelect = "SELECT * FROM GIOITINH";
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
