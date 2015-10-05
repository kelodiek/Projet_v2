namespace Projet
{
    partial class frmGesGenre
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridGenre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // GridGenre
            // 
            this.GridGenre.AllowUserToAddRows = false;
            this.GridGenre.AllowUserToResizeRows = false;
            this.GridGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGenre.Location = new System.Drawing.Point(12, 71);
            this.GridGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridGenre.MultiSelect = false;
            this.GridGenre.Name = "GridGenre";
            this.GridGenre.ReadOnly = true;
            this.GridGenre.RowTemplate.Height = 24;
            this.GridGenre.Size = new System.Drawing.Size(1059, 369);
            this.GridGenre.TabIndex = 45;
            this.GridGenre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGenre_CellClick);
            this.GridGenre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGenre_CellDoubleClick);
            // 
            // frmGesGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 500);
            this.Controls.Add(this.GridGenre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGesGenre";
            this.Text = "Gestion des Genres";
            this.Controls.SetChildIndex(this.GridGenre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridGenre;
    }
}

