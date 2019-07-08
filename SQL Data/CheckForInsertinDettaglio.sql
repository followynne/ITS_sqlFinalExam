USE [Shop_Gregoricchio]
GO
/****** Object:  Trigger [dbo].[CopyScontotoScontoApplicato]    Script Date: 08/07/2019 16:12:16 ******/
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

	
	if (select p.Giacenza from Prodotto p inner join inserted i on i.IdProdotto=p.Id
	where p.Id=i.IdProdotto)<(select i.Quantita from inserted i)
	ROLLBACK TRANSACTION;

	update Prodotto set Prodotto.Giacenza -= (select inserted.Quantita from inserted where Prodotto.Id=inserted.IdProdotto)

	update DettaglioOrdine set DettaglioOrdine.ScontoApplicato = (select Prodotto.Sconto from Prodotto
	inner join inserted i on Prodotto.Id = i.IdProdotto) where DettaglioOrdine.IdProdotto =
	(select inserted.IdProdotto from inserted)

RETURN
END;