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
    public partial class Autorization : Form
    {
        private int _loginId;
        private string _password;
        private string _passwordHashed;

        public Autorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();

            regForm.Show();
            Hide();
        }
    }
}
