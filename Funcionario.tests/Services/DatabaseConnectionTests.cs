using MySql.Data.MySqlClient;
using static Funcionario.Services.DatabaseConnection;

namespace Funcionario.Tests
{
    public class DatabaseConnectionTests
    {
        [Fact(DisplayName = "Should open connection successfully")]
        public void ShouldOpenConnectionSuccesfully()
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