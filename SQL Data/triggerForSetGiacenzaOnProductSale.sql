USE [Shop_Gregoricchio]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[SetGiacenzaBasedOnProductSale] ON [Shop_Gregoricchio].[dbo].[DettaglioOrdine]
AFTER INSERT 
as 
BEGIN  
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update Prodotto set Prodotto.Giacenza -= (select inserted.Quantita from inserted where Prodotto.Id=inserted.IdProdotto)

	

RETURN
END;