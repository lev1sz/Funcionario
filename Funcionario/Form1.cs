using DotNetEnv;
using static Funcionario.DatabaseHelper;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        private readonly string? connectionString;
        public Form1()
        {
            InitializeComponent();
            Env.Load();
            try
            {
                connectionString = GetConnectionString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as variáveis de ambiente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblNome.Text = $"Conectado ao banco de dados!";
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    CadastroFuncionario cadastro = new CadastroFuncionario
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cpf = txtCpf.Text,
                        Endereco = txtEndereco.Text
                    };
                    if (cadastro.cadastrarFuncionario())
                    {
                        MessageBox.Show($"Funcionário {cadastro.Nome} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencher todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
