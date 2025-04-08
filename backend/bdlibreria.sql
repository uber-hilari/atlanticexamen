/****** Object:  Table [dbo].[Alquiler]    Script Date: 7/04/2025 22:24:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquiler](
	[Id] [uniqueidentifier] NOT NULL,
	[IdLibro] [uniqueidentifier] NOT NULL,
	[IdCliente] [uniqueidentifier] NOT NULL,
	[FechaAlquiler] [datetime2](7) NOT NULL,
	[FechaRetorno] [datetime2](7) NULL,
	[Precio] [decimal](18, 4) NOT NULL,
	[EstadoLibro] [int] NOT NULL,
	[EstadoAlquiler] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[CreadoPor] [nvarchar](max) NOT NULL,
	[CreadoEn] [datetime2](7) NOT NULL,
	[ModificadoPor] [nvarchar](max) NOT NULL,
	[ModificadoEn] [datetime2](7) NULL,
	[EliminadoPor] [nvarchar](max) NOT NULL,
	[EliminadoEn] [datetime2](7) NULL,
 CONSTRAINT [PK_Alquiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 7/04/2025 22:24:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombres] [nvarchar](max) NOT NULL,
	[Apellidos] [nvarchar](max) NOT NULL,
	[TipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Dirección] [nvarchar](max) NOT NULL,
	[Ubigeo] [nvarchar](max) NOT NULL,
	[EnListaNegra] [bit] NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[CreadoPor] [nvarchar](max) NOT NULL,
	[CreadoEn] [datetime2](7) NOT NULL,
	[ModificadoPor] [nvarchar](max) NOT NULL,
	[ModificadoEn] [datetime2](7) NULL,
	[EliminadoPor] [nvarchar](max) NOT NULL,
	[EliminadoEn] [datetime2](7) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 7/04/2025 22:24:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[Id] [uniqueidentifier] NOT NULL,
	[Titulo] [nvarchar](max) NOT NULL,
	[Autor] [nvarchar](max) NOT NULL,
	[PrecioAlquiler] [decimal](18, 4) NOT NULL,
	[PrecioVenta] [decimal](18, 4) NOT NULL,
	[CodigoQR] [uniqueidentifier] NOT NULL,
	[CantidadCopias] [int] NOT NULL,
	[CopiasDisponibles] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[CreadoPor] [nvarchar](max) NOT NULL,
	[CreadoEn] [datetime2](7) NOT NULL,
	[ModificadoPor] [nvarchar](max) NOT NULL,
	[ModificadoEn] [datetime2](7) NULL,
	[EliminadoPor] [nvarchar](max) NOT NULL,
	[EliminadoEn] [datetime2](7) NULL,
 CONSTRAINT [PK_Libro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Alquiler_IdCliente]    Script Date: 7/04/2025 22:24:05 ******/
CREATE NONCLUSTERED INDEX [IX_Alquiler_IdCliente] ON [dbo].[Alquiler]
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Alquiler_IdLibro]    Script Date: 7/04/2025 22:24:05 ******/
CREATE NONCLUSTERED INDEX [IX_Alquiler_IdLibro] ON [dbo].[Alquiler]
(
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Cliente_IdCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alquiler] CHECK CONSTRAINT [FK_Alquiler_Cliente_IdCliente]
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Libro_IdLibro] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Libro] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alquiler] CHECK CONSTRAINT [FK_Alquiler_Libro_IdLibro]
GO
USE [master]
GO
ALTER DATABASE [atlanticlibreria] SET  READ_WRITE 
GO


insert into cliente values
  ('CBCEF394-BC8B-4C41-912E-608E324E5C22', 'Juan', 'Perez', 1, '20123212', '994995992', 'mimail@correo.com', 'Jr Las Palmas', '150101', 0, 0, 'System', GETUTCDATE(), '', null, '', null)
  
insert into cliente values
  ('BE53BFAD-23DA-48E3-A351-B420FFAEFA7E', 'Miguel', 'Caceres', 1, '40158754', '911945945', 'mcaceres@correo.com', 'Av Colmena', '150101', 1, 0, 'System', GETUTCDATE(), '', null, '', null)
GO

insert into Libro values
  ('788EF8F5-FD91-4A09-9E6C-5D9AC5E1F2FA', 'El Mago de los Libros', 'Autor Uno', 15, 65, '34719D76-2DA1-4194-8063-E47B72FDB2AA', 3, 3, 0, 'System', GETUTCDATE(), '', null, '', null)

insert into Libro values
  ('F5CDB965-F51F-4A5D-B32E-7CB40E143269', 'El Mago de los Libros II', 'Autor Uno', 15, 65, '2EEF8691-5902-414C-89EF-1BB5A8702444', 3, 1, 0, 'System', GETUTCDATE(), '', null, '', null)
  
insert into Libro values
  ('DA7D3495-A3CD-49E3-851F-CA8C9B64C42E', 'El Mago de los Libros III', 'Autor Uno', 15, 65, '39DEA692-1C6A-4922-B9C6-D33BC71AA22C', 1, 0, 0, 'System', GETUTCDATE(), '', null, '', null)
GO