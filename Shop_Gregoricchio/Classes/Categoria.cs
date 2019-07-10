using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.Classes
{
    class Categoria
    {
        public Categoria(int id, string denom, string descrip)
        {
            _id = id;
            _denominazione = denom;
            _descrizione = descrip;
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



        public override string ToString()
        {
            return "Categoria: " + _id + ", " + _denominazione + ", " + _descrizione + ".\r\n";
        }

        public override bool Equals(object obj)
        {
            var categoria = obj as Categoria;
            return categoria != null &&
                   _id == categoria._id &&
                   Id == categoria.Id &&
                   _denominazione == categoria._denominazione &&
                   Denominazione == categoria.Denominazione &&
                   _descrizione == categoria._descrizione &&
                   Descrizione == categoria.Descrizione;
        }
    }
}
