namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastrar : Form
    {



        public FormCadastrar()
        {
            InitializeComponent();
        }
        private void LimparTela()
        {
            txtNome.Clear();
            mkttelefone.Clear();
            txtCodigo.Clear();
            mktcpf.Clear();
            cbfilhos.Checked = false;
            txtEmail.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void FormCadastrar_Load_1(object sender, EventArgs e)
        {
            int qtdeProdutos = pessoa.ListaPessoa.Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString("D4");
        }

        private void Salvar_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Preenche todos os campos");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Preenche todos os campos");
                    return;
                }
                if (string.IsNullOrEmpty(mktcpf.Text))
                {
                    MessageBox.Show("Preenche todos os campos");
                    return;
                }

                if (string.IsNullOrEmpty(gpxTipoTelefone.Text))
                {
                    MessageBox.Show("Preenche todos os campos");
                    return;
                }

                if (string.IsNullOrEmpty(mkttelefone.Text))
                {
                    MessageBox.Show("Preenche todos os campos");
                    return;
                }
                bool possuiFilhos = cbfilhos.Checked;


                pessoa Pessoa = new pessoa();

                Pessoa.Codigo = (txtCodigo.Text);
                Pessoa.Nome = txtNome.Text;
                Pessoa.Email = txtEmail.Text;
                Pessoa.CPF = mktcpf.Text;
                Pessoa.Telefone = mkttelefone.Text;

                if (rdbComercial.Checked)
                {
                    Pessoa.TipoTelefone = "Comercial";
                }
                else if (rdbPessoal.Checked)
                {
                    Pessoa.TipoTelefone = "Pessoal";
                }
                else
                {
                    Pessoa.TipoTelefone = "Recado";
                }

                if (cbfilhos.Checked)
                {
                    Pessoa.PossuiFilhos = true;
                }
                else
                {
                    Pessoa.PossuiFilhos = false;
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
                pessoa.ListaPessoa.Add(Pessoa);
                LimparTela();

                int qtdeProdutos = pessoa.ListaPessoa.Count;
                int novoCodigo = qtdeProdutos + 1;
                txtCodigo.Text = novoCodigo.ToString("D4");

            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

