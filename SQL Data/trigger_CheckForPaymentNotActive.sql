CREATE TRIGGER CheckForPaymentNotActive ON Shop_Gregoricchio.[dbo].[Ordine]
AFTER INSERT, update 
as 
BEGIN  

IF (SELECT t.Attivo from TipiPagamento as t  inner join INSERTED as i on t.Id= i.TipoPagamento) = 0

ROLLBACK TRANSACTION;  
RETURN
END;
GO 
