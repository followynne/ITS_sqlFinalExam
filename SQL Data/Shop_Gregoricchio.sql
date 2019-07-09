USE [master]
GO
/****** Object:  Database [Shop_Gregoricchio]    Script Date: 09/07/2019 15:49:40 ******/
CREATE DATABASE [Shop_Gregoricchio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop_Gregoricchio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\Shop_Gregoricchio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_Gregoricchio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\Shop_Gregoricchio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
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
/****** Object:  User [ITS_IBS]    Script Date: 09/07/2019 15:49:41 ******/
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
/****** Object:  Table [dbo].[Azienda]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Azienda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
	[Cellulare] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NULL,
	[Email] [varchar](255) NOT NULL,
	[Sito] [varchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denominazione] [varchar](50) NOT NULL,
	[Descrizione] [text] NULL,
 CONSTRAINT [PK__Categori__3214EC07967495B3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DettaglioOrdine]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DettaglioOrdine](
	[IdOrdine] [int] NOT NULL,
	[IdProdotto] [int] NOT NULL,
	[Quantita] [int] NOT NULL,
	[ScontoApplicato] [float] NULL,
 CONSTRAINT [PK_DettaglioOrdine] PRIMARY KEY CLUSTERED 
(
	[IdOrdine] ASC,
	[IdProdotto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordine]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodiceOrdine] [varchar](8) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Data] [datetime] NOT NULL,
	[TipoPagamento] [int] NOT NULL,
 CONSTRAINT [PK_Ordine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodotto]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodotto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denominazione] [varchar](50) NOT NULL,
	[Descrizione] [text] NULL,
	[IdCategoria] [int] NOT NULL,
	[PrezzoNoIva] [float] NOT NULL,
	[Sconto] [float] NOT NULL,
	[Giacenza] [int] NOT NULL,
 CONSTRAINT [PK__Prodotto__3214EC07F86F25B0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipiPagamento]    Script Date: 09/07/2019 15:49:41 ******/
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [CF_Azienda_Unique]    Script Date: 09/07/2019 15:49:41 ******/
ALTER TABLE [dbo].[Azienda] ADD  CONSTRAINT [CF_Azienda_Unique] UNIQUE NONCLUSTERED 
(
	[CF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PIva_Azienda_Unique]    Script Date: 09/07/2019 15:49:41 ******/
ALTER TABLE [dbo].[Azienda] ADD  CONSTRAINT [PIva_Azienda_Unique] UNIQUE NONCLUSTERED 
(
	[PartitaIva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_CodiceOrdine]    Script Date: 09/07/2019 15:49:41 ******/
ALTER TABLE [dbo].[Ordine] ADD  CONSTRAINT [UK_CodiceOrdine] UNIQUE NONCLUSTERED 
(
	[CodiceOrdine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DettaglioOrdine] ADD  CONSTRAINT [DF_DettaglioOrdine_ScontoApplicato]  DEFAULT ((0.0)) FOR [ScontoApplicato]
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
REFERENCES [dbo].[Azienda] ([Id])
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
/****** Object:  StoredProcedure [dbo].[sp_best_selling_product]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_best_selling_product]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 IdProdotto, SUM(Quantita) as SommaAcquisto FROM DettaglioOrdine group by IdProdotto order by SommaAcquisto DESC

	END
GO
/****** Object:  StoredProcedure [dbo].[sp_ordine_prezzo_totale_ivato]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ordine_prezzo_totale_ivato]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select IdOrdine, SUM((p.PrezzoNoIva+(p.PrezzoNoIva*22/100) - (p.PrezzoNoIva*d.ScontoApplicato/100))*d.Quantita) as prezzo 
	from DettaglioOrdine d inner join Prodotto p on p.Id = d.IdProdotto group by IdOrdine
    
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_prodotti_in_scorta]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_prodotti_in_scorta]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT * FROM Prodotto where Giacenza <= 10

	END
GO
/****** Object:  StoredProcedure [dbo].[sp_top10clients_by_fatturato]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_top10clients_by_fatturato]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	Declare @temp_table table
	(
	  IdOrdine int,
	  totale float
	)
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Insert into @temp_table
	Exec sp_ordine_prezzo_totale_ivato
	
    -- Insert statements for procedure here

	 select TOP 10 o.IdCliente, SUM(t.totale) as fatturato from @temp_table t inner join
	 Ordine o on o.Id = t.IdOrdine group by o.IdCliente order by fatturato DESC

	END
GO
/****** Object:  StoredProcedure [dbo].[sp_total_order_completed]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_total_order_completed]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT COUNT(*) FROM Ordine;

	END
GO
/****** Object:  Trigger [dbo].[CheckForInsertinDettaglio]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckForInsertinDettaglio] ON [Shop_Gregoricchio].[dbo].[DettaglioOrdine]
FOR INSERT 
as 
BEGIN  
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	if ((select p.Giacenza from Prodotto p inner join inserted i on i.IdProdotto=p.Id
	where p.Id=i.IdProdotto)<(select i.Quantita from inserted i))
	ROLLBACK TRANSACTION;

	update Prodotto set Prodotto.Giacenza = (Prodotto.Giacenza - (select inserted.Quantita from inserted))
	from Prodotto inner join inserted i on Prodotto.Id = i.IdProdotto

	update DettaglioOrdine set DettaglioOrdine.ScontoApplicato = (select Prodotto.Sconto from Prodotto
	inner join inserted i on Prodotto.Id = i.IdProdotto) where DettaglioOrdine.IdProdotto =
	(select inserted.IdProdotto from inserted)

RETURN
END;
GO
ALTER TABLE [dbo].[DettaglioOrdine] ENABLE TRIGGER [CheckForInsertinDettaglio]
GO
/****** Object:  Trigger [dbo].[CheckForPaymentNotActive]    Script Date: 09/07/2019 15:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckForPaymentNotActive] ON [Shop_Gregoricchio].[dbo].[Ordine]
AFTER INSERT, update 
as 
BEGIN  

--IF (SELECT * from INSERTED as i inner join TipiPagamento as t on t.Id= i.TipoPagamento where t.Attivo = 0) 
IF (SELECT t.Attivo from TipiPagamento as t  inner join INSERTED as i on t.Id= i.TipoPagamento) = 0

ROLLBACK TRANSACTION;  
RETURN
END;
GO
ALTER TABLE [dbo].[Ordine] ENABLE TRIGGER [CheckForPaymentNotActive]
GO
USE [master]
GO
ALTER DATABASE [Shop_Gregoricchio] SET  READ_WRITE 
GO
