﻿using Cuestionarios.Controllers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NewUser : Form
    {
        private readonly UserController _usrController = new UserController();
        public NewUser()
        {
            InitializeComponent();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User")
            {
                txtuser.Text = "";
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User";
            }
        }

        private void texpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void texpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.UseSystemPasswordChar = false;

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                _usrController.AddUser(txtuser.Text, txtpass.Text, false);

                MessageBox.Show("User added successfully");
                
                this.Hide();
                //Login login = new Login();
                //login.ShowDialog();
                this.Close();
            }
            catch (NpgsqlException exc)
            {
                MessageBox.Show("Error on the database operation: ", exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unknown Error: ", exc.Message);
            }
        }

        private void brnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Login login = new Login();
            //login.ShowDialog();
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}