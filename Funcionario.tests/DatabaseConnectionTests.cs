using MySql.Data.MySqlClient;
using static Funcionario.DatabaseHelper;

namespace Funcionario.tests
{
    public class DatabaseConnectionTests
    {
        [Fact]
        public void ConnectionOpen()
        {
            Exception? connectionException = null;
            string connectionString = GetConnectionString();
            using var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                connectionException = ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            Assert.Null(connectionException);
        }
    }
}