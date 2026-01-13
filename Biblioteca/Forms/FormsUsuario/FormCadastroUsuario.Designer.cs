namespace Biblioteca.Forms
{
    partial class FormCadastroUsuario
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
            this.CadastrarUsuario = new System.Windows.Forms.GroupBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTelefoneUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCpfUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvarNovoUsuario = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltarCadastroUsuario_Click = new System.Windows.Forms.Button();
            this.CadastrarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastrarUsuario
            // 
            this.CadastrarUsuario.Controls.Add(this.cbTipoUsuario);
            this.CadastrarUsuario.Controls.Add(this.lblTipo);
            this.CadastrarUsuario.Controls.Add(this.txtTelefoneUsuario);
            this.CadastrarUsuario.Controls.Add(this.lblTelefone);
            this.CadastrarUsuario.Controls.Add(this.txtCpfUsuario);
            this.CadastrarUsuario.Controls.Add(this.txtEmailUsuario);
            this.CadastrarUsuario.Controls.Add(this.txtNomeUsuario);
            this.CadastrarUsuario.Controls.Add(this.btnSalvarNovoUsuario);
            this.CadastrarUsuario.Controls.Add(this.lblCPF);
            this.CadastrarUsuario.Controls.Add(this.lblEmail);
            this.CadastrarUsuario.Controls.Add(this.lblNome);
            this.CadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarUsuario.Location = new System.Drawing.Point(45, 26);
            this.CadastrarUsuario.Name = "CadastrarUsuario";
            this.CadastrarUsuario.Size = new System.Drawing.Size(860, 177);
            this.CadastrarUsuario.TabIndex = 11;
            this.CadastrarUsuario.TabStop = false;
            this.CadastrarUsuario.Text = "Novo Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Funcionário",
            "Cliente",
            "Visitante"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(433, 126);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(121, 24);
            this.cbTipoUsuario.TabIndex = 10;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(378, 129);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTelefoneUsuario
            // 
            this.txtTelefoneUsuario.Location = new System.Drawing.Point(97, 126);
            this.txtTelefoneUsuario.Mask = "(00) 00000-0000";
            this.txtTelefoneUsuario.Name = "txtTelefoneUsuario";
            this.txtTelefoneUsuario.Size = new System.Drawing.Size(96, 22);
            this.txtTelefoneUsuario.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(19, 129);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 16);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtCpfUsuario
            // 
            this.txtCpfUsuario.Location = new System.Drawing.Point(266, 126);
            this.txtCpfUsuario.Mask = "000.000.000-00";
            this.txtCpfUsuario.Name = "txtCpfUsuario";
            this.txtCpfUsuario.Size = new System.Drawing.Size(96, 22);
            this.txtCpfUsuario.TabIndex = 6;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(97, 86);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(692, 22);
            this.txtEmailUsuario.TabIndex = 5;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(97, 43);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(692, 22);
            this.txtNomeUsuario.TabIndex = 4;
            // 
            // btnSalvarNovoUsuario
            // 
            this.btnSalvarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovoUsuario.Location = new System.Drawing.Point(593, 122);
            this.btnSalvarNovoUsuario.Name = "btnSalvarNovoUsuario";
            this.btnSalvarNovoUsuario.Size = new System.Drawing.Size(196, 31);
            this.btnSalvarNovoUsuario.TabIndex = 3;
            this.btnSalvarNovoUsuario.Text = "Salvar";
            this.btnSalvarNovoUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarNovoUsuario.Click += new System.EventHandler(this.btnSalvarNovoUsuario_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(213, 129);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnVoltarCadastroUsuario_Click
            // 
            this.btnVoltarCadastroUsuario_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCadastroUsuario_Click.Location = new System.Drawing.Point(775, 218);
            this.btnVoltarCadastroUsuario_Click.Name = "btnVoltarCadastroUsuario_Click";
            this.btnVoltarCadastroUsuario_Click.Size = new System.Drawing.Size(130, 31);
            this.btnVoltarCadastroUsuario_Click.TabIndex = 12;
            this.btnVoltarCadastroUsuario_Click.Text = "Voltar";
            this.btnVoltarCadastroUsuario_Click.UseVisualStyleBackColor = true;
            this.btnVoltarCadastroUsuario_Click.Click += new System.EventHandler(this.btnVoltarCadastroUsuario_Click_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 261);
            this.Controls.Add(this.btnVoltarCadastroUsuario_Click);
            this.Controls.Add(this.CadastrarUsuario);
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroUsuario";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.CadastrarUsuario.ResumeLayout(false);
            this.CadastrarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CadastrarUsuario;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.MaskedTextBox txtTelefoneUsuario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpfUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnSalvarNovoUsuario;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltarCadastroUsuario_Click;
    }
}