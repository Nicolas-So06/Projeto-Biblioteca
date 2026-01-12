namespace Biblioteca.Forms
{
    partial class FormCadastroLivro
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
            this.CadastrarLivro = new System.Windows.Forms.GroupBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltarCadastroLivro = new System.Windows.Forms.Button();
            this.CadastrarLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastrarLivro
            // 
            this.CadastrarLivro.Controls.Add(this.numQuantidade);
            this.CadastrarLivro.Controls.Add(this.lblQuantidade);
            this.CadastrarLivro.Controls.Add(this.btnCadastrar);
            this.CadastrarLivro.Controls.Add(this.numAno);
            this.CadastrarLivro.Controls.Add(this.txtAutor);
            this.CadastrarLivro.Controls.Add(this.txtTitulo);
            this.CadastrarLivro.Controls.Add(this.lblAno);
            this.CadastrarLivro.Controls.Add(this.lblAutor);
            this.CadastrarLivro.Controls.Add(this.lblTitulo);
            this.CadastrarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarLivro.Location = new System.Drawing.Point(36, 25);
            this.CadastrarLivro.Name = "CadastrarLivro";
            this.CadastrarLivro.Size = new System.Drawing.Size(832, 181);
            this.CadastrarLivro.TabIndex = 5;
            this.CadastrarLivro.TabStop = false;
            this.CadastrarLivro.Text = "Novo Livro";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(387, 135);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(97, 22);
            this.numQuantidade.TabIndex = 8;
            this.numQuantidade.Tag = "";
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(288, 135);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(80, 16);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(593, 128);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(196, 31);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(97, 135);
            this.numAno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(97, 22);
            this.numAno.TabIndex = 6;
            this.numAno.Tag = "";
            this.numAno.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(97, 86);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(692, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(97, 43);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(692, 22);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(19, 135);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(34, 16);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(19, 86);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(41, 16);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(19, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // btnVoltarCadastroLivro
            // 
            this.btnVoltarCadastroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadastroLivro.Location = new System.Drawing.Point(761, 232);
            this.btnVoltarCadastroLivro.Name = "btnVoltarCadastroLivro";
            this.btnVoltarCadastroLivro.Size = new System.Drawing.Size(107, 31);
            this.btnVoltarCadastroLivro.TabIndex = 8;
            this.btnVoltarCadastroLivro.Text = "Voltar";
            this.btnVoltarCadastroLivro.UseVisualStyleBackColor = true;
            this.btnVoltarCadastroLivro.Click += new System.EventHandler(this.btnVoltarCadastroLivro_Click);
            // 
            // FormCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 275);
            this.Controls.Add(this.btnVoltarCadastroLivro);
            this.Controls.Add(this.CadastrarLivro);
            this.Name = "FormCadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroLivro";
            this.Load += new System.EventHandler(this.FormCadastroLivro_Load);
            this.CadastrarLivro.ResumeLayout(false);
            this.CadastrarLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CadastrarLivro;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnVoltarCadastroLivro;
    }
}