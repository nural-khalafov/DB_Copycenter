namespace DB_Copycenter
{
    class Client : User
    {
        public int client_id;
        public string own_data;
        public float own_cash;

        public Client(string login_, string password_) : base(login_, password_)
        {
            own_data = "";
            own_cash = 0;
        }

        public Client(User user) : base(user)
        {
        }
    }
}
