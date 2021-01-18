using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuayLyGiay
{
	/*MADONDATHANG VARCHAR(10) NOT NULL UNIQUE,
	MANHANVIEN VARCHAR(10) NOT NULL,
	TENKHACHHANG NVARCHAR(50) NOT NULL,
	SODIENTHOAI VARCHAR(15) NOT NULL,
	DIACHIGIAO NVARCHAR(100) NOT NULL,
	NGAYLAPDON DATE,
	NGAYGIAODON DATE,
	GIA FLOAT,
	MATRANGTHAI VARCHAR(10) NOT NULL*/

	public class DTO_DonDatHang
    {
		public String maDonDatHang { set; get; }
		public String maNhanVien { set; get; }
		public String tenKhachHang { set; get; }
		public String soDienThoai { set; get; }
		public String diaChiGiao { set; get; }
		public String ngayLapDon { get; set; }
		public String ngayGiaoDon { get; set; }
		public float gia { get; set; }
		public int maTrangThai { set; get; }

        public DTO_DonDatHang()
        {
			this.ngayLapDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
		}

		public DTO_DonDatHang(String maDonDatHang, String maNhanVien, String tenKhachHang, String soDienThoai,
								String diaChiGiao, String ngayGiaoDon, float gia, int maTrangThai)
		{
			this.maDonDatHang = maDonDatHang;
			this.maNhanVien = maNhanVien;
			this.tenKhachHang = tenKhachHang;
			this.soDienThoai = soDienThoai;
			this.diaChiGiao = diaChiGiao;
			this.ngayLapDon = DateTime.UtcNow.ToString("MM-dd-yyyy");
			this.ngayGiaoDon = ngayGiaoDon;
			this.gia = gia;
			this.maTrangThai = maTrangThai;
		}
	}
}
