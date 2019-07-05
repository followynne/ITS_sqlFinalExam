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
    public partial class UpdProduct : Form
    {
        CrudComp cc = null;
        public UpdProduct()
        {
            InitializeComponent();
            cc = new CrudComp();
            //connection + insert all category plus select predefined the one existing
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
            bool res = cc.UpdProdotto(p);
            if (res)
            {
                MessageBox.Show("Prodotto modificato!");
            }
            else
            {
                MessageBox.Show("Prodotto non modificato!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            }
            Prodotto p = cc.SearchProdotto(id);
            if (p == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtId.Enabled = false;
                txtNome.Text = p.Denominazione;
                txtNome.Enabled = true;
                txtDescrizione.Text = p.Descrizione;
                txtDescrizione.Enabled = true;
                cbxCategoria.SelectedItem = p.Categoria;
                cbxCategoria.Enabled = true;
                txtPrezzo.Text = "" + p.Prezzo;
                txtPrezzo.Enabled = true;
                txtSconto.Text = "" + p.Sconto;
                txtSconto.Enabled = true;
                txtGiacenza.Text = "" + p.Giacenza;
                txtGiacenza.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNome.Text = "";
            txtNome.Enabled = false;
            txtDescrizione.Text = "";
            txtDescrizione.Enabled = false;
            cbxCategoria.SelectedItem = "";
            cbxCategoria.Enabled = false;
            txtPrezzo.Text = "";
            txtPrezzo.Enabled = false;
            txtSconto.Text = "";
            txtSconto.Enabled = false;
            txtGiacenza.Text = "";
            txtGiacenza.Enabled = true;
        }
        
    }
}
