using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
    public class DTO_DangNhap
    {
        public String userName { get; set; }
        public String password { get; set; }

        public DTO_DangNhap()
        {

        }
        public DTO_DangNhap(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
