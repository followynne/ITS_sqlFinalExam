using Shop_Gregoricchio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.CRUD
{
    class CrudComp
    {
        // dbAccess = null

        public bool NewProdotto(Prodotto p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            //se il dato è inserito (query pos) true altrimenti...
            return true;
        }
        public bool NewCategoria(Categoria p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public bool NewOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public bool NewCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public bool UpdProdotto(Prodotto p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdCategoria(Categoria p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public bool UpdOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public bool UpdCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
        }
        public Prodotto SearchProdotto(int id)
        {
            return new Prodotto();
        }
    }
}
