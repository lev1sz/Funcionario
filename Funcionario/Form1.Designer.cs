namespace Funcionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblEndereco = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            btnCadastra = new Button();
            btnPesquisar = new Button();
            btnAtualizar = new Button();
            lblIdTexto = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Leelawadee UI", 12F);
            lblNome.Location = new Point(12, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Leelawadee UI", 12F);
            lblEmail.Location = new Point(12, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Leelawadee UI", 12F);
            lblCpf.Location = new Point(12, 126);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(40, 21);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Leelawadee UI", 12F);
            lblEndereco.Location = new Point(12, 165);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(77, 21);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Leelawadee UI", 14.25F);
            txtNome.Location = new Point(95, 48);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 33);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Leelawadee UI", 14.25F);
            txtEmail.Location = new Point(95, 87);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 33);
            txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Leelawadee UI", 14.25F);
            txtCpf.Location = new Point(95, 126);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(309, 33);
            txtCpf.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Leelawadee UI", 14.25F);
            txtEndereco.Location = new Point(95, 165);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(309, 33);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastra
            // 
            btnCadastra.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastra.Location = new Point(307, 204);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(90, 35);
            btnCadastra.TabIndex = 5;
            btnCadastra.Text = "Cadastrar";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(211, 204);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(90, 35);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(115, 204);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(90, 35);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblIdTexto
            // 
            lblIdTexto.AutoSize = true;
            lblIdTexto.Font = new Font("Leelawadee UI", 12F);
            lblIdTexto.Location = new Point(12, 9);
            lblIdTexto.Name = "lblIdTexto";
            lblIdTexto.Size = new Size(131, 21);
            lblIdTexto.TabIndex = 8;
            lblIdTexto.Text = "Id do funcionário:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Leelawadee UI", 12F);
            lblId.Location = new Point(149, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 21);
            lblId.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 248);
            Controls.Add(lblId);
            Controls.Add(lblIdTexto);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastra);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblEndereco);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblEndereco;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Button btnCadastra;
        private Button btnPesquisar;
        private Button btnAtualizar;
        private Label lblIdTexto;
        private Label lblId;
    }
}
