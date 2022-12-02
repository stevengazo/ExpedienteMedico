USE [master]
GO
/****** Object:  Database [Proyecto_Hospital]    Script Date: 12/1/2022 10:23:45 PM ******/
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
/****** Object:  Table [dbo].[Administrador]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[idAdministrador] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Citas]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[idCita] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[idDiagnostico] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Descripcion] [varchar](1000) NULL,
	[Enfermedad_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enfermedades]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enfermedades](
	[idEnfermedad] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](1000) NULL,
	[Sintomas] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEnfermedad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpedienteMedico]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpedienteMedico](
	[idExpediente] [int] NOT NULL,
	[FechaApertura] [date] NULL,
	[UltimaModificacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idExpediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventarioMedico]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventarioMedico](
	[idInventario] [int] NOT NULL,
	[NumLote] [varchar](30) NULL,
	[FechaIngreso] [date] NULL,
	[FechaVencimiento] [date] NULL,
	[Refrigeracion] [binary](1) NULL,
	[CantDisponible] [int] NULL,
	[Medicamento_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvHasSucur]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvHasSucur](
	[idSucursal] [int] NULL,
	[idInventario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedHasEspe]    Script Date: 12/1/2022 10:23:45 PM ******/
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
/****** Object:  Table [dbo].[Medicamento]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[idMedicamento] [int] NOT NULL,
	[Nombre] [varchar](40) NULL,
	[CasaFarmaceutica] [varchar](30) NULL,
	[Descripcion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[idMedico] [int] NOT NULL,
	[Usuario] [varchar](25) NULL,
	[HashContraseña] [varchar](50) NULL,
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
PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[idPaciente] [int] NOT NULL,
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
	[Provincia] [varchar](15) NULL,
	[Canton] [varchar](15) NULL,
	[EstaActivo] [binary](1) NULL,
	[Expediente_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceHasMedi]    Script Date: 12/1/2022 10:23:45 PM ******/
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
/****** Object:  Table [dbo].[Receta]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[idReceta] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Indicaciones] [varchar](100) NULL,
	[FechaVencimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idReceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[idRegistro] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Sucursal]    Script Date: 12/1/2022 10:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [int] NOT NULL,
	[Nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrador] ([idAdministrador], [Usuario], [Nombre], [Apellidos], [Contrasena]) VALUES (6, N'Sgazo', N'Steven', N'Gazo', N'Password123')
GO
INSERT [dbo].[Citas] ([idCita], [Fecha], [Hora]) VALUES (1, CAST(N'2022-02-02' AS Date), CAST(N'1900-01-01T10:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Enfermedades] FOREIGN KEY([Enfermedad_id])
REFERENCES [dbo].[Enfermedades] ([idEnfermedad])
GO
ALTER TABLE [dbo].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Enfermedades]
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
/****** Object:  StoredProcedure [dbo].[AdministradorActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[AdministradorActualizar]
    @_idAdministrador int = 0,
    @_usuario VARCHAR(25) = null,
    @_nombre VARCHAR(20) = null,
    @_apellidos VARCHAR(50) = null,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		UPDATE Administrador
		SET 
			Usuario = @_usuario,
			Nombre = @_nombre,
			Apellidos = @_apellidos,
			Contrasena = @_contrasena
		WHERE 
			Administrador.idAdministrador = @_idAdministrador					
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AdministradorAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AdministradorAgregar]
    @_idAdministrador int = 0,
    @_usuario VARCHAR(25) = null,
    @_nombre VARCHAR(20) = null,
    @_apellidos VARCHAR(50) = null,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		INSERT INTO Administrador( idAdministrador, Usuario, Nombre,Apellidos,Contrasena)
					values(@_idAdministrador,@_usuario,@_nombre,@_apellidos, @_contrasena)
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AdministradorBorrar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AdministradorBorrar]
    @_idAdministrador int = 0,   
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idAdministrador int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		DELETE FROM Administrador
		WHERE 
			Administrador.idAdministrador = @_idAdministrador					
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AdministradorComprobarSesion]    Script Date: 12/1/2022 10:23:46 PM ******/
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
/****** Object:  StoredProcedure [dbo].[AdministradorModificarContraseña]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdministradorModificarContraseña]
    @_idAdministrador int = 0,
    @_contrasena VARCHAR(50) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idAdministrador int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		UPDATE Administrador
		SET
			Contrasena = @_contrasena
		WHERE 
			Administrador.idAdministrador =@_idAdministrador
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CitaActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CitaActualizar]
    @_idCita int = 0,
	@_Fecha datetime = null,
	@_Hora time = null,

    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		UPDATE  Citas
		SET 
			Fecha = @_Fecha,
			Hora = @_Hora
		WHERE
			Citas.idCita = @_idCita
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CitaAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CitaAgregar]
    @_idCita int = 0,
	@_Fecha datetime = null,
	@_Hora time = null,

    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		INSERT INTO Citas(idCita,Fecha,Hora)
					values(@_idCita, @_Fecha,@_Hora)
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CitaBorrar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CitaBorrar]
    @_idCita int = 0,

    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output
AS
BEGIN
    -- Datos de Salida
    set @_codigo_error= 0
    set @_mensaje_error = ''
 
	BEGIN TRY
		DELETE FROM Citas
		WHERE
			Citas.idCita = @_idCita
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DiagnosticoActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo 
-- Create date: 2022-11-27
-- Description:	Modifica un registro existente
-- =============================================
Create PROCEDURE [dbo].[DiagnosticoActualizar]
	@_idDiagnostico int = 0,
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

		UPDATE
			Diagnostico
		SET 
			Fecha = @_Fecha,
			Descripcion = @_Descripcion,
			Enfermedad_id = @_idEnfermedad
		WHERE
			Diagnostico.idDiagnostico = @_idDiagnostico
	END TRY
	BEGIN CATCH 
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH 
END
GO
/****** Object:  StoredProcedure [dbo].[DiagnosticoAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo 
-- Create date: 2022-11-27
-- Description:	Agrega nuevo registro
-- =============================================
CREATE PROCEDURE [dbo].[DiagnosticoAgregar]
	@_idDiagnostico int = 0,
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
		INSERT INTO Diagnostico( idDiagnostico, Fecha, Descripcion, Enfermedad_id )
		VALUES( @_idDiagnostico,@_Fecha , @_Descripcion, @_idEnfermedad );
	END TRY
	BEGIN CATCH 
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH 
END
GO
/****** Object:  StoredProcedure [dbo].[EnfermedadActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnfermedadActualizar]
	@_idEnfermedad int = 0,
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
		UPDATE Enfermedades
		SET 
			Nombre = @_Nombre,
			Descripcion = @_Descripcion,
			Sintomas = @_Sintomas
		WHERE 
			Enfermedades.idEnfermedad = @_idEnfermedad
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EnfermedadAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnfermedadAgregar]
	@_idEnfermedad int = 0,
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
		INSERT INTO Enfermedades( idEnfermedad,Nombre,Descripcion,Sintomas)
							VALUES( @_idEnfermedad, @_Nombre, @_Descripcion, @_Sintomas )
	END TRY
	BEGIN CATCH
		set @_codigo_error=@@ERROR
		set @_mensaje_error=ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[EspecialidadActualizar]
	@_idEspecialidad int = 0,
	@_Nombre varchar(50) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idEspecialidad int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		UPDATE 
			Especialidad
		SET
			Nombre = @_Nombre
		WHERE 
			Especialidad.idEspecialidad = @_idEspecialidad
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[EspecialidadAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EspecialidadAgregar]
	@_idEspecialidad int = 0,
	@_Nombre varchar(50) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[ExpedienteMedicoActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo
-- Create date: 2022-11-27
-- Description:	Modifica un especiente existente
-- =============================================
CREATE PROCEDURE [dbo].[ExpedienteMedicoActualizar]
	@_idExpediente int = 0,
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
		UPDATE 
			ExpedienteMedico
		SET 
			UltimaModificacion = @_UltimaModificacion,
			FechaApertura = @_FechaApertura
		WHERE		
			ExpedienteMedico.idExpediente = @_idExpediente;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[ExpedienteMedicoAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Steven Gazo
-- Create date: 2022-11-27
-- Description:	Añadir nuevo expediente
-- =============================================
CREATE PROCEDURE [dbo].[ExpedienteMedicoAgregar]
	@_idExpediente int = 0,
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
	
		INSERT INTO ExpedienteMedico( idExpediente, FechaApertura, UltimaModificacion )
		VALUES( @_idExpediente, @_FechaApertura, @_UltimaModificacion );
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[InvenHasSucurAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InvenHasSucurAgregar]
	@_idSucursal int = 0,
	@_idInventario int = 0,
	
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO InvHasSucur( idInventario, idSucursal )
						VALUES( @_idInventario, @_idSucursal );
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicoActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Steven gazo
-- Create date: 2022-11-27
-- Description:	modifica un registro existente en la DB
-- =============================================
CREATE PROCEDURE [dbo].[MedicoActualizar]
	@_idMedico		int = 0,
	@_Usuario		varchar(25) = null,
	@_Contraseña	varchar(50) = null,
	@_Nombre		varchar(25) = null,
	@_Apellidos		varchar(50) = null,
	@_Identificacion varchar(30) = null,
	@_TipoIdentificacion varchar(15) = null,
	@_Sexo			varchar(15) = null,
	@_EstadoCivil	varchar(15) = null,
	@_Nacionalidad	varchar(15) = null,
	@_FechaNacimiento datetime = null,
	@_NumeroTelefonico int = 0,
	@_correo		varchar(40) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idMedico int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		UPDATE
			Medicos
		SET 
			Usuario = @_Usuario,
			Nombre = @_Nombre,
			Apellidos = @_Apellidos,
			Identificacion = @_Identificacion,
			TipoIdentificacion = @_TipoIdentificacion,
			Sexo = @_Sexo,
			EstadoCivil = @_EstadoCivil,
			Nacionalidad = @_Nacionalidad,
			FechaNacimiento = @_FechaNacimiento,
			NumeroTelefonico = @_NumeroTelefonico,
			Correo = @_correo
		where 
			Medicos.idMedico = @_idMedico;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicoAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven gazo
-- Create date: 2022-11-27
-- Description:	Agregar nuevo registro de medico
-- =============================================
CREATE PROCEDURE [dbo].[MedicoAgregar]
	@_idMedico		int = 0,
	@_Usuario		varchar(25) = null,
	@_Contraseña	varchar(50) = null,
	@_Nombre		varchar(25) = null,
	@_Apellidos		varchar(50) = null,
	@_Identificacion varchar(30) = null,
	@_TipoIdentificacion varchar(15) = null,
	@_Sexo			varchar(15) = null,
	@_EstadoCivil	varchar(15) = null,
	@_Nacionalidad	varchar(15) = null,
	@_FechaNacimiento datetime = null,
	@_NumeroTelefonico int = 0,
	@_correo		varchar(40) = null,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO Medicos (idMedico,Usuario,HashContraseña,Nombre,Apellidos,Identificacion,TipoIdentificacion,Sexo,EstadoCivil,Nacionalidad,FechaNacimiento,NumeroTelefonico,Correo)
		VALUES(@_idMedico,@_Usuario,@_Contraseña,@_Nombre,@_Apellidos,@_Identificacion,@_TipoIdentificacion,@_Sexo,@_EstadoCivil,@_Nacionalidad,@_FechaNacimiento,@_NumeroTelefonico,@_correo);
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MedicoComprobarSesion]    Script Date: 12/1/2022 10:23:46 PM ******/
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
/****** Object:  StoredProcedure [dbo].[MediHasEspeActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo
-- Create date:  2022-11-27
-- Description:	modifica registro de Medico - Especialidad
-- =============================================
Create PROCEDURE [dbo].[MediHasEspeActualizar]
	@_IdMedico int = 0,
	@_Cantidad int = 0,
	@_idEspecialidad int = 0,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error =0;
		SET @_mensaje_error = '';
		UPDATE
			MedHasEspe
		SET 
			años = @_Cantidad
		WHERE idMedico = @_IdMedico AND idEspecialidad =@_idEspecialidad;
	END TRY
	BEGIN CATCH
		SET @_codigo_error =@@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MediHasEspeAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Steven Gazo
-- Create date:  2022-11-27
-- Description:	Añade nuevo registro de Medico - Especialidad
-- =============================================
CREATE PROCEDURE [dbo].[MediHasEspeAgregar]
	@_IdMedico int = 0,
	@_Cantidad int = 0,
	@_idEspecialidad int = 0,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error =0;
		SET @_mensaje_error = '';
		INSERT INTO MedHasEspe(idEspecialidad, años, idMedico)
		VALUES( @_idEspecialidad,@_Cantidad,@_IdMedico);

	END TRY
	BEGIN CATCH
		SET @_codigo_error =@@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PacientesActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		STEVEN GAZO
-- Create date: 2022-11-27
-- Description:	ACTUALIZA UN PACIENTE EXISTENTE
-- =============================================
CREATE PROCEDURE [dbo].[PacientesActualizar]
	@_idPaciente int = 0,
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
	@_Provincia varchar(15) = null,
	@_Canton varchar(15) = null,
	@_EstaActivo binary = 0,
	@_idExpediente int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		UPDATE 
			Pacientes
		SET
			Nombre = @_Nombre,  
			Apellidos= @_Apellidos, 
			Identificacion = @_Identificacion, 
			TipoIdentificacion = @_TipoIdentificacion, 
			Sexo = @_Sexo, 
			EstadoCivil = @_EstadoCivil, 
			Nacionalidad = @_Nacionalidad, 
			FechaNacimiento = @_FechaNacimiento, 
			NumeroTelefonico = @_NumeroTelefonico, 
			Correo = @_Correo, 
			Provincia = @_Provincia, 
			Canton = @_Canton, 
			EstaActivo = @_EstaActivo, 
			Expediente_id =@_idExpediente
		WHERE
			Pacientes.idPaciente = @_idPaciente;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PacientesAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		STEVEN GAZO
-- Create date: 2022-11-27
-- Description:	Agrega nuevo registro a la tabla pacientes
-- =============================================
CREATE PROCEDURE [dbo].[PacientesAgregar]
	@_idPaciente int = 0,
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
	@_Provincia varchar(15) = null,
	@_Canton varchar(15) = null,
	@_EstaActivo binary = 0,
	@_idExpediente int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		insert into Pacientes	( 
		idPaciente,
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
		Provincia, 
		Canton, 
		EstaActivo, 
		Expediente_id )
		values		
		(@_idPaciente,
		@_Nombre,
		@_Apellidos,
		@_Identificacion, 
		@_TipoIdentificacion, 
		@_Sexo, 
		@_EstadoCivil,
		@_Nacionalidad,
		@_FechaNacimiento,
		@_NumeroTelefonico,
		@_Correo,
		@_Provincia,
		@_Canton, 
		@_EstaActivo, 
		@_idExpediente)
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[ReceHasMediAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReceHasMediAgregar]
	@_idInventarioMedico int = 0,
	@_CantidadMedicamento int = 0,
	@_idReceta int = 0,
	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idPersona int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO ReceHasMedi(idInvMedico,CantMedic,idReceta)
					VALUES (@_idInventarioMedico,@_CantidadMedicamento,@_idReceta);
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RecetaActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RecetaActualizar]
	@_idReceta int = 0,
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
		UPDATE
			Receta
		SET 
			Fecha = @_Fecha,
			FechaVencimiento= @_FechaVencimiento,
			Indicaciones = @_Indicaciones
		WHERE
			Receta.idReceta = @_idReceta;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RecetaAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RecetaAgregar]
	@_idReceta int = 0,
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
		INSERT INTO Receta	( idReceta, Fecha, Indicaciones, FechaVencimiento )
					VALUES	(@_idReceta, @_Fecha, @_Indicaciones, @_FechaVencimiento );
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RegitroActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegitroActualizar]
	@_idRegistro int = 0,
	@_idMedico int = 0,
	@_idDiagnostico int = 0,
	@_idReceta int = 0,
	@_idCita int = 0,
	@_idSucursal int = 0,
	@_idExpediente int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idRegistro int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		UPDATE 
			Registro
		SET		
		Medico_id=@_idMedico,
		Diagnostico_id=@_idDiagnostico,
		Receta_id=@_idReceta,
		Cita_id=@_idCita,
		Sucursal_id=@_idSucursal,
		Expediente_id = @_idExpediente
		WHERE
			Registro.idRegistro = @_idRegistro;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RegitroAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegitroAgregar]
	@_idRegistro int = 0,
	@_idMedico int = 0,
	@_idDiagnostico int = 0,
	@_idReceta int = 0,
	@_idCita int = 0,
	@_idSucursal int = 0,
	@_idExpediente int = 0,

	@_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idRegistro int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0;
		SET @_mensaje_error = '';
		INSERT INTO Registro	(idRegistro,Medico_id,Diagnostico_id,Receta_id,Cita_id,Sucursal_id,Expediente_id)
						VALUES	(@_idRegistro,@_idMedico,@_idDiagnostico,@_idReceta,@_idCita,@_idSucursal,@_idExpediente)
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR;
		SET @_mensaje_error = ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SucursalActualizar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SucursalActualizar]
	@_idSucursal int = 0,
	@_Nombre varchar(30) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idSucursal int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0
		SET @_mensaje_error = ''
		UPDATE
			Sucursal
		SET 
			Nombre =@_Nombre
		WHERE
			Sucursal.idSucursal = @_idSucursal;
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR
		SET @_mensaje_error = ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SucursalAgregar]    Script Date: 12/1/2022 10:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SucursalAgregar]
	@_idSucursal int = 0,
	@_Nombre varchar(30) = null,
    @_codigo_error int output, 
    @_mensaje_error varchar(MaX) output,
    @idSucursal int output
AS
BEGIN
	BEGIN TRY
		SET @_codigo_error = 0
		SET @_mensaje_error = ''
		INSERT INTO Sucursal( idSucursal,Nombre)
					VALUES(@_idSucursal,@_Nombre)
	END TRY
	BEGIN CATCH
		SET @_codigo_error = @@ERROR
		SET @_mensaje_error = ERROR_MESSAGE()
	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [Proyecto_Hospital] SET  READ_WRITE 
GO
