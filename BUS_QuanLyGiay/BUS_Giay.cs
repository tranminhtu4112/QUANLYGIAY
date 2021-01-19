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
        private DAL_Common dalCommon = new DAL_Common();
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
        public bool UpdateSoLuong(String maGiay, int soLuong)
        {
            String mg = "'" + maGiay + "'";
            String SQLUpdate = "UPDATE GIAY SET SOLUONG = " + soLuong + " WHERE MAGIAY = " + mg;
            return dalCommon.thucThiSql(SQLUpdate);
        }
        public DataTable getViewTrangChu()
        {
            String SQLSelect = "SELECT GIAY.MAGIAY, GIAY.TENGIAY, GIAY.HINHANH, GIAY.GIA - (KHUYENMAI.PHANTRAMGIAMGIA / 100 *  GIAY.GIA) " +
                               "FROM GIAY, KHUYENMAI " +
                                "WHERE GIAY.MAKHUYENMAI = KHUYENMAI.MAKHUYENMAI AND KHUYENMAI.PHANTRAMGIAMGIA > 0";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getGiayByMaGiay(String maGiay)
        {
            String SQLSelect = "SELECT * FROM GIAY WHERE MAGIAY = '" + maGiay + "'";
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
