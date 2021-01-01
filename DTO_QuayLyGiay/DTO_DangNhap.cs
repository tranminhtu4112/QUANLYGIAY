using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_DangNhap
    {
        public String tenNhanVien { get; set; }
        public String userName { get; set; }
        public String password { get; set; }

        public DTO_DangNhap()
        {

        }
        public DTO_DangNhap(String tenNhanVien, String userName, String password)
        {
            this.tenNhanVien = tenNhanVien;
            this.userName = userName;
            this.password = password;
        }
    }
}
