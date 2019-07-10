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
        SqlConnectionStringBuilder db;

        public Form1()
        {
            InitializeComponent();
            try
            {
                db = DBConnection.DB();
                using (SqlConnection s = new SqlConnection(db.ConnectionString))
                {
                    s.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = s;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "sp_total_order_completed";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            textBox1.Text = "\r\nIl numero totale di ordini registrati al " + DateTime.Now.ToString() +
                                " è:\r\n";
                            while (reader.Read())
                            {
                                textBox1.Text += reader.GetInt32(0) + "\r\n";
                            }
                        }
                    }
                    using (SqlCommand command2 = new SqlCommand())
                    {
                        command2.Connection = s;
                        command2.CommandType = CommandType.StoredProcedure;

                        command2.CommandText = "sp_best_selling_product";
                        using (SqlDataReader reader = command2.ExecuteReader())
                        {
                            textBox1.Text += "Prodotto più venduto\r\n";
                            while (reader.Read())
                            {
                                textBox1.Text += reader.GetInt32(0) + "Somma acquistata: " + reader.GetInt32(1) + "\r\n";
                            }
                        }
                    }
                    using (SqlCommand command3 = new SqlCommand())
                    {
                        command3.Connection = s;
                        command3.CommandType = CommandType.StoredProcedure;

                        command3.CommandText = "sp_prodotti_in_scorta";
                        using (SqlDataReader reader = command3.ExecuteReader())
                        {
                            textBox1.Text += "I seguenti prodotti sono in scorta:\r\n";
                            while (reader.Read())
                            {
                                textBox1.Text += "ID " + reader.GetInt32(0) + " - " + reader.GetString(1)
                                    + " - Giacenza: " + reader.GetInt32(6) + "\r\n";
                            }
                        }
                    }
                    using (SqlCommand command4 = new SqlCommand())
                    {
                        command4.Connection = s;
                        command4.CommandType = CommandType.StoredProcedure;

                        command4.CommandText = "sp_top10clients_by_fatturato";
                        using (SqlDataReader reader = command4.ExecuteReader())
                        {
                            textBox1.Text += "I 10 migliori clienti per fatturato sono:\r\n";
                            while (reader.Read())
                            {
                                //textBox1.Text += reader.GetInt32(0) + " - Fatturato: " + reader.GetFloat(1) + "\r\n";
                            }
                        }

                    }
                }

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

        private void tsmElenco_Click(object sender, EventArgs e)
        {
            ShowAll s = new ShowAll();
            s.ShowDialog();
        }

        private void tsmDettaglio_Click(object sender, EventArgs e)
        {
            ShowByID s = new ShowByID();
            s.ShowDialog();
        }
    }
}
