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
            this.GridGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGenre.Location = new System.Drawing.Point(12, 71);
            this.GridGenre.Name = "GridGenre";
            this.GridGenre.RowTemplate.Height = 24;
            this.GridGenre.Size = new System.Drawing.Size(1058, 369);
            this.GridGenre.TabIndex = 45;
            // 
            // frmGesGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 500);
            this.Controls.Add(this.GridGenre);
            this.Name = "frmGesGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Genres";
            this.Controls.SetChildIndex(this.GridGenre, 0);
            this.Load += new System.EventHandler(this.frmGesGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion

        internal System.Windows.Forms.DataGridView GridGenre;
    }
}

