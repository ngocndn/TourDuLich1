USE [QuanlyTour2]
GO
/****** Object:  Table [dbo].[BOOKING]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[CHIPHI]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[CHITIET]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[CHITIETCHIPHI]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[DIADIEM]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[DOANDL]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[GIATOUR]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[LOAICHIPHI]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[LOAIHINHDULICH]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/30/2021 1:04:00 AM ******/
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
/****** Object:  Table [dbo].[TOURDULICH]    Script Date: 12/30/2021 1:04:00 AM ******/
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
