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
        CrudComp c = null;
        public DelProduct()
        {
            InitializeComponent();
            c = new CrudComp();
            // db connection
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            }
            Prodotto p = c.SearchProdotto(id);
            if (p == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtNome.Text = p.Denominazione;
                txtDescrizione.Text = p.Descrizione;
                cbxCategoria.SelectedItem = p.Categoria;
                txtPrezzo.Text = "" + p.Prezzo;
                txtSconto.Text = "" + p.Sconto;
                txtGiacenza.Text = "" + p.Giacenza;
                btnSend.Enabled = true;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id) || !float.TryParse(txtPrezzo.Text, out float price)
                || !float.TryParse(txtSconto.Text, out float sale) || !int.TryParse(txtGiacenza.Text, out int giacenza))
            {
                MessageBox.Show("Errore, dati non valido.");
                return;
            }
            Prodotto p = new Prodotto(id, txtNome.Text, txtDescrizione.Text, (Categoria)cbxCategoria.SelectedItem,
                price, sale, giacenza);
            bool res = c.DelProdotto(p);
            if (res)
            {
                MessageBox.Show("Prodotto modificato!");
            }
            else
            {
                MessageBox.Show("Prodotto non modificato!");
            }
        }
    }
}
