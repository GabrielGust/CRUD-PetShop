namespace ProjetoDS
{
    partial class CRUDPet
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
            this.labelTituloPet = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelPorte = new System.Windows.Forms.Label();
            this.labelClassificacao = new System.Windows.Forms.Label();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.labelNomePet = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtBoxNomePet = new System.Windows.Forms.TextBox();
            this.txtBoxSexo = new System.Windows.Forms.TextBox();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonCadastrarPet = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroPet = new System.Windows.Forms.Button();
            this.buttonAlterarPet = new System.Windows.Forms.Button();
            this.buttonExcluirPet = new System.Windows.Forms.Button();
            this.cmbBoxClassificacao = new System.Windows.Forms.ComboBox();
            this.cmbBoxPorte = new System.Windows.Forms.ComboBox();
            this.cmbBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTituloPet
            // 
            this.labelTituloPet.AutoSize = true;
            this.labelTituloPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelTituloPet.Location = new System.Drawing.Point(290, 46);
            this.labelTituloPet.Name = "labelTituloPet";
            this.labelTituloPet.Size = new System.Drawing.Size(195, 31);
            this.labelTituloPet.TabIndex = 5;
            this.labelTituloPet.Text = "Cadastrar Pet";
            this.labelTituloPet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSexo.Location = new System.Drawing.Point(475, 126);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(59, 24);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo:";
            // 
            // labelPorte
            // 
            this.labelPorte.AutoSize = true;
            this.labelPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPorte.Location = new System.Drawing.Point(447, 242);
            this.labelPorte.Name = "labelPorte";
            this.labelPorte.Size = new System.Drawing.Size(59, 24);
            this.labelPorte.TabIndex = 7;
            this.labelPorte.Text = "Porte:";
            // 
            // labelClassificacao
            // 
            this.labelClassificacao.AutoSize = true;
            this.labelClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelClassificacao.Location = new System.Drawing.Point(48, 242);
            this.labelClassificacao.Name = "labelClassificacao";
            this.labelClassificacao.Size = new System.Drawing.Size(123, 24);
            this.labelClassificacao.TabIndex = 8;
            this.labelClassificacao.Text = "Classificação:";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelResponsavel.Location = new System.Drawing.Point(48, 181);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(124, 24);
            this.labelResponsavel.TabIndex = 9;
            this.labelResponsavel.Text = "Responsável:";
            // 
            // labelNomePet
            // 
            this.labelNomePet.AutoSize = true;
            this.labelNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNomePet.Location = new System.Drawing.Point(48, 126);
            this.labelNomePet.Name = "labelNomePet";
            this.labelNomePet.Size = new System.Drawing.Size(126, 24);
            this.labelNomePet.TabIndex = 11;
            this.labelNomePet.Text = "Nome do Pet:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDescricao.Location = new System.Drawing.Point(48, 293);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(99, 24);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição:";
            // 
            // txtBoxNomePet
            // 
            this.txtBoxNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxNomePet.Location = new System.Drawing.Point(180, 123);
            this.txtBoxNomePet.MaxLength = 20;
            this.txtBoxNomePet.Name = "txtBoxNomePet";
            this.txtBoxNomePet.Size = new System.Drawing.Size(276, 29);
            this.txtBoxNomePet.TabIndex = 12;
            // 
            // txtBoxSexo
            // 
            this.txtBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxSexo.Location = new System.Drawing.Point(540, 123);
            this.txtBoxSexo.MaxLength = 5;
            this.txtBoxSexo.Name = "txtBoxSexo";
            this.txtBoxSexo.Size = new System.Drawing.Size(204, 29);
            this.txtBoxSexo.TabIndex = 12;
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxDescricao.Location = new System.Drawing.Point(52, 320);
            this.txtBoxDescricao.MaxLength = 215;
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(692, 108);
            this.txtBoxDescricao.TabIndex = 13;
            // 
            // buttonCadastrarPet
            // 
            this.buttonCadastrarPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCadastrarPet.Location = new System.Drawing.Point(618, 465);
            this.buttonCadastrarPet.Name = "buttonCadastrarPet";
            this.buttonCadastrarPet.Size = new System.Drawing.Size(126, 42);
            this.buttonCadastrarPet.TabIndex = 14;
            this.buttonCadastrarPet.Text = "Cadastrar";
            this.buttonCadastrarPet.UseVisualStyleBackColor = true;
            this.buttonCadastrarPet.Click += new System.EventHandler(this.buttonCadastrarPet_Click);
            // 
            // buttonCancelarCadastroPet
            // 
            this.buttonCancelarCadastroPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancelarCadastroPet.Location = new System.Drawing.Point(52, 465);
            this.buttonCancelarCadastroPet.Name = "buttonCancelarCadastroPet";
            this.buttonCancelarCadastroPet.Size = new System.Drawing.Size(126, 42);
            this.buttonCancelarCadastroPet.TabIndex = 15;
            this.buttonCancelarCadastroPet.Text = "Voltar";
            this.buttonCancelarCadastroPet.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroPet.Click += new System.EventHandler(this.buttonCancelarCadastroPet_Click);
            // 
            // buttonAlterarPet
            // 
            this.buttonAlterarPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAlterarPet.Location = new System.Drawing.Point(618, 465);
            this.buttonAlterarPet.Name = "buttonAlterarPet";
            this.buttonAlterarPet.Size = new System.Drawing.Size(126, 42);
            this.buttonAlterarPet.TabIndex = 16;
            this.buttonAlterarPet.Text = "Alterar";
            this.buttonAlterarPet.UseVisualStyleBackColor = true;
            this.buttonAlterarPet.Click += new System.EventHandler(this.buttonAlterarPet_Click);
            // 
            // buttonExcluirPet
            // 
            this.buttonExcluirPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExcluirPet.Location = new System.Drawing.Point(417, 465);
            this.buttonExcluirPet.Name = "buttonExcluirPet";
            this.buttonExcluirPet.Size = new System.Drawing.Size(126, 42);
            this.buttonExcluirPet.TabIndex = 17;
            this.buttonExcluirPet.Text = "Excluir";
            this.buttonExcluirPet.UseVisualStyleBackColor = true;
            this.buttonExcluirPet.Click += new System.EventHandler(this.buttonExcluirPet_Click);
            // 
            // cmbBoxClassificacao
            // 
            this.cmbBoxClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbBoxClassificacao.FormattingEnabled = true;
            this.cmbBoxClassificacao.Location = new System.Drawing.Point(180, 239);
            this.cmbBoxClassificacao.Name = "cmbBoxClassificacao";
            this.cmbBoxClassificacao.Size = new System.Drawing.Size(242, 32);
            this.cmbBoxClassificacao.TabIndex = 18;
            this.cmbBoxClassificacao.SelectedIndexChanged += new System.EventHandler(this.cmbBoxClassificacao_SelectedIndexChanged);
            // 
            // cmbBoxPorte
            // 
            this.cmbBoxPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbBoxPorte.FormattingEnabled = true;
            this.cmbBoxPorte.Location = new System.Drawing.Point(512, 239);
            this.cmbBoxPorte.Name = "cmbBoxPorte";
            this.cmbBoxPorte.Size = new System.Drawing.Size(232, 32);
            this.cmbBoxPorte.TabIndex = 19;
            this.cmbBoxPorte.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPorte_SelectedIndexChanged);
            // 
            // cmbBoxResponsavel
            // 
            this.cmbBoxResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbBoxResponsavel.FormattingEnabled = true;
            this.cmbBoxResponsavel.Location = new System.Drawing.Point(180, 178);
            this.cmbBoxResponsavel.Name = "cmbBoxResponsavel";
            this.cmbBoxResponsavel.Size = new System.Drawing.Size(564, 32);
            this.cmbBoxResponsavel.TabIndex = 20;
            this.cmbBoxResponsavel.SelectedIndexChanged += new System.EventHandler(this.cmbBoxResponsavel_SelectedIndexChanged);
            // 
            // CRUDPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.cmbBoxResponsavel);
            this.Controls.Add(this.cmbBoxPorte);
            this.Controls.Add(this.cmbBoxClassificacao);
            this.Controls.Add(this.buttonExcluirPet);
            this.Controls.Add(this.buttonAlterarPet);
            this.Controls.Add(this.buttonCancelarCadastroPet);
            this.Controls.Add(this.buttonCadastrarPet);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.txtBoxSexo);
            this.Controls.Add(this.txtBoxNomePet);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelPorte);
            this.Controls.Add(this.labelClassificacao);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelNomePet);
            this.Controls.Add(this.labelTituloPet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 572);
            this.MinimumSize = new System.Drawing.Size(816, 572);
            this.Name = "CRUDPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDPet_FormClosed);
            this.Load += new System.EventHandler(this.CRUDPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloPet;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelPorte;
        private System.Windows.Forms.Label labelClassificacao;
        private System.Windows.Forms.Label labelResponsavel;
        private System.Windows.Forms.Label labelNomePet;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtBoxNomePet;
        private System.Windows.Forms.TextBox txtBoxSexo;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Button buttonCadastrarPet;
        private System.Windows.Forms.Button buttonCancelarCadastroPet;
        private System.Windows.Forms.Button buttonAlterarPet;
        private System.Windows.Forms.Button buttonExcluirPet;
        private System.Windows.Forms.ComboBox cmbBoxClassificacao;
        private System.Windows.Forms.ComboBox cmbBoxPorte;
        private System.Windows.Forms.ComboBox cmbBoxResponsavel;
    }
}