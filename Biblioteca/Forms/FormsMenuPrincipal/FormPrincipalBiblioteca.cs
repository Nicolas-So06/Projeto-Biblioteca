using Biblioteca.Forms.FormsEmprestimo;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnSairSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGerenciarLivro_Click(object sender, EventArgs e)
        {
            FormPrincipalLivro telaLivro = new FormPrincipalLivro();

            telaLivro.ShowDialog();
        }

        private void BtnGerenciarUsuario_Click(object sender, EventArgs e)
        {
            FormPrincipalUsuario telaUsuario = new FormPrincipalUsuario();

            telaUsuario.ShowDialog();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            FormPrincipalEmprestimo telaEmprestimo = new FormPrincipalEmprestimo();

            telaEmprestimo.ShowDialog();
        }
    }
}
