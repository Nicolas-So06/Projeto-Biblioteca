namespace Biblioteca.Forms
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGerenciarUsuario = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnGerenciarLivro = new System.Windows.Forms.Button();
            this.btnSairSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(227, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(460, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Gerenciamento de Biblioteca";
            // 
            // btnGerenciarUsuario
            // 
            this.btnGerenciarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsuario.Location = new System.Drawing.Point(30, 197);
            this.btnGerenciarUsuario.Name = "btnGerenciarUsuario";
            this.btnGerenciarUsuario.Size = new System.Drawing.Size(243, 118);
            this.btnGerenciarUsuario.TabIndex = 1;
            this.btnGerenciarUsuario.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuario.UseVisualStyleBackColor = true;
            this.btnGerenciarUsuario.Click += new System.EventHandler(this.BtnGerenciarUsuario_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Location = new System.Drawing.Point(327, 197);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(243, 118);
            this.btnEmprestimo.TabIndex = 2;
            this.btnEmprestimo.Text = "Empréstimos";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnGerenciarLivro
            // 
            this.btnGerenciarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarLivro.Location = new System.Drawing.Point(631, 197);
            this.btnGerenciarLivro.Name = "btnGerenciarLivro";
            this.btnGerenciarLivro.Size = new System.Drawing.Size(243, 118);
            this.btnGerenciarLivro.TabIndex = 3;
            this.btnGerenciarLivro.Text = "Gerenciar Livros";
            this.btnGerenciarLivro.UseVisualStyleBackColor = true;
            this.btnGerenciarLivro.Click += new System.EventHandler(this.BtnGerenciarLivro_Click);
            // 
            // btnSairSistema
            // 
            this.btnSairSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSistema.Location = new System.Drawing.Point(327, 431);
            this.btnSairSistema.Name = "btnSairSistema";
            this.btnSairSistema.Size = new System.Drawing.Size(243, 64);
            this.btnSairSistema.TabIndex = 4;
            this.btnSairSistema.Text = "Sair do Sistema";
            this.btnSairSistema.UseVisualStyleBackColor = true;
            this.btnSairSistema.Click += new System.EventHandler(this.BtnSairSistema_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 541);
            this.Controls.Add(this.btnSairSistema);
            this.Controls.Add(this.btnGerenciarLivro);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.btnGerenciarUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalBiblioteca";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGerenciarUsuario;
        private System.Windows.Forms.Button btnEmprestimo; 
        private System.Windows.Forms.Button btnGerenciarLivro; 
        private System.Windows.Forms.Button btnSairSistema; 
    }
}