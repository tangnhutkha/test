create database HeThongBanVeXe

use master

use HeThongBanVeXe


Create table [DIADIEM]
(
	[MADD] Char(5) NOT NULL,
	[TENDD] Nvarchar(50) NULL,
Primary Key ([MADD])
) 
go

Create table [LOTRINH]
(
	[MADIEMDI] Char(5) NOT NULL,
	[MADIMDEN] Char(5) NOT NULL,
	[KhoangCach] Decimal(6,1) NULL,
Primary Key ([MADIEMDI],[MADIMDEN])
) 
go

Create table [CHUYEN]
(
	[MACHUYEN] Char(5) NOT NULL,
	[TENCHUYEN] Nvarchar(50) NULL,
	[GioDi] Smalldatetime NULL,
	[GioDen] Smalldatetime NULL,
	[SoKM] Decimal(6,0) NULL,
Primary Key ([MACHUYEN])
) 
go

Create table [CT_CHUYEN_LOTRINH]
(
	[MACHUYEN] Char(5) NOT NULL,
	[MADIEMDI] Char(5) NOT NULL,
	[MADIMDEN] Char(5) NOT NULL,
Primary Key ([MACHUYEN],[MADIEMDI],[MADIMDEN])
) 
go

Create table [XE]
(
	[BIENSO] Char(10) NOT NULL,
	[SOCHO] Tinyint NULL,
	[MALX] Char(3) NOT NULL,
	[MADV] Char(10) NOT NULL,
Primary Key ([BIENSO])
) 
go

Create table [LICHCHAY]
(
	[MALC] Integer identity NOT NULL,
	[TENLC] Nvarchar(100) NULL,
	[NgayTao] Smalldatetime NULL,
	[ApDungTuNgay] Smalldatetime NULL,
	[DenNgay] Smalldatetime NULL,
Primary Key ([MALC])
) 
go

Create table [CT_XE_LICHCHAY]
(
	[BIENSO] Char(10) NOT NULL,
	[MACHUYEN] Char(5) NOT NULL,
	[MALC] Integer NOT NULL,
	[TienVe] Bigint NULL,
Primary Key ([BIENSO],[MALC])
) 
go

Create table [VE]
(
	[ID_VE] Char(10) NOT NULL,
	[NgayIn] Smalldatetime NULL,
	[NgayLenXe] Smalldatetime NULL,
	[GioLenXe] Smalldatetime NULL,
	[QRCode] Char(50) NULL,
	[BIENSO] Char(10) NOT NULL,
	[MALC] Integer NOT NULL,
	[MAKH] Char(10) NOT NULL,
Primary Key ([ID_VE])
) 
go

Create table [SODOGHE]
(
	[MASDG] Integer NOT NULL,
	[TENSDG] Nvarchar(50) NULL,
	[HINH_SDG] Image NULL,
	[BIENSO] Char(10) NOT NULL,
Primary Key ([MASDG])
) 
go

Create table [LOAIXE]
(
	[MALX] Char(3) NOT NULL,
	[TENLX] Nvarchar(50) NULL,
Primary Key ([MALX])
) 
go

Create table [DVVANTAI]
(
	[MADV] Char(10) NOT NULL,
	[TENDV] Nvarchar(50) NULL,
	[ID] int NOT NULL,
	[EmailDV] Varchar(50) NULL,
	[SDTDV] int NULL,
Primary Key ([MADV])
) 
go

Create table [TTKHACHHANG]
(
	[MAKH] Char(10) NOT NULL,
	[TENKH] Nvarchar(50) NULL,
	[SDT] int NULL,
	[Email] Varchar(50) NULL,
Primary Key ([MAKH])
) 
go

Create table [LOAIHANGHOA]
(
	[MALOAIHH] Char(10) NOT NULL,
	[TenLHH] Nvarchar(50) NOT NULL,
	[QuyCachTinh] Nvarchar(30) NULL,
	[DonGia] Bigint NULL,
Primary Key ([MALOAIHH])
) 
go

Create table [PHIEUGOIHANG]
(
	[SOPGH] int identity NOT NULL,
	[ID_VE] Char(10) NOT NULL,
	[NgayLapPGH] Smalldatetime NULL,
	[TONGTIEN] Bigint NULL,
Primary Key ([SOPGH])
) 
go

Create table [CT_GOIHANG]
(
	[SOPGH] int  NOT NULL,
	[MALOAIHH] Char(10) NOT NULL,
	[SoLuongHH] Tinyint NULL,
	[ThanhTien] Bigint NULL,
Primary Key ([SOPGH],[MALOAIHH])
) 
go

Create table [User]
(
	[ID] int identity NOT NULL,
	[UserName] Varchar(50) NULL,
	[Password] Varchar(50) NULL,
	[Type] Char(3) NULL,
	[Status] Bit NULL,
Primary Key ([ID])
) 
go


Alter table [LOTRINH] add  foreign key([MADIEMDI]) references [DIADIEM] ([MADD])  on update no action on delete no action 
go
Alter table [LOTRINH] add  foreign key([MADIMDEN]) references [DIADIEM] ([MADD])  on update no action on delete no action 
go
Alter table [CT_CHUYEN_LOTRINH] add  foreign key([MADIEMDI],[MADIMDEN]) references [LOTRINH] ([MADIEMDI],[MADIMDEN])  on update no action on delete no action 
go
Alter table [CT_CHUYEN_LOTRINH] add  foreign key([MACHUYEN]) references [CHUYEN] ([MACHUYEN])  on update no action on delete no action 
go
Alter table [CT_XE_LICHCHAY] add  foreign key([MACHUYEN]) references [CHUYEN] ([MACHUYEN])  on update no action on delete no action 
go
Alter table [CT_XE_LICHCHAY] add  foreign key([BIENSO]) references [XE] ([BIENSO])  on update no action on delete no action 
go
Alter table [SODOGHE] add  foreign key([BIENSO]) references [XE] ([BIENSO])  on update no action on delete no action 
go
Alter table [CT_XE_LICHCHAY] add  foreign key([MALC]) references [LICHCHAY] ([MALC])  on update no action on delete no action 
go
Alter table [VE] add  foreign key([BIENSO],[MALC]) references [CT_XE_LICHCHAY] ([BIENSO],[MALC])  on update no action on delete no action 
go
Alter table [PHIEUGOIHANG] add  foreign key([ID_VE]) references [VE] ([ID_VE])  on update no action on delete no action 
go
Alter table [XE] add  foreign key([MALX]) references [LOAIXE] ([MALX])  on update no action on delete no action 
go
Alter table [XE] add  foreign key([MADV]) references [DVVANTAI] ([MADV])  on update no action on delete no action 
go
Alter table [VE] add  foreign key([MAKH]) references [TTKHACHHANG] ([MAKH])  on update no action on delete no action 
go
Alter table [CT_GOIHANG] add  foreign key([MALOAIHH]) references [LOAIHANGHOA] ([MALOAIHH])  on update no action on delete no action 
go
Alter table [CT_GOIHANG] add  foreign key([SOPGH]) references [PHIEUGOIHANG] ([SOPGH])  on update no action on delete no action 
go
Alter table [DVVANTAI] add  foreign key([ID]) references [User] ([ID])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


