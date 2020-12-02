namespace ProjetoDS
{
    partial class BuscaUsuário
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
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBoxBuscarNomeUsuario = new System.Windows.Forms.TextBox();
            this.labelBuscarNomeUsuario = new System.Windows.Forms.Label();
            this.txtBoxBuscarCodigoUsuario = new System.Windows.Forms.TextBox();
            this.labelBuscarCodigoUsuario = new System.Windows.Forms.Label();
            this.GridViewUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(442, 25);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(119, 68);
            this.buttonBuscarUsuario.TabIndex = 14;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // txtBoxBuscarNomeUsuario
            // 
            this.txtBoxBuscarNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarNomeUsuario.Location = new System.Drawing.Point(190, 22);
            this.txtBoxBuscarNomeUsuario.Name = "txtBoxBuscarNomeUsuario";
            this.txtBoxBuscarNomeUsuario.Size = new System.Drawing.Size(238, 29);
            this.txtBoxBuscarNomeUsuario.TabIndex = 13;
            // 
            // labelBuscarNomeUsuario
            // 
            this.labelBuscarNomeUsuario.AutoSize = true;
            this.labelBuscarNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarNomeUsuario.Location = new System.Drawing.Point(21, 25);
            this.labelBuscarNomeUsuario.Name = "labelBuscarNomeUsuario";
            this.labelBuscarNomeUsuario.Size = new System.Drawing.Size(154, 24);
            this.labelBuscarNomeUsuario.TabIndex = 12;
            this.labelBuscarNomeUsuario.Text = "Busca por nome:";
            // 
            // txtBoxBuscarCodigoUsuario
            // 
            this.txtBoxBuscarCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarCodigoUsuario.Location = new System.Drawing.Point(190, 62);
            this.txtBoxBuscarCodigoUsuario.Name = "txtBoxBuscarCodigoUsuario";
            this.txtBoxBuscarCodigoUsuario.Size = new System.Drawing.Size(87, 29);
            this.txtBoxBuscarCodigoUsuario.TabIndex = 11;
            // 
            // labelBuscarCodigoUsuario
            // 
            this.labelBuscarCodigoUsuario.AutoSize = true;
            this.labelBuscarCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarCodigoUsuario.Location = new System.Drawing.Point(21, 65);
            this.labelBuscarCodigoUsuario.Name = "labelBuscarCodigoUsuario";
            this.labelBuscarCodigoUsuario.Size = new System.Drawing.Size(163, 24);
            this.labelBuscarCodigoUsuario.TabIndex = 10;
            this.labelBuscarCodigoUsuario.Text = "Busca por código:";
            // 
            // GridViewUsuarios
            // 
            this.GridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuarios.Location = new System.Drawing.Point(25, 97);
            this.GridViewUsuarios.Name = "GridViewUsuarios";
            this.GridViewUsuarios.Size = new System.Drawing.Size(536, 341);
            this.GridViewUsuarios.TabIndex = 15;
            this.GridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuarios_CellClick);
            // 
            // BuscaUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 454);
            this.Controls.Add(this.GridViewUsuarios);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.txtBoxBuscarNomeUsuario);
            this.Controls.Add(this.labelBuscarNomeUsuario);
            this.Controls.Add(this.txtBoxBuscarCodigoUsuario);
            this.Controls.Add(this.labelBuscarCodigoUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 492);
            this.MinimumSize = new System.Drawing.Size(605, 492);
            this.Name = "BuscaUsuário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscaUsuário_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.TextBox txtBoxBuscarNomeUsuario;
        private System.Windows.Forms.Label labelBuscarNomeUsuario;
        private System.Windows.Forms.TextBox txtBoxBuscarCodigoUsuario;
        private System.Windows.Forms.Label labelBuscarCodigoUsuario;
        private System.Windows.Forms.DataGridView GridViewUsuarios;
    }
}