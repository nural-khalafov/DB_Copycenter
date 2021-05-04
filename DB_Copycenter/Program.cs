using System;
using System.Windows.Forms;
using DB_Copycenter.Forms;

namespace DB_Copycenter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new LoginPresenter(new LoginForm(), new LoginService());

            presenter.Run();

        }
    }
}
