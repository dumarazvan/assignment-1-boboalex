using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Database
{
    class clientDB
    {
        public clientDB()
        {

        }
        public void insertClient(String a, String b, String c, String d)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "INSERT INTO a1.clients(name,idcard,pnc,address) VALUES('" + a + "','" + b + "','" + c + "','" + d + "')";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public String ShowClients()
        {
            String connString = "Server=localhost;port=3306;Database=a1;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from clients";
            String str = "";

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                str += reader["id"].ToString() + " " +
                    reader["name"].ToString() + " " +
                    reader["idcard"].ToString() + " " +
                    reader["pnc"].ToString() + " " +
                    reader["address"].ToString() + "\n";
            }
            return str;
        }
        public void updateClient(String a, String b, String c, String d, String x)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "update a1.clients set name='" + a + "',idcard='" + b + "',pnc='" + c + "',address='" + d + "' where pnc='" + x + "'";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}

