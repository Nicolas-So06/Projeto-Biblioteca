namespace Biblioteca.Forms.FormsEmprestimo
{
    partial class FormPrincipalEmprestimo
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
            this.btnSalvarEmprestimo = new System.Windows.Forms.Button();
            this.btnCancelarEmprestimo = new System.Windows.Forms.Button();
            this.lblTituloMenuEmprestimo = new System.Windows.Forms.Label();
            this.gbNovoEmprestimo = new System.Windows.Forms.GroupBox();
            this.lblDataDevolucaoEmprestimo = new System.Windows.Forms.Label();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbLivroEmprestimo = new System.Windows.Forms.ComboBox();
            this.lblSelecionaLivroEmprestimo = new System.Windows.Forms.Label();
            this.cbUsuarioEmprestimo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarEmprestimo = new System.Windows.Forms.Button();
            this.gbNovoEmprestimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarEmprestimo
            // 
            this.btnSalvarEmprestimo.Location = new System.Drawing.Point(311, 335);
            this.btnSalvarEmprestimo.Name = "btnSalvarEmprestimo";
            this.btnSalvarEmprestimo.Size = new System.Drawing.Size(120, 25);
            this.btnSalvarEmprestimo.TabIndex = 5;
            this.btnSalvarEmprestimo.Text = "Salvar";
            this.btnSalvarEmprestimo.UseVisualStyleBackColor = true;
            this.btnSalvarEmprestimo.Click += new System.EventHandler(this.btnSalvarEmprestimo_Click);
            // 
            // btnCancelarEmprestimo
            // 
            this.btnCancelarEmprestimo.Location = new System.Drawing.Point(168, 335);
            this.btnCancelarEmprestimo.Name = "btnCancelarEmprestimo";
            this.btnCancelarEmprestimo.Size = new System.Drawing.Size(120, 25);
            this.btnCancelarEmprestimo.TabIndex = 6;
            this.btnCancelarEmprestimo.Text = "Cancelar";
            this.btnCancelarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // lblTituloMenuEmprestimo
            // 
            this.lblTituloMenuEmprestimo.AutoSize = true;
            this.lblTituloMenuEmprestimo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenuEmprestimo.Location = new System.Drawing.Point(423, 27);
            this.lblTituloMenuEmprestimo.Name = "lblTituloMenuEmprestimo";
            this.lblTituloMenuEmprestimo.Size = new System.Drawing.Size(195, 23);
            this.lblTituloMenuEmprestimo.TabIndex = 8;
            this.lblTituloMenuEmprestimo.Text = "Menu do Emprestimo";
            // 
            // gbNovoEmprestimo
            // 
            this.gbNovoEmprestimo.Controls.Add(this.lblDataDevolucaoEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.dtpDataDevolucao);
            this.gbNovoEmprestimo.Controls.Add(this.btnSalvarEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.btnCancelarEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.cbLivroEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.lblSelecionaLivroEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.cbUsuarioEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.label1);
            this.gbNovoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNovoEmprestimo.Location = new System.Drawing.Point(24, 72);
            this.gbNovoEmprestimo.Name = "gbNovoEmprestimo";
            this.gbNovoEmprestimo.Size = new System.Drawing.Size(462, 385);
            this.gbNovoEmprestimo.TabIndex = 9;
            this.gbNovoEmprestimo.TabStop = false;
            this.gbNovoEmprestimo.Text = "Novo Emprestimo";
            // 
            // lblDataDevolucaoEmprestimo
            // 
            this.lblDataDevolucaoEmprestimo.AutoSize = true;
            this.lblDataDevolucaoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolucaoEmprestimo.Location = new System.Drawing.Point(50, 251);
            this.lblDataDevolucaoEmprestimo.Name = "lblDataDevolucaoEmprestimo";
            this.lblDataDevolucaoEmprestimo.Size = new System.Drawing.Size(202, 16);
            this.lblDataDevolucaoEmprestimo.TabIndex = 13;
            this.lblDataDevolucaoEmprestimo.Text = "Selecione a Data de Devolução:";
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(328, 251);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(103, 22);
            this.dtpDataDevolucao.TabIndex = 12;
            // 
            // cbLivroEmprestimo
            // 
            this.cbLivroEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLivroEmprestimo.FormattingEnabled = true;
            this.cbLivroEmprestimo.Location = new System.Drawing.Point(271, 162);
            this.cbLivroEmprestimo.Name = "cbLivroEmprestimo";
            this.cbLivroEmprestimo.Size = new System.Drawing.Size(160, 24);
            this.cbLivroEmprestimo.TabIndex = 11;
            // 
            // lblSelecionaLivroEmprestimo
            // 
            this.lblSelecionaLivroEmprestimo.AutoSize = true;
            this.lblSelecionaLivroEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionaLivroEmprestimo.Location = new System.Drawing.Point(50, 163);
            this.lblSelecionaLivroEmprestimo.Name = "lblSelecionaLivroEmprestimo";
            this.lblSelecionaLivroEmprestimo.Size = new System.Drawing.Size(114, 16);
            this.lblSelecionaLivroEmprestimo.TabIndex = 10;
            this.lblSelecionaLivroEmprestimo.Text = "Selecione o Livro:";
            // 
            // cbUsuarioEmprestimo
            // 
            this.cbUsuarioEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioEmprestimo.FormattingEnabled = true;
            this.cbUsuarioEmprestimo.Location = new System.Drawing.Point(271, 79);
            this.cbUsuarioEmprestimo.Name = "cbUsuarioEmprestimo";
            this.cbUsuarioEmprestimo.Size = new System.Drawing.Size(160, 24);
            this.cbUsuarioEmprestimo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione o Usuário:";
            // 
            // btnVoltarEmprestimo
            // 
            this.btnVoltarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarEmprestimo.Location = new System.Drawing.Point(911, 534);
            this.btnVoltarEmprestimo.Name = "btnVoltarEmprestimo";
            this.btnVoltarEmprestimo.Size = new System.Drawing.Size(107, 31);
            this.btnVoltarEmprestimo.TabIndex = 14;
            this.btnVoltarEmprestimo.Text = "Voltar";
            this.btnVoltarEmprestimo.UseVisualStyleBackColor = true;
            this.btnVoltarEmprestimo.Click += new System.EventHandler(this.btnVoltarEmprestimo_Click);
            // 
            // FormPrincipalEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 577);
            this.Controls.Add(this.btnVoltarEmprestimo);
            this.Controls.Add(this.gbNovoEmprestimo);
            this.Controls.Add(this.lblTituloMenuEmprestimo);
            this.Name = "FormPrincipalEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalEmprestimo";
            this.Load += new System.EventHandler(this.FormPrincipalEmprestimo_Load);
            this.gbNovoEmprestimo.ResumeLayout(false);
            this.gbNovoEmprestimo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarEmprestimo;
        private System.Windows.Forms.Button btnCancelarEmprestimo;
        private System.Windows.Forms.Label lblTituloMenuEmprestimo;
        private System.Windows.Forms.GroupBox gbNovoEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucaoEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.ComboBox cbLivroEmprestimo;
        private System.Windows.Forms.Label lblSelecionaLivroEmprestimo;
        private System.Windows.Forms.ComboBox cbUsuarioEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarEmprestimo;
    }
}