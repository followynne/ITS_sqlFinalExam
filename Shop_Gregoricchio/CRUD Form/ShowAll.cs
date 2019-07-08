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
            string choice = "";
            RadioButton rd = sender as RadioButton;
            if (rdbCategory.Checked)
            {
                choice = "categoria";
            } else if (rdbClient.Checked)
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
            string res = c.SearchAll(choice);
            textBox1.Text = res;
        }
    }
}
