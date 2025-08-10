using MySql.Data.MySqlClient;
namespace Funcionario
{
    public class Funcionario
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
    }
}