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
        Dictionary<Prodotto, int> dReceived = null;
        public Dictionary<Prodotto, int> _result { get; set; }

        CrudComp c = null;

        public ProductsToOrder(Form f, Dictionary<Prodotto, int> d1)
        {
            InitializeComponent();
            txtModProd.Enabled = true;
            cbxModProd.Enabled = true;
            btnModProd.Enabled = true;
            dReceived = d1;
            FillShowProd();
            c = new CrudComp();
            int temp = 0, maxWidth = 0;
            foreach (Prodotto p in c.SearchAllProdotto())
            {
                cbxNewProd.Items.Add(p);
                temp = TextRenderer.MeasureText(p.ToString(), cbxNewProd.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            cbxNewProd.DropDownWidth = maxWidth;
            if (cbxNewProd.Items.Count != 0)
            {
                cbxNewProd.SelectedIndex = 0;
            }
            FillCheckBox(cbxModProd, dReceived);

            FillCheckBox(cbxDelProd, dReceived);
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            Prodotto p = (Prodotto)cbxNewProd.SelectedItem;
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
            if (c.CheckGiacenza(p.Id, quantity))
            {
                MessageBox.Show("La giacenza non consente tale richiesta.");
                return;
            }
            if (dReceived.ContainsKey(p))
            {
                dReceived[p] = quantity;
            }
            else
            {
                dReceived.Add(p, quantity);
            }
            FillShowProd();
            FillCheckBox(cbxDelProd, dReceived);
            FillCheckBox(cbxModProd, dReceived);
        }

        private void btnModProd_Click(object sender, EventArgs e)
        {
            Prodotto p = (Prodotto)cbxModProd.SelectedItem;
            int quantity = 0;
            if (!int.TryParse(txtModProd.Text, out int q) || p == null)
            {
                MessageBox.Show("Quantità non valida.");
                return;
            }
            else
            {
                quantity = q;
            }
            if (c.CheckGiacenza(p.Id, quantity))
            {
                MessageBox.Show("La giacenza non consente tale richiesta.");
                return;
            }
            dReceived[p] = quantity;
            FillShowProd();
            FillCheckBox(cbxDelProd, dReceived);
            FillCheckBox(cbxModProd, dReceived);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cbxDelProd.Items.Count == 0)
            {
                return;
            }
            dReceived.Remove((Prodotto)cbxDelProd.SelectedItem);
            FillShowProd();
            FillCheckBox(cbxDelProd, dReceived);
            FillCheckBox(cbxModProd, dReceived);
        }

        private void FillCheckBox(ComboBox c, Dictionary<Prodotto, int> d)
        {
            c.Items.Clear();
            foreach (KeyValuePair<Prodotto, int> k in d)
            {
                c.Items.Add(k.Key);
            }
            if (d.Count != 0)
            {
                c.SelectedIndex = 0;
            }
        }

        private void FillShowProd()
        {
            textBox1.Text = "";
            foreach (KeyValuePair<Prodotto, int> k in dReceived)
            {
                textBox1.Text += k.Key + "Quantità:" + k.Value + "\r\n";
            }
        }

        private void ProductsToOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dReceived.Count == 0 || dReceived == null)
            {
                MessageBox.Show("Dati non validabili.");
                e.Cancel = true;
                return;
            }
            _result = dReceived;
            DialogResult = DialogResult.OK;

        }
    }
}
