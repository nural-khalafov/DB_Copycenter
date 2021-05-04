using System;

namespace DB_Copycenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginService _service;

        public LoginPresenter(ILoginView view, ILoginService service)
        {
            this._view = view;
            this._service = service;

            _view.LoginEvent += () => Login(_view.Login, _view.Fio, _view.Password, _view.SelfCash);
        }

        public void Run()
        {
            _view.Show(new Autorization());
        }

        private void Login(string userLogin, string userFio, string userPassword, int userSelfCash)
        {
            if (null == userLogin)
            {
                throw new ArgumentNullException("Invalid username");
            }
            if (null == userPassword)
            {
                throw new ArgumentNullException("Password empty");
            }

            var user = new User(userLogin, userFio, userPassword, userSelfCash);

            if (!_service.Login(user))
            {
                _view.ShowError("Invalid username or password");
            }
            else
            {
                //Application.Run(new Form1());
            }
        }
    }
}