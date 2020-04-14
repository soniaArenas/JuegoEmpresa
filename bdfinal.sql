USE [master]
GO
/****** Object:  Database [OfficeGame]    Script Date: 06/10/2019 21:26:12 ******/
CREATE DATABASE [OfficeGame]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OfficeGame', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\OfficeGame.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OfficeGame_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\OfficeGame_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OfficeGame] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OfficeGame].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OfficeGame] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OfficeGame] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OfficeGame] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OfficeGame] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OfficeGame] SET ARITHABORT OFF 
GO
ALTER DATABASE [OfficeGame] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OfficeGame] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OfficeGame] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OfficeGame] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OfficeGame] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OfficeGame] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OfficeGame] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OfficeGame] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OfficeGame] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OfficeGame] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OfficeGame] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OfficeGame] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OfficeGame] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OfficeGame] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OfficeGame] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OfficeGame] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OfficeGame] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OfficeGame] SET RECOVERY FULL 
GO
ALTER DATABASE [OfficeGame] SET  MULTI_USER 
GO
ALTER DATABASE [OfficeGame] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OfficeGame] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OfficeGame] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OfficeGame] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OfficeGame] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OfficeGame', N'ON'
GO
ALTER DATABASE [OfficeGame] SET QUERY_STORE = OFF
GO
USE [OfficeGame]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 06/10/2019 21:26:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[IdPartida] [int] IDENTITY(1,1) NOT NULL,
	[IdUsu] [int] NOT NULL,
	[Lvl] [int] NOT NULL,
	[Trabajadores] [int] NOT NULL,
	[Presupuesto] [int] NOT NULL,
	[Felicidad] [int] NOT NULL,
	[LvlOficina1] [int] NOT NULL,
	[LvlOficina2] [int] NOT NULL,
	[LvlOficina3] [int] NOT NULL,
	[LvlOficina4] [int] NOT NULL,
	[Proyectos] [int] NOT NULL,
	[TrabajadoresLibres] [int] NULL,
 CONSTRAINT [PK_Partidas] PRIMARY KEY CLUSTERED 
(
	[IdPartida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/10/2019 21:26:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsu] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[Pregunta] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[Ciudad] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [OfficeGame] SET  READ_WRITE 
GO
