using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FormCadastroLivro : Form
    {
        public FormCadastroLivro()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.AnoPublicacao = (int)numAno.Value;

            AcessoLivros acesso = new AcessoLivros();
            acesso.Cadastrar(livro);

            MessageBox.Show("Livro cadastrado com sucesso!");

            this.Close();
        }
    }
}
