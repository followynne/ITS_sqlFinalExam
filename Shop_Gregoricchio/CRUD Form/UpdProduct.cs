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
            int.TryParse(txtId.Text, out int id);
            float.TryParse(txtPrezzo.Text, out float price);
            float.TryParse(txtSconto.Text, out float sale);
            int.TryParse(txtGiacenza.Text, out int giacenza);
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
            int.TryParse(txtId.Text, out int id);
            if (cc.SearchProdotto(id) == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            Prodotto p = cc.SearchProdotto(id);
            txtNome.Text = p.Denominazione;
            txtDescrizione.Text = p.Descrizione;
            cbxCategoria.SelectedItem = p.Categoria;
            txtPrezzo.Text = ""+p.Prezzo;
            txtSconto.Text = ""+p.Sconto;
            txtGiacenza.Text = ""+p.Giacenza;

        }
    }
}
