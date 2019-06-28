USE [master]
GO
/****** Object:  Database [JEWELRYSTOREMGMT]    Script Date: 6/28/2019 5:21:31 PM ******/
CREATE DATABASE [JEWELRYSTOREMGMT]
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ARITHABORT OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET RECOVERY FULL 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET  MULTI_USER 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JEWELRYSTOREMGMT', N'ON'
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET QUERY_STORE = OFF
GO
USE [JEWELRYSTOREMGMT]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [JEWELRYSTOREMGMT]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/28/2019 5:21:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[PhoneNo] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Date]    Script Date: 6/28/2019 5:21:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Date](
	[DateSk] [int] NOT NULL,
	[Month] [int] NULL,
	[MonthShortName] [nvarchar](10) NULL,
	[Year] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DateSk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/28/2019 5:21:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[VendorID] [int] NULL,
	[ProductCategoryID] [int] NULL,
	[ImportPrice] [float] NULL,
	[Weight] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[UnitID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 6/28/2019 5:21:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryName] [nvarchar](100) NULL,
	[PercentRevenue] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](100) NULL,
	[ServicePrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTransaction]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTransaction](
	[ServiceTransID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CustomerID] [int] NULL,
	[Total] [float] NULL,
	[Prepaid] [float] NULL,
	[Remain] [float] NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceTransID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTransactionDetails]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTransactionDetails](
	[ServiceTransDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceTransID] [int] NULL,
	[ServiceID] [int] NULL,
	[AdditionalPrice] [float] NULL,
	[TransPrice] [float] NULL,
	[Quantity] [int] NULL,
	[TransTotal] [float] NULL,
	[TransPrepaid] [float] NULL,
	[TransRemain] [float] NULL,
	[DeliveredDate] [smalldatetime] NULL,
	[TransStatus] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceTransDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[TransID] [int] IDENTITY(1,1) NOT NULL,
	[TransDate] [smalldatetime] NULL,
	[CustomerID] [int] NULL,
	[VendorID] [int] NULL,
	[TransType] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[TransDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[TransID] [int] NULL,
	[TransDate] [smalldatetime] NULL,
	[ProductID] [int] NULL,
	[TransQuantity] [int] NULL,
	[TransPrice] [float] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](100) NULL,
	[UnitPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[Role] [nvarchar](20) NULL,
	[IsDistributor] [int] NULL,
	[Password] [nvarchar](100) NULL,
	[PhoneNo] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[PhoneNo] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNo], [Address]) VALUES (1, N'Tri', N'0123456789', N'TPHCM')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [PhoneNo], [Address]) VALUES (2, N'Hieu', N'08452154678', N'Ha Noi')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190101, 1, N'Jan', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190201, 2, N'Feb', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190301, 3, N'Mar', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190401, 4, N'Apr', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190501, 5, N'May', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190601, 6, N'Jun', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190701, 7, N'Jul', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190801, 8, N'Aug', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20190901, 9, N'Sep', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20191001, 10, N'Oct', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20191101, 11, N'Nov', 2019)
INSERT [dbo].[Date] ([DateSk], [Month], [MonthShortName], [Year]) VALUES (20191201, 12, N'Dec', 2019)
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [Weight], [Quantity], [UnitID]) VALUES (11, N'NE-123', 1, 2, 20, N'0.5', 10, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [Weight], [Quantity], [UnitID]) VALUES (12, N'EA-214', 2, 4, 50, N'0.2', 12, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [Weight], [Quantity], [UnitID]) VALUES (13, N'HE-OSL', 1, 5, 100, N'0.25', 50, 3)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (2, N'Necklaces', 0.25)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (3, N'Braclets', 0.14000000059604645)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (4, N'Earrings', 0.20999999344348908)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (5, N'Rings', 0.079999998211860657)
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServicePrice]) VALUES (1, N'Weight', 10)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServicePrice]) VALUES (2, N'Gold Plated', 50)
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [ServicePrice]) VALUES (3, N'Cut', 20)
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[ServiceTransaction] ON 

INSERT [dbo].[ServiceTransaction] ([ServiceTransID], [CreatedDate], [CustomerID], [Total], [Prepaid], [Remain], [Status]) VALUES (1, CAST(N'2019-06-26T00:00:00' AS SmallDateTime), 1, 0, 0, 0, N'Complete')
INSERT [dbo].[ServiceTransaction] ([ServiceTransID], [CreatedDate], [CustomerID], [Total], [Prepaid], [Remain], [Status]) VALUES (2, CAST(N'2019-06-27T00:00:00' AS SmallDateTime), 1, 0, 0, 0, N'Complete')
INSERT [dbo].[ServiceTransaction] ([ServiceTransID], [CreatedDate], [CustomerID], [Total], [Prepaid], [Remain], [Status]) VALUES (3, CAST(N'2019-06-13T00:00:00' AS SmallDateTime), 2, 0, 0, 0, N'Incomplete')
SET IDENTITY_INSERT [dbo].[ServiceTransaction] OFF
SET IDENTITY_INSERT [dbo].[ServiceTransactionDetails] ON 

INSERT [dbo].[ServiceTransactionDetails] ([ServiceTransDetailsID], [ServiceTransID], [ServiceID], [AdditionalPrice], [TransPrice], [Quantity], [TransTotal], [TransPrepaid], [TransRemain], [DeliveredDate], [TransStatus]) VALUES (1, 1, 1, 0, 10, 1, 10, 10, 0, CAST(N'2019-06-28T00:00:00' AS SmallDateTime), N'Delivered')
INSERT [dbo].[ServiceTransactionDetails] ([ServiceTransDetailsID], [ServiceTransID], [ServiceID], [AdditionalPrice], [TransPrice], [Quantity], [TransTotal], [TransPrepaid], [TransRemain], [DeliveredDate], [TransStatus]) VALUES (2, 1, 3, 2, 52, 1, 52, 52, 0, CAST(N'2019-06-28T00:00:00' AS SmallDateTime), N'Delivered')
INSERT [dbo].[ServiceTransactionDetails] ([ServiceTransDetailsID], [ServiceTransID], [ServiceID], [AdditionalPrice], [TransPrice], [Quantity], [TransTotal], [TransPrepaid], [TransRemain], [DeliveredDate], [TransStatus]) VALUES (3, 1, 3, 1, 21, 1, 21, 21, 0, CAST(N'2019-06-28T00:00:00' AS SmallDateTime), N'Delivered')
INSERT [dbo].[ServiceTransactionDetails] ([ServiceTransDetailsID], [ServiceTransID], [ServiceID], [AdditionalPrice], [TransPrice], [Quantity], [TransTotal], [TransPrepaid], [TransRemain], [DeliveredDate], [TransStatus]) VALUES (4, 1, 2, 1, 51, 1, 51, 51, 0, CAST(N'2019-06-28T00:00:00' AS SmallDateTime), N'Delivered')
INSERT [dbo].[ServiceTransactionDetails] ([ServiceTransDetailsID], [ServiceTransID], [ServiceID], [AdditionalPrice], [TransPrice], [Quantity], [TransTotal], [TransPrepaid], [TransRemain], [DeliveredDate], [TransStatus]) VALUES (6, 2, 1, 0, 10, 1, 10, 10, 0, CAST(N'2019-06-28T00:00:00' AS SmallDateTime), N'Delivered')
SET IDENTITY_INSERT [dbo].[ServiceTransactionDetails] OFF
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (8, CAST(N'2019-06-14T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (9, CAST(N'2019-06-14T00:00:00' AS SmallDateTime), NULL, 2, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (10, CAST(N'2019-06-24T00:00:00' AS SmallDateTime), 1, NULL, N'EX')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (11, CAST(N'2019-06-27T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (12, CAST(N'2019-06-24T00:00:00' AS SmallDateTime), 2, NULL, N'EX')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
SET IDENTITY_INSERT [dbo].[TransactionDetails] ON 

INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [TransQuantity], [TransPrice], [Total]) VALUES (13, 8, CAST(N'2019-06-24T16:19:00' AS SmallDateTime), 11, 10, 20, 20)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [TransQuantity], [TransPrice], [Total]) VALUES (14, 9, CAST(N'2019-06-24T16:19:00' AS SmallDateTime), 12, 20, 50, 50)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [TransQuantity], [TransPrice], [Total]) VALUES (16, 10, CAST(N'2019-06-24T16:24:00' AS SmallDateTime), 12, 8, 60.5, 484)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [TransQuantity], [TransPrice], [Total]) VALUES (17, 11, CAST(N'2019-06-27T16:10:00' AS SmallDateTime), 13, 50, 100, 100)
SET IDENTITY_INSERT [dbo].[TransactionDetails] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (1, N'24K', 36830000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (2, N'22K', 36630000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (3, N'18K', 27620000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (4, N'14K', 21580000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (5, N'10K', 15390000)
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [UserName], [Role], [IsDistributor], [Password], [PhoneNo], [Address]) VALUES (1, N'Tri', N'User', 0, N'123', N'0123456789', N'Q3')
INSERT [dbo].[User] ([UserID], [UserName], [Role], [IsDistributor], [Password], [PhoneNo], [Address]) VALUES (2, N'Admin', N'Admin', 1, N'Admin', N'111', N'Admin')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[Vendor] ON 

INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (1, N'PNJ', N'170E Phan Dang Luu St, Ward 3, Phu Nhuan District, Ho Chi Minh City', N'02839951703')
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (2, N'DOJI', N'214 Phan Dang Luu St, Ward 3, Phu Nhuan District, Ho Chi Minh City', N'02839953666')
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (3, N'SJC', N'418-420 Nguyen Thi Minh Khai St, Ward 5, District 3, Ho Chi Minh City', N'02839293388')
SET IDENTITY_INSERT [dbo].[Vendor] OFF
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([ProductCategoryID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[ServiceTransaction]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[ServiceTransactionDetails]  WITH CHECK ADD FOREIGN KEY([ServiceTransID])
REFERENCES [dbo].[ServiceTransaction] ([ServiceTransID])
GO
ALTER TABLE [dbo].[ServiceTransactionDetails]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([TransID])
REFERENCES [dbo].[Transaction] ([TransID])
GO
/****** Object:  StoredProcedure [dbo].[usp_checkAdminAccount]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_checkAdminAccount] 
	@name [nvarchar](100)
AS
BEGIN
	SELECT [UserID] 
	FROM [dbo].[User]
	WHERE [UserName] = @name AND [Role] = 'Admin'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_checkUserAccount]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_checkUserAccount] 
	@name [nvarchar](100)
	,@pass [nvarchar](100)
AS
BEGIN
	SELECT [UserID] 
	FROM [dbo].[User]
	WHERE [UserName] = @name AND [Password] = @pass
END
GO
/****** Object:  StoredProcedure [dbo].[usp_checkUserName]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_checkUserName] 
	@name [nvarchar](100)
AS
BEGIN
	SELECT [UserID]
	FROM [dbo].[User]
	WHERE [UserName] = @name;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteCustomer]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_deleteCustomer]
	@CustomerID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Customer]
	WHERE [CustomerID] = @CustomerID

	DECLARE @id INT
	SELECT @id = MAX([CustomerID]) FROM [JEWELRYSTOREMGMT].[dbo].[Customer]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[Customer]', RESEED, @id);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeletePostInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeletePostInvoice]
	@TransID [int]
AS
BEGIN
	DELETE Product
	FROM [JEWELRYSTOREMGMT].[dbo].[Product] P
	JOIN [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
	ON P.[ProductID] = TD.[ProductID]
	WHERE TD.[TransID] = @TransID

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	WHERE [TransID] = @TransID

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Transaction] 
	WHERE [TransID] = @TransID

	DECLARE @ID [int]
	SELECT @ID = MAX([TransID]) FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[Transaction]', RESEED, @ID);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deletePostInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_deletePostInvoice_Details]
	@TransDetailsID [int]
	,@ProductID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	WHERE [TransDetailsID] = @TransDetailsID

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Product]
	WHERE [ProductID] = @ProductID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteProductCategory]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HO MINH TRI
-- Create date: 2019-06-14
-- Description:	Delete Category of Product
-- =============================================
CREATE PROCEDURE [dbo].[usp_deleteProductCategory]
	@ProductCategoryID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[ProductCategory]
	WHERE [ProductCategoryID] = @ProductCategoryID

	DECLARE @id INT
	SELECT @id = MAX([ProductCategoryID]) FROM [JEWELRYSTOREMGMT].[dbo].[ProductCategory]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[ProductCategory]', RESEED, @id);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteSaleInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_deleteSaleInvoice_Details]
	@TransDetailsID [int]
	,@TransChange [int]
	,@ProductID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[Product]
	SET [Quantity] = [Quantity] + @TransChange
	WHERE [ProductID] = @ProductID

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	WHERE [TransDetailsID] = @TransDetailsID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteService]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_deleteService]
	@ServiceID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Service]
	WHERE [ServiceID] = @ServiceID

	DECLARE @id INT
	SELECT @id = MAX([ServiceID]) FROM [JEWELRYSTOREMGMT].[dbo].[Service]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[Service]', RESEED, @id);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteServiceInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteServiceInvoice]
	@ServiceTransID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransaction]
	WHERE [ServiceTransID] = @ServiceTransID

	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails]
	WHERE [ServiceTransID] = @ServiceTransID

	DECLARE @ID [int]
	SELECT @ID = ISNULL(MAX([ServiceTransID]), 0) FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransaction]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[ServiceTransaction]', RESEED, @ID);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteServiceInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_deleteServiceInvoice_Details]
	@ServiceTransDetailsID [int]
	,@ServiceTransID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS (SELECT TOP 1 * FROM [dbo].[ServiceTransactionDetails] WHERE ServiceTransID = @ServiceTransID)
	BEGIN
		DELETE FROM [dbo].[ServiceTransactionDetails]
		WHERE [ServiceTransDetailsID] = @ServiceTransDetailsID
	END
	ELSE
	BEGIN
		DELETE FROM [dbo].[ServiceTransactionDetails]
		WHERE [ServiceTransDetailsID] = @ServiceTransDetailsID

		DELETE FROM [dbo].[ServiceTransaction]
		WHERE [ServiceTransID] = @ServiceTransID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteUnit]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_deleteUnit]
	@UnitID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Unit]
	WHERE [UnitID] = @UnitID

	DECLARE @id INT
	SELECT @id = MAX([UnitID]) FROM [JEWELRYSTOREMGMT].[dbo].[Unit]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[Unit]', RESEED, @id);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteUser]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_deleteUser]
	@UserName [nvarchar](100)
	,@CurrentUserName [nvarchar](100)
AS
BEGIN
	DELETE FROM [dbo].[User]
	WHERE [UserName] = @UserName AND [UserName] <> @CurrentUserName
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteVendor]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_deleteVendor]
	@VendorID [int]
AS
BEGIN
	DELETE FROM [JEWELRYSTOREMGMT].[dbo].[Vendor]
	WHERE [VendorID] = @VendorID

	DECLARE @id INT
	SELECT @id = MAX([VendorID]) FROM [JEWELRYSTOREMGMT].[dbo].[Vendor]

	DBCC CHECKIDENT ('[JEWELRYSTOREMGMT].[dbo].[Vendor]', RESEED, @id);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getCustomerList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getCustomerList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT 
		[CustomerID]
		,[CustomerName]
		,[PhoneNo]
		,[Address]
	FROM [JEWELRYSTOREMGMT].[dbo].[Customer]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getPostInvoice]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT T.[TransID]
		,T.[VendorID]
		,V.[VendorName]
		,V.[Address]
		,V.[PhoneNo]
		,T.[TransDate]
		,ISNULL(SUM(TD.[TransPrice]),0) AS [TotalPrice]
	FROM [dbo].[Transaction] T
		LEFT JOIN [dbo].[TransactionDetails] TD
			ON T.[TransID] = TD.[TransID]
		INNER JOIN [dbo].[Vendor] V
			ON T.[VendorID] = V.[VendorID]
	GROUP BY T.[TransID]
		,T.[VendorID]
		,V.[VendorName]
		,V.[Address]
		,V.[PhoneNo]
		,T.[TransDate]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_getPostInvoice_Details]
	@TransID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT *
					FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
					INNER JOIN [dbo].[Product] P
						ON TD.[ProductID] = P.[ProductID]
					INNER JOIN [dbo].[ProductCategory] PC
						ON P.[ProductCategoryID] = PC.[ProductCategoryID]
					INNER JOIN [dbo].[Unit] U
						ON P.[UnitID] = U.[UnitID]
					WHERE TD.TransID = @TransID)
	BEGIN
		SELECT TOP 1
			0 AS [TransDetailsID]
			,0 AS [ProductID]
			,'' AS [ProductName]
			,'' AS [ProductCategoryName]
			,0 AS [TransQuantity]
			,'' AS [UnitName]
			,0 AS [TransPrice]
			,0 AS [Total]
		FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	END
	ELSE
	BEGIN
		SELECT
			TD.[TransDetailsID]
			,P.[ProductID]
			,P.[ProductName]
			,PC.[ProductCategoryName]
			,TD.[TransQuantity]
			,U.[UnitName]
			,TD.[TransPrice]
			,P.[Weight]
		FROM [dbo].[TransactionDetails] TD
		INNER JOIN [dbo].[Product] P
			ON TD.[ProductID] = P.[ProductID]
		INNER JOIN [dbo].[ProductCategory] PC
			ON P.[ProductCategoryID] = PC.[ProductCategoryID]
		INNER JOIN [dbo].[Unit] U
			ON P.[UnitID] = U.[UnitID]
		WHERE TD.TransID = @TransID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getProductCategory]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HO MINH TRI
-- Create date: 2019-06-14
-- Description:	Get Category of Product
-- =============================================
CREATE PROCEDURE [dbo].[usp_getProductCategory]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT
		[ProductCategoryID]
		,[ProductCategoryName]
		,[PercentRevenue]
	FROM [dbo].[ProductCategory]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getProductList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getProductList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT
		[ProductID]
		,[ProductName]
		,P.[VendorID]
		,V.[VendorName]
		,P.[ProductCategoryID]
		,PC.[ProductCategoryName]
		,PC.[PercentRevenue]
		,P.[UnitID]
		,U.UnitName
		,[ImportPrice]
		,[Weight]
		,[Quantity]
	FROM [JEWELRYSTOREMGMT].[dbo].[Product] P
	JOIN [dbo].[ProductCategory] PC
		ON P.[ProductCategoryID] = PC.[ProductCategoryID]
	JOIN [dbo].[Vendor] V
		ON P.[VendorID] = V.[VendorID]
	JOIN [dbo].[Unit] U
		ON P.[UnitID] = U.[UnitID]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getSaleInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getSaleInvoice]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT T.[TransID]
		,T.[CustomerID]
		,C.[CustomerName]
		,T.[TransDate]
		,ISNULL(SUM(TD.[TransPrice]),0) AS [TotalPrice]
	FROM [dbo].[Transaction] T
		LEFT JOIN [dbo].[TransactionDetails] TD
			ON T.[TransID] = TD.[TransID]
		INNER JOIN [dbo].[Customer] C
			ON T.[CustomerID] = C.[CustomerID]
	GROUP BY T.[TransID]
		,T.[CustomerID]
		,C.[CustomerName]
		,T.[TransDate]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getSaleInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_getSaleInvoice_Details]
	@TransID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT *
					FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
					INNER JOIN [dbo].[Product] P
						ON TD.[ProductID] = P.[ProductID]
					INNER JOIN [dbo].[ProductCategory] PC
						ON P.[ProductCategoryID] = PC.[ProductCategoryID]
					INNER JOIN [dbo].[Unit] U
						ON P.[UnitID] = U.[UnitID]
					WHERE TD.TransID = @TransID)
	BEGIN
		SELECT TOP 1
			0 AS [TransDetailsID]
			,0 AS [ProductID]
			,'' AS [ProductName]
			,'' AS [ProductCategoryName]
			,0 AS [TransQuantity]
			,'' AS [UnitName]
			,0 AS [TransPrice]
			,0 AS [Total]
		FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	END
	ELSE
	BEGIN
		SELECT
			TD.[TransDetailsID]
			,P.[ProductID]
			,P.[ProductName]
			,PC.[ProductCategoryName]
			,TD.[TransQuantity]
			,U.[UnitName]
			,TD.[TransPrice]
			,TD.[Total]
		FROM [dbo].[TransactionDetails] TD
		INNER JOIN [dbo].[Product] P
			ON TD.[ProductID] = P.[ProductID]
		INNER JOIN [dbo].[ProductCategory] PC
			ON P.[ProductCategoryID] = PC.[ProductCategoryID]
		INNER JOIN [dbo].[Unit] U
			ON P.[UnitID] = U.[UnitID]
		WHERE TD.TransID = @TransID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getServiceInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getServiceInvoice]
	@ServiceTransID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT [TransStatus] FROM [dbo].[ServiceTransactionDetails] WHERE [ServiceTransID] = @ServiceTransID AND [TransStatus] = 'Pending')
	BEGIN
		UPDATE [dbo].[ServiceTransaction]
		SET [Status] = 'Complete'
		WHERE [ServiceTransID] = @ServiceTransID
	END
	ELSE
	BEGIN
		UPDATE [dbo].[ServiceTransaction]
		SET [Status] = 'Incomplete'
		WHERE [ServiceTransID] = @ServiceTransID
	END

	SELECT 
		ST.[ServiceTransID]
		,[CreatedDate]
		,ST.[CustomerID]
		,C.[CustomerName]
		,ISNULL(SUM(STD.[TransTotal]), 0) AS [Total]
		,ISNULL(SUM(STD.[TransPrepaid]), 0) AS [Prepaid]
		,ISNULL(SUM(STD.[TransRemain]), 0) AS [Remain]
		,[Status]
	FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransaction] ST
	JOIN [dbo].[Customer] C ON ST.CustomerID = C.CustomerID
	LEFT JOIN [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails] STD
	ON ST.[ServiceTransID] = STD.[ServiceTransID]
	GROUP BY
		ST.[ServiceTransID]
		,[CreatedDate]
		,ST.[CustomerID]
		,C.CustomerName
		,[Status]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getServiceInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_getServiceInvoice_Details]
	@ServiceTransID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT *
					FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails] STD
					LEFT JOIN [dbo].[Service] S
						ON STD.[ServiceID] = S.[ServiceID]
					WHERE ServiceTransID = @ServiceTransID)
	BEGIN
		SELECT TOP 1
			0 AS [ServiceTransDetailsID]
			,0 AS [ServiceTransID]
			,0 AS [ServiceID]
			,'' AS [ServiceName]
			,0 AS [ServicePrice]
			,0 AS [AdditionalPrice]
			,0 AS [TransPrice]
			,0 AS [Quantity]
			,0 AS [TransTotal]
			,0 AS [TransPrepaid]
			,0 AS [TransRemain]
			,GETDATE() AS [DeliveredDate]
			,'' AS [TransStatus]
		FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails]
	END
	ELSE
	BEGIN
		SELECT
			[ServiceTransDetailsID]
			,[ServiceTransID]
			,STD.[ServiceID]
			,S.[ServiceName]
			,S.[ServicePrice]
			,[AdditionalPrice]
			,[TransPrice]
			,[Quantity]
			,[TransTotal]
			,[TransPrepaid]
			,[TransRemain]
			,[DeliveredDate]
			,[TransStatus]
		FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails] STD
		LEFT JOIN [dbo].[Service] S
			ON STD.[ServiceID] = S.[ServiceID]
		WHERE ServiceTransID = @ServiceTransID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getServiceList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getServiceList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT 
		[ServiceID]
		,[ServiceName]
		,[ServicePrice]
	FROM [JEWELRYSTOREMGMT].[dbo].[Service]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getUnitList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_getUnitList]
AS
BEGIN
	SELECT 
		[UnitID]
		,[UnitName]
		,[UnitPrice]
	FROM [JEWELRYSTOREMGMT].[dbo].[Unit]
END



GO
/****** Object:  StoredProcedure [dbo].[usp_getUserList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_getUserList] 
AS
BEGIN
	SELECT
		[UserID]
		,[UserName]
		,[Role]
		,[IsDistributor]
		,[Password]
		,[PhoneNo]
		,[Address]
	FROM [JEWELRYSTOREMGMT].[dbo].[User]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getVendorList]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_getVendorList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT [VendorID]
		,[VendorName]
		,[Address]
		,[PhoneNo]
	FROM [dbo].[Vendor]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertCustomer]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_insertCustomer]
	@CustomerName [nvarchar](100)
	,@Address [nvarchar](200)
	,@PhoneNo [nvarchar](100)
AS
BEGIN
	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Customer]
			   ([CustomerName]
			   ,[Address]
			   ,[PhoneNo])
	VALUES (@CustomerName, @Address, @PhoneNo)
END



GO
/****** Object:  StoredProcedure [dbo].[usp_insertNewUser]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_insertNewUser] 
	@name [nvarchar](100), 
	@pass [nvarchar](100)
AS
BEGIN
	INSERT INTO [dbo].[User]
           ([UserName]
           ,[Role]
           ,[IsDistributor]
           ,[Password])
     VALUES
           (@name
           ,'User'
           ,0
           ,@pass)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertPostInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_InsertPostInvoice]
	@CreateDate DATETIME
	,@VendorID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Transaction] ([TransDate],[VendorID],[TransType])
	SELECT @CreateDate,@VendorID,'IM'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertPostInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_insertPostInvoice_Details]
	@TransID [int]
	,@ProductName [nvarchar](100)
	,@ProductCategoryName [nvarchar](100)
	,@UnitName [nvarchar](100)
	,@TransQuantity [int]
	,@Weight [nvarchar](100)
	--,@ImportPrice [float]
	,@TransPrice [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @VendorID [int]

	SELECT @VendorID = VendorID
	FROM [dbo].[Transaction]
	WHERE TransID = @TransID

	DECLARE @ProductCategoryID [int]

	SELECT @ProductCategoryID = ProductCategoryID
	FROM [dbo].[ProductCategory]
	WHERE ProductCategoryName = @ProductCategoryName

	DECLARE @UnitID [int]

	SELECT @UnitID = UnitID
	FROM [dbo].[Unit]
	WHERE UnitName = @UnitName

	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Product]
           ([ProductName]
           ,[VendorID]
           ,[ProductCategoryID]
		   ,[UnitID]
           ,[ImportPrice]
           ,[Quantity]
		   ,[Weight])
     VALUES
           (@ProductName
           ,@VendorID
           ,@ProductCategoryID
		   ,@UnitID
           ,@TransPrice
           ,@TransQuantity
		   ,@Weight)

	DECLARE @ProductID [int]
	
	SELECT @ProductID = MAX([ProductID]) FROM [dbo].[Product]

	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
           ([TransID]
           ,[TransDate]
           ,[ProductID]
           ,[TransQuantity]
           ,[TransPrice]
           ,[Total])
     VALUES
           (@TransID
           ,GETDATE()
           ,@ProductID
           ,@TransQuantity
           ,@TransPrice
           ,@TransPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertProductCategory]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HO MINH TRI
-- Create date: 2019-06-14
-- Description:	Insert new Category of Product
-- =============================================
CREATE PROCEDURE [dbo].[usp_insertProductCategory]
	@ProductCategoryName [nvarchar](100)
	,@PercentRevenue [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[ProductCategory]
           ([ProductCategoryName]
           ,[PercentRevenue])
     VALUES
           (@ProductCategoryName, @PercentRevenue)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertSaleInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_insertSaleInvoice]
	@CreateDate DATETIME
	,@CustomerID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Transaction] ([TransDate],[CustomerID],[TransType])
	SELECT @CreateDate, @CustomerID, 'EX'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertSaleInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_insertSaleInvoice_Details]
	@TransID [int]
	,@ProductID [int]
	,@TransQuantity [int]
	,@TransPrice [float]
	,@Total [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @CustomerID [int]

	SELECT @CustomerID = CustomerID
	FROM [dbo].[Transaction]
	WHERE TransID = @TransID

	IF NOT EXISTS (SELECT [ProductID] 
					FROM [dbo].[TransactionDetails] 
					WHERE [ProductID] = @ProductID AND [TransID] = @TransID)
	BEGIN
		INSERT INTO [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
			   ([TransID]
			   ,[TransDate]
			   ,[ProductID]
			   ,[TransQuantity]
			   ,[TransPrice]
			   ,[Total])
		 VALUES
			   (@TransID
			   ,GETDATE()
			   ,@ProductID
			   ,@TransQuantity
			   ,@TransPrice
			   ,@Total)

		UPDATE [dbo].[Product]
		SET Quantity = Quantity - @TransQuantity
		WHERE [ProductID] = @ProductID
	END
	ELSE
	BEGIN
		DECLARE @TransDetailsID [int]

		SELECT @TransDetailsID = TransDetailsID
		FROM [dbo].[TransactionDetails]
		WHERE [ProductID] = @ProductID

		UPDATE [dbo].[TransactionDetails]
		SET [TransQuantity] = [TransQuantity] + @TransQuantity
			,[TransPrice] = [TransPrice] + @TransPrice
			,[Total] = [Total] + @Total
		WHERE TransDetailsID = @TransDetailsID

		UPDATE [dbo].[Product]
		SET Quantity = Quantity - @TransQuantity
		WHERE [ProductID] = @ProductID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertService]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_insertService]
	@ServiceName [nvarchar](100)
	,@ServicePrice [nvarchar](100)
AS
BEGIN
	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Service]
			   ([ServiceName]
			   ,[ServicePrice])
	VALUES (@ServiceName, CAST(@ServicePrice AS [float]))
END



GO
/****** Object:  StoredProcedure [dbo].[usp_InsertServiceInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_InsertServiceInvoice]
	@CreateDate [datetime]
	,@CustomerID [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[ServiceTransaction]
           ([CreatedDate]
           ,[CustomerID]
           ,[Total]
           ,[Prepaid]
           ,[Remain]
           ,[Status])
     VALUES
           (@CreateDate
           ,@CustomerID
           ,0
           ,0
           ,0
           ,'Incomplete')
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertServiceInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_insertServiceInvoice_Details]
	@ServiceTransID [int]
	,@ServiceID [int]
	,@AdditionalPrice [float]
	,@TransPrice [float]
	,@Quantity [int]
	,@TransTotal [float]
	,@TransPrepaid [float]
	,@TransRemain [float]
	,@DeliveredDate [datetime]
	,@TransStatus [nvarchar](20)
AS
BEGIN
	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails]
		([ServiceTransID]
		,[ServiceID]
		,[AdditionalPrice]
		,[TransPrice]
		,[Quantity]
		,[TransTotal]
		,[TransPrepaid]
		,[TransRemain]
		,[DeliveredDate]
		,[TransStatus])
	VALUES
		(@ServiceTransID
		,@ServiceID
		,@AdditionalPrice
		,@TransPrice
		,@Quantity
		,@TransTotal
		,@TransPrepaid
		,@TransRemain
		,@DeliveredDate
		,@TransStatus)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertUnit]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_insertUnit]
	@UnitName [nvarchar](100)
	,@UnitPrice [nvarchar](100)
AS
BEGIN
	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Unit]
			   ([UnitName]
			   ,[UnitPrice])
	VALUES (@UnitName, CAST(@UnitPrice AS [float]))
END



GO
/****** Object:  StoredProcedure [dbo].[usp_insertVendor]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_insertVendor]
	@VendorName [nvarchar](100)
	,@Address [nvarchar](200)
	,@PhoneNo [nvarchar](100)
AS
BEGIN
	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Vendor]
			   ([VendorName]
			   ,[Address]
			   ,[PhoneNo])
	VALUES (@VendorName, @Address, @PhoneNo)
END



GO
/****** Object:  StoredProcedure [dbo].[usp_InventoryReport]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_InventoryReport]
	@Month [int]
	,@Year [int]
AS
BEGIN
	WITH _Prev AS
	(
		SELECT
			 P.[ProductID]
			,ISNULL(SUM(TD.[TransQuantity]),0) AS [OpeningStock]
		FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
		JOIN [dbo].[Product] P ON TD.[ProductID] = P.[ProductID]
		WHERE MONTH(TD.[TransDate]) = (@Month - 1) AND YEAR(TD.[TransDate]) = @Year
		GROUP BY P.[ProductID]
	), _Import AS
	(
		SELECT
			 TD.ProductID
			,ISNULL(SUM(TD.TransQuantity),0) AS [Import]
		FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
		JOIN [dbo].[Transaction] T ON TD.TransID = T.TransID
		WHERE MONTH(TD.[TransDate]) = @Month AND YEAR(TD.[TransDate]) = @Year AND T.[TransType] = 'IM'
		GROUP BY TD.[ProductID]
	), _Export AS
	(
		SELECT
			 TD.[ProductID]
			,ISNULL(SUM(TD.[TransQuantity]),0) AS [Export]
		FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
		JOIN [dbo].[Transaction] T ON TD.[TransID] = T.[TransID]
		WHERE MONTH(TD.[TransDate]) = @Month AND YEAR(TD.[TransDate]) = @Year AND T.[TransType] = 'EX'
		GROUP BY TD.[ProductID]
	)
	SELECT DISTINCT
		TD.[ProductID]
		,P.[ProductName]
		,ISNULL(Prev.[OpeningStock], 0) AS [OpeningStock]
		,ISNULL(IM.[Import], 0) AS [Import]
		,ISNULL(EX.[Export], 0) AS [Export]
		,P.[Quantity] AS [CloseStock]
		,U.[UnitName] AS [Unit]
	FROM [JEWELRYSTOREMGMT].[dbo].[TransactionDetails] TD
	LEFT JOIN _Prev Prev ON TD.[ProductID] = Prev.[ProductID]
	LEFT JOIN _Import IM ON TD.[ProductID] = IM.[ProductID]
	LEFT JOIN _Export EX ON TD.[ProductID] = EX.[ProductID]
	LEFT JOIN Product P ON TD.[ProductID] = P.[ProductID]
	JOIN Unit U ON P.[UnitID] = U.[UnitID]
	WHERE MONTH(TD.[TransDate]) = @Month AND YEAR(TD.[TransDate]) = @Year
END
GO
/****** Object:  StoredProcedure [dbo].[usp_loadUserInfo]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_loadUserInfo]
	@UserName [nvarchar](100)
AS
BEGIN
	SELECT 
		[UserName]
		,[Role]
		,[PhoneNo]
		,[Address]
	FROM [JEWELRYSTOREMGMT].[dbo].[User]
	WHERE [UserName] = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateCustomer]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateCustomer]
	@CustomerID [int]
	,@CustomerName [nvarchar](100)
	,@Address [nvarchar](200)
	,@PhoneNo [nvarchar](100)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[Customer]
	SET [CustomerName] = @CustomerName
		,[Address] = @Address
		,[PhoneNo] = @PhoneNo
	WHERE [CustomerID] = @CustomerID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePostInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdatePostInvoice]
	@TransID [int]
	,@CreateDate [datetime]
	,@VendorID [int]
AS
BEGIN
	UPDATE [dbo].[Transaction] 
	SET [TransDate] = @CreateDate
		,[VendorID] = @VendorID
	WHERE TransID = @TransID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updatePostInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_updatePostInvoice_Details]
	@TransID [int]
	,@TransDetailsID [int]
	,@ProductID [int]
	,@ProductName [nvarchar](100)
	,@ProductCategoryName [nvarchar](100)
	,@UnitName [nvarchar](100)
	,@TransQuantity [int]
	,@Weight [nvarchar](100)
	--,@ImportPrice [float]
	,@TransPrice [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @VendorID [int]

	SELECT @VendorID = VendorID
	FROM [dbo].[Transaction]
	WHERE TransID = @TransID

	DECLARE @ProductCategoryID [int]

	SELECT @ProductCategoryID = ProductCategoryID
	FROM [dbo].[ProductCategory]
	WHERE ProductCategoryName = @ProductCategoryName

	DECLARE @UnitID [int]

	SELECT @UnitID = UnitID
	FROM [dbo].[Unit]
	WHERE UnitName = @UnitName

	UPDATE [JEWELRYSTOREMGMT].[dbo].[Product]
	SET [ProductName] = @ProductName
		,[VendorID] = @VendorID
		,[ProductCategoryID] = @ProductCategoryID
		,[UnitID] = @UnitID
		,[ImportPrice] = @TransPrice
		,[Weight] = @Weight
		,[Quantity] = @TransQuantity
	WHERE ProductID = @ProductID

	UPDATE [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	SET [TransID] = @TransID
		,[ProductID] = @ProductID
		,[TransQuantity] = @TransQuantity
		,[TransPrice] = @TransPrice
	WHERE TransDetailsID = @TransDetailsID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateProductCategory]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HO MINH TRI
-- Create date: 2019-06-14
-- Description:	Update Category of Product
-- =============================================
CREATE PROCEDURE [dbo].[usp_updateProductCategory]
	@ProductCategoryID [int]
	,@ProductCategoryName [nvarchar](100)
	,@PercentRevenue [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [JEWELRYSTOREMGMT].[dbo].[ProductCategory]
	SET [ProductCategoryName] = @ProductCategoryName
		,[PercentRevenue] = @PercentRevenue
	WHERE [ProductCategoryID] = @ProductCategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateSaleInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_updateSaleInvoice]
	@TransID [int]
	,@CreateDate [datetime]
	,@CustomerID [int]
AS
BEGIN
	UPDATE [dbo].[Transaction] 
	SET [TransDate] = @CreateDate
		,[CustomerID] = @CustomerID
	WHERE TransID = @TransID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateSaleInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_updateSaleInvoice_Details]
	@TransID [int]
	,@TransDetailsID [int]
	,@ProductID [int]
	,@TransQuantity [int]
	,@TransChange [int]
	,@TransPrice [float]
	,@Total [float]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE [dbo].[Product]
	SET Quantity = Quantity - @TransChange
	WHERE [ProductID] = @ProductID

	UPDATE [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	SET [TransID] = @TransID
		,[ProductID] = @ProductID
		,[TransQuantity] = @TransQuantity
		,[TransPrice] = @TransPrice
		,[Total] = @Total
	WHERE TransDetailsID = @TransDetailsID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateService]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateService]
	@ServiceID [int]
	,@ServiceName [nvarchar](100)
	,@ServicePrice [nvarchar](100)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[Service]
	SET [ServiceName] = @ServiceName
		,[ServicePrice] = @ServicePrice
	WHERE [ServiceID] = @ServiceID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateServiceInvoice]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,> 
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateServiceInvoice]
	@ServiceTransID [int]
	,@CreateDate [datetime]
	,@CustomerID [int]
AS
BEGIN
	UPDATE [dbo].[ServiceTransaction]
	SET [CreatedDate] = @CreateDate
		,[CustomerID] = @CustomerID
	WHERE [ServiceTransID] = @ServiceTransID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateServiceInvoice_Details]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_updateServiceInvoice_Details]
	@ServiceTransDetailsID [int]
	,@ServiceTransID [int]
	,@ServiceID [int]
	,@AdditionalPrice [float]
	,@TransPrice [float]
	,@Quantity [int]
	,@TransTotal [float]
	,@TransPrepaid [float]
	,@TransRemain [float]
	,@DeliveredDate [datetime]
	,@TransStatus [nvarchar](20)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[ServiceTransactionDetails]
	SET [ServiceTransID] = @ServiceTransID
		,[ServiceID] = @ServiceID
		,[AdditionalPrice] = @AdditionalPrice
		,[TransPrice] = @TransPrice
		,[Quantity] = @Quantity
		,[TransTotal] = @TransTotal
		,[TransPrepaid] = @TransPrepaid
		,[TransRemain] = @TransRemain
		,[DeliveredDate] = @DeliveredDate
		,[TransStatus] = @TransStatus
	WHERE [ServiceTransDetailsID] = @ServiceTransDetailsID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateUnit]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateUnit]
	@UnitID [int]
	,@UnitName [nvarchar](100)
	,@UnitPrice [nvarchar](100)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[Unit]
	SET [UnitName] = @UnitName
		,[UnitPrice] = @UnitPrice
	WHERE [UnitID] = @UnitID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateUser]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateUser]
	@UserName [nvarchar](100)
	,@Role [nvarchar](20)
	,@Address [nvarchar](200)
	,@PhoneNo [nvarchar](100)
AS
BEGIN
	UPDATE [dbo].[User]
	SET [UserName] = @UserName
		,[Role] = @Role
		,[PhoneNo] = @PhoneNo
		,[Address] = @Address
	WHERE [UserName] = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateUserPassword]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_updateUserPassword] 
	@name [nvarchar](100)
	,@pass [nvarchar](100)
AS
BEGIN
	UPDATE [dbo].[User]
	SET [Password] = @pass 
	WHERE [UserName] = @name
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateVendor]    Script Date: 6/28/2019 5:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateVendor]
	@VendorID [int]
	,@VendorName [nvarchar](100)
	,@Address [nvarchar](200)
	,@PhoneNo [nvarchar](100)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[Vendor]
	SET [VendorName] = @VendorName
		,[Address] = @Address
		,[PhoneNo] = @PhoneNo
	WHERE [VendorID] = @VendorID
END
GO
USE [master]
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET  READ_WRITE 
GO
