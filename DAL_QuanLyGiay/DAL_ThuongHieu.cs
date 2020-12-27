using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL_QuanLyGiay
{
    public class DAL_ThuongHieu
    {
        DAL_Common dalCommon = new DAL_Common();
        public DataTable getAllThuongHieu()
        {
            String SQLSelect = "SELECT * FROM THUONGHIEU";
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
