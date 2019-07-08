SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE total_order_completed_count
	
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

CREATE PROCEDURE best_selling_product
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 IdProdotto, SUM(Quantita) as SommaAcquisto FROM DettaglioOrdine group by IdProdotto order by Sum(Quantita)

	END
GO

------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE prodotti_in_scorta
	
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

CREATE PROCEDURE max_fatturato_by_client
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	Insert into @temp_table
	Exec secondSPName @anyparams
    

	END
GO


---------------------https://stackoverflow.com/questions/15802511/execute-a-stored-procedure-in-another-stored-procedure-in-sql-server
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE max_fatturato_by_client

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @tep_table table
(
  Id int,
  Name varchar(64)
)
	Insert into @temp_table
	Exec secondSPName
	Select * From @tep_table

    -- Insert statements for procedure here
	select TOP 10 o.IdCliente from (select IdOrdine, SUM((p.PrezzoNoIva+(p.PrezzoNoIva*22/100) - (p.PrezzoNoIva*d.ScontoApplicato/100))) as prezzo 
	from DettaglioOrdine d inner join Prodotto p on p.Id = d.IdProdotto group by IdOrdine) as tmp
	 inner join Ordine o on o.Id = tmp.IdOrdine group by o.IdCliente order by SUM(tmp.IdOrdine)

	END
GO