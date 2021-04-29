namespace DB_Copycenter
{
    class User
    {
        public int id;
        public string login;
        public string password;

        public User(string login_, string password_)
        {
            login = login_;
            password = password_;
        }

        public User(User user)
        {
            login = user.password;
            password = user.password;
        }
    }
}
