using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.Classes
{
    class TipiPagamento
    {
        public TipiPagamento(int id, string denom, bool attivo)
        {
            _id = id;
            _denominazione = denom;
            _attivo = attivo;
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

        private bool _attivo;

        public bool Attivo
        {
            get { return _attivo; }
            set { _attivo = value; }
        }
    }
}
