using System;
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
        private readonly Autorization _autorizationForm;
        private User _user;

        private string _login;
        private string _fio;
        private string _password;
        private string _passwordConfirm;

        public RegistrationForm()
        {
            InitializeComponent();

            _autorizationForm = new Autorization();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            _login = loginTextBox.Text;
            _fio = fioTextBox.Text;
            _password = passwordTextBox.Text;
            _passwordConfirm = confirmPassTextBox.Text;

            if (_password != _passwordConfirm)
            {
                MessageBox.Show("Password is Incorrect");
            }
            else
            {
                _user = new User(_login, _fio, _password, 1000);
                _user.Id = DBHandler.GetDatabase().InsertUserData(_user);

                MessageBox.Show("Registration is successful!");
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _autorizationForm.Show();
            this.Close();
        }
    }
}
