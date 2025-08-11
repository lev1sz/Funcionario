using DotNetEnv;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static Funcionario.Services.DatabaseConnection;
using static Funcionario.Services.FuncionarioServices;

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
                    Funcionario cadastro = new Funcionario
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cpf = txtCpf.Text,
                        Endereco = txtEndereco.Text
                    };
                    if (InsertFuncionario(cadastro))
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCpf.Text))
                {
                    Funcionario pesquisa = new Funcionario();
                    pesquisa.Cpf = txtCpf.Text;
                    MySqlDataReader? reader = ReadFuncionarioByCPF(pesquisa.Cpf);
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        txtNome.Text = reader["nome"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtEndereco.Text = reader["endereco"].ToString();
                        lblId.Text = reader["Id"].ToString();
                        MessageBox.Show($"Funcionário encontrado: {txtNome.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencher o campo CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtCpf.Text) && !string.IsNullOrEmpty(txtEndereco.Text))
                {
                    Funcionario atualiza = new Funcionario();
                    atualiza.Nome = txtNome.Text;
                    atualiza.Cpf = txtCpf.Text;
                    atualiza.Email = txtEmail.Text;
                    atualiza.Endereco = txtEndereco.Text;
                    atualiza.Id = int.Parse(lblId.Text);
                    if (UpdateFuncionario(atualiza))
                    {
                        MessageBox.Show($"Funcionário \"{atualiza.Nome}\" atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        lblId.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, localizar o funcionário que deseja atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtCpf.Text) && !string.IsNullOrEmpty(txtEndereco.Text))
                {
                    Funcionario excluir = new Funcionario();
                    excluir.Nome = txtNome.Text;
                    excluir.Cpf = txtCpf.Text;
                    excluir.Email = txtEmail.Text;
                    excluir.Endereco = txtEndereco.Text;
                    excluir.Id = int.Parse(lblId.Text);
                    if (DeleteFuncionarioByCPF(excluir.Cpf))
                    {
                        MessageBox.Show($"Funcionário \"{excluir.Nome}\" excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        lblId.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, localizar o funcionário que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
