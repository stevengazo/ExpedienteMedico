USE [master]
GO
/****** Object:  Database [Proyecto_Hospital]    Script Date: 18/12/2022 19:49:38 ******/
CREATE DATABASE [Proyecto_Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto_Hospital', FILENAME = N'/var/opt/mssql/data/Proyecto_Hospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_Hospital_log', FILENAME = N'/var/opt/mssql/data/Proyecto_Hospital_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proyecto_Hospital] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto_Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto_Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Proyecto_Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto_Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Proyecto_Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyecto_Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto_Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto_Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto_Hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto_Hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyecto_Hospital] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Proyecto_Hospital] SET QUERY_STORE = OFF
GO
USE [Proyecto_Hospital]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[idAdministrador] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](25) NULL,
	[Nombre] [varchar](20) NULL,
	[Apellidos] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canton]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canton](
	[IdCanton] [int] IDENTITY(1,1) NOT NULL,
	[Canton] [varchar](50) NULL,
	[IdProvincia] [int] NULL,
 CONSTRAINT [PK_Canton] PRIMARY KEY CLUSTERED 
(
	[IdCanton] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[idDiagnostico] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Descripcion] [varchar](1000) NULL,
	[Enfermedad_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[IdDistrito] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[IdCanton] [int] NULL,
 CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED 
(
	[IdDistrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enfermedades]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enfermedades](
	[idEnfermedad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](1000) NULL,
	[Sintomas] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEnfermedad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpedienteMedico]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpedienteMedico](
	[idExpediente] [int] IDENTITY(1,1) NOT NULL,
	[FechaApertura] [date] NULL,
	[UltimaModificacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idExpediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventarioMedico]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventarioMedico](
	[idInventario] [int] IDENTITY(1,1) NOT NULL,
	[NumLote] [varchar](30) NULL,
	[FechaIngreso] [date] NULL,
	[FechaVencimiento] [date] NULL,
	[Refrigeracion] [bit] NULL,
	[CantDisponible] [int] NULL,
	[Medicamento_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvHasSucur]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvHasSucur](
	[idSucursal] [int] NULL,
	[idInventario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedHasEspe]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedHasEspe](
	[idMedico] [int] NULL,
	[años] [int] NULL,
	[idEspecialidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[idMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NULL,
	[CasaFarmaceutica] [varchar](30) NULL,
	[Descripcion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[idMedico] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](25) NULL,
	[HashContraseña] [varchar](50) NULL,
	[Nombre] [varchar](25) NULL,
	[Apellidos] [varchar](50) NULL,
	[Identificacion] [varchar](30) NULL,
	[TipoIdentificacion] [varchar](15) NULL,
	[Sexo] [varchar](15) NULL,
	[EstadoCivil] [varchar](15) NULL,
	[Nacionalidad] [varchar](15) NULL,
	[FechaNacimiento] [varchar](10) NULL,
	[NumeroTelefonico] [int] NULL,
	[Correo] [varchar](40) NULL,
	[otrasSenas] [varchar](100) NULL,
	[IdDistrito] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NULL,
	[Apellidos] [varchar](50) NULL,
	[Identificacion] [varchar](30) NULL,
	[TipoIdentificacion] [varchar](15) NULL,
	[Sexo] [varchar](15) NULL,
	[EstadoCivil] [varchar](15) NULL,
	[Nacionalidad] [varchar](15) NULL,
	[FechaNacimiento] [date] NULL,
	[NumeroTelefonico] [int] NULL,
	[Correo] [varchar](40) NULL,
	[EstaActivo] [bit] NULL,
	[Expediente_id] [int] NULL,
	[IdDistrito] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceHasMedi]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceHasMedi](
	[idInvMedico] [int] NULL,
	[CantMedic] [int] NULL,
	[idReceta] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receta]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[idReceta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Indicaciones] [varchar](100) NULL,
	[FechaVencimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idReceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[idRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Medico_id] [int] NULL,
	[Diagnostico_id] [int] NULL,
	[Receta_id] [int] NULL,
	[Cita_id] [int] NULL,
	[Sucursal_id] [int] NULL,
	[Expediente_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrador] ON 

INSERT [dbo].[Administrador] ([idAdministrador], [Usuario], [Nombre], [Apellidos], [Contrasena]) VALUES (0, N'', N'', N'', N'')
INSERT [dbo].[Administrador] ([idAdministrador], [Usuario], [Nombre], [Apellidos], [Contrasena]) VALUES (1, N'Sgazo', N'Steven', N'Gazo', N'Password123')
INSERT [dbo].[Administrador] ([idAdministrador], [Usuario], [Nombre], [Apellidos], [Contrasena]) VALUES (2, N'sr', N'Susan', N'Rojas Salazar', N'1234')
SET IDENTITY_INSERT [dbo].[Administrador] OFF
GO
SET IDENTITY_INSERT [dbo].[Canton] ON 

INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (0, N'', 0)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (2, N'San Jose', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (3, N'Alajuelita', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (4, N'Vazquez de Coronado', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (5, N'Acosta', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (6, N'Tibas', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (7, N'Moravia', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (8, N'Montes de Oca', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (9, N'Turribares', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (10, N'Dota', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (11, N'Curridabat', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (12, N'Perez Zeledon', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (13, N'Escazú', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (14, N'Leon Cortes Castro', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (15, N'Desamparados', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (16, N'Puriscal', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (17, N'Tarrazu', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (18, N'Aserri', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (19, N'Mora', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (20, N'Goicochea', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (21, N'Santa Ana', 1)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (22, N'Heredia', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (23, N'Sarapiquí', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (24, N'Barva', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (25, N'San Pablo', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (26, N'Santo Domingo', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (27, N'Flores', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (28, N'Santa Barbara', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (29, N'Belén', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (30, N'San Rafael', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (31, N'San Isidro', 4)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (32, N'Cartago', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (33, N'El Guarco', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (34, N'Paraíso', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (35, N'Oreamuno', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (36, N'La Unión', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (37, N'Alvarado', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (38, N'Jiménez', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (39, N'Turrialba', 2)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (40, N'Alajuela', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (41, N'Río Cuarto', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (42, N'San Ramón', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (43, N'Guatuso', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (44, N'Grecia', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (45, N'Los Chiles', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (46, N'San Mateo', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (47, N'Upala', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (48, N'Atenas', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (49, N'Sarchí', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (50, N'Naranjo', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (51, N'Zarcero', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (52, N'Palmares', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (53, N'San Carlos', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (54, N'Poás', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (55, N'Orotina', 3)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (56, N'Puntarenas', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (57, N'Pitahaya', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (58, N'Chomes', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (59, N'Lepanto', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (60, N'Paquera', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (61, N'Manzanillo', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (62, N'Guacimal', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (63, N'Barranca', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (64, N'Isla del Coco', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (65, N'Cóbano', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (66, N'Chacarita', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (67, N'Chira', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (68, N'Acapulco', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (69, N'El Roble', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (70, N'Arancibia', 5)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (71, N'Limón', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (72, N'Guácimo', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (73, N'Matina', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (74, N'Pococí', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (75, N'Siquirres', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (76, N'Talamanca', 6)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (77, N'Libería', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (78, N'Abangares', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (79, N'Bagaces', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (80, N'Cañas', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (81, N'Carrillo', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (82, N'Hojancha', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (83, N'La Cruz', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (84, N'Nandayure', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (85, N'Nicoya', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (86, N'Santa Cruz', 7)
INSERT [dbo].[Canton] ([IdCanton], [Canton], [IdProvincia]) VALUES (87, N'Tilarán', 7)
SET IDENTITY_INSERT [dbo].[Canton] OFF
GO
SET IDENTITY_INSERT [dbo].[Citas] ON 

INSERT [dbo].[Citas] ([idCita], [Fecha]) VALUES (0, CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Citas] ([idCita], [Fecha]) VALUES (13, CAST(N'2022-12-29' AS Date))
INSERT [dbo].[Citas] ([idCita], [Fecha]) VALUES (14, CAST(N'2023-01-05' AS Date))
INSERT [dbo].[Citas] ([idCita], [Fecha]) VALUES (15, CAST(N'2022-12-27' AS Date))
SET IDENTITY_INSERT [dbo].[Citas] OFF
GO
SET IDENTITY_INSERT [dbo].[Diagnostico] ON 

INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (0, CAST(N'2000-01-01' AS Date), N'', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (1, CAST(N'2000-01-01' AS Date), N'', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (2, CAST(N'2020-02-02' AS Date), N'Ejemplo', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (3, CAST(N'2022-12-15' AS Date), N'esto es un ejemplo', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (4, CAST(N'2022-12-24' AS Date), N'esto es un ejemplo', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (5, CAST(N'2022-12-15' AS Date), N'esto es otro ejemplo', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (6, CAST(N'2023-01-06' AS Date), N'Esto es umpl ejepmlfsdfk', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (7, CAST(N'2022-12-09' AS Date), N'esto es una prueba', 0)
INSERT [dbo].[Diagnostico] ([idDiagnostico], [Fecha], [Descripcion], [Enfermedad_id]) VALUES (10, CAST(N'2022-12-16' AS Date), N'dolor estomacal', 5)
SET IDENTITY_INSERT [dbo].[Diagnostico] OFF
GO
SET IDENTITY_INSERT [dbo].[Distrito] ON 

INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (0, N'San José', 0)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (1, N'San José', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (2, N'Carmen', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (3, N'Catedral', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (4, N'Hatillo', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (5, N'Hospital', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (6, N'La Uruca', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (7, N'Mata Redonda', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (8, N'Merced', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (9, N'Pavas', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (10, N'San Francisco de Dos Rios', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (11, N'San Sebastian', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (12, N'Zapote', 2)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (13, N'Alajuelita', 3)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (14, N'Concepción', 3)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (15, N'San Antonio', 3)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (16, N'San Felipe', 3)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (17, N'San Josecito', 3)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (18, N'Aserrí', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (19, N'Legua', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (20, N'Monterrey', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (21, N'Salitrillos', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (22, N'San Gabriel', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (23, N'Tarbaca', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (24, N'Vuelta de Jorco', 18)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (25, N'Copey', 10)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (26, N'Jardín', 10)
INSERT [dbo].[Distrito] ([IdDistrito], [Nombre], [IdCanton]) VALUES (27, N'Santa María', 10)
SET IDENTITY_INSERT [dbo].[Distrito] OFF
GO
SET IDENTITY_INSERT [dbo].[Enfermedades] ON 

INSERT [dbo].[Enfermedades] ([idEnfermedad], [Nombre], [Descripcion], [Sintomas]) VALUES (0, NULL, NULL, NULL)
INSERT [dbo].[Enfermedades] ([idEnfermedad], [Nombre], [Descripcion], [Sintomas]) VALUES (5, N'gastritis', N'pruebas', N'dolor estomacal')
SET IDENTITY_INSERT [dbo].[Enfermedades] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (0, N'')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (45, N'Aparato digestivo')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (46, N'Cardiología')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (47, N'Endocrinología y nutrición')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (48, N'Geriatría')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (49, N'Hematología y hemoterapia')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (50, N'Medicina espacial')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (51, N'Medicina intensiva')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (52, N'Medicina interna')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (53, N'Medicina legal y forense')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (54, N'Medicina del trabajo')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (55, N'Nefrología')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (56, N'Neumología')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (57, N'Neurología')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (58, N'Neurofisiología Clínica')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (59, N'Oncología médica')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (60, N'Oncología radioterápica')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (61, N'Pediatría')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (62, N'Psiquiatría')
INSERT [dbo].[Especialidad] ([idEspecialidad], [Nombre]) VALUES (63, N'Rehabilitación')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
GO
SET IDENTITY_INSERT [dbo].[ExpedienteMedico] ON 

INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (0, CAST(N'2001-01-01' AS Date), CAST(N'2001-01-01' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (1, CAST(N'2022-12-01' AS Date), CAST(N'2022-12-01' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (2, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (3, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (4, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (5, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (6, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (7, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
INSERT [dbo].[ExpedienteMedico] ([idExpediente], [FechaApertura], [UltimaModificacion]) VALUES (8, CAST(N'2022-12-17' AS Date), CAST(N'2022-12-17' AS Date))
SET IDENTITY_INSERT [dbo].[ExpedienteMedico] OFF
GO
SET IDENTITY_INSERT [dbo].[InventarioMedico] ON 

INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (10, N'2ewd', CAST(N'2022-12-15' AS Date), CAST(N'2022-12-30' AS Date), 0, 8, 2)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (11, N'lo584', CAST(N'2022-12-18' AS Date), CAST(N'2022-12-18' AS Date), 0, 3, 3)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (12, N'lo584', CAST(N'2022-12-18' AS Date), CAST(N'2022-12-18' AS Date), 0, 10, 3)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (13, N'lo584', CAST(N'2022-12-18' AS Date), CAST(N'2022-12-18' AS Date), 0, 10, 3)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (14, N'dfrygtui', CAST(N'2022-12-18' AS Date), CAST(N'2023-01-06' AS Date), 0, 7, 2)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (15, N'dfrygtui', CAST(N'2022-12-18' AS Date), CAST(N'2023-01-06' AS Date), 0, 7, 2)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (16, N'jñklj', CAST(N'2022-12-24' AS Date), CAST(N'2023-01-06' AS Date), 0, 10, 2)
INSERT [dbo].[InventarioMedico] ([idInventario], [NumLote], [FechaIngreso], [FechaVencimiento], [Refrigeracion], [CantDisponible], [Medicamento_id]) VALUES (17, N'eejemplo', CAST(N'2022-12-18' AS Date), CAST(N'2023-01-08' AS Date), 0, 10, 3)
SET IDENTITY_INSERT [dbo].[InventarioMedico] OFF
GO
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (2, 10)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (2, 11)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (1, 12)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (3, 13)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (1, 14)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (1, 15)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (3, 16)
INSERT [dbo].[InvHasSucur] ([idSucursal], [idInventario]) VALUES (1, 17)
GO
INSERT [dbo].[MedHasEspe] ([idMedico], [años], [idEspecialidad]) VALUES (0, 0, 0)
INSERT [dbo].[MedHasEspe] ([idMedico], [años], [idEspecialidad]) VALUES (29, 8, 46)
GO
SET IDENTITY_INSERT [dbo].[Medicamento] ON 

INSERT [dbo].[Medicamento] ([idMedicamento], [Nombre], [CasaFarmaceutica], [Descripcion]) VALUES (0, N'', N'2000-01-01', N'')
INSERT [dbo].[Medicamento] ([idMedicamento], [Nombre], [CasaFarmaceutica], [Descripcion]) VALUES (1, N'', N'2000-01-01', N'')
INSERT [dbo].[Medicamento] ([idMedicamento], [Nombre], [CasaFarmaceutica], [Descripcion]) VALUES (2, N'aspirina', N'bayer', N'para dolores')
INSERT [dbo].[Medicamento] ([idMedicamento], [Nombre], [CasaFarmaceutica], [Descripcion]) VALUES (3, N'geks', N'ni idea', N'para resfriados')
INSERT [dbo].[Medicamento] ([idMedicamento], [Nombre], [CasaFarmaceutica], [Descripcion]) VALUES (4, N'Dorival', N'Bayer', N'Ayuda para el dolor menstrual')
SET IDENTITY_INSERT [dbo].[Medicamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicos] ON 

INSERT [dbo].[Medicos] ([idMedico], [Usuario], [HashContraseña], [Nombre], [Apellidos], [Identificacion], [TipoIdentificacion], [Sexo], [EstadoCivil], [Nacionalidad], [FechaNacimiento], [NumeroTelefonico], [Correo], [otrasSenas], [IdDistrito]) VALUES (0, N'', NULL, N'', N'', N'', N'', N'', N'', N'', N'2000-01-01', 0, N'', N'', 0)
INSERT [dbo].[Medicos] ([idMedico], [Usuario], [HashContraseña], [Nombre], [Apellidos], [Identificacion], [TipoIdentificacion], [Sexo], [EstadoCivil], [Nacionalidad], [FechaNacimiento], [NumeroTelefonico], [Correo], [otrasSenas], [IdDistrito]) VALUES (29, N'aalfaro', N'1234', N'Allen', N'Alfaro', N'102360245', N'Nacional', N'Masculino', N'Soltero', N'Costarricense', N'1994-04-05', 89456710, N'aa@gmail.com', N'Calle 12', 2)
SET IDENTITY_INSERT [dbo].[Medicos] OFF
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([idPaciente], [Nombre], [Apellidos], [Identificacion], [TipoIdentificacion], [Sexo], [EstadoCivil], [Nacionalidad], [FechaNacimiento], [NumeroTelefonico], [Correo], [EstaActivo], [Expediente_id], [IdDistrito]) VALUES (1, N'Juan Pablo', N'Perez Luna', N'104870145', N'Cédula de ident', N'Masculino', N'Casado', N'Costarricense', CAST(N'1982-04-05' AS Date), 89630148, N'juan@gmail.com', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (0, N'')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (1, N'San José')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (2, N'Cartago')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (3, N'Alajuela')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (4, N'Heredia')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (5, N'Puntarenas')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (6, N'Limón')
INSERT [dbo].[Provincia] ([IdProvincia], [Nombre]) VALUES (7, N'Guanacaste')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
GO
INSERT [dbo].[ReceHasMedi] ([idInvMedico], [CantMedic], [idReceta]) VALUES (11, 2, 1002)
GO
SET IDENTITY_INSERT [dbo].[Receta] ON 

INSERT [dbo].[Receta] ([idReceta], [Fecha], [Indicaciones], [FechaVencimiento]) VALUES (0, CAST(N'2000-01-01' AS Date), N'', CAST(N'2000-01-01' AS Date))
INSERT [dbo].[Receta] ([idReceta], [Fecha], [Indicaciones], [FechaVencimiento]) VALUES (1002, CAST(N'2022-12-18' AS Date), N'dfja;lk', CAST(N'2022-12-18' AS Date))
SET IDENTITY_INSERT [dbo].[Receta] OFF
GO
SET IDENTITY_INSERT [dbo].[Registro] ON 

INSERT [dbo].[Registro] ([idRegistro], [Medico_id], [Diagnostico_id], [Receta_id], [Cita_id], [Sucursal_id], [Expediente_id]) VALUES (1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Registro] ([idRegistro], [Medico_id], [Diagnostico_id], [Receta_id], [Cita_id], [Sucursal_id], [Expediente_id]) VALUES (6, 0, 0, 0, 14, 1, 1)
INSERT [dbo].[Registro] ([idRegistro], [Medico_id], [Diagnostico_id], [Receta_id], [Cita_id], [Sucursal_id], [Expediente_id]) VALUES (7, 0, 0, 0, 15, 3, 1)
INSERT [dbo].[Registro] ([idRegistro], [Medico_id], [Diagnostico_id], [Receta_id], [Cita_id], [Sucursal_id], [Expediente_id]) VALUES (9, 0, 0, 0, 0, 2, 1)
SET IDENTITY_INSERT [dbo].[Registro] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([idSucursal], [Nombre]) VALUES (0, N'0')
INSERT [dbo].[Sucursal] ([idSucursal], [Nombre]) VALUES (1, N'San José')
INSERT [dbo].[Sucursal] ([idSucursal], [Nombre]) VALUES (2, N'Heredia')
INSERT [dbo].[Sucursal] ([idSucursal], [Nombre]) VALUES (3, N'Alajuela')
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
ALTER TABLE [dbo].[Canton]  WITH CHECK ADD  CONSTRAINT [FK_Canton_Provincia] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
GO
ALTER TABLE [dbo].[Canton] CHECK CONSTRAINT [FK_Canton_Provincia]
GO
ALTER TABLE [dbo].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Enfermedades] FOREIGN KEY([Enfermedad_id])
REFERENCES [dbo].[Enfermedades] ([idEnfermedad])
GO
ALTER TABLE [dbo].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Enfermedades]
GO
ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [FK_Distrito_Canton] FOREIGN KEY([IdCanton])
REFERENCES [dbo].[Canton] ([IdCanton])
GO
ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [FK_Distrito_Canton]
GO
ALTER TABLE [dbo].[InventarioMedico]  WITH CHECK ADD  CONSTRAINT [FK_InventarioMedico_Medicamento] FOREIGN KEY([Medicamento_id])
REFERENCES [dbo].[Medicamento] ([idMedicamento])
GO
ALTER TABLE [dbo].[InventarioMedico] CHECK CONSTRAINT [FK_InventarioMedico_Medicamento]
GO
ALTER TABLE [dbo].[InvHasSucur]  WITH CHECK ADD  CONSTRAINT [FK_InvHasSucur_InventarioMedico] FOREIGN KEY([idInventario])
REFERENCES [dbo].[InventarioMedico] ([idInventario])
GO
ALTER TABLE [dbo].[InvHasSucur] CHECK CONSTRAINT [FK_InvHasSucur_InventarioMedico]
GO
ALTER TABLE [dbo].[InvHasSucur]  WITH CHECK ADD  CONSTRAINT [FK_InvHasSucur_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
ALTER TABLE [dbo].[InvHasSucur] CHECK CONSTRAINT [FK_InvHasSucur_Sucursal]
GO
ALTER TABLE [dbo].[MedHasEspe]  WITH CHECK ADD  CONSTRAINT [FK_MedHasEspe_Especialidad] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
GO
ALTER TABLE [dbo].[MedHasEspe] CHECK CONSTRAINT [FK_MedHasEspe_Especialidad]
GO
ALTER TABLE [dbo].[MedHasEspe]  WITH CHECK ADD  CONSTRAINT [FK_MedHasEspe_Medicos] FOREIGN KEY([idMedico])
REFERENCES [dbo].[Medicos] ([idMedico])
GO
ALTER TABLE [dbo].[MedHasEspe] CHECK CONSTRAINT [FK_MedHasEspe_Medicos]
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Medicos_Distrito] FOREIGN KEY([IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDistrito])
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [FK_Medicos_Distrito]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Distrito] FOREIGN KEY([IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDistrito])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Distrito]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_ExpedienteMedico] FOREIGN KEY([Expediente_id])
REFERENCES [dbo].[ExpedienteMedico] ([idExpediente])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_ExpedienteMedico]
GO
ALTER TABLE [dbo].[ReceHasMedi]  WITH CHECK ADD  CONSTRAINT [FK_ReceHasMedi_InventarioMedico] FOREIGN KEY([idInvMedico])
REFERENCES [dbo].[InventarioMedico] ([idInventario])
GO
ALTER TABLE [dbo].[ReceHasMedi] CHECK CONSTRAINT [FK_ReceHasMedi_InventarioMedico]
GO
ALTER TABLE [dbo].[ReceHasMedi]  WITH CHECK ADD  CONSTRAINT [FK_ReceHasMedi_Receta] FOREIGN KEY([idReceta])
REFERENCES [dbo].[Receta] ([idReceta])
GO
ALTER TABLE [dbo].[ReceHasMedi] CHECK CONSTRAINT [FK_ReceHasMedi_Receta]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Citas] FOREIGN KEY([Cita_id])
REFERENCES [dbo].[Citas] ([idCita])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Citas]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Diagnostico] FOREIGN KEY([Diagnostico_id])
REFERENCES [dbo].[Diagnostico] ([idDiagnostico])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Diagnostico]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_ExpedienteMedico] FOREIGN KEY([Expediente_id])
REFERENCES [dbo].[ExpedienteMedico] ([idExpediente])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_ExpedienteMedico]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Medicos] FOREIGN KEY([Medico_id])
REFERENCES [dbo].[Medicos] ([idMedico])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Medicos]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Receta] FOREIGN KEY([Receta_id])
REFERENCES [dbo].[Receta] ([idReceta])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Receta]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Sucursal] FOREIGN KEY([Sucursal_id])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Sucursal]
GO
/****** Object:  StoredProcedure [dbo].[AdministradorAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdministradorAgregar]
    @_usuario VARCHAR(25) = null,
    @_nombre VARCHAR(20) = null,
    @_apellidos VARCHAR(50) = null,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idAdmin int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		INSERT INTO Administrador(Usuario, Nombre,Apellidos,Contrasena)
					values(@_usuario,@_nombre,@_apellidos,@_contrasena)

					set @idAdmin= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AdministradorComprobarSesion]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Steven Gazo
-- Create date: 12-01-2022
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AdministradorComprobarSesion]
    @_usuario VARCHAR(25) = null,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idAdministrador int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error ='';
		SET @idAdministrador = (SELECT AD.idAdministrador FROM Administrador AS AD WHERE AD.Usuario = @_usuario AND AD.Contrasena=@_contrasena)
		if @idAdministrador is null 
			set @idAdministrador = 0;		
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarReceta]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarReceta] 
	@_Fecha as date = null,
	@_Indicaciones as varchar(100)= null,
	@_fechaVencimiento as date = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idReceta int output
AS
BEGIN
BEGIN TRY
	insert into Receta(Fecha,FechaVencimiento,Indicaciones)
	values(@_fechaVencimiento,@_fechaVencimiento,@_Indicaciones)
		SET @_codigo_error =0 ;
		SET @_mensaje_error = ''
		SET @idReceta = SCOPE_IDENTITY() ;
END TRY
BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
		SET @idReceta = 0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CitaAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Steven 
-- Create date: 14-12-2022
-- Description:	Agrega una nueva cita 
-- =============================================
CREATE PROCEDURE [dbo].[CitaAgregar]
	@_Fecha date = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idCita int output
AS
BEGIN
BEGIN TRY
	INSERT INTO Citas(Fecha)
	VALUES(@_Fecha);
	SET @_codigo_error = 0;
	SET @_mensaje_error = '';
	SET @idCita = SCOPE_IDENTITY();
END TRY
BEGIN CATCH
	SET @_codigo_error = @@ERROR;
	SET @_mensaje_error = ERROR_MESSAGE();
	SET @idCita = 0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CitaBorrar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Steven 
-- Create date: 14-12-2022
-- Description:	Agrega una nueva cita 
-- =============================================
Create PROCEDURE [dbo].[CitaBorrar]
	@_idCita int = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @Borrado bit output
AS
BEGIN
BEGIN TRY
	DELETE FROM Citas
	WHERE Citas.idCita = @_idCita;
	SET @_codigo_error = 0;
	SET @_mensaje_error = '';
	SET @Borrado = 1;
END TRY
BEGIN CATCH
	SET @_codigo_error = @@ERROR;
	SET @_mensaje_error = ERROR_MESSAGE();
	SET @Borrado = 0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DiagnosticoAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DiagnosticoAgregar]
	@_Fecha datetime = null,
	@_Descripcion varchar(1000) = null,
	@_idEnfermedad int = 0,

    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idDiagnostico int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO Diagnostico(Fecha, Descripcion, Enfermedad_id )
		VALUES(@_Fecha , @_Descripcion, @_idEnfermedad );
		set @idDiagnostico= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH 
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH 
END
GO
/****** Object:  StoredProcedure [dbo].[DiagnosticoEliminar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[DiagnosticoEliminar]
		@idDiagnostico int = null,
		@ErrorMessage varchar(max) output,
		@ErrorCode int output,
		@borrado bit output
AS
BEGIN
BEGIN TRY
	update Diagnostico
	set Enfermedad_id = 0;
	delete from Diagnostico
	where Diagnostico.idDiagnostico = @idDiagnostico
	SET @ErrorCode = 0;
	SET @ErrorMessage= '';
	set @borrado = 1;
END TRY
BEGIN CATCH
	SET @ErrorCode = @@ERROR;
	SET @ErrorMessage = ERROR_MESSAGE()
	set @borrado = 0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEnfermedad]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarEnfermedad]
		@idEnfermedad int =0,
		@ErrorMessage varchar(max) output,
		@ErrorCode int output
AS
BEGIN
BEGIN TRY
	DELETE FROM Enfermedades
	WHERE Enfermedades.idEnfermedad = @idEnfermedad
	SET @ErrorCode = 0;
	SET @ErrorMessage= '';
END TRY
BEGIN CATCH
	SET @ErrorCode = @@ERROR;
	SET @ErrorMessage = ERROR_MESSAGE()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMedicamento]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarMedicamento]
		@idMedicamento int =0,
		@ErrorMessage varchar(max) output,
		@ErrorCode int output
AS
BEGIN
BEGIN TRY
	DELETE FROM Medicamento
	WHERE Medicamento.idMedicamento = @idMedicamento
	SET @ErrorCode = 0;
	SET @ErrorMessage= '';
END TRY
BEGIN CATCH
	SET @ErrorCode = @@ERROR;
	SET @ErrorMessage = ERROR_MESSAGE()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMedico]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarMedico]
		@idMedico int =0,
		@ErrorMessage varchar(max) output,
		@ErrorCode int output,
		@borrado bit output
AS
BEGIN
BEGIN TRY
	DELETE FROM MedHasEspe
	WHERE MedHasEspe.idMedico = @idMedico
	update Registro
	set Medico_id = 0 where Medico_id= @idMedico
	DELETE FROM Medicos
	WHERE Medicos.idMedico = @idMedico
	SET @ErrorCode = 0;
	SET @ErrorMessage= '';
	SET @borrado = 1;
END TRY
BEGIN CATCH 
	SET @ErrorCode = @@ERROR;
	SET @ErrorMessage = ERROR_MESSAGE()
	SET @borrado=0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarPaciente]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarPaciente]
		@idPaciente int =0,
		@ErrorMessage varchar(max) output,
		@ErrorCode int output		
AS
BEGIN
BEGIN TRY
	DELETE FROM Pacientes
	WHERE Pacientes.idPaciente = @idPaciente
	SET @ErrorCode = 0;
	SET @ErrorMessage= '';
	
END TRY
BEGIN CATCH 
	SET @ErrorCode = @@ERROR;
	SET @ErrorMessage = ERROR_MESSAGE()
	
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EnfermedadActualizar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[EnfermedadActualizar]
	@_Nombre varchar(50) = null,
	@_Descripcion varchar(1000) = null,
	@_Sintomas varchar(100) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idEnfermedad int output,
	@Editado bit output
AS
BEGIN
	BEGIN TRY
		UPDATE Enfermedades
		SET 
			Nombre = @_Nombre,
			Descripcion = @_Descripcion,
			Sintomas = @_Sintomas
		WHERE 
			idEnfermedad = @idEnfermedad;
		set @_codigo_error = 0;
		set @_mensaje_error = '';
		set @Editado = 1;
	END TRY
	BEGIN CATCH
		set @_codigo_error = @@ERROR;
		set @_mensaje_error = ERROR_MESSAGE();
		set @Editado = 0;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EnfermedadAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnfermedadAgregar]
	@_Nombre varchar(50) = null,
	@_Descripcion varchar(1000) = null,
	@_Sintomas varchar(100) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idEnfermedad int output
AS
BEGIN
	set @_codigo_error = 0
	set @_mensaje_error= ''
	BEGIN TRY
		INSERT INTO Enfermedades(Nombre,Descripcion,Sintomas)
		VALUES(@_Nombre, @_Descripcion, @_Sintomas )

		set @idEnfermedad= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EspecialidadAgregar]
	@_Nombre varchar(50) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idEspecialidad int output
AS
BEGIN
	SET @_codigo_error = 0;
	SET @_mensaje_error = '';
	BEGIN TRY
		INSERT INTO Especialidad(Nombre)
		values (@_Nombre)

		set @idEspecialidad= SCOPE_IDENTITY()

	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[ExpedienteMedicoAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExpedienteMedicoAgregar]
	@_FechaApertura datetime = null,
	@_UltimaModificacion datetime = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idExpedienteMedico int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
	
		INSERT INTO ExpedienteMedico( FechaApertura, UltimaModificacion )
		VALUES( @_FechaApertura, @_UltimaModificacion );
		set @idExpedienteMedico= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GenerarExpediente]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GenerarExpediente]	
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @_idExpediente int output
AS
BEGIN
	BEGIN TRY
		insert into ExpedienteMedico (FechaApertura,UltimaModificacion)
							values ( GETDATE(),GETDATE())
		set @_idExpediente =SCOPE_IDENTITY()
		set @_codigo_error=0
		set @_mensaje_error=' '
	END TRY
	BEGIN CATCH
			set @_codigo_error=@@ERROR
			set @_mensaje_error=ERROR_MESSAGE()
			SET @_idExpediente =0;
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[GenerarRegistroEnExpediente]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven
-- Create date: 13-12-2022
-- Description:	Genera un nuevo registro en la base de datos
-- =============================================
CREATE PROCEDURE [dbo].[GenerarRegistroEnExpediente]
	@_idExpediente as int = 0,
	@_idSucursal as int =0 ,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idRegistro int output
AS
BEGIN
	begin try
		insert into Registro(Medico_id,Diagnostico_id,Receta_id,Cita_id,Sucursal_id,Expediente_id)
		values(0,0,0,0,@_idSucursal,@_idExpediente) 
		set @idRegistro =  SCOPE_IDENTITY()
		set @_codigo_error = 0
		set @_mensaje_error = ''
	end try
	begin catch
		set @_codigo_error = @@ERROR
		set @_mensaje_error = ERROR_MESSAGE()
	end catch
END
GO
/****** Object:  StoredProcedure [dbo].[InventarioActualizar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[InventarioActualizar]
	@_idInventario int = null,
	@_NumLote varchar(30) = null,
	@_FechaIngreso date = null,
	@_FechaVencimiento date = null,
	@_Refrigeracion bit = null,
	@_Cantidad int = 0,
	@_idMedicamento int = 0,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @Editado bit output
AS
BEGIN
	BEGIN TRY
		update InventarioMedico
		set 
			NumLote = @_NumLote,
			FechaIngreso = @_FechaIngreso,
			FechaVencimiento = @_FechaVencimiento,
			Refrigeracion = @_Refrigeracion,
			CantDisponible = @_Cantidad,
			Medicamento_id = @_idMedicamento
		where 
			idInventario = @_idInventario
		SET @Editado= 1;
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
	END TRY
	BEGIN CATCH
		SET @Editado= 0;
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[InventarioAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InventarioAgregar]
	@_NumLote varchar(30) = null,
	@_FechaIngreso date = null,
	@_FechaVencimiento date = null,
	@_Refrigeracion bit = null,
	@_Cantidad int = 0,
	@_idMedicamento int = 0,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idInventario int output
AS
BEGIN
	BEGIN TRY
		INSERT INTO InventarioMedico(NumLote,FechaIngreso,FechaVencimiento,Refrigeracion,CantDisponible,Medicamento_id)
		VALUES(@_NumLote,@_FechaIngreso,@_FechaVencimiento,@_Refrigeracion,@_Cantidad,@_idMedicamento)
		SET @idInventario = SCOPE_IDENTITY()
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
	END TRY
	BEGIN CATCH
		SET @idInventario = 0;
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[InvHasSucurAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InvHasSucurAgregar]
	@_idInventario int = null,
	@_idSucursal int = null,
	
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @_Agregado bit output
AS
BEGIN
	begin try
		insert into InvHasSucur (idInventario,idSucursal)
		values(@_idInventario,@_idSucursal)
		set @_codigo_error = 0;
		set @_mensaje_error = '';
		set @_Agregado = 1;
	end try
	begin catch
		set @_codigo_error = @@ERROR;
		set @_mensaje_error = ERROR_MESSAGE();
		set @_Agregado = 1;
	end catch
END
GO
/****** Object:  StoredProcedure [dbo].[MedicamentoActualizar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[MedicamentoActualizar]
	@_idMedicamento int = null,
	@_Nombre varchar(50) = null,
	@_Casa_Farmaceutica varchar(30) = null,
	@_Descripcion varchar(60) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @Editado bit output
AS
BEGIN
	set @_codigo_error = 0
	set @_mensaje_error= ''
	BEGIN TRY
		update 
			Medicamento
		set 
			Nombre = @_Nombre,
			CasaFarmaceutica = @_Casa_Farmaceutica,
			Descripcion = @_Descripcion
		where 
			idMedicamento = @_idMedicamento;
		
		set @_codigo_error= 0
		set @_mensaje_error=''
		set @Editado = 1
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicamentoAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MedicamentoAgregar]
	@_Nombre varchar(50) = null,
	@_Casa_Farmaceutica varchar(1000) = null,
	@_Descripcion varchar(1000) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idMedicamento int output
AS
BEGIN
	set @_codigo_error = 0
	set @_mensaje_error= ''
	BEGIN TRY
		INSERT INTO Medicamento(Nombre,CasaFarmaceutica,Descripcion)
		VALUES(@_Nombre, @_Casa_Farmaceutica, @_Descripcion)

		set @idMedicamento= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicoAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MedicoAgregar]
	@_Usuario		varchar(25) = null,
	@_Contraseña	varchar(50) = null,
	@_Nombre		varchar(25) = null,
	@_Apellidos		varchar(50) = null,
	@_Identificacion varchar(30) = null,
	@_TipoIdentificacion varchar(15) = null,
	@_Sexo			varchar(15) = null,
	@_EstadoCivil	varchar(15) = null,
	@_Nacionalidad	varchar(15) = null,
	@_FechaNacimiento varchar(10),
	@_NumeroTelefonico int = 0,
	@_correo		varchar(40) = null,
	@_OtrasSenas varchar(100) = null,
	@_idDistrito int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idMedico int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO Medicos (Usuario,HashContraseña,Nombre,Apellidos,Identificacion,TipoIdentificacion,Sexo,EstadoCivil,Nacionalidad,FechaNacimiento,NumeroTelefonico,Correo,otrasSenas,IdDistrito)
		VALUES(@_Usuario,@_Contraseña,@_Nombre,@_Apellidos,@_Identificacion,@_TipoIdentificacion,@_Sexo,@_EstadoCivil,@_Nacionalidad,@_FechaNacimiento,@_NumeroTelefonico,@_correo,@_OtrasSenas,@_idDistrito)
	set @idMedico=SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicoComprobarSesion]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Steven Gazo
-- Create date: 12-01-2022
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[MedicoComprobarSesion]
    @_usuario VARCHAR(25) = null,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idMedico int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error ='';
		SET @idMedico = (SELECT Med.idMedico FROM Medicos AS MED WHERE med.Usuario= @_usuario AND med.HashContraseña=@_contrasena)
		if @idMedico is null 
			set @idMedico = 0;		
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MediHasEspeAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[MediHasEspeAgregar]
    @_idMedico int = 0,
	@_años int = 0,
	@_idEspecialidad int = 0,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idAdmin binary output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		INSERT INTO MedHasEspe(idMedico,años,idEspecialidad)
					values(@_idMedico,@_años,@_idEspecialidad);
					set @idAdmin= 1
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PacientesActualizar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PacientesActualizar]
	@_Nombre varchar(25) = null,
	@_Apellidos varchar(50) = null,
	@_Identificacion varchar(30) = null,
	@_TipoIdentificacion varchar(15) = null,
	@_Sexo varchar(15) = null,
	@_EstadoCivil varchar(15) = null,
	@_Nacionalidad varchar(15) = null,
	@_FechaNacimiento datetime = null,
	@_NumeroTelefonico int = 0,
	@_Correo varchar(40) = null,
	@_EstaActivo binary = 0,
	@_idDistrito int = 0,
	@Editado bit output,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPaciente int output

AS
BEGIN
	BEGIN TRY
		UPDATE Pacientes
		SET 
			Nombre = @_Nombre,
			Apellidos = @_Apellidos,
			Identificacion = @_Identificacion,
			TipoIdentificacion=@_TipoIdentificacion,
			Sexo=@_Sexo,
			EstadoCivil=@_EstadoCivil,
			Nacionalidad= @_Nacionalidad,
			FechaNacimiento= @_FechaNacimiento,
			NumeroTelefonico= @_NumeroTelefonico,
			Correo=@_Correo,
			EstaActivo=@_EstaActivo,
			IdDistrito= @_idDistrito
		WHERE 
			idPaciente = @idPaciente;
		set @_codigo_error = 0;
		set @_mensaje_error = '';
		set @Editado = 1;

	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
		set @Editado = 0;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PacientesAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PacientesAgregar]
	@_Nombre varchar(25) = null,
	@_Apellidos varchar(50) = null,
	@_Identificacion varchar(30) = null,
	@_TipoIdentificacion varchar(15) = null,
	@_Sexo varchar(15) = null,
	@_EstadoCivil varchar(15) = null,
	@_Nacionalidad varchar(15) = null,
	@_FechaNacimiento datetime = null,
	@_NumeroTelefonico int = 0,
	@_Correo varchar(40) = null,
	@_EstaActivo binary = 0,
	@_idExpediente int = 0,
	@_idDistrito int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPaciente int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		insert into Pacientes	( 
		Nombre, 
		Apellidos, 
		Identificacion, 
		TipoIdentificacion, 
		Sexo, 
		EstadoCivil, 
		Nacionalidad, 
		FechaNacimiento, 
		NumeroTelefonico, 
		Correo, 		
		EstaActivo, 
		Expediente_id,
		IdDistrito)
		values		
		(@_Nombre,
		@_Apellidos,
		@_Identificacion, 
		@_TipoIdentificacion, 
		@_Sexo, 
		@_EstadoCivil,
		@_Nacionalidad,
		@_FechaNacimiento,
		@_NumeroTelefonico,
		@_Correo,
		@_EstaActivo, 
		@_idExpediente,
		@_idDistrito)

		set @idPaciente= SCOPE_IDENTITY()

	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[ReceHasInvenAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ReceHasInvenAgregar]
	@_idInventario int,
	@_cantidad int,
	@_idReceta int,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @_Estado bit output
AS
BEGIN
	begin try
		insert into ReceHasMedi(idInvMedico,CantMedic,idReceta)
		values(@_idInventario,@_cantidad,@_idReceta)

		update InventarioMedico
		set CantDisponible = CantDisponible - @_cantidad
		where InventarioMedico.idInventario = @_idInventario

		set @_codigo_error =0
		set @_mensaje_error = ''
		set @_Estado = 1
	end try
	begin catch
		set @_codigo_error = @@ERROR
		set @_mensaje_error = ERROR_MESSAGE()
		set @_Estado = 0
	end catch
END
GO
/****** Object:  StoredProcedure [dbo].[RecetaAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RecetaAgregar]
	@_Fecha datetime =null,
	@_Indicaciones varchar(100) = null,
	@_FechaVencimiento datetime = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idReceta int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO Receta	(Fecha, Indicaciones, FechaVencimiento )
					VALUES	(@_Fecha, @_Indicaciones, @_FechaVencimiento );

		set @idReceta= SCOPE_IDENTITY()
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RecInveAgregar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RecInveAgregar]
	@_idInve as integer = null,
	@_idRece as integer = null,
	@_Cantidad as integer = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @Agregado bit output
AS
BEGIN
BEGIN TRY
	
	insert into ReceHasMedi(idInvMedico,CantMedic,idReceta)
	values(@_idInve,@_Cantidad,@_idRece);

	update InventarioMedico
	set CantDisponible =  CantDisponible - @_Cantidad
	where InventarioMedico.idInventario = @_idInve

	set @_codigo_error=0;
	set @_mensaje_error =''
	set @Agregado = 0;
END TRY
BEGIN CATCH
	set @_codigo_error = @@ERROR;
	set @_mensaje_error = ERROR_MESSAGE();
	set @Agregado = 0;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RegistroActualizar]    Script Date: 18/12/2022 19:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo
-- Create date: 14-12-2022
-- Description:	Actualiza registro de expediente
-- =============================================
CREATE PROCEDURE [dbo].[RegistroActualizar]
	@_idRegistro int = 0,
	@_idMedico int = 0,
	@_idDiagnostico int = 0,
	@_idReceta int = 0,
	@_idCita int = 0,	
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @Editado bit output
AS
BEGIN
	BEGIN TRY
		UPDATE Registro
		SET 
			Medico_id = @_idMedico,
			Diagnostico_id = @_idDiagnostico,
			Receta_id = @_idReceta,
			Cita_id = @_idCita
		WHERE 
			idRegistro = @_idRegistro;
		set @_codigo_error = 0;
		set @_mensaje_error = '';
		set @Editado = 1;


	END TRY
	BEGIN CATCH
		set @_codigo_error = @@ERROR;
		set @_mensaje_error = ERROR_MESSAGE();
		set @Editado = 0;
	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [Proyecto_Hospital] SET  READ_WRITE 
GO
