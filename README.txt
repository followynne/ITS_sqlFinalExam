Nella Cartella ITS_sqlFinalExam sono presenti:
- la soluzione in c# dell'applicativo per lo shop.
- una cartella "Sql Data", nel quale sono contenuti script e backup per database e query del database.

Dentro la cartella ".\SQL Data", sono salvati:

- 2 file sql contenenti 2 trigger (vedi spiegazione sotto)
- 1 file sql con le Stored Procedure richieste da esame
- 1 file sql per il ripristino del db via codice
- 1 file .bak contenente un backup completo del database
- Il modello E-R del database, in pdf

NB: Nel caso il ripristino via .bak non permetta di aprire il diagramma database, vedasi istruzioni in "SQLData\Err15517_Impossibile accedere al DiagrammaDatabase.txt"

---------CONNESSIONE AL DATABASE-----------

I dati di connessione al database sono contenuti nella classe ".\Shop_Gregoricchio\CRUD\DBConnection.cs", nella soluzione c#. 
Per connettersi al database da casa, modificare il campo .DataSource con l'indirizzo del proprio server personale.
L'errore di connessione è catchato nel caso siano errati i dati indicati in connessione. In caso di errore, l'utente riceve un messaggio di errore ma non può interagire in alcun modo con l'applicativo.

L'utente di accesso predefinito ha le seguenti credenziali
ITS_IBS
!Its-2019


---------MODIFICHE RISPETTO AL DB ORIGINALE--------------

1. Rispetto al progetto originale, ho aggiunto alla tabella Dettaglio Ordine un attributo ScontoApplicato. Serve a memorizzare, per ogni prodotto dell'ordine, lo sconto che era stato applicato al momento dell'acquisto.
È un elemento ridondante ma che è utile per salvare l'elemento temporale legato allo sconto per recuperi futuri della fattura dell'ordine.
(ex: c'è uno sconto base indicato per ogni prodotto, modificabile a seconda dell'offerta in corso. Se viene modificato e si esegue la stored procedure per recuperare la fattura di un ordine precedente (con sconti differenti), il totale sarà errato rispetto al prezzo pagato al momento dell'acquisto. Salvando il riferimento dello sconto nel dettaglio ordine, si risale direttamente allo sconto che era attivo al momento dell'ordine.)

Tale aggiunta è gestita in automatico dal database, ossia l'utente non deve inserire manualmente lo sconto per ogni prodotto scelto. Tramite l'uso di un trigger, alla conferma di un ordine viene copiato lo sconto attivo per il Prodotto X nel campo corrispondente del Dettaglio Ordine.
EX: Azienda 1 acquista Prodotto id 1. Il Prodotto id 1 ha lo sconto attivo del 20%. Nel dettaglio Ordine verrà indicato IdAzienda 1, IdProdotto 1, Quantità desiderata, ScontoApplicato. Quest'ultimo campo verrà copiato automaticamente dal campo Sconto presente per il Prodotto id 1. In futuro il totale della fattura verrà ricreata riferendosi allo ScontoApplicato, non al campo Sconto di Prodotto (che potrebbe essere mutato da allora).

2. L'iva viene calcolata in base a 3 possibili valori: 4, 10, 22 %. L'iva è collegata alla categoria - in questo modo ogni prodotto avrà la sua iva a seconda della categoria di appartenenza. L'iva nell'attributo in database è di Default al 22, nell'applicativo la scelta è ristretta manualmente tramite combobox a scelte predefinite.

------------CALCOLO DELLA FATTURA FINALE (COSTO COMPLESSIVO ORDINE) e DEL CODICE ORDINE--------
Il calcolo è stato eseguito come:
La somma del costo di ogni singolo prodotto ordinato, fatta come segue:

(((PrezzoProdotto + IvaProdotto) - ((PrezzoProdotto+IvaProdotto)*ScontoApplicatoinFloat/100))*QuantitàProdottoOrdinato

Il Codice Ordine è stato calcolato come un alfanumerico (A-Z0-9) calcolato randomicamente di 8 cifre, unico e non ripetibile.

-----------FUNZIONE TRIGGER E S.Procedure-----------

I trigger servono ad eseguire i seguenti controlli:
- trigger_CheckForPaymentNotActive: controlla che ,se viene scelto un pagamento non attivo per un ordine, la transazione non avvenga. L'utente da applicativo può scegliere un pagamento non attivo ma la transazione non verrà completata, restituendogli errore.

- trigger_ValidateInsertInDettaglioOrdine: fa 3 controlli sull'inserimento di un prodotto per l'ordine, ossia 1. controlla che la giacenza del Prodotto sia maggiore della Quantità richiesta (altrimenti annulla la transazione); 2. se la quantità è valida, aggiorna la giacenza in magazzino del Prodotto (Prodotto.giacenza - DettaglioProdotto.Quantità); 3. se la quantità è valida, copia il valore di sconto presente in Prodotto nell'attributo ScontoApplicato.

Per visualizzare tutti i trigger:
select * from Shop_Gregoricchio.sys.triggers

La spiegazione delle StoredProcedure è presente come commento nel file .sql delle Stored Procedures.


---------------ADDENDUM----------

Per eventuali problemi, questioni, dubbi etc., scrivere a matteo.gregoricchio at edu.itspiemonte.it
Il codice è disponibile anche su https://github.com/followynne/ITS_sqlFinalExam