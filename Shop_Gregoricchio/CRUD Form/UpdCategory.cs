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
    public partial class UpdCategory : Form
    {
        CrudComp c = null;

        public UpdCategory()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string description = txtDescrizione.Text;
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, id non valido.");
                return;
            }
            if (name == "")
            {
                MessageBox.Show("Errore, nome non inserito.");
                return;
            }
            Categoria cat = new Categoria(id, name, description);
            int result = c.UpdCategoria(cat);
            if (result!= 0)
            {
                MessageBox.Show("Categoria aggiornata!");
            }
            else
            {
                MessageBox.Show("Errore, categoria non inserita.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, id non valido.");
                return;
            };
            Categoria cat = c.SearchCategoria(id);
            if (cat == null)
            {
                MessageBox.Show("Errore, dato non recuperato.");
            } else
            {
                txtNome.Text = cat.Denominazione;
                txtDescrizione.Text = cat.Descrizione;
                txtNome.Enabled = true;
                txtDescrizione.Enabled = true;
                txtId.Enabled = false;
                btnSend.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescrizione.Text = "";
            txtId.Text = "";
            txtNome.Enabled = false;
            txtDescrizione.Enabled = false;
            txtId.Enabled = true;
            btnSend.Enabled = false;
        }
    }
}
