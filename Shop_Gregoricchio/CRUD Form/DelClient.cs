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
    public partial class DelClient : Form
    {
        CrudComp c = null;
        int id = 0;
        public DelClient()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Errore, id non valido.");
                return;
            }
            Cliente client = c.SearchCliente(id);
            if (client == null)
            {
                MessageBox.Show("Dato non trovato");
                return;
            }
            else
            {
                txtPIva.Text = client.PartitaIva;
                txtCF.Text = client.CodiceFiscale;
                txtRSoc.Text = client.RagioneSociale;
                txtNome.Text = client.Nome;
                txtCognome.Text = client.Cognome;
                txtVia.Text = client.Via;
                txtCity.Text = client.Città;
                txtCap.Text = "" + client.Cap;
                txtPV.Text = client.PV;
                txtTel.Text = client.Telefono;
                txtFax.Text = client.Fax;
                txtCell.Text = client.Cellulare;
                txtMail.Text = client.Mail;
                txtSito.Text = client.SitoWeb;
                btnSend.Enabled = true;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id2) || (id2!=id))
            {
                MessageBox.Show("Errore, id modificato rispetto alla search, non valido.");
                return;
            }
            Cliente client = new Cliente(int.Parse(txtId.Text), txtPIva.Text, txtCF.Text, txtRSoc.Text, txtNome.Text, txtCognome.Text, txtVia.Text,
                 txtCity.Text, int.Parse(txtCap.Text), txtPV.Text, txtTel.Text, txtFax.Text, txtCell.Text, txtMail.Text, txtSito.Text);
            int res = c.DelCliente(client);
            if (res!=0)
            {
                MessageBox.Show("Cliente eliminato!");
            }
            else
            {
                MessageBox.Show("Errore, cliente non cancellato. Vincolo di integrità referenziale attivo.");
            }
        }
    }
}
