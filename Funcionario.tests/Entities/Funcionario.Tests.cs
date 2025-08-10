namespace Funcionario.Tests
{
    public class FuncionarioTests
    {
        [Fact(DisplayName = "Should create a new Funcionario instance")]
        public void ShouldCreateNewFuncionarioInstance()
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Test Name";
            funcionario.Email = "test@email.com";
            funcionario.Cpf = "12345678901";
            funcionario.Endereco = "Rua Teste, 123";
            Assert.NotNull(funcionario);
            Assert.Equal("Test Name", funcionario.Nome);
            Assert.Equal("test@email.com", funcionario.Email);
            Assert.Equal("12345678901", funcionario.Cpf);
            Assert.Equal("Rua Teste, 123", funcionario.Endereco);
        }
    }
}