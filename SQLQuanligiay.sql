CREATE DATABASE QUANLYGIAY_MAIN
USE QUANLYGIAY_MAIN

CREATE TABLE THUONGHIEU(
	ID INT IDENTITY PRIMARY KEY,
	MATHUONGHIEU VARCHAR(10) NOT NULL UNIQUE,
	TENTHUONGHIEU NVARCHAR(50),
	MOTA NVARCHAR(500),
	HINHANH IMAGE
)
CREATE TABLE GIOITINH(
	ID int IDENTITY primary key,
	MAGIOITINH VARCHAR(10) NOT NULL UNIQUE,
	TENGIOITINH NVARCHAR(20) NOT NULL,
	MOTA NVARCHAR(500),
)
CREATE TABLE KHUYENMAI(
	ID int IDENTITY primary key,
	MAKHUYENMAI VARCHAR(10) NOT NULL UNIQUE,
	TENSUKIEN NVARCHAR(100),
	PHANTRAMGIAMGIA FLOAT DEFAULT 0
)
CREATE TABLE GIAY(
	ID int NOT NULL IDENTITY primary key,
	MAGIAY VARCHAR(10) NOT NULL UNIQUE,
	TENGIAY NVARCHAR(50)NOT NULL, 
	MAGIOITINH VARCHAR(10) NOT NULL,
	MATHUONGHIEU VARCHAR(10) NOT NULL,
	MOTA NVARCHAR(400),
	HINHANH IMAGE,
	MAKHUYENMAI VARCHAR(10),
	SOLUONG INT DEFAULT 0,
	GIA FLOAT NOT NULL
)
ALTER TABLE GIAY
ADD FOREIGN KEY(MATHUONGHIEU) REFERENCES THUONGHIEU(MATHUONGHIEU)
ALTER TABLE GIAY
ADD FOREIGN KEY(MAGIOITINH) REFERENCES GIOITINH(MAGIOITINH)
ALTER TABLE GIAY
ADD FOREIGN KEY(MAKHUYENMAI) REFERENCES KHUYENMAI(MAKHUYENMAI)

CREATE TABLE HOADON(
	ID int NOT NULL IDENTITY primary key,
	MAHOADON VARCHAR(10) NOT NULL UNIQUE,
	MANHANVIEN VARCHAR(10) NOT NULL,
	TENKHACHHANG NVARCHAR(50) NOT NULL,
	NGAYLAPDON DATE,
	GIA FLOAT
) 

CREATE TABLE CHITIETHOADON(
	MAHOADON VARCHAR(10),
	MAGIAY VARCHAR(10),
	PRIMARY KEY (MAHOADON, MAGIAY),
	SOLUONG INT,
	GIA FLOAT
) 

ALTER TABLE CHITIETHOADON
ADD FOREIGN KEY(MAGIAY) REFERENCES GIAY(MAGIAY)
ALTER TABLE CHITIETHOADON
ADD FOREIGN KEY(MAHOADON) REFERENCES HOADON(MAHOADON)

CREATE TABLE DONDATHANG(
	ID int NOT NULL IDENTITY primary key,
	MADONDATHANG VARCHAR(10) NOT NULL UNIQUE,
	MANHANVIEN VARCHAR(10) NOT NULL,
	TENKHACHHANG NVARCHAR(50) NOT NULL,
	SODIENTHOAI VARCHAR(15) NOT NULL,
	DIACHIGIAO NVARCHAR(100) NOT NULL,
	NGAYLAPDON DATE,
	NGAYGIAODON DATE,
	GIA FLOAT,
	MATRANGTHAI int NOT NULL
)
CREATE TABLE CHITIETDONDATHANG(
	MADONDATHANG VARCHAR(10),
	MAGIAY VARCHAR(10),
	PRIMARY KEY (MADONDATHANG, MAGIAY),
	SOLUONG INT,
	GIA FLOAT
) 
ALTER TABLE CHITIETDONDATHANG
ADD FOREIGN KEY(MAGIAY) REFERENCES GIAY(MAGIAY)
ALTER TABLE CHITIETDONDATHANG
ADD FOREIGN KEY(MADONDATHANG) REFERENCES DONDATHANG(MADONDATHANG)

CREATE TABLE NHANVIEN(
	ID int NOT NULL IDENTITY primary key,
	MANHANVIEN VARCHAR(10) NOT NULL UNIQUE,
	TENNHANVIEN NVARCHAR(50) NOT NULL,
	CMND VARCHAR(15),
	NGAYSINH DATE,
	QUEQUAN NVARCHAR(100),
	DIACHI NVARCHAR(100),
	USERNAME VARCHAR(50),
	UPASSWORD VARCHAR(50),
	TRANGTHAIDANGNHAP INT DEFAULT 0
)
DROP TABLE NHANVIEN
CREATE TABLE TRANGTHAI(
	MATRANGTHAI int primary key,
	TENTRANGTHAI NVARCHAR(50) NOT NULL UNIQUE,
)
INSERT INTO TRANGTHAI (MATRANGTHAI,TENTRANGTHAI)
VALUES (1,'Đang giao')
INSERT INTO TRANGTHAI (MATRANGTHAI,TENTRANGTHAI)
VALUES (2,'Đã giao')
INSERT INTO TRANGTHAI (MATRANGTHAI,TENTRANGTHAI)
VALUES (3,'Đã huy')

ALTER TABLE DONDATHANG
ADD FOREIGN KEY(MATRANGTHAI) REFERENCES TRANGTHAI(MATRANGTHAI)


select * from HOADON
SELECT HOADON.MAHOADON, NHANVIEN.TENNHANVIEN, HOADON.TENKHACHHANG, FORMAT (HOADON.NGAYLAPDON, 'dd-MM-yyyy') as date, HOADON.GIA 
                        FROM HOADON, NHANVIEN 
                        WHERE HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN

						select * from HOADON

						select * from NHANVIEN

update NHANVIEN SET TRANGTHAIDANGNHAP = 0 where USERNAME = 'tu'
