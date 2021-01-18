using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    
    public class BUS_ChiTietDonDatHang
    {
        private DAL_Common dalCommon = new DAL_Common();
        private DAL_ChiTietDonDatHang dalChiTietDonDatHang = new DAL_ChiTietDonDatHang();
        public bool delelteChiTietDonDatHang(String maDonDatHang)
        {
            return dalChiTietDonDatHang.deleteChiTietHoaDon(maDonDatHang);
        }
      
        public DataTable getMaGiayandSoLuongByMaDonDatHang(String maDonDatHang)
        {
            String SQLSelect = "SELECT CHITIETDONDATHANG.MAGIAY, CHITIETDONDATHANG.SOLUONG, GIAY.SOLUONG " +
                                "FROM CHITIETDONDATHANG, GIAY " +
                                "WHERE CHITIETDONDATHANG.MAGIAY = GIAY.MAGIAY AND MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool addChiTietDonDatHang(DTO_ChiTietDonDatHang dtoChiTietDonDatHangg)
        {
            return dalChiTietDonDatHang.addChiTietDonDatHang(dtoChiTietDonDatHangg);
        }
        public bool UpdateSoLuongAndGia(String maDonDatHang, String maGiay, int soLuong, float gia)
        {
            String mg = "'" + maGiay + "'";
            String mddh = "'" + maDonDatHang + "'";
            String SQLUpdate = "UPDATE CHITIETDONDATHANG SET SOLUONG = " + soLuong + ", GIA = " + gia +
                " WHERE MAGIAY = " + mg + " AND MADONDATHANG = " + mddh;
            return dalCommon.thucThiSql(SQLUpdate);
        }
        public DataTable getViewChiTietDonDatHangByMaDonDatHang(String maDonDatHang)
        {
            return dalChiTietDonDatHang.getViewChiTietDonDatHangByMaDonDatHang(maDonDatHang);
        }
        public DataTable get2SoLuongbyMaHoaDonandMaGiay(String maDonDatHang, String maGiay)
        {
            String SQLSelect = "SELECT CHITIETDONDATHANG.SOLUONG, GIAY.SOLUONG " +
                "FROM CHITIETDONDATHANG, GIAY " +
                "WHERE CHITIETDONDATHANG.MAGIAY = GIAY.MAGIAY AND MADONDATHANG = '" + maDonDatHang + "'" +
                " AND CHITIETDONDATHANG.MAGIAY = '" + maGiay + "'";
            return dalCommon.getSelect(SQLSelect);
        }
        public bool deleteChiTietDonDatHang(String maDonDatHang, String maGiay)
        {
            return dalChiTietDonDatHang.deleteChiTietDonDatHang(maDonDatHang, maGiay);
        }
        public DataTable getMaGiayandSoLuongByMaHoaDon(String maDonDatHang)
        {
            String SQLSelect = "SELECT CHITIETDONDATHANG.MAGIAY, CHITIETDONDATHANG.SOLUONG, GIAY.SOLUONG " +
                                "FROM CHITIETDONDATHANG, GIAY " +
                                "WHERE CHITIETDONDATHANG.MAGIAY = GIAY.MAGIAY AND MADONDATHANG = '" + maDonDatHang + "'";
            return dalCommon.getSelect(SQLSelect);
        }
    }
}
