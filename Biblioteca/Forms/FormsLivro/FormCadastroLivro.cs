using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FormCadastroLivro : Form
    {
        public FormCadastroLivro()
        {
            InitializeComponent();
        }


        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Por favor, preencha Título e Autor.");
                return;
            }

            if (ValidarCamposObrigatorios()) return;

            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int ano = (int)numAno.Value;
            int quantidade = (int)numQuantidade.Value; 

            AcessoLivros acesso = new AcessoLivros();

            int idDoLivro = acesso.VerificarSeLivroExiste(titulo);

            if (idDoLivro > 0)
            {
                acesso.AdicionarQuantidadeLivro(idDoLivro, quantidade);

                MessageBox.Show($"O livro '{titulo}' já existia!\nEstoque atualizado com +{quantidade} unidades.");
            }
            else
            {
                Livro novoLivro = new Livro();
                novoLivro.Titulo = titulo;
                novoLivro.Autor = autor;
                novoLivro.AnoPublicacao = ano;

                acesso.CadastrarLivro(novoLivro, quantidade);

                MessageBox.Show("Novo livro cadastrado com sucesso!");
            }

            this.Close();
        }

        private void btnVoltarCadastroLivro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroLivro_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("O Autor é obrigatório.");
                txtAutor.Focus();
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O Titulo é obrigatório.");
                txtAutor.Focus();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O o Titulo é necessário para organizarmos o estoque!");
                txtTitulo.Focus();
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("O o Autor é necessários para organizarmos o estoque!");
                txtTitulo.Focus();
                return true;
            }

            return false;
        }
    }
}
