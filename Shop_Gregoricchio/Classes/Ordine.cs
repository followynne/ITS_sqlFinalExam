using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.Classes
{
    class Ordine
    {
        public Ordine(int id, string codiceOrdine, Cliente cliente, DateTime data,
            TipiPagamento tp, Dictionary<Prodotto, int> listaProdotti )
        {
            _id = id;
            _codiceordine = codiceOrdine;
            _cliente = cliente;
            _data = data;
            _tipopagamento = tp;
            _listaprodotti = listaProdotti;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _codiceordine;

        public string CodiceOrdine
        {
            get { return _codiceordine; }
            set { _codiceordine = value; }
        }
        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private TipiPagamento _tipopagamento;

        public TipiPagamento TipoPagamento
        {
            get { return _tipopagamento; }
            set { _tipopagamento = value; }
        }
        private Dictionary<Prodotto, int> _listaprodotti;

        public Dictionary<Prodotto, int> ListaProdotti
        {
            get { return _listaprodotti; }
            set { _listaprodotti = value; }
        }



    }
}
