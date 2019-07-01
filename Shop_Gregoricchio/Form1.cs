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
            NewProduct n = new NewProduct();
            n.ShowDialog();
        }
    }
}
