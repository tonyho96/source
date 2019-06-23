USE [master]
GO
/****** Object:  Database [JEWELRYSTOREMGMT]    Script Date: 6/23/2019 11:23:52 AM ******/
CREATE DATABASE [JEWELRYSTOREMGMT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JEWELRYSTOREMGMT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JEWELRYSTOREMGMT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JEWELRYSTOREMGMT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JEWELRYSTOREMGMT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JEWELRYSTOREMGMT] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JEWELRYSTOREMGMT].[dbo].[sp_fulltext_database] @action = 'enable'
end
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
/****** Object:  Table [dbo].[Customer]    Script Date: 6/23/2019 11:23:52 AM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 6/23/2019 11:23:53 AM ******/
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
	[ImageUrl] [nvarchar](200) NULL,
	[Weight] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[Service]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[ServiceTransaction]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[ServiceTransactionDetails]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[Transaction]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 6/23/2019 11:23:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[TransDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[TransID] [int] NULL,
	[TransDate] [smalldatetime] NULL,
	[ProductID] [int] NULL,
	[UnitID] [int] NULL,
	[TransQuantity] [int] NULL,
	[TransPrice] [float] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  Table [dbo].[Vendor]    Script Date: 6/23/2019 11:23:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [ImageUrl], [Weight], [Quantity]) VALUES (6, N'NE-Calvin', 2, 2, 25, NULL, N'0.25', 2)
INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [ImageUrl], [Weight], [Quantity]) VALUES (7, N'BR-Hello', 2, 3, 12, NULL, N'0.5', 20)
INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [ImageUrl], [Weight], [Quantity]) VALUES (8, N'RG-IID', 1, 5, 22, NULL, N'1', 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [VendorID], [ProductCategoryID], [ImportPrice], [ImageUrl], [Weight], [Quantity]) VALUES (10, N'BR-DAD', 1, 3, 21, NULL, N'0.63', 25)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[ProductCategory] ON 

INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (2, N'Necklaces', 0.25)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (3, N'Braclets', 0.14000000059604645)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (4, N'Earrings', 0.20999999344348908)
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName], [PercentRevenue]) VALUES (5, N'Rings', 0.079999998211860657)
SET IDENTITY_INSERT [dbo].[ProductCategory] OFF
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (3, CAST(N'2019-06-14T00:00:00' AS SmallDateTime), NULL, 2, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (4, CAST(N'2019-06-14T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
SET IDENTITY_INSERT [dbo].[TransactionDetails] ON 

INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [UnitID], [TransQuantity], [TransPrice], [Total]) VALUES (6, 3, CAST(N'2019-06-23T11:06:00' AS SmallDateTime), 6, 3, 2, 25, 25)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [UnitID], [TransQuantity], [TransPrice], [Total]) VALUES (7, 3, CAST(N'2019-06-23T11:06:00' AS SmallDateTime), 7, 2, 20, 12, 12)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [UnitID], [TransQuantity], [TransPrice], [Total]) VALUES (8, 4, CAST(N'2019-06-23T11:07:00' AS SmallDateTime), 8, 2, 1, 22, 23)
INSERT [dbo].[TransactionDetails] ([TransDetailsID], [TransID], [TransDate], [ProductID], [UnitID], [TransQuantity], [TransPrice], [Total]) VALUES (10, 4, CAST(N'2019-06-23T11:11:00' AS SmallDateTime), 10, 1, 25, 21, 21)
SET IDENTITY_INSERT [dbo].[TransactionDetails] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (1, N'24K', 36830000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (2, N'22K', 36630000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (3, N'18K', 27620000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (4, N'14K', 21580000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (5, N'10K', 15390000)
SET IDENTITY_INSERT [dbo].[Unit] OFF
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
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([UnitID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
/****** Object:  StoredProcedure [dbo].[usp_DeletePostInvoice]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_deletePostInvoice_Details]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_deleteProductCategory]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_deleteUnit]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_deleteVendor]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice_Details]    Script Date: 6/23/2019 11:23:53 AM ******/
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
	SELECT
		TD.TransDetailsID
		,P.ProductID
		,P.[ProductName]
		,PC.[ProductCategoryName]
		,TD.[TransQuantity]
		,U.[UnitName]
		--,P.[ImportPrice]
		,TD.[TransPrice]
		--,P.[ImageUrl]
		,P.[Weight]
	FROM [dbo].[TransactionDetails] TD
	INNER JOIN [dbo].[Product] P
		ON TD.[ProductID] = P.[ProductID]
	INNER JOIN [dbo].[ProductCategory] PC
		ON P.[ProductCategoryID] = PC.[ProductCategoryID]
	INNER JOIN [dbo].[Unit] U
		ON TD.[UnitID] = U.[UnitID]
	WHERE TD.TransID = @TransID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getProductCategory]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getUnitList]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getVendorList]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_InsertPostInvoice]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_insertPostInvoice_Details]    Script Date: 6/23/2019 11:23:53 AM ******/
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

	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[Product]
           ([ProductName]
           ,[VendorID]
           ,[ProductCategoryID]
           ,[ImportPrice]
           ,[ImageUrl]
           ,[Weight]
           ,[Quantity])
     VALUES
           (@ProductName
           ,@VendorID
           ,@ProductCategoryID
           ,@TransPrice
           ,NULL
           ,@Weight
           ,@TransQuantity)

	DECLARE @ProductID [int]

	SELECT @ProductID = ProductID
	FROM [dbo].[Product]
	WHERE ProductName = @ProductName

	DECLARE @UnitID [int]

	SELECT @UnitID = UnitID
	FROM [dbo].[Unit]
	WHERE UnitName = @UnitName

	INSERT INTO [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
           ([TransID]
           ,[TransDate]
           ,[ProductID]
           ,[UnitID]
           ,[TransQuantity]
           ,[TransPrice]
           ,[Total])
     VALUES
           (@TransID
           ,GETDATE()
           ,@ProductID
           ,@UnitID
           ,@TransQuantity
           ,@TransPrice
           ,@TransPrice)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_insertProductCategory]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_insertUnit]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_insertVendor]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_UpdatePostInvoice]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_updatePostInvoice_Details]    Script Date: 6/23/2019 11:23:53 AM ******/
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

	UPDATE [JEWELRYSTOREMGMT].[dbo].[Product]
	SET [ProductName] = @ProductName
		,[VendorID] = @VendorID
		,[ProductCategoryID] = @ProductCategoryID
		,[ImportPrice] = @TransPrice
		,[Weight] = @Weight
		,[Quantity] = @TransQuantity
	WHERE ProductID = @ProductID

	DECLARE @UnitID [int]

	SELECT @UnitID = UnitID
	FROM [dbo].[Unit]
	WHERE UnitName = @UnitName

	UPDATE [JEWELRYSTOREMGMT].[dbo].[TransactionDetails]
	SET [TransID] = @TransID
		,[ProductID] = @ProductID
		,[UnitID] = @UnitID
		,[TransQuantity] = @TransQuantity
		,[TransPrice] = @TransPrice
	WHERE TransDetailsID = @TransDetailsID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateProductCategory]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_updateUnit]    Script Date: 6/23/2019 11:23:53 AM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_updateVendor]    Script Date: 6/23/2019 11:23:53 AM ******/
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
