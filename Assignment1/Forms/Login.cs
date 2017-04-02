using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using Assignment1.Database;
using Assignment1.Forms;

namespace Assignment1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loginPanel.Width = 200;
            loginPanel.Height = 230;
            testBtn.Visible = false;
            testConn.Visible = false;
            button1.Visible = false;
            clearBtn.Visible = false;
            if (button1.Visible)
            {
                this.Width = 900;
                this.Height = 900;

            }

            
        }



        private void testBtn_Click(object sender, EventArgs e)
        {
            String connString = "Server=localhost;port=3306;Database=bankapp;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from users";
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
                testConLabel.Text = "conexiune buna";
                testLbl.Text += reader["username"].ToString()+" "+
                    /*reader["password"].ToString()+" "+*/
                    reader["first_name"].ToString()+ " " +
                    reader["last_name"].ToString()+" " +
                    reader["is_admin"].ToString()+"\n";
            }
        }
        private void testConn_Click(object sender, EventArgs e)
        {
            connect conn = new connect();
            conn.getConnection();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "open";
            connect con = new connect();
            con.getConnection().Close();
            button1.Text = "closed";
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            testLbl.Text = "";
            testConLabel.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            String connString = "Server=localhost;port=3306;Database=a1;Uid=root;password=ketchup";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select * from users";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                testConLabel.Text = ex.ToString();
            }
            MySqlDataReader reader = command.ExecuteReader();
            bool ok = false;
            //int i = 0;
            while (reader.Read())
            {

                testConLabel.Text = "conexiune buna";
                if (reader["username"].ToString() == textBox1.Text &&
                    reader["password"].ToString() == textBox2.Text)
                {
                    Console.WriteLine("username bun");
                    
                    try
                    {
                        if (reader["isadmin"].ToString() == "1")
                        {
                            
                            AdminForm a1 = new AdminForm();
                            a1.Show();
                            ok = true;
                            this.Hide();
                            break;

                        }
                        else if (reader["isadmin"].ToString() == "0")
                        {
                            
                            UserForm u1 = new UserForm();
                            u1.Show();
                            this.Hide();
                            ok = true;
                            //this.Close();
                            break;
                        }
                        
                    }
                    catch(Exception e1)
                    {
                        Console.WriteLine(e1);
                    }
                }
            }
            if (ok == false)
            {
                MessageBox.Show("Wrong username/password try again!", "Incorrect username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
