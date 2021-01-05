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
    }
}
