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

        public float TotaleIvato()
        {
            float total = 0.0f;
            foreach(KeyValuePair<Prodotto, int> p in _listaprodotti)
            {
                total += p.Value * p.Key.PrezzoIvato();
            }
            return total;
        }

        public override string ToString()
        {
            string fattura = "Categoria: ID - " + _id + ", Codice - " + _codiceordine + ", " + _cliente.ToString()
                + "Data - " + _data + ", " + _tipopagamento.ToString() + ", Prodotti:\r\n";
            foreach(KeyValuePair<Prodotto, int> p in _listaprodotti)
            {
                fattura += p.Key.Denominazione + " - prezzo (iva inclusa): " + p.Key.Prezzo + " - quantità" + p.Value + "\r\n";
            }
            return fattura += "Totale con Iva: " + TotaleIvato() + "\r\nTotale Scontato: " + "";
        }

        public override bool Equals(object obj)
        {
            var ordine = obj as Ordine;
            return ordine != null &&
                   _id == ordine._id &&
                   Id == ordine.Id &&
                   _codiceordine == ordine._codiceordine &&
                   CodiceOrdine == ordine.CodiceOrdine &&
                   EqualityComparer<Cliente>.Default.Equals(_cliente, ordine._cliente) &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, ordine.Cliente) &&
                   _data == ordine._data &&
                   Data == ordine.Data &&
                   EqualityComparer<TipiPagamento>.Default.Equals(_tipopagamento, ordine._tipopagamento) &&
                   EqualityComparer<TipiPagamento>.Default.Equals(TipoPagamento, ordine.TipoPagamento) &&
                   EqualityComparer<Dictionary<Prodotto, int>>.Default.Equals(_listaprodotti, ordine._listaprodotti) &&
                   EqualityComparer<Dictionary<Prodotto, int>>.Default.Equals(ListaProdotti, ordine.ListaProdotti);
        }
    }
}
