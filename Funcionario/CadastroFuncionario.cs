using MySql.Data.MySqlClient;
using static Funcionario.DatabaseHelper;

namespace Funcionario
{
    class CadastroFuncionario
    {
        // 1. Campos PRIVADOS com _camelCase
        private int _id;
        private string? _nome;
        private string? _email;
        private string? _cpf;
        private string? _endereco;

        // 2. Propriedades PÚBLICAS com PascalCase
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
        public bool cadastrarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(GetConnectionString());
                MySqlConnection.Open();

                string insert = $"INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES ('{Nome}', '{Email}', '{Cpf}', '{Endereco}')";

                MySqlCommand sqlCommand = MySqlConnection.CreateCommand();
                sqlCommand.CommandText = insert;

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:{ex.Message}");
            }
            return false;
        }
    }
}