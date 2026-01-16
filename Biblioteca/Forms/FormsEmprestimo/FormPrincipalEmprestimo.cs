using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms.FormsEmprestimo
{
    public partial class FormPrincipalEmprestimo : Form
    {
        int idEmprestimoSelecionado = 0;
        int idLivroSelecionado = 0; 

        public FormPrincipalEmprestimo()
        {
            InitializeComponent();

            dtpDataDevolucao.MinDate = DateTime.Today;
            dtpDataDevolucao.Value = DateTime.Today;
        }

        private void FormPrincipalEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarCombos();

            TabelaEmprestimo();
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


        private void btnSalvarEmprestimo_Click(object sender, EventArgs e)
        {
            if (cbUsuarioEmprestimo.SelectedIndex == -1 || cbLivroEmprestimo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Usuario e um Livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(cbUsuarioEmprestimo.SelectedValue);
                int idLivro = Convert.ToInt32(cbLivroEmprestimo.SelectedValue);
                DateTime dataDevolucao = dtpDataDevolucao.Value;

                AcessoEmprestimos acesso = new AcessoEmprestimos();

                int estoqueAtual = acesso.VerificarEstoqueAtual(idLivro);

                if (estoqueAtual <= 0)
                {
                    MessageBox.Show("Não é possível realizar o empréstimo.\nEstoque esgotado para este livro!", "Estoque Zerado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                acesso.NovoEmprestimo(idUsuario, idLivro, dataDevolucao);

                MessageBox.Show("Empréstimo realizado com sucesso!");

                CarregarTabela();

                cbUsuarioEmprestimo.SelectedIndex = -1;      
                cbLivroEmprestimo.SelectedIndex = -1;        
                dtpDataDevolucao.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }

        }

        private void TabelaEmprestimo()
        {
            AcessoEmprestimos acesso = new AcessoEmprestimos();
            var tabelaDados = acesso.ListarEmprestimosDetalhados();

            dgvEmprestimos.DataSource = tabelaDados;

            dgvEmprestimos.Columns["Id"].Visible = false;

            dgvEmprestimos.Columns["NomeUsuario"].HeaderText = "Usuário";
            dgvEmprestimos.Columns["NomeLivro"].HeaderText = "Livro Emprestado";
            dgvEmprestimos.Columns["DataEmprestimo"].HeaderText = "Data Retirada";
            dgvEmprestimos.Columns["DataDevolucaoPrevista"].HeaderText = "Previsão Devolução";
            dgvEmprestimos.Columns["StatusEmprestimo"].HeaderText = "Status";
        }

        private void CarregarTabela()
        {
            AcessoEmprestimos acesso = new AcessoEmprestimos();
            dgvEmprestimos.DataSource = acesso.ListarEmprestimosDetalhados();

        }

        private void dgvEmprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmprestimos.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dgvEmprestimos.SelectedRows[0];

                idEmprestimoSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
                idLivroSelecionado = Convert.ToInt32(linha.Cells["LivroId"].Value);

                txtEditarUsuarioEmp.Text = linha.Cells["NomeUsuario"].Value.ToString();
                txtEditarLivroEmp.Text = linha.Cells["NomeLivro"].Value.ToString();

                dtpEditarDataDevolucaoEmp.Value = Convert.ToDateTime(linha.Cells["DataDevolucaoPrevista"].Value);

                string status = linha.Cells["StatusEmprestimo"].Value.ToString();

                if (status == "Ativo")
                {
                    btnDevolverLivroEmp.Enabled = true;
                    btnSalvarEdicaoEmp.Enabled = true;
                }
                else
                {
                    btnDevolverLivroEmp.Enabled = false;
                    btnSalvarEdicaoEmp.Enabled = false;

                }
            }
        }

        private void btnDevolverLivroEmp_Click(object sender, EventArgs e)
        {

            if (idEmprestimoSelecionado == 0)
            {
                MessageBox.Show("Selecione um empréstimo primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            var confirmacao = MessageBox.Show("Confirmar a devolução do livro?\nO estoque será reposto automaticamente.", "Finalizar Empréstimo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    AcessoEmprestimos acesso = new AcessoEmprestimos();

                    acesso.RealizarDevolucao(idEmprestimoSelecionado, idLivroSelecionado);

                    MessageBox.Show("Livro devolvido! Empréstimo finalizado.");

                    CarregarTabela();
                    LimparCamposEditar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na devolução: " + ex.Message);
                }
            }
        }

        private void btnSalvarEdicaoEmp_Click(object sender, EventArgs e)
        {
            if (idEmprestimoSelecionado == 0)
            {
                MessageBox.Show("Selecione um empréstimo primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                AcessoEmprestimos acesso = new AcessoEmprestimos();
                acesso.AtualizarDataDevolucao(idEmprestimoSelecionado, dtpEditarDataDevolucaoEmp.Value);

                MessageBox.Show("Data de devolução atualizada com sucesso!");

                CarregarTabela(); 
                LimparCamposEditar(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void LimparCamposEditar()
        {
            idEmprestimoSelecionado = 0;
            idLivroSelecionado = 0;

            txtEditarUsuarioEmp.Clear();
            txtEditarLivroEmp.Clear();
            dtpEditarDataDevolucaoEmp.Value = DateTime.Now;

        }
    }
}
