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

            Usuario usuarioEditado = new Usuario();

            usuarioEditado.Id = idSelecionado;
            usuarioEditado.Nome = txtNomeUsuario.Text;
            usuarioEditado.Email = txtEmailUsuario.Text;
            usuarioEditado.CPF = txtCpfUsuario.Text;
            usuarioEditado.Telefone = txtTelefoneUsuario.Text;
            usuarioEditado.TipoUsuario = cbTipoUsuario.Text;

            AcessoUsuario acesso = new AcessoUsuario();
            acesso.EditarUsuario(usuarioEditado);

            MessageBox.Show("Dados atualizados com sucesso!");

            CarregarTabela();

            LimparCampo();

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                int idParaApagar = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["Id"].Value);

                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.No)
                {
                    return;
                }

                AcessoUsuario acesso = new AcessoUsuario();
                acesso.RemoverUsuario(idParaApagar);

                CarregarTabela();

                LimparCampo();

                MessageBox.Show("Usuario removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um usuario para fazer a exclusão!");
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
    }
}