namespace ProjetoDS
{
    partial class BuscaPet
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
            this.buttonBuscarPet = new System.Windows.Forms.Button();
            this.txtBoxBuscarNomePet = new System.Windows.Forms.TextBox();
            this.labelBuscarNomePet = new System.Windows.Forms.Label();
            this.txtBoxBuscarCodigoPet = new System.Windows.Forms.TextBox();
            this.labelBuscarCodigoPet = new System.Windows.Forms.Label();
            this.GridViewPets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPets)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarPet
            // 
            this.buttonBuscarPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBuscarPet.Location = new System.Drawing.Point(645, 22);
            this.buttonBuscarPet.Name = "buttonBuscarPet";
            this.buttonBuscarPet.Size = new System.Drawing.Size(119, 68);
            this.buttonBuscarPet.TabIndex = 9;
            this.buttonBuscarPet.Text = "Buscar";
            this.buttonBuscarPet.UseVisualStyleBackColor = true;
            this.buttonBuscarPet.Click += new System.EventHandler(this.buttonBuscarPet_Click);
            // 
            // txtBoxBuscarNomePet
            // 
            this.txtBoxBuscarNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarNomePet.Location = new System.Drawing.Point(190, 22);
            this.txtBoxBuscarNomePet.Name = "txtBoxBuscarNomePet";
            this.txtBoxBuscarNomePet.Size = new System.Drawing.Size(441, 29);
            this.txtBoxBuscarNomePet.TabIndex = 8;
            // 
            // labelBuscarNomePet
            // 
            this.labelBuscarNomePet.AutoSize = true;
            this.labelBuscarNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarNomePet.Location = new System.Drawing.Point(21, 25);
            this.labelBuscarNomePet.Name = "labelBuscarNomePet";
            this.labelBuscarNomePet.Size = new System.Drawing.Size(154, 24);
            this.labelBuscarNomePet.TabIndex = 7;
            this.labelBuscarNomePet.Text = "Busca por nome:";
            // 
            // txtBoxBuscarCodigoPet
            // 
            this.txtBoxBuscarCodigoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxBuscarCodigoPet.Location = new System.Drawing.Point(190, 62);
            this.txtBoxBuscarCodigoPet.Name = "txtBoxBuscarCodigoPet";
            this.txtBoxBuscarCodigoPet.Size = new System.Drawing.Size(122, 29);
            this.txtBoxBuscarCodigoPet.TabIndex = 6;
            // 
            // labelBuscarCodigoPet
            // 
            this.labelBuscarCodigoPet.AutoSize = true;
            this.labelBuscarCodigoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBuscarCodigoPet.Location = new System.Drawing.Point(21, 65);
            this.labelBuscarCodigoPet.Name = "labelBuscarCodigoPet";
            this.labelBuscarCodigoPet.Size = new System.Drawing.Size(163, 24);
            this.labelBuscarCodigoPet.TabIndex = 5;
            this.labelBuscarCodigoPet.Text = "Busca por código:";
            // 
            // GridViewPets
            // 
            this.GridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPets.Location = new System.Drawing.Point(25, 97);
            this.GridViewPets.Name = "GridViewPets";
            this.GridViewPets.Size = new System.Drawing.Size(739, 452);
            this.GridViewPets.TabIndex = 10;
            this.GridViewPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPets_CellClick);
            // 
            // BuscaPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 572);
            this.Controls.Add(this.GridViewPets);
            this.Controls.Add(this.buttonBuscarPet);
            this.Controls.Add(this.txtBoxBuscarNomePet);
            this.Controls.Add(this.labelBuscarNomePet);
            this.Controls.Add(this.txtBoxBuscarCodigoPet);
            this.Controls.Add(this.labelBuscarCodigoPet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 610);
            this.MinimumSize = new System.Drawing.Size(805, 610);
            this.Name = "BuscaPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscaPet_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarPet;
        private System.Windows.Forms.TextBox txtBoxBuscarNomePet;
        private System.Windows.Forms.Label labelBuscarNomePet;
        private System.Windows.Forms.TextBox txtBoxBuscarCodigoPet;
        private System.Windows.Forms.Label labelBuscarCodigoPet;
        private System.Windows.Forms.DataGridView GridViewPets;
    }
}