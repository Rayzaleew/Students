using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Students
{
    internal class DataBase
    {
        SQLiteConnection connection = new SQLiteConnection(@"data source = database.db");

        public SQLiteConnection getConnection()
        {
            return connection;
        }
        public void openConnection()
        {

            if (connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    connection.Open();
                }
                catch
                {
        

                }
        }
        public void closeConnection()
        {
            
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

    }
}
