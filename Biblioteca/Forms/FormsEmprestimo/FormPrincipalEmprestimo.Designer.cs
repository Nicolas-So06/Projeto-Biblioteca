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
            this.lblTituloMenuEmprestimo = new System.Windows.Forms.Label();
            this.gbNovoEmprestimo = new System.Windows.Forms.GroupBox();
            this.lblDataDevolucaoEmprestimo = new System.Windows.Forms.Label();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbLivroEmprestimo = new System.Windows.Forms.ComboBox();
            this.lblSelecionaLivroEmprestimo = new System.Windows.Forms.Label();
            this.cbUsuarioEmprestimo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditarLivroEmp = new System.Windows.Forms.Label();
            this.btnVoltarEmprestimo = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.gbEditarEmprestimo = new System.Windows.Forms.GroupBox();
            this.btnDevolverLivroEmp = new System.Windows.Forms.Button();
            this.btnSalvarEdicaoEmp = new System.Windows.Forms.Button();
            this.dtpEditarDataDevolucaoEmp = new System.Windows.Forms.DateTimePicker();
            this.lblEditarDataDevolucaoEmp = new System.Windows.Forms.Label();
            this.txtEditarLivroEmp = new System.Windows.Forms.TextBox();
            this.txtEditarUsuarioEmp = new System.Windows.Forms.TextBox();
            this.lblEditarUsuarioEmp = new System.Windows.Forms.Label();
            this.gbNovoEmprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.gbEditarEmprestimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarEmprestimo
            // 
            this.btnSalvarEmprestimo.Location = new System.Drawing.Point(311, 386);
            this.btnSalvarEmprestimo.Name = "btnSalvarEmprestimo";
            this.btnSalvarEmprestimo.Size = new System.Drawing.Size(120, 25);
            this.btnSalvarEmprestimo.TabIndex = 5;
            this.btnSalvarEmprestimo.Text = "Salvar";
            this.btnSalvarEmprestimo.UseVisualStyleBackColor = true;
            this.btnSalvarEmprestimo.Click += new System.EventHandler(this.btnSalvarEmprestimo_Click);
            // 
            // lblTituloMenuEmprestimo
            // 
            this.lblTituloMenuEmprestimo.AutoSize = true;
            this.lblTituloMenuEmprestimo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenuEmprestimo.Location = new System.Drawing.Point(422, 27);
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
            this.gbNovoEmprestimo.Controls.Add(this.cbLivroEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.lblSelecionaLivroEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.cbUsuarioEmprestimo);
            this.gbNovoEmprestimo.Controls.Add(this.label1);
            this.gbNovoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNovoEmprestimo.Location = new System.Drawing.Point(24, 72);
            this.gbNovoEmprestimo.Name = "gbNovoEmprestimo";
            this.gbNovoEmprestimo.Size = new System.Drawing.Size(462, 437);
            this.gbNovoEmprestimo.TabIndex = 9;
            this.gbNovoEmprestimo.TabStop = false;
            this.gbNovoEmprestimo.Text = "Novo Emprestimo";
            // 
            // lblDataDevolucaoEmprestimo
            // 
            this.lblDataDevolucaoEmprestimo.AutoSize = true;
            this.lblDataDevolucaoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolucaoEmprestimo.Location = new System.Drawing.Point(50, 263);
            this.lblDataDevolucaoEmprestimo.Name = "lblDataDevolucaoEmprestimo";
            this.lblDataDevolucaoEmprestimo.Size = new System.Drawing.Size(202, 16);
            this.lblDataDevolucaoEmprestimo.TabIndex = 13;
            this.lblDataDevolucaoEmprestimo.Text = "Selecione a Data de Devolução:";
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(328, 263);
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
            // lblEditarLivroEmp
            // 
            this.lblEditarLivroEmp.AutoSize = true;
            this.lblEditarLivroEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarLivroEmp.Location = new System.Drawing.Point(35, 97);
            this.lblEditarLivroEmp.Name = "lblEditarLivroEmp";
            this.lblEditarLivroEmp.Size = new System.Drawing.Size(39, 16);
            this.lblEditarLivroEmp.TabIndex = 14;
            this.lblEditarLivroEmp.Text = "Livro:";
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
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AllowUserToDeleteRows = false;
            this.dgvEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(556, 335);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(462, 174);
            this.dgvEmprestimos.TabIndex = 15;
            this.dgvEmprestimos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellContentClick);
            this.dgvEmprestimos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellContentClick);
            // 
            // gbEditarEmprestimo
            // 
            this.gbEditarEmprestimo.Controls.Add(this.btnDevolverLivroEmp);
            this.gbEditarEmprestimo.Controls.Add(this.btnSalvarEdicaoEmp);
            this.gbEditarEmprestimo.Controls.Add(this.dtpEditarDataDevolucaoEmp);
            this.gbEditarEmprestimo.Controls.Add(this.lblEditarDataDevolucaoEmp);
            this.gbEditarEmprestimo.Controls.Add(this.txtEditarLivroEmp);
            this.gbEditarEmprestimo.Controls.Add(this.txtEditarUsuarioEmp);
            this.gbEditarEmprestimo.Controls.Add(this.lblEditarLivroEmp);
            this.gbEditarEmprestimo.Controls.Add(this.lblEditarUsuarioEmp);
            this.gbEditarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditarEmprestimo.Location = new System.Drawing.Point(556, 72);
            this.gbEditarEmprestimo.Name = "gbEditarEmprestimo";
            this.gbEditarEmprestimo.Size = new System.Drawing.Size(462, 246);
            this.gbEditarEmprestimo.TabIndex = 16;
            this.gbEditarEmprestimo.TabStop = false;
            this.gbEditarEmprestimo.Text = "Editar Emprestimo";
            // 
            // btnDevolverLivroEmp
            // 
            this.btnDevolverLivroEmp.Location = new System.Drawing.Point(38, 205);
            this.btnDevolverLivroEmp.Name = "btnDevolverLivroEmp";
            this.btnDevolverLivroEmp.Size = new System.Drawing.Size(120, 25);
            this.btnDevolverLivroEmp.TabIndex = 14;
            this.btnDevolverLivroEmp.Text = "Devolver Livro";
            this.btnDevolverLivroEmp.UseVisualStyleBackColor = true;
            this.btnDevolverLivroEmp.Click += new System.EventHandler(this.btnDevolverLivroEmp_Click);
            // 
            // btnSalvarEdicaoEmp
            // 
            this.btnSalvarEdicaoEmp.Location = new System.Drawing.Point(305, 205);
            this.btnSalvarEdicaoEmp.Name = "btnSalvarEdicaoEmp";
            this.btnSalvarEdicaoEmp.Size = new System.Drawing.Size(120, 25);
            this.btnSalvarEdicaoEmp.TabIndex = 14;
            this.btnSalvarEdicaoEmp.Text = "Salvar";
            this.btnSalvarEdicaoEmp.UseVisualStyleBackColor = true;
            this.btnSalvarEdicaoEmp.Click += new System.EventHandler(this.btnSalvarEdicaoEmp_Click);
            // 
            // dtpEditarDataDevolucaoEmp
            // 
            this.dtpEditarDataDevolucaoEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditarDataDevolucaoEmp.Location = new System.Drawing.Point(322, 145);
            this.dtpEditarDataDevolucaoEmp.Name = "dtpEditarDataDevolucaoEmp";
            this.dtpEditarDataDevolucaoEmp.Size = new System.Drawing.Size(103, 22);
            this.dtpEditarDataDevolucaoEmp.TabIndex = 14;
            // 
            // lblEditarDataDevolucaoEmp
            // 
            this.lblEditarDataDevolucaoEmp.AutoSize = true;
            this.lblEditarDataDevolucaoEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarDataDevolucaoEmp.Location = new System.Drawing.Point(35, 150);
            this.lblEditarDataDevolucaoEmp.Name = "lblEditarDataDevolucaoEmp";
            this.lblEditarDataDevolucaoEmp.Size = new System.Drawing.Size(127, 16);
            this.lblEditarDataDevolucaoEmp.TabIndex = 14;
            this.lblEditarDataDevolucaoEmp.Text = "Data de Devolução:";
            // 
            // txtEditarLivroEmp
            // 
            this.txtEditarLivroEmp.Location = new System.Drawing.Point(189, 97);
            this.txtEditarLivroEmp.Name = "txtEditarLivroEmp";
            this.txtEditarLivroEmp.ReadOnly = true;
            this.txtEditarLivroEmp.Size = new System.Drawing.Size(236, 22);
            this.txtEditarLivroEmp.TabIndex = 16;
            // 
            // txtEditarUsuarioEmp
            // 
            this.txtEditarUsuarioEmp.Location = new System.Drawing.Point(189, 45);
            this.txtEditarUsuarioEmp.Name = "txtEditarUsuarioEmp";
            this.txtEditarUsuarioEmp.ReadOnly = true;
            this.txtEditarUsuarioEmp.Size = new System.Drawing.Size(236, 22);
            this.txtEditarUsuarioEmp.TabIndex = 15;
            // 
            // lblEditarUsuarioEmp
            // 
            this.lblEditarUsuarioEmp.AutoSize = true;
            this.lblEditarUsuarioEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarUsuarioEmp.Location = new System.Drawing.Point(35, 45);
            this.lblEditarUsuarioEmp.Name = "lblEditarUsuarioEmp";
            this.lblEditarUsuarioEmp.Size = new System.Drawing.Size(57, 16);
            this.lblEditarUsuarioEmp.TabIndex = 14;
            this.lblEditarUsuarioEmp.Text = "Usuário:";
            // 
            // FormPrincipalEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 577);
            this.Controls.Add(this.gbEditarEmprestimo);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.btnVoltarEmprestimo);
            this.Controls.Add(this.gbNovoEmprestimo);
            this.Controls.Add(this.lblTituloMenuEmprestimo);
            this.Name = "FormPrincipalEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalEmprestimo";
            this.Load += new System.EventHandler(this.FormPrincipalEmprestimo_Load);
            this.gbNovoEmprestimo.ResumeLayout(false);
            this.gbNovoEmprestimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.gbEditarEmprestimo.ResumeLayout(false);
            this.gbEditarEmprestimo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarEmprestimo;
        private System.Windows.Forms.Label lblTituloMenuEmprestimo;
        private System.Windows.Forms.GroupBox gbNovoEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucaoEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.ComboBox cbLivroEmprestimo;
        private System.Windows.Forms.Label lblSelecionaLivroEmprestimo;
        private System.Windows.Forms.ComboBox cbUsuarioEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarEmprestimo;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.GroupBox gbEditarEmprestimo;
        private System.Windows.Forms.Label lblEditarLivroEmp;
        private System.Windows.Forms.Label lblEditarUsuarioEmp;
        private System.Windows.Forms.Label lblEditarDataDevolucaoEmp;
        private System.Windows.Forms.TextBox txtEditarLivroEmp;
        private System.Windows.Forms.TextBox txtEditarUsuarioEmp;
        private System.Windows.Forms.Button btnDevolverLivroEmp;
        private System.Windows.Forms.Button btnSalvarEdicaoEmp;
        private System.Windows.Forms.DateTimePicker dtpEditarDataDevolucaoEmp;
    }
}