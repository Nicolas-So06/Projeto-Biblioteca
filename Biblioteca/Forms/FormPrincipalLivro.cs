using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Data;
using Biblioteca.Forms;
using Biblioteca.Models;

namespace Biblioteca
{
    public partial class FormPrincipalLivro : Form
    {
        int idSelecionado = 0;

        public FormPrincipalLivro()
        {
            InitializeComponent();

            numAno.Value = DateTime.Now.Year;


            CarregarTabela();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CarregarTabela()
        {
            AcessoLivros acesso = new AcessoLivros();

            List<Livro> lista = acesso.ListarTodosLivros();

            dgvLivros.DataSource = lista;
        }


        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione um livro na tabela para editar.");
                return;
            }

            if (txtTitulo.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Você não pode deixar Título ou Autor em branco na edição!");
                return; 
            }

            Livro livro = new Livro();
            livro.Id = idSelecionado;
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.AnoPublicacao = (int)numAno.Value;

            AcessoLivros acesso = new AcessoLivros();
            acesso.EditarLivro(livro);

            MessageBox.Show("Edição salva com sucesso!");

            CarregarTabela();

            idSelecionado = 0;
            txtTitulo.Text = "";
            txtAutor.Text = "";
            numAno.Value = DateTime.Now.Year;
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            if (dgvLivros.SelectedRows.Count > 0)
            {
                int idParaApagar = Convert.ToInt32(dgvLivros.SelectedRows[0].Cells["Id"].Value);

                AcessoLivros acesso = new AcessoLivros();
                acesso.RemoverLivro(idParaApagar);

                CarregarTabela(); 

                MessageBox.Show("Livro removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um livro para excluir.");
            }
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLivros.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dgvLivros.Rows[e.RowIndex];

                txtTitulo.Text = linha.Cells["Titulo"].Value.ToString();
                txtAutor.Text = linha.Cells["Autor"].Value.ToString();

                numAno.Value = Convert.ToDecimal(linha.Cells["AnoPublicacao"].Value);

                idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
            }
        }

        private void btnAdicionarLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro telaCadastro = new FormCadastroLivro();

            telaCadastro.ShowDialog();

            CarregarTabela();
        }

        private void btnVoltarLivro_Click_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
