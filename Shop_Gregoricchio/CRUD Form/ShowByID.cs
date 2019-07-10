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
    public partial class ShowByID : Form
    {
        CrudComp c = null;
        public ShowByID()
        {
            InitializeComponent();
            c = new CrudComp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Id non valido, riprova.");
                return;
            }
            if (rdbCategory.Checked)
            {
                if (c.SearchCategoria(id)!= null)
                    textBox1.Text = c.SearchCategoria(id).ToString();
            }
            else if (rdbClient.Checked)
            {
                if (c.SearchCliente(id) != null)
                    textBox1.Text = c.SearchCliente(id).ToString();
            }
            else if (rdbOrder.Checked)
            {
                if (c.SearchOrdine(id) != null)
                    textBox1.Text = c.SearchOrdine(id).ToString();
            }
            else if (rdbProduct.Checked)
            {
                if (c.SearchProdotto(id) != null)
                    textBox1.Text = c.SearchProdotto(id).ToString();
            }
        }
    }
}
