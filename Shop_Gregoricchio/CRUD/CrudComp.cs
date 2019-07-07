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
            bool result = false;
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return result;
        }
        public bool NewOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool NewCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
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
            return true;
        }
        public bool UpdOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql isert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelProdotto(Prodotto p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelCategoria(Categoria p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql isert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public Prodotto SearchProdotto(int id)
        {

        }
        public Categoria SearchCategoria(int id)
        {

        }
        public Ordine SearchOrdine(int id)
        {

        }
        public Cliente SearchCliente(int id)
        {

        }
        public string SearchAll(string s)
        {
            return "";
        }
        public string SearchbyId(string s, int id)
        {
            return "";
        }
        public bool CheckGiacenza(int id)
        {
            return false;
        }
    }
}
