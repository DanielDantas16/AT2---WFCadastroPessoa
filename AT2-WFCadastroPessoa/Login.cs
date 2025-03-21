using AT2_WFCadastroPessoa;

namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Login();
        }

        public void Login()
        {
            Usuario.ListaUsuarios.Add(new Usuario
            {
                Codigo = 001,
                Login = "Sistema",
                Senha = "123456"
            });
        }

        

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        
                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);


            txtLogin.Clear();
            txtSenha.Clear();

            return;
        }      
    }
}