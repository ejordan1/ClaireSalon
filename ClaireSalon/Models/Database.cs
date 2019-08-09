using System;
using MySql.Data.MySqlClient;
using ClaireSalon;

namespace ClaireSalon.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            return conn;
        }
    }
}
