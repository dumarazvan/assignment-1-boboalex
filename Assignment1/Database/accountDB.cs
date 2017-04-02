using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Classes;
using MySql.Data.MySqlClient;

namespace Assignment1.Database
{
    class accountDB
    {
        public accountDB()
        {

        }
        public void createAccount(String a, String b, String c, String d)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "INSERT INTO a1.accounts(idnumber,type,amount,date) VALUES('" + a + "','" + b + "','" + c + "','" + d + "')";
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
        public String ShowAccounts()
        {
            String connString = "Server=localhost;port=3306;Database=a1;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from accounts";
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
                    reader["idnumber"].ToString() + " " +
                    reader["type"].ToString() + " " +
                    reader["amount"].ToString() + " " +
                    reader["date"].ToString() + "\n";
            }
            return str;
        }
        public void updateAccountByIdnum(String a, String b, String c, String d, String x)
        {
            //connect con = new connect();
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "update a1.accounts set idnumber='" + a + "',type='" + b + "',amount='" + c + "',date='" + d + "' where idnumber='" + x + "'";
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
        public void deleteAccountByIdnum(String a)
        {
            MySqlConnection conn = new MySqlConnection("datasource = localhost; port = 3306; Database = a1; Uid = root; password = ketchup");

            String query = "delete from a1.accounts where idnumber='" + a + "'";
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
