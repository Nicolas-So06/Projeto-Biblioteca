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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGerenciarLivro_Click_Click(object sender, EventArgs e)
        {
            FormPrincipalLivro telaLivro = new FormPrincipalLivro();

            telaLivro.ShowDialog();
        }

        private void btnSairSistema_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
