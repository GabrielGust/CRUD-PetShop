namespace ProjetoDS
{
    partial class CRUDUser
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
            this.labelTituloUsuario = new System.Windows.Forms.Label();
            this.txtBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.txtBoxSenhaUsuario = new System.Windows.Forms.TextBox();
            this.labelSenhaUsuario = new System.Windows.Forms.Label();
            this.txtBoxPalavraChave = new System.Windows.Forms.TextBox();
            this.labelPalavraChave = new System.Windows.Forms.Label();
            this.buttonCadastrarUsuario = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.buttonAtualizarUsuario = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelTituloUsuario
            // 
            this.labelTituloUsuario.AutoSize = true;
            this.labelTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelTituloUsuario.Location = new System.Drawing.Point(143, 44);
            this.labelTituloUsuario.MaximumSize = new System.Drawing.Size(252, 31);
            this.labelTituloUsuario.MinimumSize = new System.Drawing.Size(252, 31);
            this.labelTituloUsuario.Name = "labelTituloUsuario";
            this.labelTituloUsuario.Size = new System.Drawing.Size(252, 31);
            this.labelTituloUsuario.TabIndex = 5;
            this.labelTituloUsuario.Text = "Cadastrar Usuário";
            this.labelTituloUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxNomeUsuario
            // 
            this.txtBoxNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxNomeUsuario.Location = new System.Drawing.Point(200, 123);
            this.txtBoxNomeUsuario.MaxLength = 75;
            this.txtBoxNomeUsuario.Name = "txtBoxNomeUsuario";
            this.txtBoxNomeUsuario.Size = new System.Drawing.Size(285, 29);
            this.txtBoxNomeUsuario.TabIndex = 9;
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNomeUsuario.Location = new System.Drawing.Point(33, 126);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(161, 24);
            this.labelNomeUsuario.TabIndex = 8;
            this.labelNomeUsuario.Text = "Nome de usuário:";
            // 
            // txtBoxSenhaUsuario
            // 
            this.txtBoxSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxSenhaUsuario.Location = new System.Drawing.Point(200, 188);
            this.txtBoxSenhaUsuario.MaxLength = 14;
            this.txtBoxSenhaUsuario.Name = "txtBoxSenhaUsuario";
            this.txtBoxSenhaUsuario.Size = new System.Drawing.Size(285, 29);
            this.txtBoxSenhaUsuario.TabIndex = 11;
            this.txtBoxSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // labelSenhaUsuario
            // 
            this.labelSenhaUsuario.AutoSize = true;
            this.labelSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSenhaUsuario.Location = new System.Drawing.Point(33, 191);
            this.labelSenhaUsuario.Name = "labelSenhaUsuario";
            this.labelSenhaUsuario.Size = new System.Drawing.Size(70, 24);
            this.labelSenhaUsuario.TabIndex = 10;
            this.labelSenhaUsuario.Text = "Senha:";
            // 
            // txtBoxPalavraChave
            // 
            this.txtBoxPalavraChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxPalavraChave.Location = new System.Drawing.Point(200, 251);
            this.txtBoxPalavraChave.MaxLength = 75;
            this.txtBoxPalavraChave.Name = "txtBoxPalavraChave";
            this.txtBoxPalavraChave.Size = new System.Drawing.Size(285, 29);
            this.txtBoxPalavraChave.TabIndex = 13;
            // 
            // labelPalavraChave
            // 
            this.labelPalavraChave.AutoSize = true;
            this.labelPalavraChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPalavraChave.Location = new System.Drawing.Point(33, 254);
            this.labelPalavraChave.Name = "labelPalavraChave";
            this.labelPalavraChave.Size = new System.Drawing.Size(133, 24);
            this.labelPalavraChave.TabIndex = 12;
            this.labelPalavraChave.Text = "Palavra-chave:";
            // 
            // buttonCadastrarUsuario
            // 
            this.buttonCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCadastrarUsuario.Location = new System.Drawing.Point(359, 347);
            this.buttonCadastrarUsuario.Name = "buttonCadastrarUsuario";
            this.buttonCadastrarUsuario.Size = new System.Drawing.Size(126, 42);
            this.buttonCadastrarUsuario.TabIndex = 14;
            this.buttonCadastrarUsuario.Text = "Cadastrar";
            this.buttonCadastrarUsuario.UseVisualStyleBackColor = true;
            this.buttonCadastrarUsuario.Click += new System.EventHandler(this.buttonCadastrarUsuario_Click);
            // 
            // buttonCancelarCadastroUsuario
            // 
            this.buttonCancelarCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancelarCadastroUsuario.Location = new System.Drawing.Point(37, 347);
            this.buttonCancelarCadastroUsuario.Name = "buttonCancelarCadastroUsuario";
            this.buttonCancelarCadastroUsuario.Size = new System.Drawing.Size(126, 42);
            this.buttonCancelarCadastroUsuario.TabIndex = 15;
            this.buttonCancelarCadastroUsuario.Text = "Voltar";
            this.buttonCancelarCadastroUsuario.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroUsuario.Click += new System.EventHandler(this.buttonCancelarCadastroUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(200, 347);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(126, 42);
            this.buttonExcluirUsuario.TabIndex = 18;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
            // 
            // buttonAtualizarUsuario
            // 
            this.buttonAtualizarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAtualizarUsuario.Location = new System.Drawing.Point(359, 347);
            this.buttonAtualizarUsuario.MaximumSize = new System.Drawing.Size(126, 42);
            this.buttonAtualizarUsuario.MinimumSize = new System.Drawing.Size(126, 42);
            this.buttonAtualizarUsuario.Name = "buttonAtualizarUsuario";
            this.buttonAtualizarUsuario.Size = new System.Drawing.Size(126, 42);
            this.buttonAtualizarUsuario.TabIndex = 19;
            this.buttonAtualizarUsuario.Text = "Atualizar";
            this.buttonAtualizarUsuario.UseVisualStyleBackColor = true;
            this.buttonAtualizarUsuario.Click += new System.EventHandler(this.buttonAtualizarUsuario_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(399, 220);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci a senha";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 427);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonAtualizarUsuario);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonCancelarCadastroUsuario);
            this.Controls.Add(this.buttonCadastrarUsuario);
            this.Controls.Add(this.txtBoxPalavraChave);
            this.Controls.Add(this.labelPalavraChave);
            this.Controls.Add(this.txtBoxSenhaUsuario);
            this.Controls.Add(this.labelSenhaUsuario);
            this.Controls.Add(this.txtBoxNomeUsuario);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.labelTituloUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 465);
            this.MinimumSize = new System.Drawing.Size(548, 465);
            this.Name = "CRUDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDUser_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloUsuario;
        private System.Windows.Forms.TextBox txtBoxNomeUsuario;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.TextBox txtBoxSenhaUsuario;
        private System.Windows.Forms.Label labelSenhaUsuario;
        private System.Windows.Forms.TextBox txtBoxPalavraChave;
        private System.Windows.Forms.Label labelPalavraChave;
        private System.Windows.Forms.Button buttonCadastrarUsuario;
        private System.Windows.Forms.Button buttonCancelarCadastroUsuario;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Button buttonAtualizarUsuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}