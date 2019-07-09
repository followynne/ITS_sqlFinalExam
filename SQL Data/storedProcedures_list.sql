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
----------------------------------
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
	
	SELECT TOP 1 IdProdotto, SUM(Quantita) as SommaAcquisto FROM DettaglioOrdine group by IdProdotto order by SommaAcquisto DESC

	END
GO

------------------------
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

	SELECT * FROM Prodotto where Giacenza <= 10

	END
GO

------------------
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
	
	select IdOrdine, SUM((p.PrezzoNoIva+(p.PrezzoNoIva*22/100) - (p.PrezzoNoIva*d.ScontoApplicato/100))*d.Quantita) as prezzo 
	from DettaglioOrdine d inner join Prodotto p on p.Id = d.IdProdotto group by IdOrdine
    
	END
GO

---------------------
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

	 select TOP 10 o.IdCliente, SUM(t.totale) as fatturato from @temp_table t inner join
	 Ordine o on o.Id = t.IdOrdine group by o.IdCliente order by fatturato DESC

	END
GO