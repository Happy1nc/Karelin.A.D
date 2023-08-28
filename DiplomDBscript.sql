USE [master]
GO
/****** Object:  Database [SiteFairDB]    Script Date: 28.08.2023 15:14:42 ******/
CREATE DATABASE [SiteFairDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SiteFairDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\SiteFairDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SiteFairDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\SiteFairDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SiteFairDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SiteFairDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SiteFairDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SiteFairDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SiteFairDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SiteFairDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SiteFairDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SiteFairDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SiteFairDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SiteFairDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SiteFairDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SiteFairDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SiteFairDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SiteFairDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SiteFairDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SiteFairDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SiteFairDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SiteFairDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SiteFairDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SiteFairDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SiteFairDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SiteFairDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SiteFairDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SiteFairDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SiteFairDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SiteFairDB] SET  MULTI_USER 
GO
ALTER DATABASE [SiteFairDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SiteFairDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SiteFairDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SiteFairDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SiteFairDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SiteFairDB] SET QUERY_STORE = OFF
GO
USE [SiteFairDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SiteFairDB]
GO
/****** Object:  User [test]    Script Date: 28.08.2023 15:14:42 ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Anton]    Script Date: 28.08.2023 15:14:42 ******/
CREATE USER [Anton] FOR LOGIN [Anton] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [test]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [test]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Anton]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Anton]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](25) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Patronymic] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[PostIndex] [varchar](6) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformationOfSeller]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformationOfSeller](
	[ID_Seller] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_InformationOfSeller] PRIMARY KEY CLUSTERED 
(
	[ID_Seller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ID_Manager] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ID_Manager] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[ID_Offer] [int] IDENTITY(1,1) NOT NULL,
	[ID_Product] [int] NOT NULL,
	[ID_Seller] [int] NOT NULL,
	[ID_Client] [int] NOT NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[ID_Offer] ASC,
	[ID_Product] ASC,
	[ID_Seller] ASC,
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID_Product] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Duration] [varchar](200) NULL,
	[Cost] [money] NOT NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[ID_Request] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[ID_Manager] [int] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[ID_Request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request_Seller]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request_Seller](
	[ID_Seller] [int] NOT NULL,
	[ID_Request] [int] NOT NULL,
	[DateOfRequest] [datetime] NOT NULL,
	[DateOfVerified] [datetime] NOT NULL,
 CONSTRAINT [PK_Request_Seller] PRIMARY KEY CLUSTERED 
(
	[ID_Seller] ASC,
	[ID_Request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ID_Review] [int] IDENTITY(1,1) NOT NULL,
	[Text] [varchar](50) NOT NULL,
	[Rating] [int] NOT NULL,
	[ID_Client] [int] NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[ID_Review] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[ID_Seller] [int] NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Duration] [varchar](150) NULL,
	[ID_Review] [int] NOT NULL,
 CONSTRAINT [PK_Seller] PRIMARY KEY CLUSTERED 
(
	[ID_Seller] ASC,
	[ID_Review] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller_Product]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller_Product](
	[ID_Seller] [int] NOT NULL,
	[ID_Product] [int] NOT NULL,
 CONSTRAINT [PK_Seller_Product] PRIMARY KEY CLUSTERED 
(
	[ID_Seller] ASC,
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller_Review]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller_Review](
	[ID_Seller] [int] NOT NULL,
	[ID_Review] [int] NOT NULL,
 CONSTRAINT [PK_Seller_Review] PRIMARY KEY CLUSTERED 
(
	[ID_Seller] ASC,
	[ID_Review] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VerifiedType]    Script Date: 28.08.2023 15:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VerifiedType](
	[Name] [varchar](50) NOT NULL,
	[ID_Type] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_VerifiedType] PRIMARY KEY CLUSTERED 
(
	[ID_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID_Client], [FName], [Name], [Patronymic], [Address], [Login], [Password], [PostIndex]) VALUES (2, N'Карелин', N'Антон', N'Дмитриевич', N'Ул.Игнатова 31', N'w', N'w', N'350061')
INSERT [dbo].[Client] ([ID_Client], [FName], [Name], [Patronymic], [Address], [Login], [Password], [PostIndex]) VALUES (3, N'Севрюкова', N'Милена', N'Дмитриевна', N'Ул.Игнатова 31', N'1', N'1', N'350061')
INSERT [dbo].[Client] ([ID_Client], [FName], [Name], [Patronymic], [Address], [Login], [Password], [PostIndex]) VALUES (1010, N'Карелин', N'Антон', NULL, NULL, N'111', N'111', NULL)
INSERT [dbo].[Client] ([ID_Client], [FName], [Name], [Patronymic], [Address], [Login], [Password], [PostIndex]) VALUES (1011, N'Карелин', N'Антон', NULL, NULL, N'111', N'111', NULL)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[InformationOfSeller] ON 

INSERT [dbo].[InformationOfSeller] ([ID_Seller], [Address], [Login], [Password]) VALUES (1, N'Тест', N'W', N'W')
SET IDENTITY_INSERT [dbo].[InformationOfSeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([ID_Manager], [Login], [Password], [FName], [Name]) VALUES (2, N'w1', N'w2', N'Кузнецов', N'Святогор')
INSERT [dbo].[Manager] ([ID_Manager], [Login], [Password], [FName], [Name]) VALUES (4, N'Happy_inc', N'BKS)jKE4PWGkOnazge', N'Антон', N'Карелин')
INSERT [dbo].[Manager] ([ID_Manager], [Login], [Password], [FName], [Name]) VALUES (6, N'Happy_inc', N'$P$BnSbldX5K34aFjTj4lCMp/eDXn6BjF/', N'Карелин', N'Антон')
SET IDENTITY_INSERT [dbo].[Manager] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID_Product], [Name], [Duration], [Cost], [Image]) VALUES (1, N'Свечи восковые', N'Красивые свечечки', 250.0000, NULL)
INSERT [dbo].[Product] ([ID_Product], [Name], [Duration], [Cost], [Image]) VALUES (4, N'Свеча восковая в ракушке', N'Свеча с запахом розы и малины', 75.0000, NULL)
INSERT [dbo].[Product] ([ID_Product], [Name], [Duration], [Cost], [Image]) VALUES (5, N'Свеча таблетка в деревянной подставке', N'Свеча будет красиво смотреться в доме, украшая его. Советуем зажигать во время ужинов и новогодних праздников', 60.0000, NULL)
INSERT [dbo].[Product] ([ID_Product], [Name], [Duration], [Cost], [Image]) VALUES (6, N'Свеча из кокоса', N'Свеча содержится в скорлупе кокоса, что дает красивый внешний вид и защиту от ожогов', 100.0000, NULL)
INSERT [dbo].[Product] ([ID_Product], [Name], [Duration], [Cost], [Image]) VALUES (8, N'Свеча восковая (розовая)', N'Сегодня свечи воспринимаются нами, в основном, как атрибут праздников и романтических вечеров (конечно, если вы — не автомеханик, тогда значение слова кардинально меняется).', 50.0000, NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 

INSERT [dbo].[Reviews] ([ID_Review], [Text], [Rating], [ID_Client]) VALUES (6, N'Текст', 1, 2)
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
INSERT [dbo].[Seller] ([ID_Seller], [FName], [Name], [Duration], [ID_Review]) VALUES (1, N'Карелин', N'Антон', N'Описание', 6)
GO
INSERT [dbo].[Seller_Product] ([ID_Seller], [ID_Product]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[VerifiedType] ON 

INSERT [dbo].[VerifiedType] ([Name], [ID_Type]) VALUES (N'Прошел', 1)
INSERT [dbo].[VerifiedType] ([Name], [ID_Type]) VALUES (N'Не прошел', 2)
SET IDENTITY_INSERT [dbo].[VerifiedType] OFF
GO
ALTER TABLE [dbo].[Offers]  WITH CHECK ADD  CONSTRAINT [FK_Offers_Client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[Offers] CHECK CONSTRAINT [FK_Offers_Client]
GO
ALTER TABLE [dbo].[Offers]  WITH CHECK ADD  CONSTRAINT [FK_Offers_InformationOfSeller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[InformationOfSeller] ([ID_Seller])
GO
ALTER TABLE [dbo].[Offers] CHECK CONSTRAINT [FK_Offers_InformationOfSeller]
GO
ALTER TABLE [dbo].[Offers]  WITH CHECK ADD  CONSTRAINT [FK_Offers_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID_Product])
GO
ALTER TABLE [dbo].[Offers] CHECK CONSTRAINT [FK_Offers_Product]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Manager] FOREIGN KEY([ID_Manager])
REFERENCES [dbo].[Manager] ([ID_Manager])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Manager]
GO
ALTER TABLE [dbo].[Request_Seller]  WITH CHECK ADD  CONSTRAINT [FK_Request_Seller_InformationOfSeller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[InformationOfSeller] ([ID_Seller])
GO
ALTER TABLE [dbo].[Request_Seller] CHECK CONSTRAINT [FK_Request_Seller_InformationOfSeller]
GO
ALTER TABLE [dbo].[Request_Seller]  WITH CHECK ADD  CONSTRAINT [FK_Request_Seller_Request] FOREIGN KEY([ID_Request])
REFERENCES [dbo].[Request] ([ID_Request])
GO
ALTER TABLE [dbo].[Request_Seller] CHECK CONSTRAINT [FK_Request_Seller_Request]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Client]
GO
ALTER TABLE [dbo].[Seller]  WITH CHECK ADD  CONSTRAINT [FK_Seller_InformationOfSeller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[InformationOfSeller] ([ID_Seller])
GO
ALTER TABLE [dbo].[Seller] CHECK CONSTRAINT [FK_Seller_InformationOfSeller]
GO
ALTER TABLE [dbo].[Seller_Product]  WITH CHECK ADD  CONSTRAINT [FK_Seller_Product_InformationOfSeller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[InformationOfSeller] ([ID_Seller])
GO
ALTER TABLE [dbo].[Seller_Product] CHECK CONSTRAINT [FK_Seller_Product_InformationOfSeller]
GO
ALTER TABLE [dbo].[Seller_Product]  WITH CHECK ADD  CONSTRAINT [FK_Seller_Product_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID_Product])
GO
ALTER TABLE [dbo].[Seller_Product] CHECK CONSTRAINT [FK_Seller_Product_Product]
GO
ALTER TABLE [dbo].[Seller_Review]  WITH CHECK ADD  CONSTRAINT [FK_Seller_Review_InformationOfSeller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[InformationOfSeller] ([ID_Seller])
GO
ALTER TABLE [dbo].[Seller_Review] CHECK CONSTRAINT [FK_Seller_Review_InformationOfSeller]
GO
ALTER TABLE [dbo].[Seller_Review]  WITH CHECK ADD  CONSTRAINT [FK_Seller_Review_Reviews] FOREIGN KEY([ID_Review])
REFERENCES [dbo].[Reviews] ([ID_Review])
GO
ALTER TABLE [dbo].[Seller_Review] CHECK CONSTRAINT [FK_Seller_Review_Reviews]
GO
USE [master]
GO
ALTER DATABASE [SiteFairDB] SET  READ_WRITE 
GO
