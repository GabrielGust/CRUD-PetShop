namespace ProjetoDS
{
    partial class BuscaCliente
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
            this.labelBuscarCodigo = new System.Windows.Forms.Label();
            this.txtBoxBuscarCodigo = new System.Windows.Forms.TextBox();
            this.labelBuscarNome = new System.Windows.Forms.Label();
            this.txtBoxBuscarNome = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.GridViewClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscarCodigo
            // 
            this.labelBuscarCodigo.AutoSize = true;
            this.labelBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarCodigo.Location = new System.Drawing.Point(21, 65);
            this.labelBuscarCodigo.Name = "labelBuscarCodigo";
            this.labelBuscarCodigo.Size = new System.Drawing.Size(163, 24);
            this.labelBuscarCodigo.TabIndex = 0;
            this.labelBuscarCodigo.Text = "Busca por código:";
            // 
            // txtBoxBuscarCodigo
            // 
            this.txtBoxBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarCodigo.Location = new System.Drawing.Point(190, 62);
            this.txtBoxBuscarCodigo.Name = "txtBoxBuscarCodigo";
            this.txtBoxBuscarCodigo.Size = new System.Drawing.Size(122, 29);
            this.txtBoxBuscarCodigo.TabIndex = 1;
            // 
            // labelBuscarNome
            // 
            this.labelBuscarNome.AutoSize = true;
            this.labelBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarNome.Location = new System.Drawing.Point(21, 25);
            this.labelBuscarNome.Name = "labelBuscarNome";
            this.labelBuscarNome.Size = new System.Drawing.Size(154, 24);
            this.labelBuscarNome.TabIndex = 2;
            this.labelBuscarNome.Text = "Busca por nome:";
            // 
            // txtBoxBuscarNome
            // 
            this.txtBoxBuscarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarNome.Location = new System.Drawing.Point(190, 22);
            this.txtBoxBuscarNome.Name = "txtBoxBuscarNome";
            this.txtBoxBuscarNome.Size = new System.Drawing.Size(441, 29);
            this.txtBoxBuscarNome.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBuscar.Location = new System.Drawing.Point(645, 22);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(119, 68);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // GridViewClientes
            // 
            this.GridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewClientes.Location = new System.Drawing.Point(25, 97);
            this.GridViewClientes.Name = "GridViewClientes";
            this.GridViewClientes.Size = new System.Drawing.Size(739, 452);
            this.GridViewClientes.TabIndex = 5;
            this.GridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewClientes_CellClick);
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 572);
            this.Controls.Add(this.GridViewClientes);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.txtBoxBuscarNome);
            this.Controls.Add(this.labelBuscarNome);
            this.Controls.Add(this.txtBoxBuscarCodigo);
            this.Controls.Add(this.labelBuscarCodigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 610);
            this.MinimumSize = new System.Drawing.Size(805, 610);
            this.Name = "BuscaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscaCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscarCodigo;
        private System.Windows.Forms.TextBox txtBoxBuscarCodigo;
        private System.Windows.Forms.Label labelBuscarNome;
        private System.Windows.Forms.TextBox txtBoxBuscarNome;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView GridViewClientes;
    }
}