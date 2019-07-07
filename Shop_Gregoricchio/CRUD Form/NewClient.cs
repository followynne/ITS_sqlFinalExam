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
    public partial class NewClient : Form
    {
        CrudComp c = null;
        public NewClient()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtPIva.Text.Length != 11 || txtCF.Text.Length != 16 || 
                (txtCap.Text.Length <5 || txtCap.Text.Length > 7) || !int.TryParse(txtCap.Text, out int cap))
            {
                MessageBox.Show("Dati non validi.");
                return;
            }
            Cliente client = new Cliente(1, txtPIva.Text, txtCF.Text, txtRSoc.Text, txtNome.Text, txtCognome.Text, txtVia.Text,
                 txtCity.Text, cap, txtPV.Text, txtTel.Text, txtFax.Text, txtCell.Text, txtMail.Text, txtSito.Text);
            bool res = c.NewCliente(client);
            if (res)
            {
                MessageBox.Show("Cliente aggiunto!");
            }
            else
            {
                MessageBox.Show("Cliente non aggiunto!");
            }
        }
    }
}
