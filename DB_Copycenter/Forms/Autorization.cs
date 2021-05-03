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
        
        private string _login;
        private string _password;
        private string _passwordHashed;

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
                _user = new User(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetInt32(4));
                _user.Id = reader.GetInt32(0);
                reader.Close();

                if (_passwordHashed == _user.Password)
                {
                    reader = DBHandler.GetDatabase().SelectFromUsersTable(_user.Login);
                    reader.Read();

                    if (reader.IsOnRow)
                    {
                        var client = new User(reader.GetString(1),reader.GetString(3), reader.GetString(2), reader.GetInt32(4));
                        reader.Close();

                        var clientForm = new ClientForm(client);

                        clientForm.Show();
                        Hide();

                        MessageBox.Show("You logged in as Client!");
                        //if ("Admin")
                        //{
                        //    var Worker = new Worker(_user, reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3),
                        //        reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6));
                        //    reader.Close();
                        //
                        //    var workerForm = new WorkerForm(Worker);
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Password is Invalid. Please, try again...");
                }
                reader.Close();
            }
            else
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
