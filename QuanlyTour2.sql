USE [QuanlyTour2]
GO
/****** Object:  Table [dbo].[BOOKING]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOKING](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDOANDL] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaTour] [int] NOT NULL,
	[Siso] [int] NOT NULL,
	[GiaTour] [int] NOT NULL,
 CONSTRAINT [PK_BOOKING] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHIPHI]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHIPHI](
	[CHIPHI_ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCP] [nvarchar](50) NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_CHIPHI] PRIMARY KEY CLUSTERED 
(
	[CHIPHI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET](
	[IDCHITIET] [int] IDENTITY(1,1) NOT NULL,
	[MaTour] [int] NULL,
	[MaDiaDiem] [int] NULL,
	[thutu] [int] NULL,
 CONSTRAINT [PK_CHITIET] PRIMARY KEY CLUSTERED 
(
	[IDCHITIET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETCHIPHI]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETCHIPHI](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDOANDL] [int] NOT NULL,
	[ChiPhi_ID] [int] NOT NULL,
	[ThanhTien] [float] NULL,
	[TenCP] [nvarchar](50) NOT NULL,
	[TongCong] [float] NOT NULL,
 CONSTRAINT [PK_CHITIETCHIPHI] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIADIEM]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIADIEM](
	[MaDiaDiem] [int] IDENTITY(1,1) NOT NULL,
	[TenDiaDiem] [nvarchar](150) NULL,
	[DD_MoTa] [nvarchar](150) NULL,
 CONSTRAINT [PK_DIADIEM] PRIMARY KEY CLUSTERED 
(
	[MaDiaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANDL]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANDL](
	[MaDOANDL] [int] IDENTITY(1,1) NOT NULL,
	[NgayKhoiHanh] [datetime2](6) NOT NULL,
	[NgayKetThuc] [datetime2](6) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaTour] [int] NOT NULL,
	[TenDoan] [nvarchar](50) NOT NULL,
	[Soluong] [int] NULL,
	[ChiPhi] [float] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_DOANDL] PRIMARY KEY CLUSTERED 
(
	[MaDOANDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIATOUR]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIATOUR](
	[IDGIATOUR] [int] IDENTITY(1,1) NOT NULL,
	[TGBatDau] [datetime2](6) NOT NULL,
	[TGKetThuc] [datetime2](6) NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[MaTour] [int] NOT NULL,
	[STT] [int] NOT NULL,
 CONSTRAINT [PK_GIATOUR] PRIMARY KEY CLUSTERED 
(
	[IDGIATOUR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](150) NULL,
	[KH_NgaySinh] [datetime2](6) NULL,
	[KH_DiaChi] [nvarchar](150) NULL,
	[KH_SoDienThoai] [nvarchar](150) NULL,
	[KH_GioiTinh] [nvarchar](50) NULL,
	[KH_email] [nvarchar](50) NULL,
	[KH_CMND] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAICHIPHI]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICHIPHI](
	[LoaiCP_ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiCP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAICHIPHI] PRIMARY KEY CLUSTERED 
(
	[LoaiCP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHINHDULICH]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHINHDULICH](
	[MaLoaiHinh] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHinh] [nvarchar](150) NULL,
	[LH_MoTa] [nvarchar](150) NULL,
 CONSTRAINT [PK_LOAIHINHDULICH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](150) NULL,
	[NV_NgaySinh] [datetime2](6) NULL,
	[NV_SoDienThoai] [nvarchar](50) NULL,
	[NV_NhiemVu] [nvarchar](150) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOURDULICH]    Script Date: 12/31/2021 9:38:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOURDULICH](
	[MaTour] [int] IDENTITY(1,1) NOT NULL,
	[TenTour] [nvarchar](50) NULL,
	[DacDiem] [nvarchar](150) NULL,
	[IDGiaTour] [int] NULL,
	[MaDOANDL] [int] NULL,
	[MaLoaiHinh] [int] NULL,
	[MaDiaDiem] [int] NULL,
 CONSTRAINT [PK_TOURDULICH] PRIMARY KEY CLUSTERED 
(
	[MaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BOOKING] ON 

INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (23, 8, 2, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (24, 8, 3, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (29, 7, 2, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (30, 7, 3, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (31, 7, 5, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (32, 6, 2, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (33, 6, 3, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (34, 5, 2, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (35, 9, 2, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (36, 9, 3, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (37, 9, 5, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (38, 6, 6, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (39, 12, 2, 42, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (40, 12, 3, 42, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (42, 5, 6, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (43, 5, 3, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (44, 9, 6, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (45, 9, 9, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (46, 9, 6, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (47, 12, 5, 42, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (48, 12, 6, 42, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (49, 5, 12, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (51, 5, 5, 34, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (53, 14, 3, 45, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (54, 14, 5, 45, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (55, 14, 6, 45, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (56, 14, 2, 45, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (57, 14, 2, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (58, 15, 2, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (59, 15, 5, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (60, 15, 6, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (61, 19, 2, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (62, 19, 3, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (63, 19, 19, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (64, 19, 16, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (65, 6, 6, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (66, 6, 19, 33, 1, 0)
INSERT [dbo].[BOOKING] ([id], [MaDOANDL], [MaKH], [MaTour], [Siso], [GiaTour]) VALUES (67, 6, 20, 33, 1, 0)
SET IDENTITY_INSERT [dbo].[BOOKING] OFF
GO
SET IDENTITY_INSERT [dbo].[CHIPHI] ON 

INSERT [dbo].[CHIPHI] ([CHIPHI_ID], [TenCP], [ThanhTien]) VALUES (4, N'Chi Phí Ăn Uống', 0)
INSERT [dbo].[CHIPHI] ([CHIPHI_ID], [TenCP], [ThanhTien]) VALUES (5, N'Chi Phí Xe Cộ', 0)
INSERT [dbo].[CHIPHI] ([CHIPHI_ID], [TenCP], [ThanhTien]) VALUES (6, N'Chi Phí Phát Sinh', 0)
SET IDENTITY_INSERT [dbo].[CHIPHI] OFF
GO
SET IDENTITY_INSERT [dbo].[CHITIETCHIPHI] ON 

INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (6, 6, 0, NULL, N'Chi Phí Ăn Uống', 150000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (7, 6, 0, NULL, N'Chi Phí Xe Cộ', 350000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (10, 12, 0, NULL, N'Chi Phí Ăn Uống', 120000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (11, 5, 0, NULL, N'Chi Phí Xe Cộ', 160000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (14, 7, 0, NULL, N'Chi Phí Ăn Uống', 200000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (15, 7, 0, NULL, N'Chi Phí Xe Cộ', 600000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (16, 7, 0, NULL, N'Chi Phí Phát Sinh', 25000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (17, 9, 0, NULL, N'Chi Phí Ăn Uống', 120000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (18, 5, 0, NULL, N'Chi Phí Ăn Uống', 450000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (19, 12, 0, NULL, N'Chi Phí Xe Cộ', 220000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (20, 5, 0, NULL, N'Chi Phí Ăn Uống', 500000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (25, 15, 0, NULL, N'Chi Phí Ăn Uống', 1300000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (26, 15, 0, NULL, N'Chi Phí Xe Cộ', 152000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (29, 17, 0, NULL, N'Chi Phí Ăn Uống', 122500)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (30, 14, 0, NULL, N'Chi Phí Ăn Uống', 250000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (31, 19, 0, NULL, N'Chi Phí Ăn Uống', 120000)
INSERT [dbo].[CHITIETCHIPHI] ([id], [MaDOANDL], [ChiPhi_ID], [ThanhTien], [TenCP], [TongCong]) VALUES (32, 6, 0, NULL, N'Chi Phí Phát Sinh', 250000)
SET IDENTITY_INSERT [dbo].[CHITIETCHIPHI] OFF
GO
SET IDENTITY_INSERT [dbo].[DIADIEM] ON 

INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (7, N'Đà Lạt', N'12s')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (8, N'Nha Trang', N'BT')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (9, N'Phan Rang', N's')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (10, N'Bình Định', N's')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (11, N'Phan Thiết', N'd')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (12, N'Miền Tây', N'a')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (13, N'Cần Thơ', N'f')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (17, N'Long An', N'a')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem], [DD_MoTa]) VALUES (20, N'Đà Nẵng', N'a')
SET IDENTITY_INSERT [dbo].[DIADIEM] OFF
GO
SET IDENTITY_INSERT [dbo].[DOANDL] ON 

INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (5, CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-23T12:00:00.0000000' AS DateTime2), 6, 34, N'Đoàn FTU111', 5, 1110000, 3610000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (6, CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-23T12:00:00.0000000' AS DateTime2), 6, 33, N'Đoàn TDTU', 6, 750000, 4750000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (7, CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), 7, 34, N'DHSG', 3, 825000, 3825000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (9, CAST(N'2021-12-28T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-31T12:00:00.0000000' AS DateTime2), 8, 33, N'Đại Học Văn Hiến', 6, 120000, 2370000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (12, CAST(N'2021-12-30T12:00:00.0000000' AS DateTime2), CAST(N'2022-01-03T12:00:00.0000000' AS DateTime2), 4, 42, N'Đoàn ĐHXHNV', 4, 340000, 2540000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (14, CAST(N'2021-12-31T12:00:00.0000000' AS DateTime2), CAST(N'2022-01-06T12:00:00.0000000' AS DateTime2), 8, 33, N'Đoàn 1', 5, 250000, 3550000)
INSERT [dbo].[DOANDL] ([MaDOANDL], [NgayKhoiHanh], [NgayKetThuc], [MaNV], [MaTour], [TenDoan], [Soluong], [ChiPhi], [TongTien]) VALUES (19, CAST(N'2021-12-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-31T12:00:00.0000000' AS DateTime2), 6, 33, N'a', 4, 120000, 3420000)
SET IDENTITY_INSERT [dbo].[DOANDL] OFF
GO
SET IDENTITY_INSERT [dbo].[GIATOUR] ON 

INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (8, CAST(N'2021-12-22T00:25:50.1926000' AS DateTime2), CAST(N'2021-12-22T00:25:42.7462140' AS DateTime2), 2250000, 33, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (10, CAST(N'2021-12-23T00:48:51.8986730' AS DateTime2), CAST(N'2021-12-23T00:48:46.8857520' AS DateTime2), 2000000, 34, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (11, CAST(N'2021-12-23T13:31:16.3804830' AS DateTime2), CAST(N'2021-12-23T13:31:11.4149360' AS DateTime2), 3000000, 34, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (15, CAST(N'2021-12-27T02:37:23.6298680' AS DateTime2), CAST(N'2021-12-27T02:37:17.3430610' AS DateTime2), 1800000, 35, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (16, CAST(N'2021-12-27T02:37:29.5178690' AS DateTime2), CAST(N'2021-12-27T02:37:17.3430610' AS DateTime2), 2100000, 35, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (17, CAST(N'2021-12-27T02:37:55.9900240' AS DateTime2), CAST(N'2021-12-27T02:37:51.0575820' AS DateTime2), 1500000, 36, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (18, CAST(N'2021-12-27T02:38:02.5820380' AS DateTime2), CAST(N'2021-12-27T02:37:51.0575820' AS DateTime2), 1600000, 36, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (19, CAST(N'2021-12-27T02:38:07.4369050' AS DateTime2), CAST(N'2021-12-27T02:37:51.0575820' AS DateTime2), 1450000, 36, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (20, CAST(N'2021-12-27T02:38:20.8689780' AS DateTime2), CAST(N'2021-12-27T02:38:16.7776370' AS DateTime2), 2500000, 37, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (21, CAST(N'2021-12-27T02:38:25.6449090' AS DateTime2), CAST(N'2021-12-27T02:38:16.7776370' AS DateTime2), 3200000, 37, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (27, CAST(N'2021-12-29T00:36:42.9906440' AS DateTime2), CAST(N'2021-12-29T00:36:38.7228090' AS DateTime2), 2200000, 42, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (28, CAST(N'2021-12-29T01:58:05.6650260' AS DateTime2), CAST(N'2021-12-29T01:57:56.1275920' AS DateTime2), 2500000, 34, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (29, CAST(N'2021-12-29T11:55:57.1741280' AS DateTime2), CAST(N'2021-12-29T11:55:48.9308130' AS DateTime2), 3300000, 33, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (30, CAST(N'2021-12-30T00:05:28.5602340' AS DateTime2), CAST(N'2021-12-30T00:05:21.2933120' AS DateTime2), 200000, 43, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (32, CAST(N'2021-12-30T00:05:28.5602340' AS DateTime2), CAST(N'2021-12-30T00:05:28.5602340' AS DateTime2), 0, 0, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (34, CAST(N'2021-12-30T00:52:46.5655070' AS DateTime2), CAST(N'2021-12-30T00:52:41.3000940' AS DateTime2), 2000000, 45, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (35, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 0, 0, 0)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (36, CAST(N'2021-12-31T00:06:23.5755760' AS DateTime2), CAST(N'2021-12-31T00:06:16.3490910' AS DateTime2), 2000000, 46, 1)
INSERT [dbo].[GIATOUR] ([IDGIATOUR], [TGBatDau], [TGKetThuc], [ThanhTien], [MaTour], [STT]) VALUES (37, CAST(N'2021-12-31T01:23:43.8162690' AS DateTime2), CAST(N'2021-12-31T01:23:38.6527020' AS DateTime2), 4000000, 33, 1)
SET IDENTITY_INSERT [dbo].[GIATOUR] OFF
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (2, N'Nguyễn Văn Thủ', CAST(N'2021-12-01T00:19:00.0000000' AS DateTime2), N'242/60 Hàn Hải Nguyên', N'01221456789', N'Nam', N'nvt@gmail.com', N'0212145451')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (3, N'Lê Thị Hoàng Anh', CAST(N'1992-12-15T01:04:49.0000000' AS DateTime2), N'256/56 Bà Hạt', N'01665898636', N'Nữ', N'ltls@gmail.com', N'0121454787')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (5, N'NDNN', CAST(N'2021-12-22T23:36:07.8913700' AS DateTime2), N'sss', N'0123456789', N'Nam', N'123@gmail.com', N'12312313')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (6, N'Nguyễn Thị Xuân Mây', CAST(N'1994-06-14T02:39:18.0000000' AS DateTime2), N'285 Hàn Hải Nguyên', N'0125896365', N'NỮ', N'd@gmail.com', N'025869363')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (16, N'Nguyễn Ngọc Thái', CAST(N'1999-12-02T00:18:09.0000000' AS DateTime2), N'256 Hậu Giang', N'0123456789', N'Nam', N'nnt@gmail.com', N'025836545')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (17, N'Nguyễn Hữu Hưng', CAST(N'1997-12-02T00:18:51.0000000' AS DateTime2), N'234 Nguyễn Văn Luông', N'0145632522', N'Nam', N'as@gmail.com', N'0121536963')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (18, N'Lâm Quốc Quang', CAST(N'2019-12-02T00:19:25.0000000' AS DateTime2), N'1031 3/2', N'0147852369', N'Nam', N'aaa@gmail.com', N'012523654')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (19, N'Đỗ Anh Quốc', CAST(N'1999-12-24T00:20:04.0000000' AS DateTime2), N'24 Lữ Gia', N'0906356984', N'Nam', N'daq@hotmail.com', N'0256369852')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [KH_NgaySinh], [KH_DiaChi], [KH_SoDienThoai], [KH_GioiTinh], [KH_email], [KH_CMND]) VALUES (20, N'Nguyễn Quốc Đại', CAST(N'1999-02-03T00:00:00.0000000' AS DateTime2), N'242/60', N'0123456789', N'Nam', N'a@gmail.com', N'028563692')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAICHIPHI] ON 

INSERT [dbo].[LOAICHIPHI] ([LoaiCP_ID], [TenLoaiCP]) VALUES (1, N'Chi phí khách sạn')
INSERT [dbo].[LOAICHIPHI] ([LoaiCP_ID], [TenLoaiCP]) VALUES (2, N'Chi phí di chuyển')
SET IDENTITY_INSERT [dbo].[LOAICHIPHI] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAIHINHDULICH] ON 

INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (3, N'Du Lịch Trong Nước', N'Tour Trong Nước')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (5, N'Du Lịch Nghỉ Dưỡng', N'MMM')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (6, N'Du Lịch Sinh Thái', N'Tour sinh thái')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (7, N'Du Lịch Eco', N'giá rẻ')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (9, N'Du Lịch Tiết Kiệm', N'Kinh phí thấp1')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh], [LH_MoTa]) VALUES (11, N'Du Lịch Hạng Sang', N'AAAs')
SET IDENTITY_INSERT [dbo].[LOAIHINHDULICH] OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (4, N'Nguyễn Văn An', CAST(N'1994-06-07T15:24:00.0000000' AS DateTime2), N'0902146821', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (5, N'Nguyễn Đức Nguyên Ngọc', CAST(N'1999-03-02T22:38:32.0000000' AS DateTime2), N'0933926175', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (6, N'Nguyễn Thị Ngọc Linh', CAST(N'1999-07-25T22:38:41.0000000' AS DateTime2), N'0121456852', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (7, N'Vũ Minh Nhật', CAST(N'1996-02-11T22:38:50.0000000' AS DateTime2), N'0125636987', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (8, N'Nguyễn Thiện Sang', CAST(N'1994-02-15T23:08:39.0000000' AS DateTime2), N'0906356852', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (9, N'Nguyễn Tiến Linh', CAST(N'2021-12-27T15:24:00.0000000' AS DateTime2), N'01225369874', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (11, N'Nguyễn Thị B', CAST(N'2021-12-30T00:52:58.2745410' AS DateTime2), N'0123659856', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (12, N'Nguyễn Văn Thái', CAST(N'2000-12-01T00:15:18.0000000' AS DateTime2), N'0985165456', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NV_NgaySinh], [NV_SoDienThoai], [NV_NhiemVu]) VALUES (13, N'Lâm Doanh Sâm', CAST(N'2001-09-20T00:15:42.0000000' AS DateTime2), N'0124563963', NULL)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[TOURDULICH] ON 

INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (33, N'Du lịch Đà Lạt', N'Tour cao cấp', 37, NULL, 3, 7)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (34, N'DHSG', N'Tour trường DHSG', 28, NULL, 3, 7)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (35, N'Du Lịch Nha Trang', N'4n3d', 16, NULL, 3, 8)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (36, N'Du Lịch Phan Rang', N'Tour tiết kiệm', 19, NULL, 9, 9)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (37, N'Du Lịch Bình Định', N'Tour mới', 21, NULL, 3, 10)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (42, N'Du lịch Phan Thiết', N'Tour giá rẻ', 27, NULL, 9, 11)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (43, N'Tour Đà Lạt 12', N'Du lịch tiết kiệm', 30, NULL, 7, 7)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (45, N'Du Lịch ', N'AAA', 34, NULL, 3, 10)
INSERT [dbo].[TOURDULICH] ([MaTour], [TenTour], [DacDiem], [IDGiaTour], [MaDOANDL], [MaLoaiHinh], [MaDiaDiem]) VALUES (46, N'Du lịch ', N'a', 36, NULL, 3, 7)
SET IDENTITY_INSERT [dbo].[TOURDULICH] OFF
GO
