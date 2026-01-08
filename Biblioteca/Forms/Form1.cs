using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
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
            Livro novoLivro = new Livro();

            novoLivro.Titulo = txtTitulo.Text;
            novoLivro.Autor = txtAutor.Text;

            novoLivro.AnoPublicacao = (int)numAno.Value;

            AcessoLivros acesso = new AcessoLivros();
            acesso.Cadastrar(novoLivro);

            CarregarTabela();

            txtTitulo.Text = "";
            txtAutor.Text = "";
            numAno.Value = DateTime.Now.Year;

            MessageBox.Show("Livro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
