using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Copycenter.Forms;
using Npgsql;

namespace DB_Copycenter
{
    public partial class Autorization : Form
    {
        private User _user;
        private Worker _worker;

        private string _login;
        private string _password;
        private string _passwordHashed;
        private bool _isLoginExists = false;

        public Autorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _login = loginTextBox.Text;
            _password = passwordTextBox.Text;

            _passwordHashed = DBHandler.GetDatabase().GetHash(_password);

            var reader = DBHandler.GetDatabase().SelectFromUsersTable(_login);

            reader.Read();

            if (reader.IsOnRow)
            {
                _isLoginExists = true;
                _user = new User(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetInt32(4));
                _user.Id = reader.GetInt32(0);
                reader.Close();

                if (_passwordHashed == _user.Password)
                {
                    //reader = DBHandler.GetDatabase().SelectFromUsersTable(_user.Login);
                    reader = DBHandler.GetDatabase().SelectFromWorkerTable(_user.Login);
                    reader.Read();
                    if (reader.IsOnRow)
                    {
                        var worker = new Worker(_user, reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4),
                            reader.GetString(7), reader.GetInt32(5), reader.GetInt32(8));
                        if (_worker.Position == "Администратор")
                        {
                            
                            var adminForm = new AdminForm(worker);
                            reader.Close();

                            adminForm.Show();
                            Hide();

                            MessageBox.Show("You logged in as Admin");
                        }
                    }
                    
                    var client = new User(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetInt32(4));
                    reader.Close();

                    var clientForm = new ClientForm(client);

                    clientForm.Show();
                    Hide();

                    MessageBox.Show("You logged in as Client!");
                }
                else
                {
                    MessageBox.Show("Password is Invalid. Please, try again...");
                }
            }
            else
            {
                _isLoginExists = true;
                reader.Read();

                if (reader.IsOnRow)
                {
                    //else if ()
                    //{

                    //}
                    //else if ()
                    //{

                    //}
                }
            }
            if (!_isLoginExists)
            {
                reader.Close();
                var regForm = new RegistrationForm();

                regForm.Show();
                Hide();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();

            regForm.Show();
            Hide();
        }
    }
}
