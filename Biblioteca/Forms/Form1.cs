using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        int idSelecionado = 0;

        public Form1()
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

            List<Livro> lista = acesso.ListarTodos();

            dgvLivros.DataSource = lista;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.AnoPublicacao = (int)numAno.Value;

            AcessoLivros acesso = new AcessoLivros();

            if (idSelecionado == 0)
            {
                acesso.Cadastrar(livro);
                MessageBox.Show("Livro cadastrado com sucesso!");
            }
            else
            {

                livro.Id = idSelecionado; 

                acesso.Editar(livro); 
                MessageBox.Show("Livro editado com sucesso!");

                idSelecionado = 0;
            }

            CarregarTabela();

            txtTitulo.Text = "";
            txtAutor.Text = "";
            numAno.Value = DateTime.Now.Year;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLivros.SelectedRows.Count > 0)
            {
                int idParaApagar = Convert.ToInt32(dgvLivros.SelectedRows[0].Cells["Id"].Value);

                AcessoLivros acesso = new AcessoLivros();
                acesso.Remover(idParaApagar);

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
    }
}
