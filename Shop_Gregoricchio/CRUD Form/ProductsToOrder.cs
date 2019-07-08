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
    internal partial class ProductsToOrder : Form
    {
        Dictionary<Prodotto, int> d = null;
        Dictionary<Prodotto, int> dReceived = null;
        public Dictionary<Prodotto, int> _result { get; set; }

        CrudComp c = null;

        public ProductsToOrder()
        {
            InitializeComponent();
            c = new CrudComp();
            d = new Dictionary<Prodotto, int>();
            //chiamata db e recupero all elements
            foreach(Prodotto p in calldb)
            {
                cbxNewProd.Items.Add(p);
            }

        }

        public ProductsToOrder(Form f, Dictionary<Prodotto, int> d1)
        {
            InitializeComponent();
            txtModProd.Enabled = true;
            cbxModProd.Enabled = true;
            btnModProd.Enabled = true;
            dReceived = d1;
            c = new CrudComp();
            //chiamata db e recupero all elements prodotto
            foreach (Prodotto p in calldb)
            {
                cbxNewProd.Items.Add(p);
            }
            FillCheckBox(cbxModProd, dReceived);

            FillCheckBox(cbxDelProd, dReceived);
        }

        private void ProductsToOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            _result = dReceived;
            if (_result.Count == 0)
            {
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            Prodotto p = (Prodotto)cbxNewProd.SelectedItem;
            int quantity = 0;
            if (int.TryParse(txtNewProd.Text, out int q))
            {
                quantity = q;
            } else
            {
                MessageBox.Show("Quantità non valida.");
                return;
            }
            if (!c.CheckGiacenza(p.Id))
            {
                MessageBox.Show("La giacenza non consente tale richiesta.");
                return;
            }
            if (dReceived.ContainsKey(p))
            {
                dReceived[p] = quantity;
            } else
            {
                dReceived.Add(p, quantity);
            }
            textBox1.Text = "";
            foreach(KeyValuePair<Prodotto, int> k in dReceived)
            {
                textBox1.Text += k.Key + " - " + k.Value + "\r\n";
            }
            FillCheckBox(cbxDelProd, dReceived);
        }

        private void btnModProd_Click(object sender, EventArgs e)
        {
            Prodotto p = (Prodotto)cbxModProd.SelectedItem;
            int quantity = 0;
            if (int.TryParse(txtNewProd.Text, out int q))
            {
                quantity = q;
            }
            else
            {
                MessageBox.Show("Quantità non valida.");
                return;
            }
            if (!c.CheckGiacenza(p.Id))
            {
                MessageBox.Show("La giacenza non consente tale richiesta.");
                return;
            }
            dReceived[p] = quantity;
            textBox1.Text = "";
            foreach (KeyValuePair<Prodotto, int> k in dReceived)
            {
                textBox1.Text += k.Key + " - " + k.Value + "\r\n";
            }
            FillCheckBox(cbxDelProd, dReceived);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dReceived.Remove((Prodotto)cbxDelProd.SelectedItem);
        }

        private void FillCheckBox(ComboBox c, Dictionary<Prodotto, int> d)
        {
            foreach (KeyValuePair<Prodotto, int> k in d)
            {
                c.Items.Add(k.Value);
            }
        }
    }
}
