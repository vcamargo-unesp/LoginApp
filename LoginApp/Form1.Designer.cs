namespace LoginApp
{
    partial class FrmLogin
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
            label1 = new Label();
            txtSenha = new MaskedTextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            chbExibir = new CheckBox();
            btEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(32, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 18F);
            txtSenha.Location = new Point(147, 117);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(182, 39);
            txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 18F);
            txtUsuario.Location = new Point(147, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 39);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(46, 120);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // chbExibir
            // 
            chbExibir.AutoSize = true;
            chbExibir.Font = new Font("Segoe UI", 18F);
            chbExibir.Location = new Point(147, 166);
            chbExibir.Name = "chbExibir";
            chbExibir.Size = new Size(160, 36);
            chbExibir.TabIndex = 4;
            chbExibir.Text = "Exibir senha";
            chbExibir.UseVisualStyleBackColor = true;
            chbExibir.CheckedChanged += chbExibir_CheckedChanged;
            // 
            // btEntrar
            // 
            btEntrar.Font = new Font("Segoe UI", 18F);
            btEntrar.Location = new Point(122, 208);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(104, 46);
            btEntrar.TabIndex = 5;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 306);
            Controls.Add(btEntrar);
            Controls.Add(chbExibir);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private CheckBox chbExibir;
        private Button btEntrar;
    }
}
