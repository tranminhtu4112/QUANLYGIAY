using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_ChiTietHoaDon
    {
        private DAL_Common dalCommon = new DAL_Common();
        private DAL_ChiTietHoaDon dalChiTietHoaDon = new DAL_ChiTietHoaDon();
        public bool addChiTietHoaDon(DTO_ChiTietHoaDon dtoChiTietHoaDon)
        {
            return dalChiTietHoaDon.addChiTietHoaDon(dtoChiTietHoaDon);
        }
        public bool deleteChiTietHoaDon(String maHoDon)
        {
            return dalChiTietHoaDon.deleteChiTietHoaDon(maHoDon);
        }
        public bool deleteChiTietHoaDon(String maHoDon, String maGiay)
        {
            return dalChiTietHoaDon.deleteChiTietHoaDon(maHoDon, maGiay);
        }
        public DataTable getViewChiTietHoaDonByMaHoaDon(String maHoaDon)
        {
            return dalChiTietHoaDon.getViewChiTietHoaDonByMaHoaDon(maHoaDon);
        }
        public DataTable getMaGiayandSoLuongByMaHoaDon(String maHoaDon)
        {
            String SQLSelect = "SELECT CHITIETHOADON.MAGIAY, CHITIETHOADON.SOLUONG, GIAY.SOLUONG " +
                                "FROM CHITIETHOADON, GIAY " +
                                "WHERE CHITIETHOADON.MAGIAY = GIAY.MAGIAY AND MAHOADON = '" + maHoaDon +"'";
            return dalCommon.getSelect(SQLSelect);
        }
        public DataTable get2SoLuongbyMaHoaDonandMaGiay(String maHoaDon, String maGiay)
        {
            String SQLSelect = "SELECT CHITIETHOADON.SOLUONG, GIAY.SOLUONG " +
                "FROM CHITIETHOADON, GIAY " +
                "WHERE CHITIETHOADON.MAGIAY = GIAY.MAGIAY AND MAHOADON = '" + maHoaDon + "'" +
                " AND CHITIETHOADON.MAGIAY = '" + maGiay + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool UpdateSoLuong(String maHoaDon, String maGiay, int soLuong)
        {
            String mg = "'" + maGiay + "'";
            String mhd = "'" + maHoaDon + "'";
            String SQLUpdate = "UPDATE CHITIETHOADON SET SOLUONG = " + soLuong + 
                " WHERE MAGIAY = " + mg + "AND MAHOADON = " + mhd;
            return dalCommon.thucThiSql(SQLUpdate);
        }
        public bool UpdateSoLuongAndGia(String maHoaDon, String maGiay, int soLuong, float gia)
        {
            String mg = "'" + maGiay + "'";
            String mhd = "'" + maHoaDon + "'";
            String SQLUpdate = "UPDATE CHITIETHOADON SET SOLUONG = " + soLuong + ", GIA = " + gia +
                " WHERE MAGIAY = " + mg + " AND MAHOADON = " + mhd ;
            return dalCommon.thucThiSql(SQLUpdate);
        }
    }
}
