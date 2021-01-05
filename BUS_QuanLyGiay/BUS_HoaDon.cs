using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon dalHoaDon = new DAL_HoaDon();
        private DAL_Common dalCommon = new DAL_Common();

        public bool addHoaDon(DTO_HoaDon dtoHoaDon)
        {
            return dalHoaDon.addHoaDon(dtoHoaDon);
        }
        public int getMaxID()
        {
            String SQLSelect = "SELECT MAX(HOADON.ID) FROM HOADON";

            DataTable tableId = dalCommon.getSelect(SQLSelect);
            try
            {
                return int.Parse(tableId.Rows[0][0].ToString());
            }
            catch
            {
                return 1;
            }
        }
        public bool deleteHoaDon(String maHoaDon)
        {
            return dalHoaDon.deleteHoaDon(maHoaDon);
        }
    }
}
