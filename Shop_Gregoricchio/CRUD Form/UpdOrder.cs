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

    public partial class UpdOrder : Form
    {
        private CrudComp c = null;
        private Dictionary<Prodotto, int> _listaP = null;

        public UpdOrder()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsToOrder p = new ProductsToOrder(this, _listaP);
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK)
            {
                _listaP = p._result;
            }
            textBox1.Text = "";
            foreach (KeyValuePair<Prodotto, int> k in _listaP)
            {
                textBox1.Text += k.Key + "Quantità: " + k.Value + "\r\n";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, id non valido.");
                return;
            }
            Ordine order = c.SearchOrdinebyId(id);
            if (order == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtId.Enabled = false;
                txtCodOrdine.Text = order.CodiceOrdine;
                cbxCliente.SelectedItem = order.Cliente;
                cbxCliente.Enabled = true;
                dtpDate.Value = order.Data;
                dtpDate.Enabled = true;
                cbxPagamento.SelectedItem = order.TipoPagamento;
                cbxPagamento.Enabled = true;
                button1.Enabled = true;
                _listaP = order.ListaProdotti;
                textBox1.Text = "";
                foreach (KeyValuePair<Prodotto, int> k in _listaP)
                {
                    textBox1.Text += k.Key + "Quantità: " + k.Value + "\r\n";
                }
                btnSend.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtId.Text = "";
            txtCodOrdine.Text = "";
            cbxCliente.SelectedItem = "";
            cbxCliente.Enabled = false;
            dtpDate.Value = DateTime.Now;
            dtpDate.Enabled = false;
            cbxPagamento.SelectedItem = "";
            cbxPagamento.Enabled = false;
            button1.Enabled = false;
            _listaP = null;
            textBox1.Text = "";
            btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_listaP.Count == 0)
            {
                MessageBox.Show("Errore, non hai inserito prodotti.");
                return;
            }
            Ordine order = new Ordine(int.Parse(txtId.Text), txtCodOrdine.Text, (Cliente)cbxCliente.SelectedItem, dtpDate.Value, (TipiPagamento)cbxPagamento.SelectedItem, _listaP);
            int res = c.UpdOrdine(order);
            if (res!=0)
            {
                MessageBox.Show("Ordine aggiornato!");
            }
            else
            {
                MessageBox.Show("Ordine non aggiornato, controlla per favore i dati.");
            }
        }
    }
}
