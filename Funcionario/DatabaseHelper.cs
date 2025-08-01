using DotNetEnv;
namespace Funcionario
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            Env.Load();

            string server = Env.GetString("Server");
            string dataBase = Env.GetString("DataBase");
            string user = Env.GetString("User");
            string password = Env.GetString("Password");
            if (string.IsNullOrEmpty(dataBase))
            {
                throw new InvalidOperationException("Database connection parameters are not set in the environment variables.");
            }
            return $"server={server}; database={dataBase}; user id={user}; password={password};";
        }
    }
}