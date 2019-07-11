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
    public partial class DelProduct : Form
    {
        private CrudComp c = null;
        private int idd;

        public DelProduct()
        {
            InitializeComponent();
            c = new CrudComp();
            idd = 0;
            List<Categoria> l = c.SearchAllCategoria();
            int temp = 0, maxWidth = 0;
            foreach (Categoria cat in l)
            {
                cbxCategoria.Items.Add(cat);

                temp = TextRenderer.MeasureText(cat.ToString(), cbxCategoria.Font).Width;
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out idd))
            {
                MessageBox.Show("Errore, id non valido.");
                return;
            }
            Prodotto p = c.SearchProdotto(idd);
            if (p == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtNome.Text = p.Denominazione;
                txtDescrizione.Text = p.Descrizione;
                foreach (Categoria c in cbxCategoria.Items)
                {
                    if (c.Equals(p.Categoria))
                    {
                        cbxCategoria.SelectedItem = c;
                    }
                }
                txtPrezzo.Text = "" + p.Prezzo;
                txtSconto.Text = "" + p.Sconto;
                txtGiacenza.Text = "" + p.Giacenza;
                btnSend.Enabled = true;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id2) || (idd!=id2))
            {
                MessageBox.Show("Errore, id modificato rispetto alla search, non valido.");
                return;
            }
            if (!int.TryParse(txtId.Text, out int id) || !float.TryParse(txtPrezzo.Text, out float price)
                || !float.TryParse(txtSconto.Text, out float sale) || !int.TryParse(txtGiacenza.Text, out int giacenza))
            {
                MessageBox.Show("Errore, dati non validi.");
                return;
            }
            Prodotto p = new Prodotto(id, txtNome.Text, txtDescrizione.Text, (Categoria)cbxCategoria.SelectedItem,
                price, sale, giacenza);
            int res = c.DelProdotto(p);
            if (res!=0)
            {
                MessageBox.Show("Prodotto eliminato!");
            }
            else
            {
                MessageBox.Show("Errore, prodotto non cancellata. Vincolo di integrità referenziale attivo.");
            }
        }
    }
}
