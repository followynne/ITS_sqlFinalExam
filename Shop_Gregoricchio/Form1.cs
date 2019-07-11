using Shop_Gregoricchio.CRUD;
using Shop_Gregoricchio.CRUD_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Gregoricchio
{
    public partial class Form1 : Form
    {

        CrudComp c = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                c = new CrudComp();
                c.DashBoardCreation(textBox1);
            }
            catch (SqlException)
            {
                MessageBox.Show("Connessione al database non funzionante, controlla per favore i dati di connessione.");
                tsmNew.Enabled = false;
                tsmUpdate.Enabled = false;
                tsmDelete.Enabled = false;
                tsmElenco.Enabled = false;
                tsmDettaglio.Enabled = false;
            }
        }

        private void tsiNewOrdine_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiNewCliente_Click(object sender, EventArgs e)
        {
            NewClient n = new NewClient();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiNewProdotto_Click(object sender, EventArgs e)
        {
            NewProduct n = new NewProduct();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiNewCategoria_Click(object sender, EventArgs e)
        {
            NewCategory n = new NewCategory();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiUpdOrdine_Click(object sender, EventArgs e)
        {
            UpdOrder n = new UpdOrder();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiUpdCliente_Click(object sender, EventArgs e)
        {
            UpdClient n = new UpdClient();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiUpdProdotto_Click(object sender, EventArgs e)
        {
            UpdProduct n = new UpdProduct();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsiUpdCategoria_Click(object sender, EventArgs e)
        {
            UpdCategory n = new UpdCategory();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DelOrder n = new DelOrder();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DelClient n = new DelClient();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DelProduct n = new DelProduct();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DelCategory n = new DelCategory();
            n.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsmElenco_Click(object sender, EventArgs e)
        {
            ShowAll s = new ShowAll();
            s.ShowDialog();
            c.DashBoardCreation(textBox1);
        }

        private void tsmDettaglio_Click(object sender, EventArgs e)
        {
            ShowByID s = new ShowByID();
            s.ShowDialog();
            c.DashBoardCreation(textBox1);
        }
    }
}
