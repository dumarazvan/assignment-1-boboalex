namespace Assignment1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.usersLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdminQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelUpdateUser = new System.Windows.Forms.Panel();
            this.usersULbl = new System.Windows.Forms.Label();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUAdminQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUfullname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDeleteUser = new System.Windows.Forms.Panel();
            this.showDUsersBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.usersDLbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelShowUsers = new System.Windows.Forms.Panel();
            this.showAllLbl = new System.Windows.Forms.Label();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panelUpdateUser.SuspendLayout();
            this.panelDeleteUser.SuspendLayout();
            this.panelShowUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.showAllToolStripMenuItem.Text = "Show all";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.SkyBlue;
            this.panelAddUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddUser.Controls.Add(this.usersLbl);
            this.panelAddUser.Controls.Add(this.label9);
            this.panelAddUser.Controls.Add(this.txtAdminQ);
            this.panelAddUser.Controls.Add(this.label5);
            this.panelAddUser.Controls.Add(this.btnAdd);
            this.panelAddUser.Controls.Add(this.txtFname);
            this.panelAddUser.Controls.Add(this.label3);
            this.panelAddUser.Controls.Add(this.txtPassword);
            this.panelAddUser.Controls.Add(this.label2);
            this.panelAddUser.Controls.Add(this.txtUsername);
            this.panelAddUser.Controls.Add(this.label1);
            this.panelAddUser.Location = new System.Drawing.Point(0, 56);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(245, 31);
            this.panelAddUser.TabIndex = 2;
            this.panelAddUser.Visible = false;
            // 
            // usersLbl
            // 
            this.usersLbl.AutoSize = true;
            this.usersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLbl.Location = new System.Drawing.Point(22, 175);
            this.usersLbl.Name = "usersLbl";
            this.usersLbl.Size = new System.Drawing.Size(0, 24);
            this.usersLbl.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Add User";
            // 
            // txtAdminQ
            // 
            this.txtAdminQ.Location = new System.Drawing.Point(118, 109);
            this.txtAdminQ.Name = "txtAdminQ";
            this.txtAdminQ.Size = new System.Drawing.Size(24, 20);
            this.txtAdminQ.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Admin:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(118, 83);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(120, 20);
            this.txtFname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "FullName:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUsername.Location = new System.Drawing.Point(118, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(428, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelUpdateUser
            // 
            this.panelUpdateUser.BackColor = System.Drawing.Color.SkyBlue;
            this.panelUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpdateUser.Controls.Add(this.usersULbl);
            this.panelUpdateUser.Controls.Add(this.txtIdUpdate);
            this.panelUpdateUser.Controls.Add(this.label10);
            this.panelUpdateUser.Controls.Add(this.txtUAdminQ);
            this.panelUpdateUser.Controls.Add(this.label4);
            this.panelUpdateUser.Controls.Add(this.btnUpdate);
            this.panelUpdateUser.Controls.Add(this.txtUfullname);
            this.panelUpdateUser.Controls.Add(this.label6);
            this.panelUpdateUser.Controls.Add(this.txtUPassword);
            this.panelUpdateUser.Controls.Add(this.label7);
            this.panelUpdateUser.Controls.Add(this.txtUUsername);
            this.panelUpdateUser.Controls.Add(this.label8);
            this.panelUpdateUser.Location = new System.Drawing.Point(0, 93);
            this.panelUpdateUser.Name = "panelUpdateUser";
            this.panelUpdateUser.Size = new System.Drawing.Size(245, 39);
            this.panelUpdateUser.TabIndex = 9;
            this.panelUpdateUser.Visible = false;
            // 
            // usersULbl
            // 
            this.usersULbl.AutoSize = true;
            this.usersULbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersULbl.Location = new System.Drawing.Point(27, 174);
            this.usersULbl.Name = "usersULbl";
            this.usersULbl.Size = new System.Drawing.Size(0, 24);
            this.usersULbl.TabIndex = 12;
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(137, 137);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(24, 20);
            this.txtIdUpdate.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Update User";
            // 
            // txtUAdminQ
            // 
            this.txtUAdminQ.Location = new System.Drawing.Point(118, 109);
            this.txtUAdminQ.Name = "txtUAdminQ";
            this.txtUAdminQ.Size = new System.Drawing.Size(24, 20);
            this.txtUAdminQ.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(47, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUfullname
            // 
            this.txtUfullname.Location = new System.Drawing.Point(118, 83);
            this.txtUfullname.Name = "txtUfullname";
            this.txtUfullname.Size = new System.Drawing.Size(120, 20);
            this.txtUfullname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "FullName:";
            // 
            // txtUPassword
            // 
            this.txtUPassword.Location = new System.Drawing.Point(118, 57);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(120, 20);
            this.txtUPassword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password:";
            // 
            // txtUUsername
            // 
            this.txtUUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUUsername.Location = new System.Drawing.Point(118, 31);
            this.txtUUsername.Name = "txtUUsername";
            this.txtUUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUUsername.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:";
            // 
            // panelDeleteUser
            // 
            this.panelDeleteUser.BackColor = System.Drawing.Color.SkyBlue;
            this.panelDeleteUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDeleteUser.Controls.Add(this.showDUsersBtn);
            this.panelDeleteUser.Controls.Add(this.label11);
            this.panelDeleteUser.Controls.Add(this.usersDLbl);
            this.panelDeleteUser.Controls.Add(this.btnDelete);
            this.panelDeleteUser.Controls.Add(this.txtDeleteId);
            this.panelDeleteUser.Controls.Add(this.label15);
            this.panelDeleteUser.Location = new System.Drawing.Point(0, 140);
            this.panelDeleteUser.Name = "panelDeleteUser";
            this.panelDeleteUser.Size = new System.Drawing.Size(245, 36);
            this.panelDeleteUser.TabIndex = 11;
            this.panelDeleteUser.Visible = false;
            // 
            // showDUsersBtn
            // 
            this.showDUsersBtn.Location = new System.Drawing.Point(144, 60);
            this.showDUsersBtn.Name = "showDUsersBtn";
            this.showDUsersBtn.Size = new System.Drawing.Size(75, 23);
            this.showDUsersBtn.TabIndex = 11;
            this.showDUsersBtn.Text = "Show users";
            this.showDUsersBtn.UseVisualStyleBackColor = true;
            this.showDUsersBtn.Click += new System.EventHandler(this.showDUsersBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Delete User";
            // 
            // usersDLbl
            // 
            this.usersDLbl.AutoSize = true;
            this.usersDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersDLbl.Location = new System.Drawing.Point(23, 92);
            this.usersDLbl.Name = "usersDLbl";
            this.usersDLbl.Size = new System.Drawing.Size(0, 24);
            this.usersDLbl.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDeleteId.Location = new System.Drawing.Point(84, 34);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(120, 20);
            this.txtDeleteId.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID: ";
            // 
            // panelShowUsers
            // 
            this.panelShowUsers.BackColor = System.Drawing.Color.SkyBlue;
            this.panelShowUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShowUsers.Controls.Add(this.showAllLbl);
            this.panelShowUsers.Controls.Add(this.showAllBtn);
            this.panelShowUsers.Location = new System.Drawing.Point(0, 187);
            this.panelShowUsers.Name = "panelShowUsers";
            this.panelShowUsers.Size = new System.Drawing.Size(245, 65);
            this.panelShowUsers.TabIndex = 12;
            this.panelShowUsers.Visible = false;
            // 
            // showAllLbl
            // 
            this.showAllLbl.AutoSize = true;
            this.showAllLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLbl.Location = new System.Drawing.Point(80, 45);
            this.showAllLbl.Name = "showAllLbl";
            this.showAllLbl.Size = new System.Drawing.Size(0, 24);
            this.showAllLbl.TabIndex = 2;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(61, 13);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(158, 23);
            this.showAllBtn.TabIndex = 1;
            this.showAllBtn.Text = "Show all";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(428, 473);
            this.Controls.Add(this.panelShowUsers);
            this.Controls.Add(this.panelDeleteUser);
            this.Controls.Add(this.panelUpdateUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin application";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.panelUpdateUser.ResumeLayout(false);
            this.panelUpdateUser.PerformLayout();
            this.panelDeleteUser.ResumeLayout(false);
            this.panelDeleteUser.PerformLayout();
            this.panelShowUsers.ResumeLayout(false);
            this.panelShowUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.TextBox txtAdminQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelUpdateUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUAdminQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUfullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelDeleteUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label usersDLbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelShowUsers;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label usersLbl;
        private System.Windows.Forms.Label usersULbl;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.Button showDUsersBtn;
        private System.Windows.Forms.Label showAllLbl;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
    }
}