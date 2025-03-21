using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormListagem : Form
    {
        public FormListagem()
        {
            InitializeComponent();
        }

        private List<Categoria> categorias = new List<Categoria>();


      
        private void btnAbrirCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar formCadastrar = new FormCadastrar();

            formCadastrar.ShowDialog();

        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            dvgListadeProdutos.DataSource = Categoria.ListadeCadastro;

        }

     
        
    }
}


