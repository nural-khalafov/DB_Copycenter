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
            User user;
            Worker worker;

            _login = loginTextBox.Text;
            _password = passwordTextBox.Text;

            _passwordHashed = DBHandler.GetDatabase().GetHash(_password);

            var reader = DBHandler.GetDatabase().SelectFromUsersTable(_login);

            reader.Read();

            if (reader.IsOnRow)
            {
                _isLoginExists = true;
                user = new User(reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetInt32(4));
                user.Id = reader.GetInt32(0);
                
                reader.Close();

                if (_passwordHashed == user.Password)
                {
                    reader = DBHandler.GetDatabase().SelectPositionFromWorkerTable(user.Login);

                    if (reader.Read())
                    {
                        worker = new Worker(user, reader.GetString(0));
                        reader.Close();
                        switch (worker.Position)
                        {
                            case "Администратор":
                                reader = DBHandler.GetDatabase().SelectFromWorkerTable(user.Login);
                                reader.Read();
                                worker = new Worker(user, reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3),
                                    reader.GetString(6), reader.GetInt32(4), reader.GetInt32(7));
                                reader.Close();
                                var adminForm = new AdminForm(worker);

                                adminForm.Show();
                                Hide();

                                MessageBox.Show("You logged in as Admin");
                                return;
                            case "Бухгалтер":
                                reader = DBHandler.GetDatabase().SelectFromWorkerTable(user.Login);
                                reader.Read();
                                worker = new Worker(user, reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3),
                                    reader.GetString(6), reader.GetInt32(4), reader.GetInt32(7));
                                reader.Close();
                                var bookkeeperForm = new BookkeeperForm(worker);

                                bookkeeperForm.Show();
                                Hide();

                                MessageBox.Show("You logged in as Bookkeeper");

                                return;
                            case "Работник":
                                reader = DBHandler.GetDatabase().SelectFromWorkerTable(user.Login);
                                reader.Read();
                                worker = new Worker(user, reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3),
                                    reader.GetString(6), reader.GetInt32(4), reader.GetInt32(7));
                                reader.Close();
                                var workerForm = new WorkerForm(worker);

                                workerForm.Show();
                                Hide();

                                MessageBox.Show("You logged in as Worker");

                                return;
                        }
                    }
                    reader.Close();
                    
                }
                else
                {
                    MessageBox.Show("Password is Invalid. Please, try again...");
                }

                reader = DBHandler.GetDatabase().SelectFromUsersTable(_login);
                reader.Read();

                if (_passwordHashed == user.Password)
                {
                    if (reader.IsOnRow)
                    {
                        var client = user;
                        reader.Close();

                        var clientForm = new ClientForm(client);

                        clientForm.Show();
                        Hide();

                        MessageBox.Show("You logged in as Client!");
                    }
                }
                else
                {
                    MessageBox.Show("Password is Invalid. Please, try again...");
                }
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
