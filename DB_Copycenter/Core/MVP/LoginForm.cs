using System;
using System.Windows.Forms;

namespace DB_Copycenter
{
    public partial class LoginForm : Form, ILoginView
    {
        public string Login { get; }
        public string Fio { get; }
        public string Password { get; }
        public int SelfCash { get; }
        
        public event Action LoginEvent;

        public void Show(Form form)
        {
            Application.Run(form);
        }
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
    }
}