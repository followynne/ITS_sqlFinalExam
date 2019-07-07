using Shop_Gregoricchio.Classes;
using Shop_Gregoricchio.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Gregoricchio.CRUD_Form
{
    public partial class NewOrder : Form
    {
        private CrudComp c = null;
        private Dictionary<Prodotto, int> _listaP = null;

        public NewOrder()
        {
            InitializeComponent();
            c = new CrudComp();
            _listaP = new Dictionary<Prodotto, int>();
            // codice per caricare tutti i clienti
            // codice per tirare fuori i tipi di pagamento
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsToOrder n = new ProductsToOrder();
            n.ShowDialog();
            if (n.DialogResult == DialogResult.OK)
            {
                _listaP = n._result;
            }
            foreach(KeyValuePair<Prodotto, int> k in _listaP)
            {
                txtShow.Text += k.Key + " - " + k.Value + "\r\n";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Ordine o = new Ordine(1, "", (Cliente)cbxCliente.SelectedItem, dtpDate.Value,
                (TipiPagamento)cbxPagamento.SelectedItem, _listaP);
            bool res = c.NewOrdine(o);
            if (res)
            {
                MessageBox.Show("Ordine aggiunto!");
            }
            else
            {
                MessageBox.Show("Errore, dati non validi.");
            }
        }
    }
}
