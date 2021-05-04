using System;
using System.Windows.Forms;

namespace DB_Copycenter
{
    public interface IView
    {
        void Show(Form form);
        void Close();
    }

    public interface ILoginView : IView
    {
        string Login { get; }
        string Fio { get; }
        string Password { get; }
        int SelfCash { get; }

        event Action LoginEvent;
        void ShowError(string errorMessage);
    }
}