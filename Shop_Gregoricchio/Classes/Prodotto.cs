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

        public float PrezzoIvato()
        {
            return (_prezzo + (_prezzo * 22 / 100));
        }

        public override string ToString()
        {
            return "Prodotto: ID - " + _id + ", Nome - " + _denominazione + ", Descrizione - " + _descrizione
                + ", " + _categoria.ToString() + "Prezzo - " + _prezzo + ", Sconto - " + _sconto + ", Giacenza - " + _giacenza +"\r\n"; 
        }

        public override bool Equals(object obj)
        {
            var prodotto = obj as Prodotto;
            return prodotto != null &&
                   _id == prodotto._id &&
                   Id == prodotto.Id &&
                   _denominazione == prodotto._denominazione &&
                   Denominazione == prodotto.Denominazione &&
                   _descrizione == prodotto._descrizione &&
                   Descrizione == prodotto.Descrizione &&
                   EqualityComparer<Categoria>.Default.Equals(_categoria, prodotto._categoria) &&
                   EqualityComparer<Categoria>.Default.Equals(Categoria, prodotto.Categoria) &&
                   _prezzo == prodotto._prezzo &&
                   Prezzo == prodotto.Prezzo &&
                   _sconto == prodotto._sconto &&
                   Sconto == prodotto.Sconto &&
                   _giacenza == prodotto._giacenza &&
                   Giacenza == prodotto.Giacenza;
        }
    }
}
