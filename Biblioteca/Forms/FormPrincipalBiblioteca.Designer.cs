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
            this.btnGerenciarUsuario_Click = new System.Windows.Forms.Button();
            this.btnEmprestimo_Click = new System.Windows.Forms.Button();
            this.btnGerenciarLivro_Click = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // btnGerenciarUsuario_Click
            // 
            this.btnGerenciarUsuario_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsuario_Click.Location = new System.Drawing.Point(30, 197);
            this.btnGerenciarUsuario_Click.Name = "btnGerenciarUsuario_Click";
            this.btnGerenciarUsuario_Click.Size = new System.Drawing.Size(243, 118);
            this.btnGerenciarUsuario_Click.TabIndex = 1;
            this.btnGerenciarUsuario_Click.Text = "Gerenciar Usuarios";
            this.btnGerenciarUsuario_Click.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimo_Click
            // 
            this.btnEmprestimo_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo_Click.Location = new System.Drawing.Point(327, 197);
            this.btnEmprestimo_Click.Name = "btnEmprestimo_Click";
            this.btnEmprestimo_Click.Size = new System.Drawing.Size(243, 118);
            this.btnEmprestimo_Click.TabIndex = 2;
            this.btnEmprestimo_Click.Text = "Empréstimos";
            this.btnEmprestimo_Click.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarLivro_Click
            // 
            this.btnGerenciarLivro_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarLivro_Click.Location = new System.Drawing.Point(631, 197);
            this.btnGerenciarLivro_Click.Name = "btnGerenciarLivro_Click";
            this.btnGerenciarLivro_Click.Size = new System.Drawing.Size(243, 118);
            this.btnGerenciarLivro_Click.TabIndex = 3;
            this.btnGerenciarLivro_Click.Text = "Gerenciar Livros";
            this.btnGerenciarLivro_Click.UseVisualStyleBackColor = true;
            this.btnGerenciarLivro_Click.Click += new System.EventHandler(this.btnGerenciarLivro_Click_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(327, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 64);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sair do Sistema";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 541);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGerenciarLivro_Click);
            this.Controls.Add(this.btnEmprestimo_Click);
            this.Controls.Add(this.btnGerenciarUsuario_Click);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalBiblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGerenciarUsuario_Click;
        private System.Windows.Forms.Button btnEmprestimo_Click;
        private System.Windows.Forms.Button btnGerenciarLivro_Click;
        private System.Windows.Forms.Button button4;
    }
}