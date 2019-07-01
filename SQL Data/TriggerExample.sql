CREATE TRIGGER CheckForPaymentNotActive ON [11_Gregoricchio_EsameFinaleDB].[dbo].[Ordine]
AFTER INSERT, update 
as 
BEGIN  

--IF (SELECT * from INSERTED as i inner join TipiPagamento as t on t.Id= i.TipoPagamento where t.Attivo = 0) 
IF (SELECT t.Attivo from TipiPagamento as t  inner join INSERTED as i on t.Id= i.TipoPagamento) = 0

ROLLBACK TRANSACTION;  
RETURN
END;
GO  


select * from [11_Gregoricchio_EsameFinaleDB].sys.triggers
