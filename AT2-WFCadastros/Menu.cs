using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListagem listagem = new FormListagem();
            listagem.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagem listagem = new FormListagem();
            listagem.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrar listagem = new FormCadastrar();
            listagem.Show();
        }

   
    }
}
