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
        }//DESKTOP-O1ADUOV    BE-PRI-A-11\\SQLEXPRESS01

        static public SqlConnectionStringBuilder DB(){
            connection.DataSource = "DESKTOP-O1ADUOV";
            connection.UserID = "ITS_IBS";
            connection.Password = "!Its-2019";
            connection.InitialCatalog = "Shop_Gregoricchio";
            return connection;
        }

    }
}
