using DAL_QuanLyGiay;
using System;
using System.Collections.Generic;
using System.Text;
using DTO_QuayLyGiay;
using System.Data;

namespace BUS_QuanLyGiay
{
    public class BUS_DonDatHang
    {
        private DAL_Common dalCommon = new DAL_Common();
        private DAL_DonDatHang dalDonDatHang = new DAL_DonDatHang();
        public DataTable getAllDonDatHang(String maDonDatHang)
        {
            String SQLSelect = "SELECT * FROM DONDATHANG WHERE DONDATHANG.MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool addDonDatHang(DTO_DonDatHang dtoDonDatHang)
        {
            return dalDonDatHang.addDonDatHang(dtoDonDatHang);
        }
        public int getMaxID()
        {
            String SQLSelect = "SELECT MAX(DONDATHANG.ID) FROM DONDATHANG";

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
        public DataTable getViewDonDatHang()
        {
            
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                        "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                        "FROM DONDATHANG, TRANGTHAI " +
                        "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewSapXep(String condt)
        {
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                        "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                        "FROM DONDATHANG, TRANGTHAI " +
                        "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI " + condt;
            return dalCommon.getSelect(SQLSelect);
        }
        public bool deleteDonDatHang(String maDonDatHang)
        {
            return dalDonDatHang.deleteDonDatHang(maDonDatHang);
        }
        public bool updateDonDatHang(DTO_DonDatHang dtoDonDatHang)
        {
            return dalDonDatHang.updateDonDatHang(dtoDonDatHang);
        }
        public DataTable getViewByDate(String date)
        {
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                        "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                        "FROM DONDATHANG, TRANGTHAI " +
                        "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI AND DONDATHANG.NGAYLAPDON = '" + date + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewByTrangThai(String trangThai)
        {
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                        "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                        "FROM DONDATHANG, TRANGTHAI " +
                        "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI " + trangThai;
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewDateToDate(String dateFrom, String dateTo)
        {
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                       "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                       "FROM DONDATHANG, TRANGTHAI " +
                       "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI AND DONDATHANG.NGAYLAPDON >= '" + dateFrom + "' AND DONDATHANG.NGAYLAPDON <= '" + dateTo + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewByMaDonDatHang(String maDonDatHang)
        {
            String SQLSelect = "SELECT DONDATHANG.MADONDATHANG, DONDATHANG.TENKHACHHANG, FORMAT(DONDATHANG.NGAYLAPDON, 'dd-MM-yyyy') as NGAYLAP, FORMAT(DONDATHANG.NGAYGIAODON, 'dd-MM-yyyy') as NgayGiao, " +
                       "DONDATHANG.GIA, TRANGTHAI.TENTRANGTHAI " +
                       "FROM DONDATHANG, TRANGTHAI " +
                       "WHERE DONDATHANG.MATRANGTHAI = TRANGTHAI.MATRANGTHAI AND DONDATHANG.MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool updateTrangThai(String maDonDatHang, int maTrangThai)
        {
            String SQLUpdate = "UPDATE DONDATHANG SET MATRANGTHAI = " + maTrangThai + " WHERE MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.thucThiSql(SQLUpdate);
        }
        public DataTable getViewThongKe(String whereSelect)
        {
            String SQLSelect = "SELECT MADONDATHANG, FORMAT (NGAYLAPDON, 'dd-MM-yyyy') as date, GIA " +
                        "FROM DONDATHANG " +
                        "WHERE " + whereSelect;
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
