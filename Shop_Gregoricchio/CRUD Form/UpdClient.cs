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
    public partial class UpdClient : Form
    {
        CrudComp c = null;

        public UpdClient()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex cp = new Regex(@"^\d{5,6}$");
            Regex prov = new Regex(@"^\w{2,3}$");
            Regex cFiscaleEiva = new Regex(@"^[a-zA-Z0-9]+$");
            if (txtPIva.Text.Length != 11 || txtCF.Text.Length != 16 ||
                (txtCap.Text.Length < 5 || txtCap.Text.Length > 7) || !int.TryParse(txtCap.Text, out int cap)
                || !(cp.IsMatch(txtCap.Text)) || !prov.IsMatch(txtPV.Text) || !cFiscaleEiva.IsMatch(txtPIva.Text)
                || !cFiscaleEiva.IsMatch(txtCF.Text))
            {
                MessageBox.Show("Dati non validi.");
                return;
            }
            if (txtPIva.Text == "" || txtCF.Text == "" || txtRSoc.Text == "" || txtNome.Text == "" || txtCognome2.Text == "" || txtVia.Text == "" ||
                txtCity.Text == "" || txtCap.Text == "" || txtPV.Text == "" || txtCell.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Inserisci tutti i campi non opzionali.");
                return;
            }
            Cliente client = new Cliente(int.Parse(txtId.Text), txtPIva.Text, txtCF.Text, txtRSoc.Text, txtNome.Text, txtCognome2.Text, txtVia.Text,
                 txtCity.Text, cap, txtPV.Text, txtTel.Text, txtFax.Text, txtCell.Text, txtMail.Text, txtSito.Text);
            int res = c.UpdCliente(client);
            if (res!=0)
            {
                MessageBox.Show("Cliente aggiornato!");
            }
            else
            {
                MessageBox.Show("Cliente non aggiornato!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Errore, dato non valido.");
                return;
            }
            Cliente client = c.SearchCliente(id);
            if (client == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            } else
            {
                txtId.Enabled = false;
                txtPIva.Text = client.PartitaIva;
                txtPIva.Enabled = true;
                txtCF.Text = client.CodiceFiscale;
                txtRSoc.Text = client.RagioneSociale;
                txtNome.Text = client.Nome;
                txtCognome2.Text = client.Cognome;
                txtVia.Text = client.Via;
                txtCity.Text = client.Città;
                txtCap.Text = "" + client.Cap;
                txtPV.Text = client.PV;
                txtTel.Text = client.Telefono;
                txtFax.Text = client.Fax;
                txtCell.Text = client.Cellulare;
                txtMail.Text = client.Mail;
                txtSito.Text = client.SitoWeb;
                txtCF.Enabled = true;
                txtRSoc.Enabled = true;
                txtNome.Enabled = true;
                txtCognome2.Enabled = true;
                txtVia.Enabled = true;
                txtCity.Enabled = true;
                txtCap.Enabled = true;
                txtPV.Enabled = true;
                txtTel.Enabled = true;
                txtFax.Enabled = true;
                txtCell.Enabled = true;
                txtMail.Enabled = true;
                txtSito.Enabled = true;
                btnSend.Enabled = true;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPIva.Text = "";
            txtPIva.Enabled = false;
            txtCF.Text = "";
            txtRSoc.Text = "";
            txtNome.Text = "";
            txtCognome2.Text = "";
            txtVia.Text = "";
            txtCity.Text = "";
            txtCap.Text = "";
            txtPV.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtCell.Text = "";
            txtMail.Text = "";
            txtSito.Text = "";
            txtCF.Enabled = false;
            txtRSoc.Enabled = false;
            txtNome.Enabled = false;
            txtCognome2.Enabled = false;
            txtVia.Enabled = false;
            txtCity.Enabled = false;
            txtCap.Enabled = false;
            txtPV.Enabled = false;
            txtTel.Enabled = false;
            txtFax.Enabled = false;
            txtCell.Enabled = false;
            txtMail.Enabled = false;
            txtSito.Enabled = false;
            btnSend.Enabled = false;

        }
    }
}
