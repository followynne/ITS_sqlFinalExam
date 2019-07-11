using Shop_Gregoricchio.Classes;
using Shop_Gregoricchio.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex cp = new Regex(@"^\d{5,6}$");
            Regex prov = new Regex(@"^\w{2,3}$");
            Regex cFiscaleEiva = new Regex(@"^[A-Z0-9]+$");

            if (txtPIva.Text.Length != 11 || txtCF.Text.Length != 16 ||
                (txtCap.Text.Length < 5 || txtCap.Text.Length > 7) || !int.TryParse(txtCap.Text, out int cap)
                || !(cp.IsMatch(txtCap.Text)) || !prov.IsMatch(txtPV.Text) || !cFiscaleEiva.IsMatch(txtPIva.Text)
                || !cFiscaleEiva.IsMatch(txtCF.Text))
            {
                MessageBox.Show("Dati non validi.");
                return;
            }
            if (txtPIva.Text == "" || txtCF.Text == "" || txtRSoc.Text == "" || txtNome.Text == "" || txtCognome.Text == "" || txtVia.Text == "" ||
                 txtCity.Text == "" ||  txtCap.Text == "" || txtPV.Text == "" || txtCell.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Inserisci tutti i campi non opzionali.");
                return;
            }
            Cliente client = new Cliente(1, txtPIva.Text, txtCF.Text, txtRSoc.Text, txtNome.Text, txtCognome.Text, txtVia.Text,
                 txtCity.Text, cap, txtPV.Text, txtTel.Text, txtFax.Text, txtCell.Text, txtMail.Text, txtSito.Text);
            int res = c.NewCliente(client);
            if (res!=0)
            {
                MessageBox.Show("Cliente aggiunto!");
            }
            else
            {
                MessageBox.Show("Cliente non aggiunto. È già presente in database.");
            }
        }
    }
}
