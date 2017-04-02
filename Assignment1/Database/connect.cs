using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Database
{
    class connect
    {
        public MySqlConnection getConnection()
        {
            String connString = "Server=localhost;port=3306;Database=bankapp;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                //Console.WriteLine("Conexiunea exista!");
            }
            catch (Exception ex)
            { }
            return conn;
        }
    }
}
