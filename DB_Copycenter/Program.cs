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
            Application.Run(new Autorization());

        }
    }
}
