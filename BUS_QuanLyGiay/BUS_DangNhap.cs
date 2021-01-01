using DAL_QuanLyGiay;
using DTO_QuayLyGiay;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLyGiay
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();
        public DTO_DangNhap dataTableToDTO_DangNhap(DataTable dataTable) //Chuyển database sang Obj
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return null;
            }
            DTO_DangNhap dTO_DangNhap = new DTO_DangNhap();
            foreach (DataRow dr in dataTable.Rows)
            {
                dTO_DangNhap.tenNhanVien = dr["tennhanvien"].ToString();
                dTO_DangNhap.userName = dr["username"].ToString();
                dTO_DangNhap.password = dr["upassword"].ToString();
            }
            return dTO_DangNhap;
        }
        public bool isUser(DTO_DangNhap dTO_DangNhap)
        {
            if(dataTableToDTO_DangNhap(dalDangNhap.getSelectUser(dTO_DangNhap)) != null)
            {
                return true;
            }
            return false;
        }
        public DTO_DangNhap getUser(DTO_DangNhap dTO_DangNhap)
        {
            return dataTableToDTO_DangNhap(dalDangNhap.getSelectUser(dTO_DangNhap));
        }
    }
}
