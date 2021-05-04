namespace DB_Copycenter
{
    public class Bookkeeper : User
    {
        public int BookkeeperId;
        public int ClientId;
        public int PositionId;
        public int FilialId;

        public int WorkExperience;
        public int Salary;

        public string Position;

        public Bookkeeper(string login, string fio, string password,
            int selfCash, int bookkeeperId, int positionId, int filialId, string position) : base(login, fio, password, selfCash)
        {
            this.BookkeeperId = bookkeeperId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;

            WorkExperience = 0;
            Salary = 0;
        }

        public Bookkeeper(User user, int bookkeeperId, int clientId, int positionId, int filialId,
            string position, int workExperience, int salary) : base(user)
        {
            this.BookkeeperId = bookkeeperId;
            this.ClientId = clientId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;
            this.WorkExperience = workExperience;
            this.Salary = salary;
        }
    }
}