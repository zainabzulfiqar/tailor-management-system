USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 12/08/2020 23:16:22 ******/
CREATE DATABASE [TMS] ON  PRIMARY 
( NAME = N'TMS', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TMS.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TMS_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TMS_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TMS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TMS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TMS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TMS] SET ARITHABORT OFF
GO
ALTER DATABASE [TMS] SET AUTO_CLOSE ON
GO
ALTER DATABASE [TMS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TMS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TMS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TMS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TMS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TMS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TMS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TMS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TMS] SET  ENABLE_BROKER
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TMS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TMS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TMS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TMS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TMS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TMS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TMS] SET  READ_WRITE
GO
ALTER DATABASE [TMS] SET RECOVERY SIMPLE
GO
ALTER DATABASE [TMS] SET  MULTI_USER
GO
ALTER DATABASE [TMS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TMS] SET DB_CHAINING OFF
GO
USE [TMS]
GO
/****** Object:  User [zainab]    Script Date: 12/08/2020 23:16:22 ******/
CREATE USER [zainab] FOR LOGIN [zainab] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usrss]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usrss](
	[FullName] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'Admin', N'admin', N'enter', N'operator', NULL)
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'Asma', N'aman', N'aass', N'operator', NULL)
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'Warda', N'Sana', N'ssaa', N'operator', NULL)
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'Asma', N'aman', N'aass', N'operator', NULL)
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'hina', N'amir', N'zzaa', N'operator', NULL)
INSERT [dbo].[Usrss] ([FullName], [UserName], [Password], [Type], [IsActive]) VALUES (N'Mehwish', N'maha', N'mehh', N'operator', NULL)
/****** Object:  Table [dbo].[Users]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[RegistrationDate] [datetime] NULL,
	[LastLogin] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([ID], [Name], [UserName], [Password], [RegistrationDate], [LastLogin], [IsActive]) VALUES (1000, N'Raees Ul Islam', N'rtraees', N'123', CAST(0x0000AB7B0006813C AS DateTime), NULL, 1)
INSERT [dbo].[Users] ([ID], [Name], [UserName], [Password], [RegistrationDate], [LastLogin], [IsActive]) VALUES (1001, N'Muhammad', N'Ali', N'123456', CAST(0x0000AB7B0006813C AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Sales]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Total_Amount] [decimal](18, 2) NULL,
	[Sale_Date] [datetime] NULL,
	[Operator_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sales] ON
INSERT [dbo].[Sales] ([ID], [Customer_ID], [Total_Amount], [Sale_Date], [Operator_ID]) VALUES (1, 1, CAST(1.00 AS Decimal(18, 2)), CAST(0x0000AB8B009979B2 AS DateTime), 1000)
INSERT [dbo].[Sales] ([ID], [Customer_ID], [Total_Amount], [Sale_Date], [Operator_ID]) VALUES (2, 1, CAST(1.00 AS Decimal(18, 2)), CAST(0x0000AB8B009A616D AS DateTime), 1000)
INSERT [dbo].[Sales] ([ID], [Customer_ID], [Total_Amount], [Sale_Date], [Operator_ID]) VALUES (3, 1, CAST(1500.00 AS Decimal(18, 2)), CAST(0x0000AB8B009D4FC6 AS DateTime), 1000)
SET IDENTITY_INSERT [dbo].[Sales] OFF
/****** Object:  Table [dbo].[Sale_Detail]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Detail](
	[Detail_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sale_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Unit_Price] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Detail_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sale_Detail] ON
INSERT [dbo].[Sale_Detail] ([Detail_ID], [Sale_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (1, 3, 4, 5, CAST(300.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Sale_Detail] OFF
/****** Object:  Table [dbo].[Purchases]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Dealer_ID] [int] NOT NULL,
	[Total_Amount] [decimal](18, 2) NULL,
	[Purchase_Date] [datetime] NULL,
	[Operator_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Purchases] ON
INSERT [dbo].[Purchases] ([ID], [Dealer_ID], [Total_Amount], [Purchase_Date], [Operator_ID]) VALUES (2, 1, CAST(1000.00 AS Decimal(18, 2)), CAST(0x0000AB8B009C5B2B AS DateTime), 1000)
INSERT [dbo].[Purchases] ([ID], [Dealer_ID], [Total_Amount], [Purchase_Date], [Operator_ID]) VALUES (3, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB8B009C5B2B AS DateTime), 1000)
INSERT [dbo].[Purchases] ([ID], [Dealer_ID], [Total_Amount], [Purchase_Date], [Operator_ID]) VALUES (4, 1, CAST(1000.00 AS Decimal(18, 2)), CAST(0x0000AB8B009C5B2B AS DateTime), 1000)
INSERT [dbo].[Purchases] ([ID], [Dealer_ID], [Total_Amount], [Purchase_Date], [Operator_ID]) VALUES (1004, 4, CAST(301400.00 AS Decimal(18, 2)), CAST(0x0000AB910117DE85 AS DateTime), 1000)
SET IDENTITY_INSERT [dbo].[Purchases] OFF
/****** Object:  Table [dbo].[Purchase_Detail]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Detail](
	[Detail_ID] [int] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Unit_Price] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Detail_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Purchase_Detail] ON
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (1, 2, 2, 100, CAST(10.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (2, 3, 2, 1000, CAST(100.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)))
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (3, 4, 4, 100, CAST(10.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (1003, 1004, 2, 1000, CAST(100.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)))
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (1004, 1004, 3, 200, CAST(1002.00 AS Decimal(18, 2)), CAST(200400.00 AS Decimal(18, 2)))
INSERT [dbo].[Purchase_Detail] ([Detail_ID], [Purchase_ID], [Product_ID], [Qty], [Unit_Price], [Total]) VALUES (1005, 1004, 4, 10, CAST(100.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Purchase_Detail] OFF
/****** Object:  Table [dbo].[Products]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ID], [Name], [Description], [Price]) VALUES (1, N'aaa', N'212', CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ID], [Name], [Description], [Price]) VALUES (2, N'Mouse', N'Dell Mouse', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ID], [Name], [Description], [Price]) VALUES (3, N'Key Board', N'Key Board Dell', CAST(250.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ID], [Name], [Description], [Price]) VALUES (4, N'Wireless Mouse', N'Dell Wireless mouse', CAST(500.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[Measurement_Shairwani]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Measurement_Shairwani](
	[Measurement_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Length] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Sleeves] [int] NOT NULL,
	[Collar] [int] NOT NULL,
	[ABC] [int] NOT NULL,
	[DEU] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Measurement_Pent]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Measurement_Pent](
	[Measurement_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Length] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[Type] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Measurement_Pent] PRIMARY KEY CLUSTERED 
(
	[Measurement_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ContactNumber] [nvarchar](100) NULL,
	[isDealer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT [dbo].[Customers] ([ID], [Name], [ContactNumber], [isDealer]) VALUES (1, N'Raees Ul Islam', N'101010101`0', 1)
INSERT [dbo].[Customers] ([ID], [Name], [ContactNumber], [isDealer]) VALUES (2, N'Customer 1', N'123', 0)
INSERT [dbo].[Customers] ([ID], [Name], [ContactNumber], [isDealer]) VALUES (3, N'Customer 2', N'1231', 1)
INSERT [dbo].[Customers] ([ID], [Name], [ContactNumber], [isDealer]) VALUES (4, N'Dealer 1', N'3232322', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
/****** Object:  Table [dbo].[Customer]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[FullName] [varchar](50) NOT NULL,
	[CNIC] [numeric](15, 0) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[MobileNo] [numeric](11, 0) NOT NULL,
	[Remarks] [varchar](max) NULL,
	[ID] [varchar](10) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CNIC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customer] ([FullName], [CNIC], [Address], [MobileNo], [Remarks], [ID]) VALUES (N'Rehman', CAST(312 AS Numeric(15, 0)), N'jsdhks', CAST(5388 AS Numeric(11, 0)), N'djgfhjdfg', N'3')
INSERT [dbo].[Customer] ([FullName], [CNIC], [Address], [MobileNo], [Remarks], [ID]) VALUES (N'Zayn', CAST(777 AS Numeric(15, 0)), N'hhhhh', CAST(5555 AS Numeric(11, 0)), N'djgfhjdfg', N'2')
/****** Object:  Table [dbo].[Assign_Work]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assign_Work](
	[Customer_ID] [int] NOT NULL,
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Worker_Name] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Due_Date] [datetime] NOT NULL,
	[Remarks] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker_Detail]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Worker_Detail](
	[Worker_Name] [varchar](50) NOT NULL,
	[Assigned_Task] [int] NOT NULL,
	[Completed] [int] NOT NULL,
	[Remainig/Pending] [int] NOT NULL,
	[Total Over Due Date] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'usman', 2, 1, 1, 1)
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'Ahmad', 5, 2, 2, 1)
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'Qadir', 4, 2, 2, 1)
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'Sawera', 2, 1, 1, 0)
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'Halima', 0, 0, 0, 0)
INSERT [dbo].[Worker_Detail] ([Worker_Name], [Assigned_Task], [Completed], [Remainig/Pending], [Total Over Due Date]) VALUES (N'Asfar', 3, 1, 2, 1)
/****** Object:  Table [dbo].[Worker]    Script Date: 12/08/2020 23:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Worker](
	[WorkerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](100) NOT NULL,
	[Address] [varchar](100) NULL,
	[ContactNo] [int] NULL,
	[JoiningDate] [datetime] NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[WorkerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Worker] ON
INSERT [dbo].[Worker] ([WorkerID], [FullName], [Address], [ContactNo], [JoiningDate], [Salary]) VALUES (1, N'usman', N'shadbagh', 55555, CAST(0x0000AB99013B5BA4 AS DateTime), 80000)
INSERT [dbo].[Worker] ([WorkerID], [FullName], [Address], [ContactNo], [JoiningDate], [Salary]) VALUES (2, N'Ahmad', N'lahore', 222222, CAST(0x0000ABA7000E7E28 AS DateTime), 222222)
INSERT [dbo].[Worker] ([WorkerID], [FullName], [Address], [ContactNo], [JoiningDate], [Salary]) VALUES (3, N'Asim', N'Lahore444', 77777, CAST(0x0000ABA7011A8F28 AS DateTime), 90000)
INSERT [dbo].[Worker] ([WorkerID], [FullName], [Address], [ContactNo], [JoiningDate], [Salary]) VALUES (4, N'Ahmad', N'Ahmad', 8888888, CAST(0x0000ABBF00000000 AS DateTime), 120000)
INSERT [dbo].[Worker] ([WorkerID], [FullName], [Address], [ContactNo], [JoiningDate], [Salary]) VALUES (5, N'shdvjh', N'lahore', 1234, CAST(0x0000AC6000FA5654 AS DateTime), 34555)
SET IDENTITY_INSERT [dbo].[Worker] OFF
/****** Object:  View [dbo].[view_Stock]    Script Date: 12/08/2020 23:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_Stock] as (
select  pp.id ,sum(pd.Qty)  Stock_IN ,0 as Stock_Out
from Purchases p inner join purchase_detail pd on ( pd.Purchase_Id = p.id)
inner join products pp on ( pp.ID=pd.Product_id)
group by pp.id
union all
select pp.id ,0 as Stock_in , sum(sd.Qty) Stock_Out from Sales s inner join Sale_detail sd on (sd.Sale_ID=s.id)
inner join products pp on(pp.id=sd.Product_Id)
group by pp.id
)
GO
/****** Object:  Default [DF__Customers__isDea__286302EC]    Script Date: 12/08/2020 23:16:24 ******/
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('false') FOR [isDealer]
GO
/****** Object:  ForeignKey [FK_Measurement_Pent_Measurement_Pent]    Script Date: 12/08/2020 23:16:24 ******/
ALTER TABLE [dbo].[Measurement_Pent]  WITH CHECK ADD  CONSTRAINT [FK_Measurement_Pent_Measurement_Pent] FOREIGN KEY([Measurement_ID])
REFERENCES [dbo].[Measurement_Pent] ([Measurement_ID])
GO
ALTER TABLE [dbo].[Measurement_Pent] CHECK CONSTRAINT [FK_Measurement_Pent_Measurement_Pent]
GO
/****** Object:  ForeignKey [FK_Measurement_Pent_Measurement_Pent1]    Script Date: 12/08/2020 23:16:24 ******/
ALTER TABLE [dbo].[Measurement_Pent]  WITH CHECK ADD  CONSTRAINT [FK_Measurement_Pent_Measurement_Pent1] FOREIGN KEY([Measurement_ID])
REFERENCES [dbo].[Measurement_Pent] ([Measurement_ID])
GO
ALTER TABLE [dbo].[Measurement_Pent] CHECK CONSTRAINT [FK_Measurement_Pent_Measurement_Pent1]
GO
