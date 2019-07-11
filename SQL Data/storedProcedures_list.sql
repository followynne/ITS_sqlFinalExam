--------- SP per avere il numero totale di Ordini Completati ------

use Shop_Gregoricchio
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_total_order_completed
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT COUNT(*) FROM Ordine;

	END
GO

-------------------------------------------------
--------- SP per ottenere il Prodotto più Venduto in DB

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_best_selling_product
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 IdProdotto, Prodotto.Denominazione as Nome, SUM(Quantita) as SommaAcquisto FROM DettaglioOrdine
	inner join Prodotto on DettaglioOrdine.IdProdotto = Prodotto.Id
	group by IdProdotto, Prodotto.Denominazione order by SommaAcquisto DESC

	END
GO

-------------------------------------------
--------- SP per ottenere i Prodotti attualmente in scorta (giacenza <= 10)

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_prodotti_in_scorta
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT * FROM Prodotto where Giacenza < 10

	END
GO

--------------------------------------------
--------- SP per ottenere il Prezzo Complessivo, con Iva e Sconto (applicato a ogni prodotto), di ogni ordine eseguito

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ordine_prezzo_totale_ivato
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select IdOrdine, SUM((p.PrezzoNoIva+(p.PrezzoNoIva*c.Iva/100) - ((p.PrezzoNoIva+(p.PrezzoNoIva*c.Iva/100))*d.ScontoApplicato/100))*d.Quantita)
	as prezzo from DettaglioOrdine d inner join Prodotto p on p.Id = d.IdProdotto inner join Categoria c on c.Id = p.IdCategoria group by IdOrdine
    
	END

GO


----------------------------------------------------
--------- SP per ottenere i 10 clienti con il maggior Fatturato (calcolato come il totale speso con tutti gli ordini eseguiti)

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_top10clients_by_fatturato

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

	 select TOP 10 o.IdCliente, c.Nome, SUM(t.totale) as fatturato from @temp_table t inner join
	 Ordine o on o.Id = t.IdOrdine inner join Cliente c on c.Id = o.IdCliente group by o.IdCliente, c.Nome
	 order by fatturato DESC

	END
GO

------------------------------------------------
--------- SP per ottenere il Prezzo Complessivo, con Iva e Sconto (applicato per ogni prodotto), di un singolo ordine

USE [Shop_Gregoricchio]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_totale_ordine_con_sconto]
@id int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select IdOrdine, SUM((p.PrezzoNoIva+(p.PrezzoNoIva*22/100) - ((p.PrezzoNoIva+(p.PrezzoNoIva*22/100))*d.ScontoApplicato/100))*d.Quantita)
	as prezzo from DettaglioOrdine d inner join Prodotto p on p.Id = d.IdProdotto inner join Categoria c on c.Id = p.IdCategoria
	where IdOrdine = @id group by IdOrdine

	END
GO