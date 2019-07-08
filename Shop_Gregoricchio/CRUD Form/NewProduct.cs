﻿using Shop_Gregoricchio.Classes;
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
            foreach (Categoria c in ) //connData)
            {
                cbxCategoria.Items.Add(c);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtPrezzo.Text, out float price) || !float.TryParse(txtSconto.Text, out float sale)
                || !int.TryParse(txtGiacenza.Text, out int giacenza) || txtNome.Text == "")
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            }

            Prodotto p = new Prodotto(1, txtNome.Text, txtDescrizione.Text, (Categoria)cbxCategoria.SelectedItem,
                price, sale, giacenza);
            bool res = cc.NewProdotto(p);
            if (res) {
                MessageBox.Show("Prodotto aggiunto!");
            } else {
                MessageBox.Show("Prodotto non aggiunto!");
            }
        }
    }
}
