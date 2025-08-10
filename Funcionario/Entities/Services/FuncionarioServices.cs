using static Funcionario.Services.DatabaseConnection;
using MySql.Data.MySqlClient;

namespace Funcionario.Services
{
    public static class FuncionarioServices
    {
        public static bool InsertFuncionario(Funcionario funcionario)
        {
            try
            {
                string insert = $"INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES ('{funcionario.Nome}', '{funcionario.Email}', '{funcionario.Cpf}', '{funcionario.Endereco}')";
                ExecuteQuery(insert);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na inserção de dados:{ex.Message}");
            }
            return false;
        }
        public static MySqlDataReader? ReadFuncionarioByCPF (string funcionarioCpf)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(GetConnectionString());
                connection.Open();

                string select = $"SELECT Id, nome, email, cpf, endereco FROM funcionarios WHERE cpf = '{funcionarioCpf}';";
                MySqlCommand command = new MySqlCommand(select, connection);
                command.CommandText = select;

                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na leitura de dados: {ex.Message}");
            }
            return null;
        }
        public static bool UpdateFuncionario(Funcionario funcionario)
        {
            try
            {
                string update = $"UPDATE funcionarios SET email = '{funcionario.Email}', endereco = '{funcionario.Endereco}' WHERE id = '{funcionario.Id}'";
                ExecuteQuery(update);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na atualização de dados: {ex.Message}");
            }
            return false;
        }
        public static bool DeleteFuncionario(Funcionario funcionario)
        {
            try
            {
                DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {funcionario.Nome}?", "Confirmação", 
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
                string delete = $"DELETE FROM funcionarios WHERE id = '{funcionario.Id}'";
                string resetIdSequence = $"SET @num := 0; UPDATE Funcionarios SET id = @num := (@num+1); ALTER TABLE Funcionarios AUTO_INCREMENT = 1;";
                ExecuteQuery(delete);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na exclusão de dados: {ex.Message}");
            }
            return false;
        }
    }
}