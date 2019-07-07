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
    public partial class DelOrder : Form
    {
        private CrudComp c = null;
        private Dictionary<Prodotto, int> _listaP = null;

        public DelOrder()
        {
            InitializeComponent();
            c = new CrudComp();
            _listaP = new Dictionary<Prodotto, int>();
            // codice per caricare tutti i clienti
            // codice per tirare fuori i tipi di pagamento
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            }
            Ordine order = c.SearchOrdine(id);
            if (order == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtId.Enabled = false;
                txtCodOrdine.Text = order.CodiceOrdine;
                txtCodOrdine.Enabled = true;
                cbxCliente.SelectedItem = order.Cliente;
                cbxCliente.Enabled = true;
                dtpDate.Value = order.Data;
                dtpDate.Enabled = true;
                cbxPagamento.SelectedItem = order.TipoPagamento;
                cbxPagamento.Enabled = true;
                _listaP = order.ListaProdotti;
                textBox1.Text = "";
                foreach (KeyValuePair<Prodotto, int> k in _listaP)
                {
                    textBox1.Text += k.Key + " - " + k.Value + "\r\n";
                }
                btnSend.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Ordine order = new Ordine(int.Parse(txtId.Text), txtCodOrdine.Text, (Cliente)cbxCliente.SelectedItem, dtpDate.Value, (TipiPagamento)cbxPagamento.SelectedItem, _listaP);
            bool res = c.DelOrdine(order);
            if (res)
            {
                MessageBox.Show("Cliente eliminato!");
            }
            else
            {
                MessageBox.Show("Cliente non eliminato!");
            }
        }
    }
}
