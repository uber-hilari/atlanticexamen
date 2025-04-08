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
  (newid(), 'Juan', 'Perez', 1, '20123212', '994995992', 'mimail@correo.com', 'Jr Las Palmas', '150101', 0, 0, 'System', GETUTCDATE(), '', null, '', null)
  
insert into cliente values
  (newid(), 'Miguel', 'Caceres', 1, '40158754', '911945945', 'mcaceres@correo.com', 'Av Colmena', '150101', 1, 0, 'System', GETUTCDATE(), '', null, '', null)
GO

insert into Libro values
  (NEWID(), 'El Mago de los Libros', 'Autor Uno', 15, 65, NEWID(), 3, 3, 0, 'System', GETUTCDATE(), '', null, '', null)

insert into Libro values
  (NEWID(), 'El Mago de los Libros II', 'Autor Uno', 15, 65, NEWID(), 3, 1, 0, 'System', GETUTCDATE(), '', null, '', null)
  
insert into Libro values
  (NEWID(), 'El Mago de los Libros III', 'Autor Uno', 15, 65, NEWID(), 1, 0, 0, 'System', GETUTCDATE(), '', null, '', null)
GO