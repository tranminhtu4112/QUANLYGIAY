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
        private DAL_Giay dalGiay = new DAL_Giay();
        public DataTable getAllGiay()
        {
            return dalGiay.getAllGiay();
        }
        public bool addGiay(DTO_Giay dtoGiay)
        {
            return dalGiay.addGiay(dtoGiay);
        }
        public bool editGiay(DTO_Giay dtoGiay)
        {
            return dalGiay.editGiay(dtoGiay);
        }
        public bool deleteGiay(String maGiay)
        {
            return dalGiay.deleteGiay(maGiay);
        }
        public DataTable getViewDetailGiay()
        {
            return dalGiay.getViewDetailGiay();
        }
        public DataTable getSapXepTheo(String StringOrderBy)
        {
            return dalGiay.getSapXepTheo(StringOrderBy);
        }
    }
}
