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
        private int id;

        public DelOrder()
        {
            InitializeComponent();
            c = new CrudComp();
            _listaP = new Dictionary<Prodotto, int>();
            foreach (Cliente c in c.SearchAllCliente())
            {
                cbxCliente.Items.Add(c);
            }
            if (cbxCliente.Items.Count != 0)
            {
                cbxCliente.SelectedIndex = 0;
            }
            foreach (TipiPagamento t in c.SearchAllTipiPagamento())
            {
                cbxPagamento.Items.Add(t);
            }
            if (cbxPagamento.Items.Count != 0)
            {
                cbxPagamento.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out id))
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
                txtCodOrdine.Text = order.CodiceOrdine;
                cbxCliente.SelectedItem = order.Cliente;
                dtpDate.Value = order.Data;
                cbxPagamento.SelectedItem = order.TipoPagamento;
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
            if (!int.TryParse(txtId.Text, out int id2) || (id2 != id))
            {
                MessageBox.Show("Id non valido.");
                return;
            }
            Ordine order = new Ordine(int.Parse(txtId.Text), txtCodOrdine.Text, (Cliente)cbxCliente.SelectedItem, dtpDate.Value, (TipiPagamento)cbxPagamento.SelectedItem, _listaP);
            int res = c.DelOrdine(order);
            if (res!=0)
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
