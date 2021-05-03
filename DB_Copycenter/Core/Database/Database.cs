using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

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

        public void InsertTestRequest()
        {
            using (var command = new NpgsqlCommand("INSERT INTO Client(login, password, fio, self_cash)" +
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

        public void InsertAdminData()
        {
            using (var command = new NpgsqlCommand("SELECT * FROM"))
            {
                
            }
        }

        public string GetHash(string password)
        {
            var md5 = MD5.Create();

            return Encoding.ASCII.GetString(md5.ComputeHash(Encoding.ASCII.GetBytes(password)));
        }

        #region Npgsql Methods

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

        public NpgsqlDataReader SelectFromUsersTable(string login)
        {
            var command = new NpgsqlCommand("SELECT * FROM Client WHERE login = '" + login + "'", conn);

            return command.ExecuteReader();
        }

        #endregion
    }
}
