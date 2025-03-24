namespace AT2_WFCadastroPessoa
{
    partial class FormCadastrar
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
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblNomeCompleto = new Label();
            lblDescricao = new Label();
            gpxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            lblEmail = new Label();
            txtEmail = new TextBox();
            cbfilhos = new CheckBox();
            mkttelefone = new MaskedTextBox();
            lblcpf = new Label();
            mktcpf = new MaskedTextBox();
            Salvar = new Button();
            btnVoltar = new Button();
            gpxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(74, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(97, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(74, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(74, 100);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 4;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(74, 204);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(80, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "DDD/Telefone";
            // 
            // gpxTipoTelefone
            // 
            gpxTipoTelefone.Controls.Add(rdbRecado);
            gpxTipoTelefone.Controls.Add(rdbComercial);
            gpxTipoTelefone.Controls.Add(rdbPessoal);
            gpxTipoTelefone.Location = new Point(261, 204);
            gpxTipoTelefone.Name = "gpxTipoTelefone";
            gpxTipoTelefone.Size = new Size(125, 100);
            gpxTipoTelefone.TabIndex = 12;
            gpxTipoTelefone.TabStop = false;
            gpxTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(30, 75);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(30, 50);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(30, 25);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(74, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 23);
            txtEmail.TabIndex = 14;
            // 
            // cbfilhos
            // 
            cbfilhos.AutoSize = true;
            cbfilhos.Location = new Point(77, 279);
            cbfilhos.Name = "cbfilhos";
            cbfilhos.Size = new Size(97, 19);
            cbfilhos.TabIndex = 15;
            cbfilhos.Text = "Possuí filhos?";
            cbfilhos.UseVisualStyleBackColor = true;
            // 
            // mkttelefone
            // 
            mkttelefone.Location = new Point(74, 222);
            mkttelefone.Mask = "(  )00000-9999";
            mkttelefone.Name = "mkttelefone";
            mkttelefone.Size = new Size(100, 23);
            mkttelefone.TabIndex = 16;
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(206, 49);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(28, 15);
            lblcpf.TabIndex = 17;
            lblcpf.Text = "CPF";
            // 
            // mktcpf
            // 
            mktcpf.Location = new Point(206, 74);
            mktcpf.Mask = "000,000,000-00";
            mktcpf.Name = "mktcpf";
            mktcpf.Size = new Size(180, 23);
            mktcpf.TabIndex = 18;
            // 
            // Salvar
            // 
            Salvar.Location = new Point(293, 351);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(93, 44);
            Salvar.TabIndex = 19;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(177, 351);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(93, 44);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 432);
            Controls.Add(btnVoltar);
            Controls.Add(Salvar);
            Controls.Add(mktcpf);
            Controls.Add(lblcpf);
            Controls.Add(mkttelefone);
            Controls.Add(cbfilhos);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(gpxTipoTelefone);
            Controls.Add(lblDescricao);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Name = "FormCadastrar";
            Text = "Cadastrar";
            Load += FormCadastrar_Load_1;
            gpxTipoTelefone.ResumeLayout(false);
            gpxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private Label lblCodigo;
        private Label lblNomeCompleto;
        private Label lblDescricao;
        private Label lblStatus;
        private DateTimePicker dtpData;
        private Label lblDatadeCadastro;
        private Button btnSalvar;
        private GroupBox gpxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Label lblEmail;
        private TextBox txtEmail;
        private CheckBox cbfilhos;
        private MaskedTextBox mkttelefone;
        private Label lblcpf;
        private MaskedTextBox mktcpf;
        private RadioButton rdbRecado;
        private Button Salvar;
        private Button btnVoltar;
    }
}
