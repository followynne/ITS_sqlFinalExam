using Shop_Gregoricchio.CRUD_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Gregoricchio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsiNewOrdine_Click(object sender, EventArgs e)
        {
            NewOrder n = new NewOrder();
            n.ShowDialog();
        }

        private void tsiNewCliente_Click(object sender, EventArgs e)
        {
            NewClient n = new NewClient();
            n.ShowDialog();
        }

        private void tsiNewProdotto_Click(object sender, EventArgs e)
        {
            NewProduct n = new NewProduct();
            n.ShowDialog();
        }

        private void tsiNewCategoria_Click(object sender, EventArgs e)
        {
            NewCategory n = new NewCategory();
            n.ShowDialog();
        }

        private void tsiUpdOrdine_Click(object sender, EventArgs e)
        {
            UpdOrder n = new UpdOrder();
            n.ShowDialog();
        }

        private void tsiUpdCliente_Click(object sender, EventArgs e)
        {
            UpdClient n = new UpdClient();
            n.ShowDialog();
        }

        private void tsiUpdProdotto_Click(object sender, EventArgs e)
        {
            UpdProduct n = new UpdProduct();
            n.ShowDialog();
        }

        private void tsiUpdCategoria_Click(object sender, EventArgs e)
        {
            UpdCategory n = new UpdCategory();
            n.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DelOrder n = new DelOrder();
            n.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DelClient n = new DelClient();
            n.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DelProduct n = new DelProduct();
            n.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DelCategory n = new DelCategory();
            n.ShowDialog();
        }
    }
}
