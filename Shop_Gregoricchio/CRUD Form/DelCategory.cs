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
    public partial class DelCategory : Form
    {
        CrudComp c = null;
        int id = 0;

        public DelCategory()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            };
            Categoria cat = c.SearchCategoria(id);
            if (cat == null)
            {
                MessageBox.Show("Errore, dato non recuperato.");
            }
            else
            {
                txtNome.Text = cat.Denominazione;
                txtDescrizione.Text = cat.Descrizione;
                btnSend.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string description = txtDescrizione.Text;
            if (!int.TryParse(txtId.Text, out int id2) || (id2!= id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            };
            Categoria cat = new Categoria(id, name, description);
            bool result = c.DelCategoria(cat);
            if (!result)
            {
                MessageBox.Show("Nuova categoria inserita!");
            }
            else
            {
                MessageBox.Show("Errore, dato non inserito.");
            }
        }
    }
}
