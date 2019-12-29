using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseBlackSea
{
    class DBConnection
    {
        private static readonly object synchronizationDBConnectionObject = new object();
        private int countConnections = 0;

        static string connString = "Data Source=DESKTOP-I3Q9AOD\\SQLEXPRESS;Initial Catalog=cruise;Integrated Security=True";

        private SqlConnection connection = new SqlConnection(connString);

        public DBConnection()
        {
            //empty constructor
        }

        public void ConnectionWithDB()
        {
            lock (synchronizationDBConnectionObject)
            {
                if (DisponibleConnection())
                {
                    countConnections++;
                }
                else
                {
                    countConnections--;
                }
            }
        }

        private bool DisponibleConnection()
        {
            if (countConnections == 0)
            {
                using (connection)
                {
                    connection.Open();
                }
                return true;
            }
            else
            {
                using (connection)
                {
                    connection.Close();
                }
                return false;
            }
        }

    }
}
