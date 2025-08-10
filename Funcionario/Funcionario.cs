using static Funcionario.DatabaseHelper;
using MySql.Data.MySqlClient;
namespace Funcionario
{
    class Funcionario
    {
        private int _id;
        private string? _nome;
        private string? _email;
        private string? _cpf;
        private string? _endereco;
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string? Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string? Email
        {
            get => _email;
            set => _email = value;
        }
        public string? Cpf
        {
            get => _cpf;
            set => _cpf = value;
        }
        public string? Endereco
        {
            get => _endereco;
            set => _endereco = value;
        }
        public bool CadastrarFuncionario()
        {
            try
            {
                string insert = $"INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES ('{Nome}', '{Email}', '{Cpf}', '{Endereco}')";
                ExecuteQuery(insert);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:{ex.Message}");
            }
            return false;
        }

        public MySqlDataReader? PesquisarFuncionario()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(GetConnectionString());
                connection.Open();

                string select = $"SELECT Id, nome, email, cpf, endereco FROM funcionarios WHERE cpf = '{Cpf}';";
                MySqlCommand command = new MySqlCommand(select, connection);    
                command.CommandText = select;

                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            return null;
        }

        public bool AtualizarFuncionario()
        {
            try
            {
                string update = $"UPDATE funcionarios SET email = '{Email}', endereco = '{Endereco}' WHERE id = '{Id}'";
                ExecuteQuery(update);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            return false;
        }
        
        public bool ExcluirFuncionario()
        {
            try
            {
                DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {Nome}?", "Confirmação",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
                string delete = $"DELETE FROM funcionarios WHERE id = '{Id}'";
                ExecuteQuery(delete);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            return false;
        }
    }
}