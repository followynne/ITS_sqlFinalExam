USE [Shop_Gregoricchio]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CopyScontotoScontoApplicato] ON [Shop_Gregoricchio].[dbo].[DettaglioOrdine]
FOR INSERT 
as 
BEGIN  
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update DettaglioOrdine set DettaglioOrdine.ScontoApplicato = (select Prodotto.Sconto from Prodotto
	inner join inserted i on Prodotto.Id = i.IdProdotto) where DettaglioOrdine.IdProdotto =
	(select inserted.IdProdotto from inserted)

RETURN
END;