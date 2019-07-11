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
            int temp = 0, maxWidth = 0;
            foreach (Cliente c in c.SearchAllCliente())
            {
                cbxCliente.Items.Add(c);
                temp = TextRenderer.MeasureText(c.ToString(), cbxCliente.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            if (cbxCliente.Items.Count != 0)
            {
                cbxCliente.SelectedIndex = 0;
                cbxCliente.DropDownWidth = maxWidth;

            }
            temp = 0; maxWidth = 0;
            foreach (TipiPagamento t in c.SearchAllTipiPagamento())
            {
                cbxPagamento.Items.Add(t);

                temp = TextRenderer.MeasureText(t.ToString(), cbxPagamento.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            if (cbxPagamento.Items.Count != 0)
            {
                cbxPagamento.SelectedIndex = 0;
                cbxPagamento.DropDownWidth = maxWidth;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsToOrder n = new ProductsToOrder(this, _listaP);
            n.ShowDialog();
            if (n.DialogResult == DialogResult.OK)
            {
                _listaP = n._result;
            }
            txtShow.Text = "";
            foreach(KeyValuePair<Prodotto, int> k in _listaP)
            {
                txtShow.Text += k.Key + "Quantità: " + k.Value + "\r\n";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_listaP.Count == 0)
            {
                MessageBox.Show("Errore, non hai inserito prodotti.");
                return;
            }
            if (cbxCliente.SelectedItem==null || cbxPagamento.SelectedItem == null)
            {
                MessageBox.Show("Dati mancanti.");
                return;
            }
            Ordine o = new Ordine(1, "", (Cliente)cbxCliente.SelectedItem, dtpDate.Value,
                (TipiPagamento)cbxPagamento.SelectedItem, _listaP);
            int res = c.NewOrdine(o);
            if (res!=0)
            {
                MessageBox.Show("Ordine aggiunto!");
                cbxCliente.SelectedIndex = 0;
                dtpDate.Value = DateTime.Now;
                cbxPagamento.SelectedIndex = 0;
                _listaP = new Dictionary<Prodotto, int>();
                txtShow.Text = "";
            }
            else
            {
                MessageBox.Show("Errore, dati non validi.");
            }
        }
    }
}
