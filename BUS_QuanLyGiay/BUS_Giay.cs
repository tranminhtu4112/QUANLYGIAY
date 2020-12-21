using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_Giay
    {
        private DAL_Giay dallGiay = new DAL_Giay();

        public DataTable getAllGiay()
        {
            return dallGiay.getAllGiay();
        }
        public void AddGiay(DTO_Giay giay)
        {
            dallGiay.AddGiay(giay);
        }


    }
}
