USE [master]
GO
/****** Object:  Database [BDJorge]    Script Date: 05/10/2024 4:25:07 ******/
CREATE DATABASE [BDJorge]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDJorge', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDJorge.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDJorge_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDJorge_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDJorge] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDJorge].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDJorge] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDJorge] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDJorge] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDJorge] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDJorge] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDJorge] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDJorge] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BDJorge] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDJorge] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDJorge] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDJorge] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDJorge] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDJorge] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDJorge] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDJorge] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDJorge] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDJorge] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDJorge] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDJorge] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDJorge] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDJorge] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDJorge] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDJorge] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDJorge] SET RECOVERY FULL 
GO
ALTER DATABASE [BDJorge] SET  MULTI_USER 
GO
ALTER DATABASE [BDJorge] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDJorge] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDJorge] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDJorge] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDJorge', N'ON'
GO
USE [BDJorge]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 05/10/2024 4:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[ci] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[paterno] [varchar](50) NOT NULL,
	[distrito] [varchar](50) NOT NULL,
	[zona] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[propiedades]    Script Date: 05/10/2024 4:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[propiedades](
	[id] [int] NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
	[direccion] [varchar](255) NULL,
	[zona] [varchar](50) NOT NULL,
	[distrito] [varchar](50) NOT NULL,
	[x_ini] [decimal](10, 6) NOT NULL,
	[y_ini] [decimal](10, 6) NOT NULL,
	[x_fin] [decimal](10, 6) NOT NULL,
	[y_fin] [decimal](10, 6) NOT NULL,
	[superficie] [decimal](10, 2) NOT NULL,
	[precio] [decimal](10, 2) NULL,
	[ci] [int] NOT NULL,
	[fecha_registro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 05/10/2024 4:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[rol] [varchar](20) NOT NULL,
	[ci] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (123456, N'Luna', N'Perez', N'Distrito 1', N'Centro')
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (246812, N'Hall', N'Payton', N'Distrito 5', N'Periférica')
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (987654, N'Jose', N'Lopez', N'Distrito 4', N'Sur')
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (1357924, N'Alisson', N'Castro', N'Distrito 4', N'Max Paredes')
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (3333333, N'Yoyo', N'Prueba', N'dada', N'sdasd')
INSERT [dbo].[Persona] ([ci], [nombre], [paterno], [distrito], [zona]) VALUES (7615158, N'Jorge', N'Fernandez', N'Distrito 7', N'Periférica')
INSERT [dbo].[propiedades] ([id], [descripcion], [direccion], [zona], [distrito], [x_ini], [y_ini], [x_fin], [y_fin], [superficie], [precio], [ci], [fecha_registro]) VALUES (100001, N'Propiedad de prueba', N'Direccion de prueba', N'Zona de prueba', N'Distrito de prueba', CAST(20.000000 AS Decimal(10, 6)), CAST(30.000000 AS Decimal(10, 6)), CAST(40.000000 AS Decimal(10, 6)), CAST(10.000000 AS Decimal(10, 6)), CAST(10000.00 AS Decimal(10, 2)), CAST(100000.00 AS Decimal(10, 2)), 7615158, CAST(0x0000B2000046F164 AS DateTime))
INSERT [dbo].[propiedades] ([id], [descripcion], [direccion], [zona], [distrito], [x_ini], [y_ini], [x_fin], [y_fin], [superficie], [precio], [ci], [fecha_registro]) VALUES (300000, N'Propiedad en el centro', N'Calle 123', N'Centro', N'Distrito 1', CAST(-16.500000 AS Decimal(10, 6)), CAST(-68.150000 AS Decimal(10, 6)), CAST(-16.500050 AS Decimal(10, 6)), CAST(-68.150050 AS Decimal(10, 6)), CAST(120.50 AS Decimal(10, 2)), CAST(150000.00 AS Decimal(10, 2)), 123456, CAST(0x0000B200000AC9EB AS DateTime))
INSERT [dbo].[propiedades] ([id], [descripcion], [direccion], [zona], [distrito], [x_ini], [y_ini], [x_fin], [y_fin], [superficie], [precio], [ci], [fecha_registro]) VALUES (300001, N'Propiedad en la zona norte', N'Avenida Norte 456', N'Norte', N'Distrito 2', CAST(-16.480000 AS Decimal(10, 6)), CAST(-68.130000 AS Decimal(10, 6)), CAST(-16.480050 AS Decimal(10, 6)), CAST(-68.130050 AS Decimal(10, 6)), CAST(200.75 AS Decimal(10, 2)), CAST(180000.00 AS Decimal(10, 2)), 987654, CAST(0x0000B20000248615 AS DateTime))
INSERT [dbo].[propiedades] ([id], [descripcion], [direccion], [zona], [distrito], [x_ini], [y_ini], [x_fin], [y_fin], [superficie], [precio], [ci], [fecha_registro]) VALUES (300002, N'Propiedad en la zona sur', N'Calle Sur 789', N'Sur', N'Distrito 3', CAST(-16.490000 AS Decimal(10, 6)), CAST(-68.140000 AS Decimal(10, 6)), CAST(-16.490050 AS Decimal(10, 6)), CAST(-68.140050 AS Decimal(10, 6)), CAST(150.30 AS Decimal(10, 2)), CAST(175000.00 AS Decimal(10, 2)), 246812, CAST(0x0000B20000248615 AS DateTime))
INSERT [dbo].[propiedades] ([id], [descripcion], [direccion], [zona], [distrito], [x_ini], [y_ini], [x_fin], [y_fin], [superficie], [precio], [ci], [fecha_registro]) VALUES (300003, N'Propiedad en el centro', N'Calle 123', N'Centro', N'Distrito 1', CAST(-16.500000 AS Decimal(10, 6)), CAST(-68.150000 AS Decimal(10, 6)), CAST(-16.500050 AS Decimal(10, 6)), CAST(-68.150050 AS Decimal(10, 6)), CAST(120.50 AS Decimal(10, 2)), CAST(150000.00 AS Decimal(10, 2)), 123456, CAST(0x0000B20000248615 AS DateTime))
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (1, N'root', N'123', N'root', NULL)
INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (4, N'luna', N'123', N'funcionario', 123456)
INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (5, N'jose', N'123', N'normal', 987654)
INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (6, N'hall', N'123', N'normal', 246812)
INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (8, N'ali', N'123', N'normal', 1357924)
INSERT [dbo].[usuarios] ([id], [username], [password], [rol], [ci]) VALUES (9, N'jorge', N'123', N'normal', 7615158)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__usuarios__F3DBC57226F6E57C]    Script Date: 05/10/2024 4:25:08 ******/
ALTER TABLE [dbo].[usuarios] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[propiedades] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ('normal') FOR [rol]
GO
ALTER TABLE [dbo].[propiedades]  WITH CHECK ADD FOREIGN KEY([ci])
REFERENCES [dbo].[Persona] ([ci])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Persona] FOREIGN KEY([ci])
REFERENCES [dbo].[Persona] ([ci])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_Usuarios_Persona]
GO
ALTER TABLE [dbo].[propiedades]  WITH CHECK ADD CHECK  (([id]>=(100000) AND [id]<=(400000)))
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD CHECK  (([rol]='funcionario' OR [rol]='normal' OR [rol]='root'))
GO
USE [master]
GO
ALTER DATABASE [BDJorge] SET  READ_WRITE 
GO
