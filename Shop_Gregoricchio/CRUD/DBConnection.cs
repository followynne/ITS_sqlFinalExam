using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Gregoricchio.CRUD
{
    static class DBConnection
    {
        static private SqlConnectionStringBuilder connection;

        static DBConnection()
        {
                connection = new SqlConnectionStringBuilder();
        }

        static public SqlConnectionStringBuilder DB(){
            connection.DataSource = "BE-PRI-A-11\\SQLEXPRESS01";
            connection.UserID = "ITS_IBS";
            connection.Password = "!Its-2019";
            connection.InitialCatalog = "Shop_Gregoricchio";
            return connection;
        }

    }
}
