using MySql.Data.MySqlClient;
using static Funcionario.Services.FuncionarioServices;

namespace Funcionario.Tests
{
    public class FuncionarioServicesTests
    {
        [Fact(DisplayName = "Should INSERT a new Funcionario in database")]
        public void ShouldInsertNewFuncionarioInDatabase()
        {
            Exception? insertException = null;
            var funcionario = new Funcionario();
            funcionario.Nome = "Insert Test Name";
            funcionario.Email = "insert_test@email.com";
            funcionario.Cpf = "12345678901";
            funcionario.Endereco = "Rua Teste, 123";
            try
            {
                InsertFuncionario(funcionario);
                MySqlDataReader? result = ReadFuncionarioByCPF("12345678901");
                Assert.NotNull(result);
                result.Read();
                Assert.Equal(funcionario.Nome, result["nome"].ToString());
                Assert.Equal(funcionario.Email, result["email"].ToString());
                Assert.Equal(funcionario.Endereco, result["endereco"].ToString());
            }
            catch (Exception ex)
            {
                insertException = ex;
            }
            finally
            {
                DeleteFuncionario(funcionario);
            }
            Assert.Null(insertException);
        }
        /*[Fact(DisplayName = "Should READ a Funcionario in database")]
        public void ShouldReadFuncionarioInDatabase()
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Insert Test Name";
            funcionario.Email = "insert_test@email.com";
            funcionario.Cpf = "12345678901";
            funcionario.Endereco = "Rua Teste, 123";

            InsertFuncionario(funcionario);
            Assert.Equal(ReadFuncionario(funcionario));
        }*/

    }
}