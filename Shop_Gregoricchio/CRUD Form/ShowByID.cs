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
            string choice = "";
            if (rdbCategory.Checked)
            {
                choice = "categoria";
            }
            else if (rdbClient.Checked)
            {
                choice = "cliente";
            }
            else if (rdbOrder.Checked)
            {
                choice = "ordine";
            }
            else if (rdbProduct.Checked)
            {
                choice = "prodotto";
            }
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Dato non valido.");
                return;
            }
            string s = c.SearchbyId(choice, id);
            textBox1.Text = s;
        }
    }
}
