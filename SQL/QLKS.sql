USE master
DROP DATABASE QUANLY_KHACHSAN
create database QUANLY_KHACHSAN
use QUANLY_KHACHSAN

SET DATEFORMAT DMY

create table LOAIPHONG
(
	MaLoaiPhong char(5) not null,
	TenLoaiPhong varchar(255) unique,
	DonGiaTC money,
	SoLuong int,
	constraint pk_LOAIPHONG primary key (MaLoaiPhong),
)

create table DANHMUCPHONG
(
	MaPhong char(5) not null,
	TenPhong varchar(255) unique,
	TinhTrang varchar(255),
	MaLoaiPhong char(5),
	GhiChu varchar(255),
	constraint pk_DANHMUCPHONG primary key (MaPhong),
	constraint fk_DANHMUCPHONG_LOAIPHONG foreign key (MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
)



create table LOAIKHACHHANG
(
	MaLoaiKH char(5) not null,
	TenLoaiKH varchar(50) unique,
	HeSo decimal(11,2),
	constraint pk_LOAIKHACHHANG primary key (MaLoaiKH),
)

create table KHACHHANG
(
	MaKH char(5) not null,
	TenKH varchar(50),
	CMND varchar(50),
	DiaChi varchar(200),
	MaLoaiKH char(5),
	constraint pk_KHACHHANG primary key (MaKH),
	constraint fk_KHACHHANG_LOAIKHACHHANG foreign key (MaLoaiKH) references LOAIKHACHHANG(MaLoaiKH),
)

create table HOADON
(
	SoHD char(5) not null,
	TriGia money,
	TenKH varchar(200),
	DiaChi varchar(200),
	NgayLap smalldatetime,
	constraint pk_HOADON primary key (SoHD),
)

create table PHIEUTHUE
(
	MaPhieuThue char(5) not null,
	NgayBDThue smalldatetime,
	DonGia money,
	SoLuongKH int,
	MaPhong char(5),
	SoHD char(5),
	ThanhTien money,
	SoNgayThue int,
	constraint pk_PHIEUTHUE primary key (MaPhieuThue),
	constraint fk_PHIEUTHUE_HOADON foreign key (SoHD) references HOADON(SoHD),
	constraint fk_PHIEUTHUE_DANHMUCPHONG foreign key (MaPhong) references DANHMUCPHONG(MaPhong),
)

create table CT_PHIEUTHUE 
(
	MaPhieuThue char(5),
	MaKH char(5),
	constraint pk_CTPT primary key (MaPhieuThue, MaKH),
	constraint fk_CT_PHIEUTHUE_PHIEUTHUE foreign key (MaPhieuThue) references PHIEUTHUE(MaPhieuThue),
	constraint fk_CT_PHIEUTHUE_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH),
)


create table BAOCAO
(
	MaBaoCaoDT char(7) not null primary key,
	Thang int,
)

create table CT_BAOCAO 
(
	DoanhThu money,
	TiLe numeric(4,2),
	MaBaoCaoDT char(7),
	MaLoaiPhong char(5),
	constraint pk_CT_BAOCAO primary key (MaLoaiPhong, MaBaoCaoDT),
	constraint fk_CT_BAOCAO_LOAIPHONG foreign key (MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
	constraint fk_CT_BAOCAO_BAOCAO foreign key (MaBaoCaoDT) references BAOCAO(MaBaoCaoDT),
)

create table THAMSO
(
	TenTS varchar(255) not null primary key,
	GiaTri decimal(11,2)
)

CREATE TABLE ID
(
	MaLoaiPhong char(5),
	MaPhong char(5),
	MaLoaiKH char(5),
	MaKH char(5),
	SoHD char(5),
	MaPhieuThue char(5),
)

--CHECK GIA TRI THAM SO
ALTER TABLE THAMSO
ADD CONSTRAINT CHECK_GIATRI CHECK(GiaTri > 0)

--CHECK SO NGAY THUE
ALTER TABLE PHIEUTHUE
ADD CONSTRAINT CHECK_SONGAYTHUE CHECK(SoNgayThue >=0)

--CAP NHAT SO LUONG LOAI PHONG
CREATE TRIGGER trigg_PHONG ON DANHMUCPHONG
FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @MALPMOI CHAR(5); 
	DECLARE @MALPCU CHAR(5);
	SELECT @MALPMOI = MaLoaiPhong
	FROM INSERTED 
	SELECT @MALPCU = MaLoaiPhong
	FROM DELETED 

	UPDATE LOAIPHONG
	SET SoLuong = SoLuong + 1
	WHERE MaLoaiPhong = @MALPMOI

	UPDATE LOAIPHONG
	SET SoLuong = SoLuong - 1
	WHERE MaLoaiPhong = @MALPCU
END




--ALTER TABLE DANHMUCPHONG
--NOCHECK CONSTRAINT fk_DANHMUCPHONG_LOAIPHONG

--ALTER TABLE KHACHHANG
--NOCHECK CONSTRAINT fk_KHACHHANG_LOAIKHACHHANG

--ALTER TABLE PHIEUTHUE
--NOCHECK CONSTRAINT fk_PHIEUTHUE_HOADON

--ALTER TABLE PHIEUTHUE
--NOCHECK CONSTRAINT fk_PHIEUTHUE_DANHMUCPHONG

--ALTER TABLE CT_PHIEUTHUE
--NOCHECK CONSTRAINT fk_CT_PHIEUTHUE_PHIEUTHUE

--ALTER TABLE CT_PHIEUTHUE
--NOCHECK CONSTRAINT fk_CT_PHIEUTHUE_KHACHHANG

--ALTER TABLE CT_BAOCAO
--NOCHECK CONSTRAINT fk_CT_BAOCAO_LOAIPHONG

--ALTER TABLE CT_BAOCAO
--NOCHECK CONSTRAINT fk_CT_BAOCAO_BAOCAO

INSERT INTO LOAIPHONG VALUES('0','A',150000,0)
INSERT INTO LOAIPHONG VALUES('1','B',170000,0)
INSERT INTO LOAIPHONG VALUES('2','C',200000,0)

INSERT INTO LOAIKHACHHANG VALUES ('0','Noi Dia',1)
INSERT INTO LOAIKHACHHANG VALUES ('1','Nuoc Ngoai', 1.5)

INSERT INTO ID VALUES ('6','9','2','3','1','1')
INSERT INTO ID VALUES ('0','0','0','0','0','0')


INSERT INTO THAMSO VALUES('So khach toi da',3)
INSERT INTO THAMSO VALUES('So khach tieu chuan',2)
INSERT INTO THAMSO VALUES('Phu thu',0.25)

SELECT * FROM DANHMUCPHONG
SELECT * FROM LOAIPHONG
SELECT * FROM ID
SELECT * FROM THAMSO
SELECT * FROM LOAIKHACHHANG
SELECT * FROM KHACHHANG
SELECT * FROM PHIEUTHUE
SELECT * FROM CT_PHIEUTHUE
SELECT * FROM HOADON
SELECT * FROM LOAIKHACHHANG

TRUNCATE TABLE DANHMUCPHONG
DROP TABLE ID
TRUNCATE TABLE PHIEUTHUE
TRUNCATE TABLE KHACHHANG
drop table KHACHHANG
TRUNCATE TABLE THAMSO
TRUNCATE TABLE ID

UPDATE PHIEUTHUE
SET SoNgayThue = DATEDIFF(day, NgayBDThue ,'2022/12/21')
WHERE MaPhong IN (SELECT MaPhong
				  FROM DANHMUCPHONG
				  WHERE TenPhong = 'a')
UPDATE PHIEUTHUE
SET ThanhTien = SoNgayThue * DonGia
WHERE MaPhong IN (SELECT MaPhong
				  FROM DANHMUCPHONG
				  WHERE TenPhong = 'a')
UPDATE PHIEUTHUE
SET ThanhTien = null
SELECT NgayBDThue, DonGia FROM PHIEUTHUE WHERE MaPhong IN (SELECT MaPhong FROM DANHMUCPHONG WHERE TenPhong = 'a')

SELECT MAX(DonGiaTC)
FROM LOAIPHONG

SELECT GiaTri FROM THAMSO WHERE TenTS = 'So khach tieu chuan'