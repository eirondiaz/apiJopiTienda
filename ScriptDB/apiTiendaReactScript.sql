USE [master]
GO
/****** Object:  Database [JopiTienda]    Script Date: 8/10/2020 12:30:14 ******/
CREATE DATABASE [JopiTienda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JopiTienda', FILENAME = N'C:\Users\eiron\JopiTienda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JopiTienda_log', FILENAME = N'C:\Users\eiron\JopiTienda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JopiTienda] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JopiTienda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JopiTienda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JopiTienda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JopiTienda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JopiTienda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JopiTienda] SET ARITHABORT OFF 
GO
ALTER DATABASE [JopiTienda] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [JopiTienda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JopiTienda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JopiTienda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JopiTienda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JopiTienda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JopiTienda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JopiTienda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JopiTienda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JopiTienda] SET  ENABLE_BROKER 
GO
ALTER DATABASE [JopiTienda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JopiTienda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JopiTienda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JopiTienda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JopiTienda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JopiTienda] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [JopiTienda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JopiTienda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JopiTienda] SET  MULTI_USER 
GO
ALTER DATABASE [JopiTienda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JopiTienda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JopiTienda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JopiTienda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JopiTienda] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JopiTienda] SET QUERY_STORE = OFF
GO
USE [JopiTienda]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [JopiTienda]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartHist]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartHist](
	[Sku] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[Currency] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[OrderId] [nvarchar](max) NULL,
	[OrdenId] [nvarchar](450) NULL,
 CONSTRAINT [PK_CartHist] PRIMARY KEY CLUSTERED 
(
	[Sku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[Currency] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direcciones]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direcciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Ciudad] [nvarchar](max) NULL,
	[Cp] [nvarchar](max) NULL,
	[Pais] [nvarchar](max) NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_Direcciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[Id] [nvarchar](450) NOT NULL,
	[Fecha] [nvarchar](max) NULL,
	[Total] [nvarchar](max) NULL,
	[UsuarioId] [int] NOT NULL,
	[Productos] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Categoria] [nvarchar](max) NULL,
	[Precio] [nvarchar](max) NULL,
	[Stock] [nvarchar](max) NULL,
	[Foto] [nvarchar](max) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/10/2020 12:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NULL,
	[Contraseña] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CartHist_OrdenId]    Script Date: 8/10/2020 12:30:16 ******/
CREATE NONCLUSTERED INDEX [IX_CartHist_OrdenId] ON [dbo].[CartHist]
(
	[OrdenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_UsuarioId]    Script Date: 8/10/2020 12:30:16 ******/
CREATE NONCLUSTERED INDEX [IX_Carts_UsuarioId] ON [dbo].[Carts]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Direcciones_UsuarioId]    Script Date: 8/10/2020 12:30:16 ******/
CREATE NONCLUSTERED INDEX [IX_Direcciones_UsuarioId] ON [dbo].[Direcciones]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ordenes_UsuarioId]    Script Date: 8/10/2020 12:30:16 ******/
CREATE NONCLUSTERED INDEX [IX_Ordenes_UsuarioId] ON [dbo].[Ordenes]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CartHist]  WITH CHECK ADD  CONSTRAINT [FK_CartHist_Ordenes_OrdenId] FOREIGN KEY([OrdenId])
REFERENCES [dbo].[Ordenes] ([Id])
GO
ALTER TABLE [dbo].[CartHist] CHECK CONSTRAINT [FK_CartHist_Ordenes_OrdenId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD  CONSTRAINT [FK_Direcciones_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Direcciones] CHECK CONSTRAINT [FK_Direcciones_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Usuarios_UsuarioId]
GO
USE [master]
GO
ALTER DATABASE [JopiTienda] SET  READ_WRITE 
GO
