using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FormPrincipalUsuario : Form
    {
        int idSelecionado = 0;

        public FormPrincipalUsuario()
        {
            InitializeComponent();

            CarregarTabela();
        }

        private void FormPrincipalUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CarregarTabela()
        {
            AcessoUsuario acesso = new AcessoUsuario();

            List<Usuario> lista = acesso.ListarTodosUsuarios();

            dgvUsuario.DataSource = lista;

        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario telaCadastro = new FormCadastroUsuario();

            telaCadastro.ShowDialog();

            CarregarTabela();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuario.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dgvUsuario.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);

                txtNomeUsuario.Text = linha.Cells["Nome"].Value.ToString();
                txtEmailUsuario.Text = linha.Cells["Email"].Value.ToString();
                txtCpfUsuario.Text = linha.Cells["CPF"].Value.ToString();
                cbTipoUsuario.Text = linha.Cells["TipoUsuario"].Value.ToString();

                if (linha.Cells["Telefone"].Value != null)
                {
                    txtTelefoneUsuario.Text = linha.Cells["Telefone"].Value.ToString();
                }
            }
        }

        private void btnSalvarEdicaoUsuario_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Por favor, clique em um usuário na tabela antes de tentar salvar a edição.");
                return;
            }

            if (txtNomeUsuario.Text == "")
            {
                MessageBox.Show("O nome não pode ficar vazio.");
                return;
            }

            if (!txtEmailUsuario.Text.Contains("@") || !txtEmailUsuario.Text.Contains("."))
            {
                MessageBox.Show("Por favor, digite um e-mail válido (ex: nome@dominio.com).");
                return;
            }

            if (ValidarCamposObrigatorios())  return; 

            Usuario usuarioEditado = new Usuario();

            usuarioEditado.Id = idSelecionado;
            usuarioEditado.Nome = txtNomeUsuario.Text.Trim();
            usuarioEditado.Email = txtEmailUsuario.Text.Trim();
            usuarioEditado.CPF = txtCpfUsuario.Text.Trim();
            usuarioEditado.Telefone = txtTelefoneUsuario.Text.Trim();
            usuarioEditado.TipoUsuario = cbTipoUsuario.Text;

            AcessoUsuario acesso = new AcessoUsuario();
            acesso.EditarUsuario(usuarioEditado);

            MessageBox.Show("Dados atualizados com sucesso!");

            CarregarTabela();

            LimparCampo();

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Usuario da Tabela para excluir.");
            }

            int IdUsuario = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["Id"].Value);

            AcessoEmprestimos acessoEmp = new AcessoEmprestimos();

            if (acessoEmp.TemEmprestimoPendente(IdUsuario))
            {
                MessageBox.Show("Não é possível excluir este usuário pois ele possui um livro emprestado (Status Ativo).\n\n" + "Solicite a devolução do livro antes de excluir o cadastro.", "Ação Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var resposta = MessageBox.Show("Tem certeza que deseja excluir este usuário?\n\n" + "ATENÇÃO: Todo o histórico de empréstimos passados dele será apagado permanentemente.", "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    acessoEmp.ExcluirHistoricoDoUsuario(IdUsuario);

                    AcessoUsuario acessoUser = new AcessoUsuario();
                    acessoUser.RemoverUsuario(IdUsuario);

                    MessageBox.Show("Usuário removido com sucesso!");

                    CarregarTabela();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void LimparCampo()
        {
            txtNomeUsuario.Text = "";
            txtEmailUsuario.Text = "";
            txtCpfUsuario.Text = "";
            txtTelefoneUsuario.Text = "";
            cbTipoUsuario.SelectedIndex = -1;
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("O nome é obrigatório.");
                txtNomeUsuario.Focus();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtEmailUsuario.Text))
            {
                MessageBox.Show("O email é obrigatório.");
                txtEmailUsuario.Focus();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("O nome é necessário para organizarmos o estoque!");
                txtNomeUsuario.Focus();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtEmailUsuario.Text))
            {
                MessageBox.Show("O nome é necessário para organizarmos o estoque!");
                txtEmailUsuario.Focus();
                return true;
            }

            return false;
        }
    }
}