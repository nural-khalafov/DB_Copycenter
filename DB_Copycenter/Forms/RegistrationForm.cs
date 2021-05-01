﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Copycenter
{
    public partial class RegistrationForm : Form
    {
        private Autorization autorizationForm;

        private string _login;
        private string _nameAndSurname;
        private string _password;
        private string _passwordConfirm;

        public RegistrationForm()
        {
            InitializeComponent();

            autorizationForm = new Autorization();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            _login = loginTextBox.Text;
            _nameAndSurname = nameSurnameTextBox.Text;
            _password = passwordTextBox.Text;
            _passwordConfirm = confirmPassTextBox.Text;

            if (_password != _passwordConfirm)
            {
                //throw new ArgumentNullException("Password is Incorrect");
                MessageBox.Show("Password is Incorrect");
            }
            else
            {
                
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            autorizationForm.Show();
            this.Close();
        }
    }
}
