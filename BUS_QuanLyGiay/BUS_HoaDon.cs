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

        public DataTable getViewHoaDon()
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " + 
                        "FROM HOADON, NHANVIEN " +
                        "WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewSapXep(String condt)
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " +
                        "FROM HOADON, NHANVIEN " +
                        "WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN " + condt;
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewByMaHoaDon(String maHoaDon)
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " +
                        "FROM HOADON, NHANVIEN " +
                        "WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN AND HOADON.MAHOADON = '" + maHoaDon  + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewByDate(String date)
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " +
                        "FROM HOADON, NHANVIEN " +
                        "WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN AND HOADON.NGAYLAPDON = '" + date + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable getViewDateToDate(String dateFrom, String dateTo)
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " +
                        "FROM HOADON, NHANVIEN " +
                        "WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN AND HOADON.NGAYLAPDON >= '" + dateFrom + "' AND HOADON.NGAYLAPDON <= '" + dateTo + "'";
            return dalCommon.getSelect(SQLSelect);
        }
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
        public bool updateHoaDon(DTO_HoaDon dtoHoaDon)
        {
            return dalHoaDon.updateHoaDon(dtoHoaDon);
        }
        public DataTable getViewThongKe(String whereSelect)
        {
            String SQLSelect = "SELECT HOADON.MAHOADON, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA " +
                        "FROM HOADON " +
                        "WHERE " + whereSelect;
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
