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
    public partial class ProductsToOrder : Form
    {
        public ProductsToOrder()
        {
            InitializeComponent();
        }
        public ProductsToOrder(Form f)
        {
            InitializeComponent();
            txtModProd.Enabled=true;
            cbxModProd.Enabled = true;
            btnModProd.Enabled = true;
        }


    }
}
