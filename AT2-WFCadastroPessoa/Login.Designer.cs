namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            lblLogin = new Label();
            lblSenha = new Label();
            btnEnviar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(94, 68);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(94, 122);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(94, 179);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(100, 31);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(94, 86);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(94, 140);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 293);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnEnviar);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblSenha;
        private Button btnEnviar;
        private TextBox txtLogin;
        private TextBox txtSenha;
    }
}
