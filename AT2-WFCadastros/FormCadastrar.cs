namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {

        public Categoria NovaCategoria { get; private set; }

        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;
            categoria.DatadeCadastro = dtpData.Value;

            if (rdbAtivo.Checked)
            {
                categoria.Status = "Ativo";
            }
            else
            {
              
                    categoria.Status = "Inativo";
            }

                txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            dtpData.Value = DateTime.Now;

            MessageBox.Show("Categoria cadastrada com sucesso!");
            Categoria.ListadeCadastro.Add(categoria);

           
            this.Close();

           
            
        }
    }
}
