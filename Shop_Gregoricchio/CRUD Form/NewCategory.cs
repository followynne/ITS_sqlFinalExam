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
    public partial class NewCategory : Form
    {
        CrudComp c = null;

        public NewCategory()
        {
            InitializeComponent();
            c = new CrudComp();
            cbxIva.Items.Add("4");
            cbxIva.Items.Add("10");
            cbxIva.Items.Add("22");
            cbxIva.SelectedIndex = 2;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string description = txtDescrizione.Text;
            if (name == "")
            {
                MessageBox.Show("Errore, nome non inserito.");
                return;
            }
            Categoria cat = new Categoria(1, name, description, int.Parse(cbxIva.SelectedItem.ToString()));
            int result = c.NewCategoria(cat);
            if (result!=0)
            {
                MessageBox.Show("Nuova categoria inserita!");
                txtNome.Text = "";
                txtDescrizione.Text = "";
                cbxIva.SelectedIndex = 2;
            } else
            {
                MessageBox.Show("Errore, dato non inserito.");
            }
        }
    }
}
