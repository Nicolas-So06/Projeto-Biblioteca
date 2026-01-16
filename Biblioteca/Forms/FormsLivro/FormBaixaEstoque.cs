using Biblioteca.Data;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms.FormsLivro
{
    public partial class FormBaixaEstoque : Form
    {
        private int idLivroSelecionado;

        public FormBaixaEstoque(int id, string titulo, int quantidadeDisponivel)
        {
            InitializeComponent();

            idLivroSelecionado = id;
            txtLivroSelecionadoExcluir.Text = titulo;
            txtLivroSelecionadoExcluir.ReadOnly = true;


            if (quantidadeDisponivel > 0)
            {
                numQuantExcluirLivro.Maximum = quantidadeDisponivel;
                numQuantExcluirLivro.Value = 1;
            }

            numQuantExcluirLivro.Minimum = 1;
        }

        private void btnComfirmarExclusaoLivro_Click(object sender, EventArgs e)
        {
            if (!UsuarioConfirmouAcao()) { return; }

            AcessoLivros acesso = new AcessoLivros();
            int quantidade = Convert.ToInt32(numQuantExcluirLivro.Value);

            if (quantidade == numQuantExcluirLivro.Maximum)
            {

                try
                {
                    acesso.RemoverLivro(idLivroSelecionado);
                    MessageBox.Show("Estoque zerado e livro excluído do sistema.");
                }
                catch 
                {
                    acesso.ExcluirQuantidadeLivro(idLivroSelecionado, quantidade);

                    MessageBox.Show("O estoque foi zerado!\n\n" + "Obs: O livro NÃO foi excluído do cadastro porque existem empréstimos vinculados a ele.", "Aviso de Integridade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                acesso.ExcluirQuantidadeLivro(idLivroSelecionado, quantidade);
                MessageBox.Show("Estoque atualizado com sucesso!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool UsuarioConfirmouAcao()
        {
            var resposta = MessageBox.Show("Tem certeza que deseja remover?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return resposta == DialogResult.Yes;
        }

        private void VoltarExclusaoLivro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
