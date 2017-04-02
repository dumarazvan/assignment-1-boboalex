using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Assignment1.Database
{
    class userDB
    {
        public userDB()
        {

        }
        public void insertUser(String a, String b, String c,String d)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "INSERT INTO a1.users(username,password,fullname,isadmin) VALUES('"+a+"','"+b+"','"+c+"','"+d+"')";
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
        public String ShowUsers()
        {
            String connString = "Server=localhost;port=3306;Database=a1;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from users";
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
                    reader["username"].ToString() + " " +
                    reader["password"].ToString()+" "+
                    reader["fullname"].ToString() + " " +
                    reader["isadmin"].ToString() + "\n";
            }
            return str;
        }
        public void updateUserbyUsername(String a, String b, String c, String d, String x)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "update a1.users set username='" + a + "',password='" + b + "',fullname='" + c + "',isadmin='" + d + "' where id='"+x+"'";
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
        public void deleteById(String a)
        {
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "delete from a1.users where id='" + a + "'";
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
