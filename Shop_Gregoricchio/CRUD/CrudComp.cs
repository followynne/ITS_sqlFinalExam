using Shop_Gregoricchio.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Gregoricchio.CRUD
{
    class CrudComp
    {
        SqlConnectionStringBuilder db;
        public CrudComp()
        {
            db = DBConnection.DB();
        }

        public int NewProdotto(Prodotto p)
        {
            int x = 0;
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "insert into Prodotto values (@denominazione,@descrizione," +
                    "@idcategoria,@prezzonoiva,@sconto, @giacenza)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                    if (p.Descrizione == "")
                    {
                        command.Parameters.Add("@descrizione", SqlDbType.Text).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@descrizione", SqlDbType.VarChar).Value = p.Descrizione;
                    }
                    command.Parameters.Add("@idcategoria", SqlDbType.Int).Value = p.Categoria.Id;
                    command.Parameters.Add("@prezzonoiva", SqlDbType.Float).Value = p.Prezzo;
                    command.Parameters.Add("@sconto", SqlDbType.Float).Value = p.Sconto;
                    command.Parameters.Add("@giacenza", SqlDbType.Int).Value = p.Giacenza;
                    x = command.ExecuteNonQuery();
                }
                return x;
            }
        }
        public int NewCategoria(Categoria p)
        {
            int x = 0;
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "insert into Categoria values (@denominazione,@descrizione)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                    if (p.Descrizione == "")
                    {
                        command.Parameters.Add("@descrizione", SqlDbType.Text).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@descrizione", SqlDbType.VarChar).Value = p.Descrizione;
                    }
                    x = command.ExecuteNonQuery();
                }
                return x;
            }
        }
        public bool NewOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale



            return true;
        }
        public bool NewCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdProdotto(Prodotto p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdCategoria(Categoria p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool UpdCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql isert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelProdotto(Prodotto p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelCategoria(Categoria p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelOrdine(Ordine p)
        {
            //connDb
            //openDb --> query sql insert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public bool DelCliente(Cliente p)
        {
            //connDb
            //openDb --> query sql isert into ... passandogli i dati di P + l'Id Casuale
            return true;
        }
        public Prodotto SearchProdotto(int id)
        {
            Prodotto p = null;
            return p;
        }
        public Categoria SearchCategoria(int id)
        {
            Categoria p = null;
            return p;
        }

        public Ordine SearchOrdine(int id)
        {
            Ordine o = null;
            return o;
        }
        public Cliente SearchCliente(int id)
        {
            Cliente client = null;
            return client;
        }
        public TipiPagamento SearchPagamento(int id)
        {
            TipiPagamento o = null;
            return o;
        }

        //public List<Ordine> SearchAllOrdine()
        //{
        //    List<Ordine> l = new List<Ordine>();
        //    using (SqlConnection connection = new SqlConnection(db.ConnectionString))
        //    {
        //        connection.Open();
        //        string sql = "SELECT * FROM Ordine";
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    l.Add(new Ordine(
        //                        reader.GetInt32(0),
        //                        reader.GetString(1),
        //                        SearchCliente(reader.GetInt32(2)),
        //                        reader.GetDateTime(3)),
        //                        SearchTipiPagamento(reader.GetInt32(4),
        //                        reader.GetFloat(5),
        //                        reader.GetInt32(6)
        //                    ));
        //                }
        //            }
        //        }
        //    }
        //    return l;
        //}
        public List<Cliente> SearchAllCliente()
        {
            List<Cliente> l = new List<Cliente>();
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Cliente";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tel = "";
                            string fax = "";
                            string sito = "";
                            try
                            {
                                tel = reader.GetString(10);
                                fax = reader.GetString(2);
                                sito = reader.GetString(2);
                            }
                            catch (SqlNullValueException)
                            {
                                descrip = null;
                            }
                            l.Add(new Cliente(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.GetString(7),
                                reader.GetInt32(8),
                                reader.GetString(9),
                                telefono
                                fax
                                cell
                                mail sito
                                descrip,
                                SearchCategoria(reader.GetInt32(3)),
                                reader.GetFloat(4),
                                reader.GetFloat(5),
                                reader.GetInt32(6)
                            ));
                        }
                    }
                }
            }
            return l;
        }
        public List<Prodotto> SearchAllProdotto()
        {
            List<Prodotto> l = new List<Prodotto>();
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Prodotto";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string descrip = "";
                            try
                            {
                                descrip = reader.GetString(2);
                            }
                            catch (SqlNullValueException)
                            {
                                descrip = null;
                            }
                            l.Add(new Prodotto(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                descrip,
                                SearchCategoria(reader.GetInt32(3)),
                                reader.GetFloat(4),
                                reader.GetFloat(5),
                                reader.GetInt32(6)
                            ));
                        }
                    }
                }
            }
            return l;
        }
        public List<Categoria> SearchAllCategoria()
        {
            List<Categoria> l = new List<Categoria>();
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Categoria";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string descrip = "";
                            try
                            {
                                descrip = reader.GetString(2);
                            } catch (SqlNullValueException)
                            {
                                descrip = null;
                            }
                            l.Add(new Categoria(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                descrip
                            ));
                        }
                    }
                }
            }
            return l;
        }
        public List<TipiPagamento> SearchAllTipiPagamento()
        {
            List<TipiPagamento> s = new List<TipiPagamento>();
            return s;
        }
        
        public bool CheckGiacenza(int id)
        {
            return false;
        }
        public string CreateRandomReference()
        {
            string numbers = "0123456789";
            string characters = "abcdefghijklmnopqrstuvwxyz";

            string pattern = characters + characters.ToUpper() + numbers;
            string pw = "";
            Random r = new Random();

            do
            {
                for (int i = 0; i < 8; i++)
                    pw += pattern.ElementAt(r.Next(pattern.Length));
            } while (SearchByReference(pw));

            return pw;
        }
        private bool SearchByReference(string id)
        {
            return false;
        }
    }
}
