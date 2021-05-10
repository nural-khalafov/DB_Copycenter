namespace DB_Copycenter
{
    public class DBHandler
    {
        public static Database db;

        static DBHandler()
        {
            db = new Database();
        }

        public static ref Database GetDatabase()
        {
            return ref db;
        }
    }
}