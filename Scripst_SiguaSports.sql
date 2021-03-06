USE [master]
GO
/****** Object:  Database [SiguaSports]    Script Date: 12/7/2020 6:46:41 PM ******/
CREATE DATABASE [SiguaSports]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SiguaSports', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SiguaSports.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SiguaSports_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SiguaSports_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SiguaSports] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SiguaSports].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SiguaSports] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SiguaSports] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SiguaSports] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SiguaSports] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SiguaSports] SET ARITHABORT OFF 
GO
ALTER DATABASE [SiguaSports] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SiguaSports] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SiguaSports] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SiguaSports] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SiguaSports] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SiguaSports] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SiguaSports] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SiguaSports] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SiguaSports] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SiguaSports] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SiguaSports] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SiguaSports] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SiguaSports] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SiguaSports] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SiguaSports] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SiguaSports] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SiguaSports] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SiguaSports] SET RECOVERY FULL 
GO
ALTER DATABASE [SiguaSports] SET  MULTI_USER 
GO
ALTER DATABASE [SiguaSports] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SiguaSports] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SiguaSports] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SiguaSports] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SiguaSports] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SiguaSports] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SiguaSports', N'ON'
GO
ALTER DATABASE [SiguaSports] SET QUERY_STORE = OFF
GO
USE [SiguaSports]
GO
/****** Object:  User [AccesoLocal]    Script Date: 12/7/2020 6:46:41 PM ******/
CREATE USER [AccesoLocal] FOR LOGIN [AccesoLocal] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_datareader] ADD MEMBER [AccesoLocal]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [AccesoLocal]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[cod_categoria] [nchar](10) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[cod_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[cod_compra] [int] NOT NULL,
	[cod_producto] [nchar](10) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioCompra] [real] NOT NULL,
 CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED 
(
	[cod_compra] ASC,
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[cod_compra] [int] NOT NULL,
	[fecha_compra] [date] NOT NULL,
	[descuentoPorcentaje] [real] NOT NULL,
	[impuestoPorcentaje] [real] NOT NULL,
	[cod_empleado] [nchar](10) NOT NULL,
	[cod_proveedor] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[cod_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DevolucionDetalle]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DevolucionDetalle](
	[num_devolucion] [int] NOT NULL,
	[cod_producto] [nchar](10) NOT NULL,
	[cantidad] [int] NOT NULL,
	[motivo] [nvarchar](50) NOT NULL,
	[cod_estado] [nchar](3) NOT NULL,
	[cod_producto_cambio] [nchar](10) NULL,
 CONSTRAINT [PK_DetallesDevolucion] PRIMARY KEY CLUSTERED 
(
	[num_devolucion] ASC,
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devoluciones]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devoluciones](
	[num_devolucion] [int] NOT NULL,
	[cod_empleado] [nchar](10) NOT NULL,
	[num_factura] [nvarchar](18) NOT NULL,
	[fecha_devolucion] [date] NOT NULL,
 CONSTRAINT [PK_Devoluciones] PRIMARY KEY CLUSTERED 
(
	[num_devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpleadodHistoricos]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadodHistoricos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[cod_empleado] [nchar](10) NOT NULL,
	[nombre] [nvarchar](75) NOT NULL,
	[fecha_contratacion] [date] NULL,
	[salario] [money] NULL,
	[fecha_despido] [date] NULL,
	[accion] [nvarchar](20) NOT NULL,
	[fecha_modificacion] [date] NULL,
	[usuario] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmpleadodHistoricos] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[cod_empleado] [nchar](10) NOT NULL,
	[nombres] [nvarchar](50) NOT NULL,
	[apellidos] [nvarchar](50) NOT NULL,
	[cod_puesto] [int] NOT NULL,
	[cod_usuario] [nvarchar](10) NOT NULL,
	[salario] [money] NOT NULL,
	[fecha_contratacion] [date] NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[cod_genero] [int] NOT NULL,
	[correo] [nvarchar](150) NULL,
	[telefono] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[cod_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[cod_estado] [nchar](3) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[cod_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[cod_genero] [int] IDENTITY(1,1) NOT NULL,
	[decripcion] [nchar](10) NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[cod_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[cod_producto] [nchar](10) NOT NULL,
	[nombre] [nvarchar](25) NOT NULL,
	[precioVenta] [real] NOT NULL,
	[precioCompra] [real] NOT NULL,
	[color] [nchar](10) NULL,
	[marca] [nchar](10) NULL,
	[cod_categoria] [nchar](10) NOT NULL,
	[existencia] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[cod_proveedor] [nchar](10) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[correo] [nvarchar](120) NULL,
	[nombre_contacto] [nvarchar](50) NOT NULL,
	[telefono_contacto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[cod_puesto] [int] NOT NULL,
	[descripcion] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[cod_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[cod_usuario] [nvarchar](10) NOT NULL,
	[contraseña] [nvarchar](20) NOT NULL,
	[confirmacion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[num_factura] [nvarchar](18) NOT NULL,
	[cod_prducto] [nchar](10) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioVenta] [money] NOT NULL,
 CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED 
(
	[num_factura] ASC,
	[cod_prducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[num_factura] [nvarchar](18) NOT NULL,
	[cod_empleado] [nchar](10) NOT NULL,
	[descuentoPorcentaje] [real] NOT NULL,
	[impuestoPorcentaje] [real] NOT NULL,
	[fecha_Venta] [date] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[num_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'ACSR      ', N'Accesorios')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'BZSS      ', N'Buzos')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'CMST      ', N'Camisas')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'LGNS      ', N'Leggins')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'SDRS      ', N'Sudaderas')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'SPLM      ', N'Suplementos')
INSERT [dbo].[Categorias] ([cod_categoria], [descripcion]) VALUES (N'TNNS      ', N'Tennis')
GO
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (1, N'T-425     ', 100, 250)
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (2, N'P-231     ', 50, 100)
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (3, N'R-456     ', 50, 320.5)
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (4, N'H-258     ', 50, 62.5)
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (6, N'A-458     ', 50, 230.6)
INSERT [dbo].[CompraDetalle] ([cod_compra], [cod_producto], [cantidad], [precioCompra]) VALUES (6, N'R-254     ', 20, 1500)
GO
INSERT [dbo].[Compras] ([cod_compra], [fecha_compra], [descuentoPorcentaje], [impuestoPorcentaje], [cod_empleado], [cod_proveedor]) VALUES (1, CAST(N'2020-10-10' AS Date), 0, 0.15, N'DBADMIN   ', N'AMZN      ')
INSERT [dbo].[Compras] ([cod_compra], [fecha_compra], [descuentoPorcentaje], [impuestoPorcentaje], [cod_empleado], [cod_proveedor]) VALUES (2, CAST(N'2020-11-11' AS Date), 0, 0.15, N'DBADMIN   ', N'SPMX      ')
INSERT [dbo].[Compras] ([cod_compra], [fecha_compra], [descuentoPorcentaje], [impuestoPorcentaje], [cod_empleado], [cod_proveedor]) VALUES (3, CAST(N'2020-11-23' AS Date), 0, 0.15, N'DBBDG     ', N'BTZP      ')
INSERT [dbo].[Compras] ([cod_compra], [fecha_compra], [descuentoPorcentaje], [impuestoPorcentaje], [cod_empleado], [cod_proveedor]) VALUES (4, CAST(N'2020-11-22' AS Date), 0, 0.15, N'DBBDG     ', N'BTZP      ')
INSERT [dbo].[Compras] ([cod_compra], [fecha_compra], [descuentoPorcentaje], [impuestoPorcentaje], [cod_empleado], [cod_proveedor]) VALUES (6, CAST(N'2020-11-23' AS Date), 0, 0.15, N'DBADMIN   ', N'AMZN      ')
GO
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (3, N'T-425     ', 1, N'T-425     ', N'2  ', N'@codProd  ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (4, N'T-425     ', 1, N'Motivo', N'1  ', NULL)
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (5, N'T-425     ', 1, N'T-425     ', N'2  ', N'T-425     ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (6, N'T-425     ', 1, N'T-425     ', N'2  ', N'T-425     ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (7, N'T-425     ', 1, N'Fallo', N'1  ', NULL)
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (9, N'T-425     ', 1, N'ERROR', N'2  ', N'T-425     ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (10, N'T-425     ', 1, N'ERROR', N'2  ', N'T-425     ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (11, N'H-258     ', 1, N'dd', N'2  ', N'H-258     ')
INSERT [dbo].[DevolucionDetalle] ([num_devolucion], [cod_producto], [cantidad], [motivo], [cod_estado], [cod_producto_cambio]) VALUES (12, N'T-425     ', 1, N'12', N'1  ', NULL)
GO
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (1, N'DBADMIN   ', N'000-001-01-0000010', CAST(N'2020-11-27' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (2, N'DBADMIN   ', N'000-001-01-0000010', CAST(N'2020-11-27' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (3, N'DBADMIN   ', N'000-001-01-0000010', CAST(N'2020-11-27' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (4, N'DBADMIN   ', N'000-001-01-0000010', CAST(N'2020-11-27' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (5, N'EdwGar    ', N'000-001-01-0000011', CAST(N'2020-11-28' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (6, N'EdwGar    ', N'000-001-01-0000010', CAST(N'2020-11-28' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (7, N'EdwGar    ', N'000-001-01-0000011', CAST(N'2020-11-28' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (8, N'EdwGar    ', N'000-001-01-0000010', CAST(N'2020-11-29' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (9, N'EdwGar    ', N'000-001-01-0000010', CAST(N'2020-11-29' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (10, N'EdwGar    ', N'000-001-01-0000010', CAST(N'2020-11-29' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (11, N'DBADMIN   ', N'000-001-01-0000015', CAST(N'2020-12-05' AS Date))
INSERT [dbo].[Devoluciones] ([num_devolucion], [cod_empleado], [num_factura], [fecha_devolucion]) VALUES (12, N'DBADMIN   ', N'000-001-01-0000014', CAST(N'2020-12-05' AS Date))
GO
SET IDENTITY_INSERT [dbo].[EmpleadodHistoricos] ON 

INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (1, N'AlaPru    ', N'Alan Prueba', CAST(N'2020-11-16' AS Date), 0.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-11-16' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (2, N'AlaPru    ', N'Alan Prueba', CAST(N'2020-11-16' AS Date), 0.0000, CAST(N'2020-11-16' AS Date), N'Despido del empleado', CAST(N'2020-11-16' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (3, N'OtrPru    ', N'Otra Prueba Prueba ', CAST(N'2020-11-20' AS Date), 12600.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-11-20' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (4, N'OtrPru    ', N'Otra Prueba Prueba ', CAST(N'2020-11-20' AS Date), 12600.0000, CAST(N'2020-11-20' AS Date), N'Despido del empleado', CAST(N'2020-11-20' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (5, N'OtoAgu    ', N'Otoniel Aguirre', CAST(N'2020-11-21' AS Date), 18500.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-11-21' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (6, N'AleMez    ', N'Alexander Meza', CAST(N'2020-11-27' AS Date), 15350.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-11-27' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (7, N'AleMez    ', N'Alexander Meza', CAST(N'2020-11-27' AS Date), 15350.0000, CAST(N'2020-11-27' AS Date), N'Despido del empleado', CAST(N'2020-11-27' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (8, N'EdwGar    ', N'Edwin Garcia', CAST(N'2020-11-28' AS Date), 12600.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-11-28' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (9, N'EdwMar    ', N'Edw Mar', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (11, N'OtoAgu    ', N'Otoniel Aguirre', CAST(N'2020-11-21' AS Date), 18500.0000, CAST(N'2020-12-05' AS Date), N'Despido del empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (12, N'DBVNDR    ', N'PRUEBA CONEXION', NULL, 12.0000, CAST(N'2020-12-05' AS Date), N'Despido del empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (14, N'OtoAgu    ', N'Otoniel  Aguirre', CAST(N'2020-12-05' AS Date), 18500.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (17, N'EdwMar    ', N'Edw Mar', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Registro Anterior', CAST(N'2020-12-05' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (18, N'EdwMar    ', N'Edw Mar', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Registro Actual', CAST(N'2020-12-05' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (19, N'EdwMar    ', N'Edw Mar', CAST(N'2020-12-05' AS Date), 15350.0000, CAST(N'2020-12-05' AS Date), N'Despido del empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (20, N'AndArc    ', N'Andres Archila', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Ingreso de Empleado', CAST(N'2020-12-05' AS Date), N'AccesoLocal')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (21, N'AndArc    ', N'Andres Archila', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Registro Anterior', CAST(N'2020-12-05' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
INSERT [dbo].[EmpleadodHistoricos] ([codigo], [cod_empleado], [nombre], [fecha_contratacion], [salario], [fecha_despido], [accion], [fecha_modificacion], [usuario]) VALUES (22, N'AndArc    ', N'Andres Archila', CAST(N'2020-12-05' AS Date), 15350.0000, NULL, N'Registro Actual', CAST(N'2020-12-05' AS Date), N'LAPTOP-2R8MIJL4\Alexander Martinez')
SET IDENTITY_INSERT [dbo].[EmpleadodHistoricos] OFF
GO
INSERT [dbo].[Empleados] ([cod_empleado], [nombres], [apellidos], [cod_puesto], [cod_usuario], [salario], [fecha_contratacion], [fecha_nacimiento], [cod_genero], [correo], [telefono]) VALUES (N'AndArc    ', N'Andres', N'Archila', 2, N'ArtD', 15350.0000, CAST(N'2020-12-05' AS Date), CAST(N'1999-12-05' AS Date), 2, N'achi@gmail.com', N'88888888')
INSERT [dbo].[Empleados] ([cod_empleado], [nombres], [apellidos], [cod_puesto], [cod_usuario], [salario], [fecha_contratacion], [fecha_nacimiento], [cod_genero], [correo], [telefono]) VALUES (N'DBADMIN   ', N'PRUEBA', N'CONEXION', 1, N'PRBADMIN', 150000.0000, CAST(N'2020-10-23' AS Date), CAST(N'1980-01-01' AS Date), 1, NULL, N'95874587')
INSERT [dbo].[Empleados] ([cod_empleado], [nombres], [apellidos], [cod_puesto], [cod_usuario], [salario], [fecha_contratacion], [fecha_nacimiento], [cod_genero], [correo], [telefono]) VALUES (N'DBBDG     ', N'PRUEBA', N'CONEXION', 2, N'PRBBDG', 35000.0000, CAST(N'2020-10-23' AS Date), CAST(N'1980-01-01' AS Date), 2, NULL, N'86595784')
INSERT [dbo].[Empleados] ([cod_empleado], [nombres], [apellidos], [cod_puesto], [cod_usuario], [salario], [fecha_contratacion], [fecha_nacimiento], [cod_genero], [correo], [telefono]) VALUES (N'EdwGar    ', N'Edwin', N'Garcia', 3, N'EGARCIA', 12600.0000, CAST(N'2020-11-28' AS Date), CAST(N'1975-11-17' AS Date), 2, N'egarcia@unicah.edu', N'31751474')
INSERT [dbo].[Empleados] ([cod_empleado], [nombres], [apellidos], [cod_puesto], [cod_usuario], [salario], [fecha_contratacion], [fecha_nacimiento], [cod_genero], [correo], [telefono]) VALUES (N'OtoAgu    ', N'Otoniel ', N'Aguirre', 1, N'OtoAguirre', 18500.0000, CAST(N'2020-12-05' AS Date), CAST(N'1999-11-15' AS Date), 2, N'otoniAg@gmail.com', N'88888888')
GO
INSERT [dbo].[Estados] ([cod_estado], [descripcion]) VALUES (N'1  ', N'Devolucion')
INSERT [dbo].[Estados] ([cod_estado], [descripcion]) VALUES (N'2  ', N'Cambio')
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 

INSERT [dbo].[Generos] ([cod_genero], [decripcion]) VALUES (1, N'FEMENINO  ')
INSERT [dbo].[Generos] ([cod_genero], [decripcion]) VALUES (2, N'MASCULINO ')
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'A-458     ', N'Complejo B', 561.12, 230.6, N'Amarillo  ', N'Joya      ', N'SPLM      ', 150)
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'H-258     ', N'Banda', 100, 62.5, N'Negro     ', N'Ejercicio ', N'ACSR      ', 131)
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'P-231     ', N'Suplemento Proteina', 500, 250, N'Negro     ', N'PROTEMAX  ', N'SPLM      ', 687)
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'R-254     ', N'Tacos Football', 3000, 1500, N'Negro     ', N'Diego     ', N'TNNS      ', 23)
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'R-456     ', N'AirBok', 625.5, 320.5, N'Negro     ', N'Reebok    ', N'TNNS      ', 58)
INSERT [dbo].[Productos] ([cod_producto], [nombre], [precioVenta], [precioCompra], [color], [marca], [cod_categoria], [existencia]) VALUES (N'T-425     ', N'Tennis Deportivo', 800, 500, N'BlancoRojo', N'Nike      ', N'TNNS      ', 252)
GO
INSERT [dbo].[Proveedores] ([cod_proveedor], [nombre], [direccion], [telefono], [correo], [nombre_contacto], [telefono_contacto]) VALUES (N'ADFG      ', N'Great Value', N'Norte ', N'5663-2112', N'grAd@Great.org', N'Fernando Ponce', N'6598-8989')
INSERT [dbo].[Proveedores] ([cod_proveedor], [nombre], [direccion], [telefono], [correo], [nombre_contacto], [telefono_contacto]) VALUES (N'AMZN      ', N'Amazon Inc.', N'Seattle, WA', N'(1) 888-280-4331', NULL, N'Jeff Bezos', N'(1) 973-280-1254')
INSERT [dbo].[Proveedores] ([cod_proveedor], [nombre], [direccion], [telefono], [correo], [nombre_contacto], [telefono_contacto]) VALUES (N'BTZP      ', N'Brtopzop', N'San Pedro Sula, La Huma', N'98653265', N'btp09@gmail.com', N'Edgardo Ponce', N'87542365')
INSERT [dbo].[Proveedores] ([cod_proveedor], [nombre], [direccion], [telefono], [correo], [nombre_contacto], [telefono_contacto]) VALUES (N'SPMX      ', N'Suplementos Max', N'Tegucigalpa centro, Honduras', N'(504) 9585-4587', NULL, N'Juan Perez', N'(504) 8756-9845')
GO
INSERT [dbo].[Puestos] ([cod_puesto], [descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Puestos] ([cod_puesto], [descripcion]) VALUES (2, N'Bodeguero')
INSERT [dbo].[Puestos] ([cod_puesto], [descripcion]) VALUES (3, N'Vendedor')
GO
INSERT [dbo].[Usuarios] ([cod_usuario], [contraseña], [confirmacion]) VALUES (N'ArtD', N'123', N'123')
INSERT [dbo].[Usuarios] ([cod_usuario], [contraseña], [confirmacion]) VALUES (N'EGARCIA', N'123456', N'123456')
INSERT [dbo].[Usuarios] ([cod_usuario], [contraseña], [confirmacion]) VALUES (N'OtoAguirre', N'asdf', N'asdf')
INSERT [dbo].[Usuarios] ([cod_usuario], [contraseña], [confirmacion]) VALUES (N'PRBADMIN', N'administracion', N'administracion')
INSERT [dbo].[Usuarios] ([cod_usuario], [contraseña], [confirmacion]) VALUES (N'PRBBDG', N'bodega', N'bodega')
GO
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000002', N'T-425     ', 2, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000004', N'P-231     ', 3, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000004', N'T-425     ', 3, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000005', N'P-231     ', 1, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000005', N'T-425     ', 1, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000006', N'P-231     ', 2, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000007', N'T-425     ', 2, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000008', N'T-425     ', 3, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000009', N'P-231     ', 3, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000010', N'P-231     ', 1, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000010', N'T-425     ', 3, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000011', N'T-425     ', 1, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000012', N'P-231     ', 3, 500.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000012', N'T-425     ', 1, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000013', N'H-258     ', 20, 100.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000014', N'T-425     ', 1, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000015', N'H-258     ', 1, 100.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000016', N'R-254     ', 2, 3000.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000017', N'R-254     ', 5, 3000.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000017', N'T-425     ', 2, 750.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000018', N'H-258     ', 1, 100.0000)
INSERT [dbo].[VentaDetalle] ([num_factura], [cod_prducto], [cantidad], [precioVenta]) VALUES (N'000-001-01-0000018', N'R-456     ', 2, 625.5000)
GO
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000001', N'DBADMIN   ', 5, 15, CAST(N'2020-11-13' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000002', N'DBADMIN   ', 5, 15, CAST(N'2020-11-13' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000003', N'DBADMIN   ', 5, 15, CAST(N'2020-11-14' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000004', N'DBADMIN   ', 5, 15, CAST(N'2020-11-14' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000005', N'DBADMIN   ', 5, 15, CAST(N'2020-11-14' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000006', N'DBADMIN   ', 5, 15, CAST(N'2020-11-14' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000007', N'DBADMIN   ', 5, 15, CAST(N'2020-11-16' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000008', N'OtrPru    ', 5, 15, CAST(N'2020-11-20' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000009', N'OtoAgu    ', 0, 15, CAST(N'2020-11-21' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000010', N'DBADMIN   ', 5, 15, CAST(N'2020-11-27' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000011', N'EdwGar    ', 0, 15, CAST(N'2020-11-28' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000012', N'EdwGar    ', 5, 15, CAST(N'2020-12-03' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000013', N'EdwGar    ', 0, 15, CAST(N'2020-12-05' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000014', N'EdwGar    ', 5, 15, CAST(N'2020-12-05' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000015', N'DBADMIN   ', 0, 15, CAST(N'2020-12-05' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000016', N'DBADMIN   ', 5, 15, CAST(N'2020-12-05' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000017', N'DBADMIN   ', 5, 15, CAST(N'2020-12-07' AS Date))
INSERT [dbo].[Ventas] ([num_factura], [cod_empleado], [descuentoPorcentaje], [impuestoPorcentaje], [fecha_Venta]) VALUES (N'000-001-01-0000018', N'EdwGar    ', 0, 15, CAST(N'2020-12-07' AS Date))
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Compras] FOREIGN KEY([cod_compra])
REFERENCES [dbo].[Compras] ([cod_compra])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Compras]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Productos] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Productos] ([cod_producto])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Productos]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedores] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[Proveedores] ([cod_proveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedores]
GO
ALTER TABLE [dbo].[DevolucionDetalle]  WITH CHECK ADD  CONSTRAINT [FK_DevolucionDetalle_Estados] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[Estados] ([cod_estado])
GO
ALTER TABLE [dbo].[DevolucionDetalle] CHECK CONSTRAINT [FK_DevolucionDetalle_Estados]
GO
ALTER TABLE [dbo].[DevolucionDetalle]  WITH CHECK ADD  CONSTRAINT [FK_DevolucionDetalle_Productos] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Productos] ([cod_producto])
GO
ALTER TABLE [dbo].[DevolucionDetalle] CHECK CONSTRAINT [FK_DevolucionDetalle_Productos]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_Ventas] FOREIGN KEY([num_factura])
REFERENCES [dbo].[Ventas] ([num_factura])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_Ventas]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Generos] FOREIGN KEY([cod_genero])
REFERENCES [dbo].[Generos] ([cod_genero])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Generos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Puestos] FOREIGN KEY([cod_puesto])
REFERENCES [dbo].[Puestos] ([cod_puesto])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Puestos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Usuarios] FOREIGN KEY([cod_usuario])
REFERENCES [dbo].[Usuarios] ([cod_usuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Usuarios]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([cod_categoria])
REFERENCES [dbo].[Categorias] ([cod_categoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Productos] FOREIGN KEY([cod_prducto])
REFERENCES [dbo].[Productos] ([cod_producto])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Productos]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Ventas] FOREIGN KEY([num_factura])
REFERENCES [dbo].[Ventas] ([num_factura])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Ventas]
GO
/****** Object:  StoredProcedure [dbo].[CodDevolucion]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CodDevolucion]
@contador int output
as
BEGIN   
	SET @contador = (SELECT top 1 COUNT(*)+1 FROM Devoluciones) 
end
GO
/****** Object:  StoredProcedure [dbo].[CodFactura]    Script Date: 12/7/2020 6:46:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CodFactura]
@p_codigo_secundario VARCHAR(18) output
as
BEGIN
    DECLARE @contador int

		SET @contador = (SELECT top 1 COUNT(*)+1 FROM Ventas) 

		IF(@contador<10)
		begin
			SET @p_codigo_secundario= CONCAT('000-001-01-000000',@contador)
		end
		else if (@contador<100)
		begin
			SET @p_codigo_secundario= CONCAT('000-001-01-00000',@contador)
		end
		else if (@contador<1000)
		begin
			SET @p_codigo_secundario= CONCAT('000-001-01-0000',@contador)
		end
	end
GO
USE [master]
GO
ALTER DATABASE [SiguaSports] SET  READ_WRITE 
GO
