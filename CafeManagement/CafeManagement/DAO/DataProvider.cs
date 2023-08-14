using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    public class DataProvider
    {
        string connectionString = "Server=localhost;Database=quanlyquancafe;User ID=root;Password=;";

        public DataTable ExecuteQuery(string query)
        {

            DataTable data = new DataTable();

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            

            return data;
        }
    }
}
