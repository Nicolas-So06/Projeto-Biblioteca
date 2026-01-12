using Biblioteca.Data;
using Biblioteca.Models;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarCadastroUsuario_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarNovoUsuario_Click(object sender, EventArgs e)
        {

            if (txtNomeUsuario.Text == "" || txtCpfUsuario.MaskCompleted == false)
            {
                MessageBox.Show("Por favor, preencha o Nome e o CPF completo.");
                return; 
            }

            if (cbTipoUsuario.Text == "")
            {
                MessageBox.Show("Selecione um Tipo de Usuário!");
                return;
            }

            if (!txtEmailUsuario.Text.Contains("@") || !txtEmailUsuario.Text.Contains("."))
            {
                MessageBox.Show("Por favor, digite um e-mail válido (ex: nome@dominio.com).");
                return;
            }

            AcessoUsuario acesso = new AcessoUsuario();

            string cpfInformado = txtCpfUsuario.Text;

            int idExistente = acesso.VerificarSeUsuarioExiste(cpfInformado);

            if (idExistente > 0)
            {
                MessageBox.Show("Já existe um usuário cadastrado com este CPF.", "Erro de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = txtNomeUsuario.Text;
            novoUsuario.CPF = txtCpfUsuario.Text;
            novoUsuario.Email = txtEmailUsuario.Text;
            novoUsuario.Telefone = txtTelefoneUsuario.Text;
            novoUsuario.TipoUsuario = cbTipoUsuario.Text;

            acesso.CadastrarUsuario(novoUsuario);

            MessageBox.Show("Usuário cadastrado com sucesso!");

            this.Close();
        }
    }
}