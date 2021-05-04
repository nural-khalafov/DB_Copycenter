using System;
using System.Security.Cryptography;
using System.Text;
using Npgsql;
using NpgsqlTypes;

namespace DB_Copycenter
{
    public class Database
    {
        private static string Host = "127.0.0.1";
        private static string User = "postgres";
        private static string DBname = "Copycenter";
        private static string Password = "1gfkflby1";
        private static string Port = "5432";

        private static string connString =
            String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                Host,
                User,
                DBname,
                Port,
                Password);

        private NpgsqlConnection conn = new NpgsqlConnection(connString);

        public Database()
        {
            Console.Out.WriteLine("Opening connection");
            conn.Open();
        }

        ~Database()
        {
            Console.Out.WriteLine("Closing connection");
            conn.Close();
        }

        public string GetHash(string password)
        {
            var md5 = MD5.Create();

            return Encoding.ASCII.GetString(md5.ComputeHash(Encoding.ASCII.GetBytes(password)));
        }

        #region Npgsql INSERT Methods

        /// <summary>
        /// Test request to the database
        /// </summary>
        public void InsertTestRequest()
        {
            using (var command = new NpgsqlCommand("INSERT INTO Client (login, password, fio, self_cash)" +
                                                   "VALUES (@login1, @password1, @fio1, @selfCash1)", conn))
            {
                command.Parameters.AddWithValue("login1", "client3");
                command.Parameters.AddWithValue("password1", "qwerty228");
                command.Parameters.AddWithValue("fio1", "Ай Мляяя");
                command.Parameters.AddWithValue("selfCash1", 1000);

                int nRows = command.ExecuteNonQuery();
                Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
            }
        }

        /// <summary>
        /// INSERT request for user registration
        /// </summary>
        /// <param name="user">Current User</param>
        /// <returns></returns>
        public int InsertUserData(User user)
        {
            using (var command = new NpgsqlCommand("INSERT INTO Client (login, password, fio, self_cash) " +
                "VALUES (@log1, @pas1, @fio1, @cash1) RETURNING id", conn))
            {
                command.Parameters.AddWithValue("log1", user.Login);
                command.Parameters.AddWithValue("pas1", GetHash(user.Password));
                command.Parameters.AddWithValue("fio1", user.Fio);
                command.Parameters.AddWithValue("cash1", user.SelfCash);

                var reader = command.ExecuteReader();
                reader.Read();
                var id = reader.GetInt32(0);
                reader.Close();

                return id;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        public void InsertWorkerData(Worker worker)
        {

        }

        /// <summary>
        /// Sends a payment to the database
        /// </summary>
        /// <param name="user">Current User</param>
        public void InsertPayment(User user)
        {
            using (var command = new NpgsqlCommand("INSERT INTO Payment (client_id, filial_id, payment_time, payment_status) " + 
                "VALUES (@cl_id, @fil_id, @pay_time, @pay_status)", conn))
            {
                command.Parameters.AddWithValue("cl_id", user.Id);
                command.Parameters.AddWithValue("fil_id", 1);
                command.Parameters.AddWithValue("pay_time", Time.PaymentTime.ToString("g"));
                command.Parameters.AddWithValue("pay_status", "in process");
            }
        }

        /// <summary>
        /// Sends service/services data into ServicesInPayment table
        /// </summary>
        /// <param name="paymentId">Current payment ID</param>
        /// <param name="service">Current selected service/services</param>
        public void InsertServicesInPayment(int paymentId, Service service)
        {
            using (var command = new NpgsqlCommand("INSERT INTO ServicesInPayment (payment_id, service_id) " + 
                                                   "VALUES (@pay_id, @serv_id)", conn))
            {
                command.Parameters.AddWithValue("pay_id", paymentId);
                command.Parameters.AddWithValue("serv_id", service.ServiceId);
            }
        }

        /// <summary>
        /// INSERT Report data request for bookkeeeper
        /// </summary>
        /// <param name="income">Filial's income</param>
        /// <param name="descripton">Report's description</param>
        /// <param name="costs">Filial's costs</param>
        public void InsertReportData(int income, string descripton, int costs)
        {
            using (var command = new NpgsqlCommand("INSERT INTO Report (filial_id, creation_date, " +
                                                   "income, description, costs)" +
                                                   "VALUES (@fil_id, @cr_date, @inc, @desc, @cost)"))
            {
                command.Parameters.AddWithValue("fil_id", 1);
                command.Parameters.AddWithValue("cr_date", Time.ReportTime.ToString("g"));
                command.Parameters.AddWithValue("inc", income);
                command.Parameters.AddWithValue("desc", descripton);
                command.Parameters.AddWithValue("@cost", costs);
            }
        }

        #endregion

        #region Npgsql SELECT Methods

        /// <summary>
        /// Returns all data from Client
        /// </summary>
        /// <param name="login">Current client login</param>
        /// <returns>Returns execute reader method</returns>
        public NpgsqlDataReader SelectFromUsersTable(string login)
        {
            var command = new NpgsqlCommand("SELECT * FROM Client WHERE login = '" + login + "'", conn);

            return command.ExecuteReader();
        }

        public NpgsqlDataReader SelectFromWorkerTable(string login)
        {
            var command = new NpgsqlCommand("SELECT * FROM Worker JOIN Position ON Position.id = position.id " +
                                            "JOIN Client ON Client.id = client_id WHERE login = '" + login + "'", conn);

            return command.ExecuteReader();
        }

        public NpgsqlDataReader SelectFromWorkerTable()
        {
            var command = new NpgsqlCommand("SELECT * FROM Worker JOIN Position ON (Position.id = Worker.position_id)", conn);

            return command.ExecuteReader();
        }

        //public NpgsqlDataReader SelectFromServiceTable(string name)
        //{
        //    var command = new NpgsqlCommand("SELECT * FROM Service WHERE id = '" + name + "'", conn);
        //
        //    return command.ExecuteReader();
        //}

        /// <summary>
        /// Returns all fields from Report
        /// </summary>
        /// <returns>Returns execute reader method</returns>
        public NpgsqlDataReader SelectFromReportTable()
        {
            var command = new NpgsqlCommand("SELECT description, creation_date, income, costs FROM Report", conn);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns clients fio and cash
        /// </summary>
        /// <returns>Returns execute reader method</returns>
        public NpgsqlDataReader SelectClientDataFromUserTable()
        {
            var command = new NpgsqlCommand("SELECT fio, self_cash FROM Client", conn);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns client from street data
        /// </summary>
        /// <returns></returns>
        public NpgsqlDataReader SelectClientFromStreetData()
        {
            var command = new NpgsqlCommand("SELECT fio, self_cash FROM Client WHERE id = 1", conn);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns all in progress payments
        /// </summary>
        /// <param name="paymentStatus">Payment status</param>
        /// <returns>Returns execute reader method</returns>
        public NpgsqlDataReader SelectInProgressPaymentsFromPaymentTable(string paymentStatus)
        {
            var command = new NpgsqlCommand("SELECT * FROM Payment WHERE payment_status = 'In progress'", conn);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns all workers, except admin of copycenter
        /// </summary>
        /// <param name="position">Position that not equals Администратор</param>
        /// <returns></returns>
        public NpgsqlDataReader SelectWorkerDataFromWorkerTable(string position)
        {
            var command = new NpgsqlCommand("SELECT Client.fio, Position.position, Worker.work_experience, Position.salary " +
                                            "FROM Worker " +
                                            "JOIN Client ON Client.id = client_id " +
                                            "JOIN Position ON Position.id = position_id " +
                                            "WHERE NOT position = 'Администратор'", conn);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns current inventory data for bookkeeper
        /// </summary>
        /// <returns></returns>
        public NpgsqlDataReader SelectInventoryDataFromInventoryTable()
        {
            var command = new NpgsqlCommand("SELECT name, quantity, costs FROM Inventory", conn);

            return command.ExecuteReader();
        }

        

        #endregion

        #region Npgsql UPDATE Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="paymentId"></param>
        public void UpdatePaymentStatusToDone(DateTime date, int paymentId)
        {
            var command = new NpgsqlCommand("UPDATE Payment SET payment_status = 'Done', " +
                                            "payment_time = '" + date.Date + "' WHERE id = " + paymentId, conn);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates NotClient payment status to Done
        /// </summary>
        /// <param name="date">Payment date</param>
        public void UpdateNotClientPaymentStatusToDone(DateTime date)
        {
            var command = new NpgsqlCommand("UPDATE Payment SET payment_status = 'Done', " +
                                            "payment_time = '" + date.Date + "' WHERE client_id = 1", conn);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workExperience"></param>
        /// <param name="workerId"></param>
        /// <param name="workerPositionId"></param>
        public void UpdateWorkerData(int workExperience, int workerId, int workerPositionId)
        {
            var command = new NpgsqlCommand("UPDATE Worker SET work_experience = " + workExperience + " WHERE id = " + workerId + ", " +
                                            "position_id = ", conn);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workerPosition"></param>
        /// <param name="workerSalary"></param>
        /// <param name="workerId"></param>
        public void UpdateWorkerPositionData(string workerPosition, int workerSalary, int workerId)
        {
            var command = new NpgsqlCommand("UPDATE Position SET position = '" + workerPosition + "', " +
                                            "salary = " + workerSalary + " WHERE id = " + workerId, conn);

            command.ExecuteNonQuery();
        }

        public void UpdateInventoryData(int quantity, string name, int costPerUnit)
        {
            var command = new NpgsqlCommand("UPDATE Inventory SET filial_id = 1, " +
                                            "quantitiy = " + quantity + ", name = '" + name + "', cost_per_unit = " + costPerUnit + "", conn);

            command.ExecuteNonQuery();
        }

        #endregion

        #region Npgsql DELETE Methods

        

        #endregion
    }
}
