using Assignment1.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;
            panelDeleteUser.Visible = false;
            panelShowUsers.Visible = false;
        }



        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = true;
            panelUpdateUser.Visible = false;
            panelShowUsers.Visible = false;
            panelDeleteUser.Visible = false;

            panelAddUser.Width = this.Width-20 ;
            panelAddUser.Height = this.Height - 130;
            

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Location = panelAddUser.Location;
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = true;
            panelDeleteUser.Visible = false;
            panelShowUsers.Visible = false;


            panelUpdateUser.Width = this.Width-20 ;
            panelUpdateUser.Height = this.Height - 130;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDeleteUser.Location = panelAddUser.Location;
            panelDeleteUser.Visible = true;
            panelShowUsers.Visible = false;
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;

            panelDeleteUser.Width = this.Width -20;
            panelDeleteUser.Height = this.Height - 130;
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAllBtn.Width = panelShowUsers.Width +50;
            panelShowUsers.Location = panelAddUser.Location;
            panelDeleteUser.Visible = false;
            panelShowUsers.Visible = true;
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;

            panelShowUsers.Width = this.Width -20;
            panelShowUsers.Height = this.Height - 130;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            userDB db = new userDB();
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtFname.Text != "" && txtAdminQ.Text != "")
                db.insertUser(txtUsername.Text, txtPassword.Text, txtFname.Text, txtAdminQ.Text);
            else MessageBox.Show("All fields must be filled!", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            usersLbl.Text = db.ShowUsers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newlogin = new Login();
            newlogin.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            userDB db = new userDB();
            db.updateUserbyUsername(txtUUsername.Text, txtUPassword.Text, txtUfullname.Text, txtUAdminQ.Text, txtIdUpdate.Text);
            usersULbl.Text = db.ShowUsers();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void showDUsersBtn_Click(object sender, EventArgs e)
        {
            userDB db = new userDB();
            usersDLbl.Text = db.ShowUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userDB db = new userDB();
            db.deleteById(txtDeleteId.Text);
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            userDB db = new userDB();
           showAllLbl.Text = db.ShowUsers();
        }
    }
}
