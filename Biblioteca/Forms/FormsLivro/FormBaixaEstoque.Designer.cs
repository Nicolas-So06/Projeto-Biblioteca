namespace Biblioteca.Forms.FormsLivro
{
    partial class FormBaixaEstoque
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
            this.lblSelecionaLivroRemover = new System.Windows.Forms.Label();
            this.lblQuantRemoverLivro = new System.Windows.Forms.Label();
            this.numQuantExcluirLivro = new System.Windows.Forms.NumericUpDown();
            this.btnComfirmarExclusaoLivro = new System.Windows.Forms.Button();
            this.VoltarExclusaoLivro = new System.Windows.Forms.Button();
            this.txtLivroSelecionadoExcluir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantExcluirLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecionaLivroRemover
            // 
            this.lblSelecionaLivroRemover.AutoSize = true;
            this.lblSelecionaLivroRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaLivroRemover.Location = new System.Drawing.Point(26, 38);
            this.lblSelecionaLivroRemover.Name = "lblSelecionaLivroRemover";
            this.lblSelecionaLivroRemover.Size = new System.Drawing.Size(117, 16);
            this.lblSelecionaLivroRemover.TabIndex = 0;
            this.lblSelecionaLivroRemover.Text = "Livro selecionado:";
            // 
            // lblQuantRemoverLivro
            // 
            this.lblQuantRemoverLivro.AutoSize = true;
            this.lblQuantRemoverLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantRemoverLivro.Location = new System.Drawing.Point(12, 75);
            this.lblQuantRemoverLivro.Name = "lblQuantRemoverLivro";
            this.lblQuantRemoverLivro.Size = new System.Drawing.Size(144, 16);
            this.lblQuantRemoverLivro.TabIndex = 1;
            this.lblQuantRemoverLivro.Text = "Quantidade a remover:";
            // 
            // numQuantExcluirLivro
            // 
            this.numQuantExcluirLivro.Location = new System.Drawing.Point(185, 75);
            this.numQuantExcluirLivro.Name = "numQuantExcluirLivro";
            this.numQuantExcluirLivro.Size = new System.Drawing.Size(120, 20);
            this.numQuantExcluirLivro.TabIndex = 2;
            // 
            // btnComfirmarExclusaoLivro
            // 
            this.btnComfirmarExclusaoLivro.Location = new System.Drawing.Point(334, 31);
            this.btnComfirmarExclusaoLivro.Name = "btnComfirmarExclusaoLivro";
            this.btnComfirmarExclusaoLivro.Size = new System.Drawing.Size(111, 23);
            this.btnComfirmarExclusaoLivro.TabIndex = 3;
            this.btnComfirmarExclusaoLivro.Text = "Confirmar";
            this.btnComfirmarExclusaoLivro.UseVisualStyleBackColor = true;
            this.btnComfirmarExclusaoLivro.Click += new System.EventHandler(this.btnComfirmarExclusaoLivro_Click);
            // 
            // VoltarExclusaoLivro
            // 
            this.VoltarExclusaoLivro.Location = new System.Drawing.Point(334, 75);
            this.VoltarExclusaoLivro.Name = "VoltarExclusaoLivro";
            this.VoltarExclusaoLivro.Size = new System.Drawing.Size(111, 23);
            this.VoltarExclusaoLivro.TabIndex = 4;
            this.VoltarExclusaoLivro.Text = "Cancelar";
            this.VoltarExclusaoLivro.UseVisualStyleBackColor = true;
            this.VoltarExclusaoLivro.Click += new System.EventHandler(this.VoltarExclusaoLivro_Click);
            // 
            // txtLivroSelecionadoExcluir
            // 
            this.txtLivroSelecionadoExcluir.Location = new System.Drawing.Point(185, 33);
            this.txtLivroSelecionadoExcluir.Name = "txtLivroSelecionadoExcluir";
            this.txtLivroSelecionadoExcluir.Size = new System.Drawing.Size(120, 20);
            this.txtLivroSelecionadoExcluir.TabIndex = 5;
            // 
            // FormBaixaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 125);
            this.Controls.Add(this.txtLivroSelecionadoExcluir);
            this.Controls.Add(this.VoltarExclusaoLivro);
            this.Controls.Add(this.btnComfirmarExclusaoLivro);
            this.Controls.Add(this.numQuantExcluirLivro);
            this.Controls.Add(this.lblQuantRemoverLivro);
            this.Controls.Add(this.lblSelecionaLivroRemover);
            this.Name = "FormBaixaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaixaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantExcluirLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecionaLivroRemover;
        private System.Windows.Forms.Label lblQuantRemoverLivro;
        private System.Windows.Forms.NumericUpDown numQuantExcluirLivro;
        private System.Windows.Forms.Button btnComfirmarExclusaoLivro;
        private System.Windows.Forms.Button VoltarExclusaoLivro;
        private System.Windows.Forms.TextBox txtLivroSelecionadoExcluir;
    }
}