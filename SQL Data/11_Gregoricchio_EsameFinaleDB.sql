USE [master]
GO
/****** Object:  Database [Shop_Gregoricchio]    Script Date: 28/06/2019 17:46:40 ******/

ALTER DATABASE [Shop_Gregoricchio] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop_Gregoricchio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop_Gregoricchio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop_Gregoricchio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop_Gregoricchio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Shop_Gregoricchio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop_Gregoricchio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Shop_Gregoricchio] SET  MULTI_USER 
GO
ALTER DATABASE [Shop_Gregoricchio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop_Gregoricchio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop_Gregoricchio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop_Gregoricchio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop_Gregoricchio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop_Gregoricchio] SET QUERY_STORE = OFF
GO
USE [Shop_Gregoricchio]
GO
/****** Object:  User [ITS_IBS]    Script Date: 28/06/2019 17:46:40 ******/
CREATE USER [ITS_IBS] FOR LOGIN [ITS_IBS] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_datareader] ADD MEMBER [ITS_IBS]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [ITS_IBS]
GO
/****** Object:  Table [dbo].[Azienda]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Azienda](
	[PartitaIva] [varchar](11) NOT NULL,
	[CF] [varchar](16) NOT NULL,
	[RagioneSociale] [varchar](50) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Cognome] [varchar](50) NOT NULL,
	[Via] [varchar](50) NOT NULL,
	[Cap] [varchar](5) NOT NULL,
	[Citta] [varchar](100) NOT NULL,
	[Provincia] [char](2) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Cellulare] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[Email] [varchar](255) NULL,
	[Sito] [varchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[PartitaIva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denominazione] [varchar](50) NOT NULL,
	[Descrizione] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DettaglioOrdine]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DettaglioOrdine](
	[IdOrdine] [int] NOT NULL,
	[IdProdotto] [int] NOT NULL,
	[Quantita] [int] NOT NULL,
 CONSTRAINT [PK_DettaglioOrdine] PRIMARY KEY CLUSTERED 
(
	[IdOrdine] ASC,
	[IdProdotto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordine]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodiceOrdine] [varchar](8) NOT NULL,
	[IdCliente] [varchar](11) NOT NULL,
	[Data] [datetime] NOT NULL,
	[TipoPagamento] [int] NOT NULL,
 CONSTRAINT [PK_Ordine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_CodiceOrdine] UNIQUE NONCLUSTERED 
(
	[CodiceOrdine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodotto]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodotto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denominazione] [varchar](50) NOT NULL,
	[Descrizione] [varchar](255) NULL,
	[IdCategoria] [int] NOT NULL,
	[PrezzoNoIva] [float] NOT NULL,
	[Sconto] [int] NOT NULL,
	[Giacenza] [int] NOT NULL,
 CONSTRAINT [PK__Prodotto__3214EC07F86F25B0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipiPagamento]    Script Date: 28/06/2019 17:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipiPagamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denominazione] [varchar](50) NOT NULL,
	[Attivo] [bit] NOT NULL,
 CONSTRAINT [PK_TipiPagamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prodotto] ADD  CONSTRAINT [DF_Prodotto_Sconto]  DEFAULT ((0)) FOR [Sconto]
GO
ALTER TABLE [dbo].[TipiPagamento] ADD  CONSTRAINT [DF_TipiPagamento_Attivo]  DEFAULT ((0)) FOR [Attivo]
GO
ALTER TABLE [dbo].[DettaglioOrdine]  WITH CHECK ADD  CONSTRAINT [FK_DettaglioOrdine_Ordine] FOREIGN KEY([IdOrdine])
REFERENCES [dbo].[Ordine] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DettaglioOrdine] CHECK CONSTRAINT [FK_DettaglioOrdine_Ordine]
GO
ALTER TABLE [dbo].[DettaglioOrdine]  WITH CHECK ADD  CONSTRAINT [FK_DettaglioOrdine_Prodotto1] FOREIGN KEY([IdProdotto])
REFERENCES [dbo].[Prodotto] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DettaglioOrdine] CHECK CONSTRAINT [FK_DettaglioOrdine_Prodotto1]
GO
ALTER TABLE [dbo].[Ordine]  WITH CHECK ADD  CONSTRAINT [FK_Ordine_Azienda] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Azienda] ([PartitaIva])
GO
ALTER TABLE [dbo].[Ordine] CHECK CONSTRAINT [FK_Ordine_Azienda]
GO
ALTER TABLE [dbo].[Ordine]  WITH CHECK ADD  CONSTRAINT [FK_Ordine_TipiPagamento] FOREIGN KEY([TipoPagamento])
REFERENCES [dbo].[TipiPagamento] ([Id])
GO
ALTER TABLE [dbo].[Ordine] CHECK CONSTRAINT [FK_Ordine_TipiPagamento]
GO
ALTER TABLE [dbo].[Prodotto]  WITH CHECK ADD  CONSTRAINT [Fk_Prodotto_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Prodotto] CHECK CONSTRAINT [Fk_Prodotto_Categoria]
GO
USE [master]
GO
ALTER DATABASE [Shop_Gregoricchio] SET  READ_WRITE 
GO
