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
    }
}
