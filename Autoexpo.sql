USE [master]
GO
/****** Object:  Database [Autoexpo]    Script Date: 30/04/2019 22:33:19 ******/
CREATE DATABASE [Autoexpo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Autoexpo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Autoexpo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Autoexpo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Autoexpo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Autoexpo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Autoexpo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Autoexpo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Autoexpo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Autoexpo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Autoexpo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Autoexpo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Autoexpo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Autoexpo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Autoexpo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Autoexpo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Autoexpo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Autoexpo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Autoexpo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Autoexpo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Autoexpo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Autoexpo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Autoexpo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Autoexpo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Autoexpo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Autoexpo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Autoexpo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Autoexpo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Autoexpo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Autoexpo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Autoexpo] SET  MULTI_USER 
GO
ALTER DATABASE [Autoexpo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Autoexpo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Autoexpo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Autoexpo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Autoexpo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Autoexpo] SET QUERY_STORE = OFF
GO
USE [Autoexpo]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Autoexpo]
GO
/****** Object:  Table [dbo].[Auto]    Script Date: 30/04/2019 22:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auto](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [nchar](6) NOT NULL,
	[Modelo] [nchar](4) NOT NULL,
	[NumeroPuertas] [int] NOT NULL,
	[Color] [nchar](20) NOT NULL,
	[Precio] [float] NOT NULL,
	[MarcaId] [int] NOT NULL,
	[EstadoAutoId] [int] NOT NULL,
 CONSTRAINT [PK_Auto] PRIMARY KEY CLUSTERED 
(
	[AutoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](25) NOT NULL,
	[Apellido] [nchar](50) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[Clave] [nchar](16) NOT NULL,
	[Direccion] [nchar](50) NOT NULL,
	[Telefono] [nchar](10) NOT NULL,
	[RolId] [int] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[VentaId] [int] IDENTITY(1,1) NOT NULL,
	[Iva] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[AutoId] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[MarcaId] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[MarcaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaVentaCompleto]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaVentaCompleto]
AS
SELECT        dbo.Usuario.Nombre AS [Nombre cliente], dbo.Usuario.Apellido AS [Apellido Cliente], dbo.Auto.Placa, dbo.Marca.Marca, dbo.Auto.Modelo, dbo.Auto.NumeroPuertas AS [Número de puertas], dbo.Auto.Color, 
                         dbo.Auto.Precio AS [Precio sin IVA], dbo.Venta.Iva, dbo.Venta.Total AS [Total + IVA]
FROM            dbo.Auto INNER JOIN
                         dbo.Marca ON dbo.Auto.MarcaId = dbo.Marca.MarcaId INNER JOIN
                         dbo.Venta ON dbo.Auto.AutoId = dbo.Venta.AutoId INNER JOIN
                         dbo.Usuario ON dbo.Venta.ClienteId = dbo.Usuario.UsuarioId
GO
/****** Object:  Table [dbo].[EstadoAuto]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoAuto](
	[EstadoAutoId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoAuto] [nchar](10) NOT NULL,
 CONSTRAINT [PK_EstadoAuto] PRIMARY KEY CLUSTERED 
(
	[EstadoAutoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaAutoCompleto]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaAutoCompleto]
AS
SELECT        dbo.Auto.AutoId AS Id, dbo.Auto.Placa, dbo.Marca.Marca, dbo.Auto.Modelo, dbo.Auto.NumeroPuertas AS [Número de puertas], dbo.Auto.Color, dbo.Auto.Precio, dbo.EstadoAuto.EstadoAuto AS Estado
FROM            dbo.Auto INNER JOIN
                         dbo.Marca ON dbo.Auto.MarcaId = dbo.Marca.MarcaId INNER JOIN
                         dbo.EstadoAuto ON dbo.Auto.EstadoAutoId = dbo.EstadoAuto.EstadoAutoId
GO
/****** Object:  View [dbo].[VistaCliente]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaCliente]
AS
SELECT        TOP (100) PERCENT Nombre, Apellido, Email, Direccion, Telefono
FROM            dbo.Usuario
WHERE        (RolId = 2)
ORDER BY Apellido
GO
/****** Object:  View [dbo].[VistaAutoDisponible]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaAutoDisponible]
AS
SELECT        dbo.Auto.AutoId AS Id, dbo.Auto.Placa, dbo.Marca.Marca, dbo.Auto.Modelo, dbo.Auto.NumeroPuertas, dbo.Auto.Color, dbo.Auto.Precio
FROM            dbo.Auto INNER JOIN
                         dbo.Marca ON dbo.Auto.MarcaId = dbo.Marca.MarcaId
WHERE        (dbo.Auto.EstadoAutoId = 1)
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 30/04/2019 22:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [nchar](15) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Auto] ON 

INSERT [dbo].[Auto] ([AutoId], [Placa], [Modelo], [NumeroPuertas], [Color], [Precio], [MarcaId], [EstadoAutoId]) VALUES (1, N'ABC123', N'2017', 4, N'Amarillo            ', 5000000, 9, 2)
INSERT [dbo].[Auto] ([AutoId], [Placa], [Modelo], [NumeroPuertas], [Color], [Precio], [MarcaId], [EstadoAutoId]) VALUES (2, N'WDD185', N'2013', 4, N'Verde               ', 10000000, 15, 2)
INSERT [dbo].[Auto] ([AutoId], [Placa], [Modelo], [NumeroPuertas], [Color], [Precio], [MarcaId], [EstadoAutoId]) VALUES (1002, N'XDD888', N'2015', 8, N'Dorado              ', 100000000, 11, 2)
SET IDENTITY_INSERT [dbo].[Auto] OFF
SET IDENTITY_INSERT [dbo].[EstadoAuto] ON 

INSERT [dbo].[EstadoAuto] ([EstadoAutoId], [EstadoAuto]) VALUES (1, N'Disponible')
INSERT [dbo].[EstadoAuto] ([EstadoAutoId], [EstadoAuto]) VALUES (2, N'Vendido   ')
SET IDENTITY_INSERT [dbo].[EstadoAuto] OFF
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (1, N'Audi                ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (2, N'BMW                 ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (3, N'Cadillac            ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (4, N'Chevrolet           ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (5, N'Citroen             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (6, N'Ferrari             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (7, N'Ford                ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (8, N'General Motors      ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (9, N'Honda               ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (10, N'Hyundai             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (11, N'Jeep                ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (12, N'Kia                 ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (13, N'Lamborghini         ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (14, N'Land Rover          ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (15, N'Mazda               ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (16, N'McLaren             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (17, N'Mercedes-Benz       ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (18, N'Mitsubishi          ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (19, N'Nissan              ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (20, N'Porsche             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (21, N'Renault             ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (22, N'Suzuki              ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (23, N'Toyota              ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (24, N'Volkswagen          ')
INSERT [dbo].[Marca] ([MarcaId], [Marca]) VALUES (25, N'Volvo               ')
SET IDENTITY_INSERT [dbo].[Marca] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([RolId], [Rol]) VALUES (1, N'Administrador  ')
INSERT [dbo].[Rol] ([RolId], [Rol]) VALUES (2, N'Cliente        ')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (1, N'Cristian                 ', N'Tellez                                            ', N'cdtellez@misena.edu.co                            ', N'12345           ', N'Calle falsa 123                                   ', N'3214567890', 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (2, N'Juan                     ', N'Perez                                             ', N'jperez@miapp.com                                  ', N'juanperez       ', N'Carrera 34 # 23-56                                ', N'123456    ', 2)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (3, N'Daniel                   ', N'Tellez                                            ', N't34m0m1bb@hotmail.com                             ', N'dan2018         ', N'Calle 23 # 45 - 56                                ', N'345345    ', 2)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (4, N'David                    ', N'Rivas                                             ', N'dsrivas@misena.edu.co                             ', N'david           ', N'Carrera 1 # 6C-30                                 ', N'3015835266', 2)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (1004, N'Wil                      ', N'Tell                                              ', N'wcd@misena.ecu.co                                 ', N'1234            ', N'AV Siempre Viva                                   ', N'2554      ', 2)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Apellido], [Email], [Clave], [Direccion], [Telefono], [RolId]) VALUES (1005, N'Salomon                  ', N'Diaz                                              ', N'cdtellez3@misena.edu.co                           ', N'123456          ', N'Av Siempre Viva                                   ', N'2436289   ', 2)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([VentaId], [Iva], [Total], [ClienteId], [AutoId]) VALUES (1, 1600000, 11600000, 2, 1)
INSERT [dbo].[Venta] ([VentaId], [Iva], [Total], [ClienteId], [AutoId]) VALUES (2, 1600000, 11600000, 4, 2)
INSERT [dbo].[Venta] ([VentaId], [Iva], [Total], [ClienteId], [AutoId]) VALUES (3, 16000000, 116000000, 1005, 1002)
SET IDENTITY_INSERT [dbo].[Venta] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Auto]    Script Date: 30/04/2019 22:33:23 ******/
ALTER TABLE [dbo].[Auto] ADD  CONSTRAINT [IX_Auto] UNIQUE NONCLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta]    Script Date: 30/04/2019 22:33:23 ******/
CREATE NONCLUSTERED INDEX [IX_Venta] ON [dbo].[Venta]
(
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_EstadoAuto] FOREIGN KEY([EstadoAutoId])
REFERENCES [dbo].[EstadoAuto] ([EstadoAutoId])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_EstadoAuto]
GO
ALTER TABLE [dbo].[Auto]  WITH CHECK ADD  CONSTRAINT [FK_Auto_Marca] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marca] ([MarcaId])
GO
ALTER TABLE [dbo].[Auto] CHECK CONSTRAINT [FK_Auto_Marca]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Rol] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolId])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Persona_Rol]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Auto] FOREIGN KEY([AutoId])
REFERENCES [dbo].[Auto] ([AutoId])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Auto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Auto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Marca"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 102
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "EstadoAuto"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 102
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaAutoCompleto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaAutoCompleto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Auto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Marca"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 102
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaAutoDisponible'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaAutoDisponible'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Auto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Marca"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 102
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Venta"
            Begin Extent = 
               Top = 102
               Left = 248
               Bottom = 232
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 136
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaVentaCompleto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaVentaCompleto'
GO
USE [master]
GO
ALTER DATABASE [Autoexpo] SET  READ_WRITE 
GO
