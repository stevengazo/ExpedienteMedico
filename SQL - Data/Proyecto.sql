USE [Proyecto_Hospital]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 22/10/2022 21:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[idAdministrador] [int] NOT NULL,
	[Usuario] [varchar](25) NULL,
	[Nombre] [varchar](20) NULL,
	[Apellidos] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Enfermedades]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Especialidad]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[ExpedienteMedico]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[InventarioMedico]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[InvHasSucur]    Script Date: 22/10/2022 21:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvHasSucur](
	[idSucursal] [int] NULL,
	[idInventario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedHasEspe]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Medicamento]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Medicos]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Pacientes]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[ReceHasMedi]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Receta]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Registro]    Script Date: 22/10/2022 21:16:51 ******/
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
/****** Object:  Table [dbo].[Sucursal]    Script Date: 22/10/2022 21:16:51 ******/
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
