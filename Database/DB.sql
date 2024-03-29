USE [master]
GO
/****** Object:  Database [JEWELRYSTOREMGMT]    Script Date: 6/16/2019 9:55:41 PM ******/
CREATE DATABASE [JEWELRYSTOREMGMT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JEWELRYSTOREMGMT', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JEWELRYSTOREMGMT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JEWELRYSTOREMGMT_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\JEWELRYSTOREMGMT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Customer]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 6/16/2019 9:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[VendorID] [int] NULL,
	[ImportPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 6/16/2019 9:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryName] [nvarchar](100) NULL,
	[ProductID] [int] NULL,
	[PercentRevenue] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[ServiceTransaction]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[ServiceTransactionDetails]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[Transaction]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[Unit]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  Table [dbo].[Vendor]    Script Date: 6/16/2019 9:55:42 PM ******/
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
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (1, CAST(N'2019-06-14T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (2, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (3, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 3, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (4, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 2, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (5, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 1, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (6, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 2, N'IM')
INSERT [dbo].[Transaction] ([TransID], [TransDate], [CustomerID], [VendorID], [TransType]) VALUES (7, CAST(N'2018-04-25T00:00:00' AS SmallDateTime), NULL, 3, N'IM')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (1, N'24K', 36830000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (2, N'22K', 36630000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (3, N'18K', 27620000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (4, N'14K', 21580000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (5, N'10K', 15390000)
INSERT [dbo].[Unit] ([UnitID], [UnitName], [UnitPrice]) VALUES (10, N'aaa', 122)
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[Vendor] ON 

INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (1, N'PNJ', N'170E Phan Dang Luu St, Ward 3, Phu Nhuan District, Ho Chi Minh City', N'02839951703')
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (2, N'DOJI', N'214 Phan Dang Luu St, Ward 3, Phu Nhuan District, Ho Chi Minh City', N'02839953666')
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [Address], [PhoneNo]) VALUES (3, N'SJC', N'418-420 Nguyen Thi Minh Khai St, Ward 5, District 3, Ho Chi Minh City', N'02839293388')
SET IDENTITY_INSERT [dbo].[Vendor] OFF
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[ProductCategory]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
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
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([TransID])
REFERENCES [dbo].[Transaction] ([TransID])
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([UnitID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
/****** Object:  StoredProcedure [dbo].[GetCategories]    Script Date: 6/16/2019 9:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HMT
-- Create date: 2019-06-14
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCategories]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT DISTINCT [ProductCategoryName]
	FROM [dbo].[ProductCategory]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteUnit]    Script Date: 6/16/2019 9:55:42 PM ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteVendor]    Script Date: 6/16/2019 9:55:42 PM ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getPostInvoice_Details]    Script Date: 6/16/2019 9:55:42 PM ******/
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
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT P.[ProductName]
		,PC.[ProductCategoryName]
		,TD.[TransQuantity]
		,U.[UnitName]
		,V.[VendorName]
		,P.[ImportPrice]
		,T.[VendorID]
		--,T.[]
		--,T.
	FROM [dbo].[Transaction] T
	INNER JOIN [dbo].[TransactionDetails] TD
		ON T.[TransID] = TD.[TransID]
	INNER JOIN [dbo].[Product] P
		ON TD.[ProductID] = P.[ProductID]
	INNER JOIN [dbo].[ProductCategory] PC
		ON P.[ProductID] = PC.[ProductID]
	INNER JOIN [dbo].[Unit] U
		ON TD.[UnitID] = U.[UnitID]
	INNER JOIN [dbo].[Vendor] V
		ON P.[VendorID] = V.[VendorName]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getUnitList]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_getVendorList]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_InsertPostInvoice]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_insertUnit]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_insertVendor]    Script Date: 6/16/2019 9:55:42 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_updateUnit]    Script Date: 6/16/2019 9:55:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_updateUnit]
	@UnitID [int]
	,@UnitName [nvarchar](100)
	--,@UnitPrice [nvarchar](100)
AS
BEGIN
	UPDATE [JEWELRYSTOREMGMT].[dbo].[Unit]
	SET [UnitName] = @UnitName
		--,[UnitPrice] = @UnitPrice
	WHERE [UnitID] = @UnitID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_updateVendor]    Script Date: 6/16/2019 9:55:42 PM ******/
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
