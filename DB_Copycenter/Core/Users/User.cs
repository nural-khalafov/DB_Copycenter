namespace DB_Copycenter
{
    public class User
    {
        public int Id;
        public int SelfCash;
        public string Login;
        public string Fio;
        public string Password;

        public User(string login, string fio, string password, int selfCash)
        {
            this.Login = login;
            this.Fio = fio;
            this.Password = password;
            this.SelfCash = selfCash;
        }

        public User(User user)
        {
            this.Login = user.Login;
            this.Fio = user.Fio;
            this.Password = user.Password;
            this.SelfCash = user.SelfCash;
        }
    }
}