using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms.FormsEmprestimo
{
    public partial class FormPrincipalEmprestimo : Form
    {
        public FormPrincipalEmprestimo()
        {
            InitializeComponent();

            dtpDataDevolucao.MinDate = DateTime.Today;
            dtpDataDevolucao.Value = DateTime.Today;
        }

        private void FormPrincipalEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarCombos();
        }

        private void btnVoltarEmprestimo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarCombos()
        { 
            AcessoUsuario acessarUsuario = new AcessoUsuario();
            var listaUsuarios = acessarUsuario.ListarTodosUsuarios();

            cbUsuarioEmprestimo.DataSource = listaUsuarios;
            cbUsuarioEmprestimo.DisplayMember = "Nome";
            cbUsuarioEmprestimo.ValueMember = "Id";
            cbUsuarioEmprestimo.SelectedIndex = -1;

            AcessoLivros acessarLivro = new AcessoLivros();
            var listaLivros = acessarLivro.ListarTodosLivros();

            cbLivroEmprestimo.DataSource = listaLivros;
            cbLivroEmprestimo.DisplayMember = "Titulo";
            cbLivroEmprestimo.ValueMember = "Id";   
            cbLivroEmprestimo.SelectedIndex= -1;
        }

        private void LimparCampo()
        {
            cbUsuarioEmprestimo.SelectedIndex = -1;
            cbLivroEmprestimo.SelectedIndex = -1;

            dtpDataDevolucao.Value = DateTime.Today;
            return;
        }

        private void btnSalvarEmprestimo_Click(object sender, EventArgs e)
        {
            if (cbUsuarioEmprestimo.SelectedIndex == -1 || cbLivroEmprestimo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Usuario e um Livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Emprestimo novoEmprestimo = new Emprestimo();

            novoEmprestimo.UsuarioId = Convert.ToInt32(cbUsuarioEmprestimo.SelectedValue);
            novoEmprestimo.LivroId = Convert.ToInt32(cbLivroEmprestimo.SelectedValue);
            novoEmprestimo.DataEmprestimo = DateTime.Now;
            novoEmprestimo.DataDevolucaoPrevista = dtpDataDevolucao.Value;
            novoEmprestimo.StatusEmprestimo = "Ativo";

            AcessoEmprestimos acesso = new AcessoEmprestimos();
            acesso.RegistrarEmprestimo(novoEmprestimo);

            MessageBox.Show("Emprestimo realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimparCampo();

        }
    }
}
