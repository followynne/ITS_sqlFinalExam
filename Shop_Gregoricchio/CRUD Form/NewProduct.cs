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
    public partial class NewProduct : Form
    {
        CrudComp cc = null;
        public NewProduct()
        {
            InitializeComponent();
            cc = new CrudComp();
            int temp = 0, maxWidth = 0;
            foreach (Categoria c in cc.SearchAllCategoria())
            {
                cbxCategoria.Items.Add(c);

                temp = TextRenderer.MeasureText(c.ToString(), cbxCategoria.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            if (cbxCategoria.Items.Count != 0)
            {
                cbxCategoria.SelectedIndex = 0;
                cbxCategoria.DropDownWidth = maxWidth;
            }
            txtSconto.Text = "0";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            if (!float.TryParse(txtPrezzo.Text, out float price) || !float.TryParse(txtSconto.Text, out float sale)
                || !int.TryParse(txtGiacenza.Text, out int giacenza) || txtNome.Text == "" || cbxCategoria.SelectedItem == null
                || txtPrezzo.Text.Contains('.') || txtSconto.Text.Contains('.'))
            {
                MessageBox.Show("Errore, dati non valido.");
                return;
            }

            Prodotto p = new Prodotto(1, txtNome.Text, txtDescrizione.Text, (Categoria)cbxCategoria.SelectedItem,
                price, sale, giacenza);
            int res = cc.NewProdotto(p);
            if (res != 0)
            {
                MessageBox.Show("Prodotto aggiunto!");
                txtNome.Text = "";
                txtDescrizione.Text = "";
                cbxCategoria.SelectedIndex = 0;
                txtPrezzo.Text = "";
                txtSconto.Text = "";
                txtGiacenza.Text = "";
            }
            else
            {
                MessageBox.Show("Prodotto non aggiunto. Errore nei dati.");
            }
        }
    }
}
