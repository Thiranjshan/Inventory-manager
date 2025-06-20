using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Inventory_manager
{
    internal class DBHelper
    {
        private static readonly string connectionString = "Data Source=inventoryDB.db;Version=3;";
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
        public static void CreateDatabaseIfNotExists()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS items (id INTEGER PRIMARY KEY, name TEXT, quantity INTEGER)", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
