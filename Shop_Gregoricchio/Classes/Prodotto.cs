using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.Classes
{
    class Prodotto
    {
        public Prodotto(int id, string denom, string descrip, Categoria idCat, float price, float sconto, int giacenza)
        {
            _id = id;
            _denominazione = denom;
            _descrizione = descrip;
            _categoria = idCat;
            _prezzo = price;
            _sconto = sconto;
            _giacenza = giacenza;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _denominazione;

        public string Denominazione
        {
            get { return _denominazione; }
            set { _denominazione = value; }
        }

        private string _descrizione;

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private float _prezzo;

        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        private float _sconto;

        public float Sconto
        {
            get { return _sconto; }
            set { _sconto = value; }
        }

        private int _giacenza;

        public int Giacenza
        {
            get { return _giacenza; }
            set { _giacenza = value; }
        }
    }
}
