USE [Shop_Gregoricchio]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CheckForGiacenzaAmmessa] ON [Shop_Gregoricchio].[dbo].[DettaglioOrdine]
AFTER INSERT 
as 
BEGIN  
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if (select p.Giacenza from Prodotto p inner join inserted i on i.IdProdotto=p.Id where p.Id=i.IdProdotto)<(select i.Quantita from inserted i)
	ROLLBACK TRANSACTION;
	

RETURN
END;