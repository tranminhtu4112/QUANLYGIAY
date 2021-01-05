using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL_QuanLyGiay;
using DTO_QuayLyGiay;

namespace BUS_QuanLyGiay
{
    public class BUS_KhuyenMai
    {
        private DAL_Common dalCommon = new DAL_Common();
        private DAL_KhuyenMai dalKhuyenMai = new DAL_KhuyenMai();
        public DataTable getAllKhuyenMai()
        {
            return dalKhuyenMai.getAllKhuyenMai();
        }
        public bool addKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            return dalKhuyenMai.addKhuyenMai(dtoKhuyenMai);
        }
        public bool editKhuyenMai(DTO_KhuyenMai dtoKhuyenMai)
        {
            return dalKhuyenMai.editKhuyenMai(dtoKhuyenMai);
        }
        public bool deleteKhuyenMai(String maKhuyenMai)
        {
            return dalKhuyenMai.deleteKhuyenMai(maKhuyenMai);
        }
        public float GetPhanTramGiamGiaTheoMaGiay(String maGiay)
        {
            String SQLSelect = "SELECT GIAY.MAKHUYENMAI FROM GIAY WHERE GIAY.MAGIAY = " + maGiay;
            DataTable maKhuyenMai = dalCommon.getSelect(SQLSelect);

            return dalKhuyenMai.GetPhanTramGiamGia(maKhuyenMai.Rows[0][0].ToString());
        }
    }
}
