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
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Franklin Gothic Medium Cond", 12.75F);
            lblNome.Location = new Point(12, 5);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Franklin Gothic Medium Cond", 12.75F);
            lblEmail.Location = new Point(12, 34);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Franklin Gothic Medium Cond", 12.75F);
            lblCpf.Location = new Point(12, 63);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(38, 21);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Franklin Gothic Medium Cond", 12.75F);
            lblEndereco.Location = new Point(12, 92);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 21);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Franklin Gothic Book", 14.25F);
            txtNome.Location = new Point(92, 5);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 29);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Franklin Gothic Book", 14.25F);
            txtEmail.Location = new Point(92, 34);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 29);
            txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Franklin Gothic Book", 14.25F);
            txtCpf.Location = new Point(92, 63);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(202, 29);
            txtCpf.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Franklin Gothic Book", 14.25F);
            txtEndereco.Location = new Point(92, 92);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(202, 29);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastra
            // 
            btnCadastra.Font = new Font("Franklin Gothic Medium Cond", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastra.Location = new Point(212, 127);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(82, 27);
            btnCadastra.TabIndex = 5;
            btnCadastra.Text = "Cadastrar";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 157);
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
    }
}
