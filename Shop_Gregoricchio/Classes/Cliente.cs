using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.Classes
{
    class Cliente
    {
        public Cliente(int id, string piva, string cf, string ragionesociale, string nome,
            string cognome, string via, string city, int cap, string pv, string telefono,
            string fax, string cellphone, string mail, string sito)
        {
            _id = id;
            _piva = piva;
            _codFiscale = cf;
            _ragioneSociale = ragionesociale;
            _nome = nome;
            _cognome = cognome;
            _via = via;
            _città = city;
            _cap = cap;
            _pv = pv;
            _telefono = telefono;
            _fax = fax;
            _cellulare = cellphone;
            _mail = mail;
            _sitoWeb = sito;
        }
        private int _id;
            
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _piva;

        public string PartitaIva
        {
            get { return _piva; }
            set { _piva = value; }
        }
        private string _codFiscale;

        public string CodiceFiscale
        {
            get { return _codFiscale; }
            set { _codFiscale = value; }
        }
        private string _ragioneSociale;

        public string RagioneSociale
        {
            get { return _ragioneSociale; }
            set { _ragioneSociale = value; }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _cognome;

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        private string _via;

        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }
        private string _città;

        public string Città
        {
            get { return _città; }
            set { _città = value; }
        }
        private int _cap;

        public int Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }
        private string _pv;

        public string PV
        {
            get { return _pv; }
            set { _pv = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _cellulare;

        public string Cellulare
        {
            get { return _cellulare; }
            set { _cellulare = value; }
        }
        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        private string _sitoWeb;

        public string SitoWeb
        {
            get { return _sitoWeb; }
            set { _sitoWeb = value; }
        }

        public override string ToString()
        {
            return "Cliente: ID -  " + _id + ", P.Iva - " + _piva + ", C.Fiscale - " + _codFiscale 
                + ", Rag. Sociale - " + _ragioneSociale + ", Nome - " + _nome + ", Cognome - " + _cognome
                + ", Via - " + _via + ", Città - " + _città + ", CAP - " + _cap + ", PV - " + _pv 
                + ", Telefono - " + _telefono + ", Cellulare - " + _cellulare
                + ", Fax - " + _fax + ", Mail - " + _mail + ", Sito Web - " + _sitoWeb + ".\r\n";
        }
    }
}
