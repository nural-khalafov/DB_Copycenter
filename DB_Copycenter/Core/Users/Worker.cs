namespace DB_Copycenter
{
    public class Worker : User
    {
        public int WorkerId;
        public int ClientId;
        public int PositionId;
        public int FilialId;

        public int WorkExperience;
        public int Salary;

        public string Position;


        public Worker(string login, string fio, string password, 
            int selfCash, int workerId, int positionId, int filialId, string position) : base(login, fio, password, selfCash)
        {
            this.WorkerId = workerId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;

            WorkExperience = 0;
            Salary = 0;
        }

        public Worker(User user, int workerId, int clientId, int positionId, int filialId, 
            string position, int workExperience, int salary) : base(user)
        {
            this.WorkerId = workerId;
            this.ClientId = clientId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;
            this.WorkExperience = workExperience;
            this.Salary = salary;
        }
    }
}
