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

            txtLivroSelecionadoExcluir.ReadOnly = true;

            idLivroSelecionado = id;

            txtLivroSelecionadoExcluir.Text = titulo;

            numQuantExcluirLivro.Maximum = quantidadeDisponivel;
            numQuantExcluirLivro.Minimum = 1;
            numQuantExcluirLivro.Value = 1;
        }




        private void VoltarExclusaoLivro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComfirmarExclusaoLivro_Click(object sender, EventArgs e)
        {
            
            
            AcessoLivros acesso = new AcessoLivros();
            int qtdExcluir = Convert.ToInt32(numQuantExcluirLivro.Value);

            if( qtdExcluir == numQuantExcluirLivro.Maximum) 
            {
                try
                {
                    confirmacaoExclusaoLivro();

                    acesso.RemoverLivro(idLivroSelecionado);
                    MessageBox.Show("Estoque zerado e livro excluído do sistema!");
                }
                catch (Exception)
                {
                    confirmacaoExclusaoLivro();

                    acesso.ExcluirQuantidadeLivro(idLivroSelecionado, qtdExcluir);

                    MessageBox.Show("O estoque foi zerado!\n\n" + "Obs: O livro NÃO foi excluído do cadastro porque existem empréstimos vinculados a ele no histórico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                confirmacaoExclusaoLivro();

                acesso.ExcluirQuantidadeLivro(idLivroSelecionado, qtdExcluir);
                MessageBox.Show("Estoque atualizado com sucesso!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();            
        }

        private void confirmacaoExclusaoLivro() 
        {
            DialogResult resposta1 = MessageBox.Show("Tem certeza que deseja excluir?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta1 == DialogResult.No) { return; }
        }
    }   
}
