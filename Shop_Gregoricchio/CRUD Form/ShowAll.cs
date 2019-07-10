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
    public partial class ShowAll : Form
    {
        CrudComp c = null;
        
        public ShowAll()
        {
            InitializeComponent();
            c = new CrudComp();
            rdbCategory.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbClient.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbOrder.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rdbProduct.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //RadioButton rd = sender as RadioButton;
            if (rdbCategory.Checked)
            {
                List<Categoria> list = c.SearchAllCategoria(); 
                foreach(Categoria cat in list)
                {
                    textBox1.Text += cat.ToString() + "\r\n";
                }
            } else if (rdbClient.Checked)
            {
                List<Cliente> list = c.SearchAllCliente();
                foreach (Cliente cat in list)
                {
                    textBox1.Text += cat.ToString() + "\r\n";
                }
            }
            else if (rdbOrder.Checked)
            {
                List<Ordine> list = c.SearchAllOrdine();
                foreach (Ordine cat in list)
                {
                    textBox1.Text += cat.ToString() + "\r\n";
                }
            }
            else if (rdbProduct.Checked)
            {
                List<Prodotto> list = c.SearchAllProdotto();
                foreach (Prodotto cat in list)
                {
                    textBox1.Text += cat.ToString() + "\r\n";
                }
            }
        }
    }
}
