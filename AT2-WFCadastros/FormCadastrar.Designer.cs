namespace AT2_WFCadastros
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
            txtDescricao = new TextBox();
            lblCodigo = new Label();
            lblNome = new Label();
            lblDescricao = new Label();
            lblStatus = new Label();
            dtpData = new DateTimePicker();
            lblDatadeCadastro = new Label();
            btnCadastrar = new Button();
            gpxSistema = new GroupBox();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            gpxSistema.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 144);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(163, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(74, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(111, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(74, 237);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(408, 137);
            txtDescricao.TabIndex = 2;
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(74, 119);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(74, 205);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(288, 31);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(282, 179);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 8;
            // 
            // lblDatadeCadastro
            // 
            lblDatadeCadastro.AutoSize = true;
            lblDatadeCadastro.Location = new Point(282, 152);
            lblDatadeCadastro.Name = "lblDatadeCadastro";
            lblDatadeCadastro.Size = new Size(97, 15);
            lblDatadeCadastro.TabIndex = 9;
            lblDatadeCadastro.Text = "Data de Cadastro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(375, 380);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(107, 41);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // gpxSistema
            // 
            gpxSistema.Controls.Add(rdbInativo);
            gpxSistema.Controls.Add(rdbAtivo);
            gpxSistema.Location = new Point(282, 49);
            gpxSistema.Name = "gpxSistema";
            gpxSistema.Size = new Size(200, 100);
            gpxSistema.TabIndex = 12;
            gpxSistema.TabStop = false;
            gpxSistema.Text = "Sistema";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(30, 25);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(30, 70);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(gpxSistema);
            Controls.Add(btnCadastrar);
            Controls.Add(lblDatadeCadastro);
            Controls.Add(dtpData);
            Controls.Add(lblStatus);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Name = "FormCadastrar";
            Text = "Cadastrar";
            gpxSistema.ResumeLayout(false);
            gpxSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblDescricao;
        private Label lblStatus;
        private DateTimePicker dtpData;
        private Label lblDatadeCadastro;
        private Button btnCadastrar;
        private GroupBox gpxSistema;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
    }
}
