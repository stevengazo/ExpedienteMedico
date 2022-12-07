USE [master]
GO
/****** Object:  Database [BIblioteca]    Script Date: 12/6/2022 9:44:22 PM ******/
CREATE DATABASE [BIblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BIblioteca', FILENAME = N'/var/opt/mssql/data/BIblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BIblioteca_log', FILENAME = N'/var/opt/mssql/data/BIblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BIblioteca] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BIblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BIblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BIblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BIblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BIblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BIblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [BIblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BIblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BIblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BIblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BIblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BIblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BIblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BIblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BIblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BIblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BIblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BIblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BIblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BIblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BIblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BIblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BIblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BIblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [BIblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [BIblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BIblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BIblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BIblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BIblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BIblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BIblioteca] SET QUERY_STORE = OFF
GO
USE [BIblioteca]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[IDAutor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[FechaMuerte] [date] NOT NULL,
 CONSTRAINT [PK_Autor] PRIMARY KEY CLUSTERED 
(
	[IDAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AutoresLibros]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutoresLibros](
	[IDAutor] [int] NULL,
	[IDTipoAutor] [int] NULL,
	[ISBN] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IDCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[IDProvincia] [int] NULL,
	[Canton] [varchar](50) NULL,
	[Distrito] [varchar](30) NULL,
	[OtrasSeñas] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[IDLibro] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [varchar](100) NOT NULL,
	[Titulo] [varchar](100) NULL,
	[NoPaginas] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLibro] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[IDPrestamos] [nchar](10) NOT NULL,
	[FechaPrestamo] [date] NULL,
	[FechaDevolucion] [date] NULL,
	[FechaRDevolucion] [date] NULL,
	[CostoAlquiler] [date] NULL,
	[CostoMulta] [date] NULL,
	[LibroDevuelto] [date] NULL,
	[IDCliente] [int] NULL,
	[IDLibro] [int] NULL,
 CONSTRAINT [PK_Prestamos] PRIMARY KEY CLUSTERED 
(
	[IDPrestamos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IDProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[IDProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[IDTelefono] [int] IDENTITY(1,1) NOT NULL,
	[NoTelefono] [int] NOT NULL,
	[IDCliente] [int] NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[IDTelefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAutor]    Script Date: 12/6/2022 9:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAutor](
	[IDTipoAutor] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NULL,
 CONSTRAINT [PK_TipoAutor] PRIMARY KEY CLUSTERED 
(
	[IDTipoAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([IDAutor], [Nombre], [Apellido], [FechaNacimiento], [FechaMuerte]) VALUES (1, N'Sui', N'Ishida', CAST(N'2000-02-02' AS Date), CAST(N'2050-02-02' AS Date))
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([IDCliente], [Nombre], [Apellidos], [IDProvincia], [Canton], [Distrito], [OtrasSeñas]) VALUES (2, N'Pedro', N'Chavez', 1, N'San Pablo', N'Santo Domingo', N'Del antiguo palo de guayaba, 300 metros hasta que de con cerca')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Libro] ON 

INSERT [dbo].[Libro] ([IDLibro], [ISBN], [Titulo], [NoPaginas]) VALUES (1, N'55852', N'Tokyo Ghoul', 100)
SET IDENTITY_INSERT [dbo].[Libro] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([IDProvincia], [Nombre]) VALUES (1, N'Heredia')
INSERT [dbo].[Provincia] ([IDProvincia], [Nombre]) VALUES (2, N'Alajuela')
INSERT [dbo].[Provincia] ([IDProvincia], [Nombre]) VALUES (3, N'Puntarenas')
INSERT [dbo].[Provincia] ([IDProvincia], [Nombre]) VALUES (4, N'San José')
INSERT [dbo].[Provincia] ([IDProvincia], [Nombre]) VALUES (5, N'Cartago')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
GO
SET IDENTITY_INSERT [dbo].[Telefono] ON 

INSERT [dbo].[Telefono] ([IDTelefono], [NoTelefono], [IDCliente]) VALUES (3, 46521284, 2)
INSERT [dbo].[Telefono] ([IDTelefono], [NoTelefono], [IDCliente]) VALUES (4, 88448844, 2)
SET IDENTITY_INSERT [dbo].[Telefono] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoAutor] ON 

INSERT [dbo].[TipoAutor] ([IDTipoAutor], [Tipo]) VALUES (1, N'Autor')
INSERT [dbo].[TipoAutor] ([IDTipoAutor], [Tipo]) VALUES (2, N'Coautor')
INSERT [dbo].[TipoAutor] ([IDTipoAutor], [Tipo]) VALUES (3, N'Autor')
INSERT [dbo].[TipoAutor] ([IDTipoAutor], [Tipo]) VALUES (4, N'Coautor')
SET IDENTITY_INSERT [dbo].[TipoAutor] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_Libro_ISBN]    Script Date: 12/6/2022 9:44:23 PM ******/
ALTER TABLE [dbo].[Libro] ADD  CONSTRAINT [AK_Libro_ISBN] UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AutoresLibros]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Libro] ([ISBN])
GO
ALTER TABLE [dbo].[AutoresLibros]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Libro] ([ISBN])
GO
ALTER TABLE [dbo].[AutoresLibros]  WITH CHECK ADD  CONSTRAINT [FK_AutoresLibros_Autor] FOREIGN KEY([IDAutor])
REFERENCES [dbo].[Autor] ([IDAutor])
GO
ALTER TABLE [dbo].[AutoresLibros] CHECK CONSTRAINT [FK_AutoresLibros_Autor]
GO
ALTER TABLE [dbo].[AutoresLibros]  WITH CHECK ADD  CONSTRAINT [FK_AutoresLibros_TipoAutor] FOREIGN KEY([IDTipoAutor])
REFERENCES [dbo].[TipoAutor] ([IDTipoAutor])
GO
ALTER TABLE [dbo].[AutoresLibros] CHECK CONSTRAINT [FK_AutoresLibros_TipoAutor]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Provincia] FOREIGN KEY([IDProvincia])
REFERENCES [dbo].[Provincia] ([IDProvincia])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Provincia]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Cliente] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([IDCliente])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Cliente]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Cliente] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([IDCliente])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefono_Cliente]
GO
USE [master]
GO
ALTER DATABASE [BIblioteca] SET  READ_WRITE 
GO
