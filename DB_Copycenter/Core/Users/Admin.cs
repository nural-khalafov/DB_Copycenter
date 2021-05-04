namespace DB_Copycenter
{
    public class Admin : User
    {
        public int AdminId;
        public int ClientId;
        public int PositionId;
        public int FilialId;

        public int WorkExperience;
        public int Salary;

        public string Position;

        public Admin(string login, string fio, string password,
            int selfCash, int adminId, int positionId, int filialId, string position) : base(login, fio, password, selfCash)
        {
            this.AdminId = adminId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;

            WorkExperience = 0;
            Salary = 0;
        }

        public Admin(User user, int adminId, int clientId, int positionId, int filialId,
            string position, int workExperience, int salary) : base(user)
        {
            this.AdminId = adminId;
            this.ClientId = clientId;
            this.PositionId = positionId;
            this.FilialId = filialId;
            this.Position = position;
            this.WorkExperience = workExperience;
            this.Salary = salary;
        }
    }
}