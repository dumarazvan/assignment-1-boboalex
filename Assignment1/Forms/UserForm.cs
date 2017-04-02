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

namespace Assignment1.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            panelShowClients.Visible = false;
            panelAddClient.Visible = false;
            panelUpdateClient.Visible = false;
            logoutBtn.Width = this.Width;


            panelAddAccount.Visible = false;
            panelUpdateAccount.Visible = false;
            panelDeleteAccount.Visible = false;
            panelViewAccount.Visible = false;

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Close() ;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowClients.Visible = false;
            panelUpdateClient.Visible = false;
            panelAddClient.Visible = true;
            panelAddClient.Width = this.Width - 30;
            panelAddClient.Height = this.Height - 100;
        }
        private void viewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAddClient.Visible = false;
            panelUpdateClient.Visible = false;

            panelShowClients.Visible = true;
            panelShowClients.Width = this.Width - 25;
            panelShowClients.Height = this.Height - 100;
            panelShowClients.Location = panelAddClient.Location;


        }
        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowClients.Visible = false;
            panelAddClient.Visible = false;

            panelUpdateClient.Visible = true;
            panelUpdateClient.Width = this.Width - 30;
            panelUpdateClient.Height = this.Height - 100;
            panelUpdateClient.Location = panelAddClient.Location;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clientDB db = new clientDB();
            if (txtAddName.Text != "" && txtAddIDCard.Text != "" && txtAddPNC.Text != "" && txtAddAddress.Text != "")
                db.insertClient(txtAddName.Text, txtAddIDCard.Text, txtAddPNC.Text, txtAddAddress.Text);
            else MessageBox.Show("All fields must be filled!", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showAddClientLbl.Text = db.ShowClients();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close() ;
        }

        private void showClientsBtn_Click(object sender, EventArgs e)
        {
            clientDB db = new clientDB();
            showClientListLbl.Text = db.ShowClients();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            clientDB db = new clientDB();
            if (txtUName.Text != "" && txtUidCard.Text != "" && txtUPNC.Text != "" && txtUAddress.Text != "")
                db.updateClient(txtUName.Text, txtUidCard.Text, txtUPNC.Text, txtUAddress.Text,txtUpdatePNC.Text);
            else MessageBox.Show("All fields must be filled!", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showClientsUpdatedLbl.Text = db.ShowClients();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelUpdateAccount.Visible = false;
            panelDeleteAccount.Visible = false;
            panelViewAccount.Visible = false;
            panelAddAccount.Visible = true;

            panelAddAccount.Location = panelAddClient.Location;
            panelAddAccount.Width = this.Width - 30;
            panelAddAccount.Height = this.Height - 100;

        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdateAccount.Visible = true;
            panelDeleteAccount.Visible = false;
            panelViewAccount.Visible = false;
            panelAddAccount.Visible = false;

            panelUpdateAccount.Location = panelAddClient.Location;
            panelUpdateAccount.Width = this.Width - 30;
            panelUpdateAccount.Height = this.Height - 100;
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdateAccount.Visible = false;
            panelDeleteAccount.Visible = true;
            panelViewAccount.Visible = false;
            panelAddAccount.Visible = false;

            panelDeleteAccount.Location = panelAddClient.Location;
            panelDeleteAccount.Width = this.Width - 30;
            panelDeleteAccount.Height = this.Height - 100;
        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdateAccount.Visible = false;
            panelDeleteAccount.Visible = false;
            panelViewAccount.Visible = true;
            panelAddAccount.Visible = false;

            panelViewAccount.Location = panelAddClient.Location;
            panelViewAccount.Width = this.Width - 30;
            panelViewAccount.Height = this.Height - 100;
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            accountDB db = new accountDB();
            if (txtAddIDNum.Text != "" && txtAddType.Text != "" && txtAddAmount.Text != "" && txtAddDate.Text != "")
                db.createAccount(txtAddIDNum.Text, txtAddType.Text, txtAddAmount.Text, txtAddDate.Text);
            else MessageBox.Show("All fields must be filled!", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showAddAccount.Text = db.ShowAccounts();
        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowClients.Visible = false;
            panelUpdateClient.Visible = false;
            panelAddClient.Visible = false;
        }

        private void clientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdateAccount.Visible = false;
            panelDeleteAccount.Visible = false;
            panelViewAccount.Visible = false;
            panelAddAccount.Visible = false;
        }

        private void showAccountsBtn_Click(object sender, EventArgs e)
        {
            accountDB db = new accountDB();
            showAccountsLbl.Text = db.ShowAccounts();
        }

        private void updateAccountBtn_Click(object sender, EventArgs e)
        {
            
            accountDB db = new accountDB();
            if (txtUpdateIDNum.Text != "" && txtUpdateType.Text != "" && txtUpdateAmount.Text != "" && txtUpdateDate.Text != "")
                db.updateAccountByIdnum(txtUpdateIDNum.Text, txtUpdateType.Text, txtUpdateAmount.Text, txtUpdateDate.Text, txtUpdateAccountByIDNUM.Text);
            else MessageBox.Show("All fields must be filled!", "Some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowUpdateAccountLbl.Text = db.ShowAccounts();
            txtUpdateIDNum.Text = "";
            txtUpdateType.Text = "";
            txtUpdateAmount.Text = "";
            txtUpdateDate.Text = "";
            txtUpdateAccountByIDNUM.Text = "";
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            accountDB db = new accountDB();
            db.deleteAccountByIdnum(txtDelAccountIDNum.Text);
        }

        private void showDelAccountBtn_Click(object sender, EventArgs e)
        {
            accountDB db = new accountDB();
            showDelAccountsLbl.Text = db.ShowAccounts();
        }
    }
}
