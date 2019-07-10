using Shop_Gregoricchio.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "insert into Prodotto values (@denominazione,@descrizione," +
                        "@idcategoria,@prezzonoiva,@sconto, @giacenza)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                        if (p.Descrizione == "" || p.Descrizione.ToUpper() == "NULL")
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
                }
            }
            catch (Exception)
            {
            }
            return x;
        }

        public int NewCategoria(Categoria p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "insert into Categoria values (@denominazione,@descrizione)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                        if (p.Descrizione == "" || p.Descrizione.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@descrizione", SqlDbType.Text).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@descrizione", SqlDbType.VarChar).Value = p.Descrizione;
                        }
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
        }

        public int NewOrdine(Ordine p)
        {
            int x = 0;
            int y = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "insert into Ordine values (@CodiceOrdine, @IdCliente," +
                        "@Data, @TipoPagamento)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        string reference = CreateRandomReference();
                        command.Parameters.Add("@CodiceOrdine", SqlDbType.VarChar).Value = reference;
                        command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = p.Cliente.Id;
                        command.Parameters.Add("@Data", SqlDbType.DateTime).Value = p.Data;
                        command.Parameters.Add("@TipoPagamento", SqlDbType.Float).Value = p.TipoPagamento.Id;
                        x = command.ExecuteNonQuery();
                        if (x != 0)
                            try
                            {
                                y = CreaListaProdotti(p.ListaProdotti, SearchOrdinebyReference(reference));
                            }
                            catch (SqlException)
                            {
                            }
                    }
                }
            }
            catch (SqlException)
            {
            }
            if (y == 0)
            {
                return x = 0;
            }
            return x;
        }

        public int CreaListaProdotti(Dictionary<Prodotto, int> lista, int idorder)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "insert into DettaglioOrdine values (@IdOrdine, @IdProdotto," +
                            "@Quantita, @ScontoApplicato)";
                    foreach (KeyValuePair<Prodotto, int> k in lista)
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.Add("@IdOrdine", SqlDbType.VarChar).Value = idorder;
                            command.Parameters.Add("@IdProdotto", SqlDbType.Int).Value = k.Key.Id;
                            command.Parameters.Add("@Quantita", SqlDbType.Int).Value = k.Value;
                            command.Parameters.Add("@ScontoApplicato", SqlDbType.Float).Value = DBNull.Value;
                            x = command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }

        public int NewCliente(Cliente p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "insert into Cliente values (@PartitaIva, @CF, @RagioneSociale, @Nome, @Cognome," +
                        "@Via, @Cap, @Citta, @Provincia, @Telefono, @Cellulare, @Fax, @Email, @Sito)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@PartitaIva", SqlDbType.VarChar).Value = p.PartitaIva;
                        command.Parameters.Add("@CF", SqlDbType.VarChar).Value = p.CodiceFiscale;
                        command.Parameters.Add("@RagioneSociale", SqlDbType.VarChar).Value = p.RagioneSociale;
                        command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = p.Nome;
                        command.Parameters.Add("@Cognome", SqlDbType.VarChar).Value = p.Cognome;
                        command.Parameters.Add("@Via", SqlDbType.VarChar).Value = p.Via;
                        command.Parameters.Add("@Cap", SqlDbType.Int).Value = p.Cap;
                        command.Parameters.Add("@Citta", SqlDbType.VarChar).Value = p.Città;
                        command.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = p.PV;
                        if (p.Telefono == "" || p.Telefono.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = p.Telefono;
                        }
                        command.Parameters.Add("@Cellulare", SqlDbType.VarChar).Value = p.Cellulare;
                        if (p.Fax == "" || p.Fax.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Fax", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Fax", SqlDbType.VarChar).Value = p.Fax;
                        }
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = p.Mail;
                        if (p.SitoWeb == "" || p.SitoWeb.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Sito", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Sito", SqlDbType.VarChar).Value = p.SitoWeb;
                        }
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
        }

        public int UpdProdotto(Prodotto p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "update Prodotto set Denominazione = @denominazione, Descrizione = @descrizione," +
                        "IdCategoria = @idcategoria, PrezzoNoIva = @prezzonoiva,Sconto = @sconto, Giacenza = @giacenza where Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                        if (p.Descrizione == "" || p.Descrizione.ToUpper() == "NULL")
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
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }
        public int UpdCategoria(Categoria p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "update Categoria set denominazione = @denominazione, descrizione = @descrizione where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        command.Parameters.Add("@denominazione", SqlDbType.VarChar).Value = p.Denominazione;
                        if (p.Descrizione == "" || p.Descrizione.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@descrizione", SqlDbType.Text).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@descrizione", SqlDbType.VarChar).Value = p.Descrizione;
                        }
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
        }
        public int UpdOrdine(Ordine p)
        {
            int x = 0;
            int y = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "update Ordine set IdCliente = @IdCliente," +
                        "Data = @Data, TipoPagamento = @TipoPagamento where Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = p.Cliente.Id;
                        command.Parameters.Add("@Data", SqlDbType.DateTime).Value = p.Data;
                        command.Parameters.Add("@TipoPagamento", SqlDbType.Int).Value = p.TipoPagamento.Id;
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                        if (x != 0)
                            try
                            {
                                y = ModificaListaProdotti(p.ListaProdotti, p.Id);
                            }
                            catch (SqlException)
                            {
                            }
                    }
                }
            }
            catch (SqlException)
            {
            }
            if (y == 0)
            {
                return x = 0;
            }
            return x;
        }

        public int ModificaListaProdotti(Dictionary<Prodotto, int> lista, int idorder)
        {
            int x = 0;
            Dictionary<Prodotto, int> listaAttuale = ListProdottiperOrdine(idorder);
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "update DettaglioProdotto set Quantita = @quantita where IdProdotto = @IdProdotto and IdOrdine = @IdOrdine";
                    string sql2 = "delete from DettaglioProdotto where IdOrdine = @IdOrdine and IdProdotto = @IdProdotto";
                    foreach (KeyValuePair<Prodotto, int> k in listaAttuale)
                    {
                        if (lista.ContainsKey(k.Key))
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.Add("@IdOrdine", SqlDbType.Int).Value = idorder;
                                command.Parameters.Add("@IdProdotto", SqlDbType.Int).Value = lista[k.Key];
                                command.Parameters.Add("@Quantita", SqlDbType.Int).Value = k.Value;
                                command.ExecuteNonQuery();
                            }
                        } else
                        {
                            using (SqlCommand command = new SqlCommand(sql2, connection))
                            {
                                command.Parameters.Add("@IdOrdine", SqlDbType.Int).Value = idorder;
                                command.Parameters.Add("@IdProdotto", SqlDbType.Int).Value = k.Key.Id;
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    x = 1;
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }

        public int UpdCliente(Cliente p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "update Cliente set PartitaIva=@PartitaIva, CF = @CF, RagioneSociale = @RagioneSociale, Nome = @Nome, Cognome=@Cognome," +
                        "Via = @Via, Cap = @Cap, Citta = @Citta, Provincia = @Provincia, Telefono = @Telefono, Cellulare =@Cellulare, Fax = @Fax, Email =  @Email, " +
                        "Sito = @Sito where Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@PartitaIva", SqlDbType.VarChar).Value = p.PartitaIva;
                        command.Parameters.Add("@CF", SqlDbType.VarChar).Value = p.CodiceFiscale;
                        command.Parameters.Add("@RagioneSociale", SqlDbType.VarChar).Value = p.RagioneSociale;
                        command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = p.Nome;
                        command.Parameters.Add("@Cognome", SqlDbType.VarChar).Value = p.Cognome;
                        command.Parameters.Add("@Via", SqlDbType.VarChar).Value = p.Via;
                        command.Parameters.Add("@Cap", SqlDbType.Int).Value = p.Cap;
                        command.Parameters.Add("@Citta", SqlDbType.VarChar).Value = p.Città;
                        command.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = p.PV;
                        if (p.Telefono == "" || p.Telefono.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = p.Telefono;
                        }
                        command.Parameters.Add("@Cellulare", SqlDbType.VarChar).Value = p.Cellulare;
                        if (p.Fax == "" || p.Fax.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Fax", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Fax", SqlDbType.VarChar).Value = p.Fax;
                        }
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = p.Mail;
                        if (p.SitoWeb == "" || p.SitoWeb.ToUpper() == "NULL")
                        {
                            command.Parameters.Add("@Sito", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add("@Sito", SqlDbType.VarChar).Value = p.SitoWeb;
                        }
                        command.Parameters.Add("Id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
        }
        public int DelProdotto(Prodotto p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "delete from Prodotto where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }
        public int DelCategoria(Categoria p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "delete from Categoria where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }
        public int DelOrdine(Ordine p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "delete from Ordine where Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                    string sql2 = "delete from DettaglioOrdine where IdOrdine = @id";
                    using (SqlCommand command2 = new SqlCommand(sql2, connection))
                    {
                        command2.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        command2.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }
        public int DelCliente(Cliente p)
        {
            int x = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "delete from Cliente where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = p.Id;
                        x = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }
        public Prodotto SearchProdotto(int id)
        {
            Prodotto p = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Prodotto where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string descrip = "";

                                if (reader.IsDBNull(2))
                                {
                                    descrip = "NULL";
                                }
                                else
                                {
                                    descrip = reader.GetTextReader(2).ToString();
                                }
                                p = new Prodotto(reader.GetInt32(0), reader.GetString(1), descrip, SearchCategoria(reader.GetInt32(3)), float.Parse(reader["PrezzoNoIva"].ToString()),
                                    float.Parse(reader["Sconto"].ToString()), reader.GetInt32(6));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return p;
        }
        public Categoria SearchCategoria(int id)
        {
            Categoria cat = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Categoria where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string descrip = "";
                                if (reader.IsDBNull(2))
                                {
                                    descrip = "NULL";
                                }
                                else
                                {
                                    descrip = reader.GetString(2);
                                }
                                cat = new Categoria(reader.GetInt32(0), reader.GetString(1), descrip);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return cat;
        }

        public Ordine SearchOrdine(int id)
        {
            Ordine p = null;
            Dictionary<Prodotto, int> lista = new Dictionary<Prodotto, int>();
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Ordine where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    lista = ListProdottiperOrdine(reader.GetInt32(0));
                                }
                                catch (Exception)
                                {
                                    return p;
                                }
                                p = new Ordine(reader.GetInt32(0), reader.GetString(1), SearchCliente(reader.GetInt32(2)),
                                    reader.GetDateTime(3), SearchPagamento(reader.GetInt32(4)), lista);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return p;
        }

        public int SearchOrdinebyReference(string order)
        {
            int o = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Ordine where CodiceOrdine = @order";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@order", SqlDbType.VarChar).Value = order;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                o = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return o;
        }
        public Cliente SearchCliente(int id)
        {
            Cliente client = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Cliente where Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tel = "";
                                string fax = "";
                                string sito = "";
                                if (reader.IsDBNull(10))
                                {
                                    tel = "NULL";
                                }
                                else
                                {
                                    tel = reader.GetString(10);
                                }
                                if (reader.IsDBNull(12))
                                {
                                    fax = "NULL";
                                }
                                else
                                {
                                    fax = reader.GetString(12);
                                }
                                if (reader.IsDBNull(14))
                                {
                                    sito = "NULL";
                                }
                                else
                                {
                                    sito = reader.GetString(14);
                                }
                                int.TryParse(reader.GetString(7), out int cap);
                                client = new Cliente(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6),
                                    reader.GetString(8),
                                    cap,
                                    reader.GetString(9),
                                    tel,
                                    fax,
                                    reader.GetString(11),
                                    reader.GetString(13),
                                    sito
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return client;
        }
        public TipiPagamento SearchPagamento(int id)
        {
            TipiPagamento cat = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from TipiPagamento where id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cat = new TipiPagamento(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return cat;
        }

        public Dictionary<Prodotto, int> ListProdottiperOrdine(int id)
        {
            Dictionary<Prodotto, int> x = new Dictionary<Prodotto, int>();
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from DettaglioOrdine where IdOrdine = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                x.Add(SearchProdotto(reader.GetInt32(1)), reader.GetInt32(2));
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
            }
            return x;
        }

        public List<Ordine> SearchAllOrdine()
        {
            List<Ordine> l = new List<Ordine>();
            using (SqlConnection connection = new SqlConnection(db.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Ordine";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            l.Add(new Ordine(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                SearchCliente(reader.GetInt32(2)),
                                reader.GetDateTime(3),
                                SearchPagamento(reader.GetInt32(4)),
                                ListProdottiperOrdine(reader.GetInt32(0))
                                ));
                        }
                    }
                }
            }
            return l;
        }

        public List<Cliente> SearchAllCliente()
        {
            List<Cliente> l = new List<Cliente>();
            try
            {
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
                                if (reader.IsDBNull(10))
                                {
                                    tel = "NULL";
                                }
                                else
                                {
                                    tel = reader.GetString(10);
                                }
                                if (reader.IsDBNull(12))
                                {
                                    fax = "NULL";
                                }
                                else
                                {
                                    fax = reader.GetString(12);
                                }
                                if (reader.IsDBNull(14))
                                {
                                    sito = "NULL";
                                }
                                else
                                {
                                    sito = reader.GetString(14);
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
                                    int.Parse(reader["Cap"].ToString()),
                                    reader.GetString(9),
                                    tel,
                                    fax,
                                    reader.GetString(11),
                                    reader.GetString(13),
                                    sito
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return l;
        }
        public List<Prodotto> SearchAllProdotto()
        {
            List<Prodotto> l = new List<Prodotto>();
            try
            {
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
                                if (reader.IsDBNull(2))
                                {
                                    descrip = "NULL";
                                }
                                else
                                {
                                    descrip = reader.GetString(2);
                                }
                                l.Add(new Prodotto(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    descrip,
                                    SearchCategoria(reader.GetInt32(3)),
                                    float.Parse(reader["PrezzoNoIva"].ToString()),
                                    float.Parse(reader["Sconto"].ToString()),
                                    reader.GetInt32(6)
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return l;
        }
        public List<Categoria> SearchAllCategoria()
        {
            List<Categoria> l = new List<Categoria>();
            try
            {
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
                                if (reader.IsDBNull(2))
                                {
                                    descrip = "NULL";
                                }
                                else
                                {
                                    descrip = reader.GetString(2);
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
            }
            catch (Exception)
            {
            }
            return l;
        }


        public List<TipiPagamento> SearchAllTipiPagamento()
        {
            List<TipiPagamento> l = new List<TipiPagamento>();
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from TipiPagamento";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                l.Add(new TipiPagamento(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2)));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return l;
        }

        public bool CheckGiacenza(int id, int giacenza)
        {
            bool x = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select Giacenza from Prodotto where Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) > giacenza)
                                {
                                    x = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
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
                pw = "";
                for (int i = 0; i < 8; i++)
                    pw += pattern.ElementAt(r.Next(pattern.Length));
            } while (SearchByReference(pw));

            return pw;
        }
        private bool SearchByReference(string cod)
        {
            bool x = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(db.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Ordine where CodiceOrdine = @cod";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                x = false;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return x;
        }
    }
}
