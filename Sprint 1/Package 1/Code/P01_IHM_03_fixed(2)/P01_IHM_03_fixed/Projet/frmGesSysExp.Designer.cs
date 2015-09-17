namespace Projet
{
    partial class frmGesSysExp
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
            this.gridSysExp = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridSysExp)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSysExp
            // 
            this.gridSysExp.AllowUserToAddRows = false;
            this.gridSysExp.AllowUserToDeleteRows = false;
            this.gridSysExp.AllowUserToResizeRows = false;
            this.gridSysExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSysExp.Location = new System.Drawing.Point(12, 71);
            this.gridSysExp.Name = "gridSysExp";
            this.gridSysExp.ReadOnly = true;
            this.gridSysExp.RowTemplate.Height = 24;
            this.gridSysExp.Size = new System.Drawing.Size(1058, 381);
            this.gridSysExp.TabIndex = 50;
            this.gridSysExp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSysExp_CellClick);
            this.gridSysExp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSysExp_CellDoubleClick);
            // 
            // frmGesSysExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridSysExp);
            this.Name = "frmGesSysExp";
            this.Text = "Gestion - Systeme Exploitation";
            this.Load += new System.EventHandler(this.frmGesSysExp_Load);
            this.Controls.SetChildIndex(this.gridSysExp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSysExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSysExp;
        private System.Windows.Forms.ColorDialog colorDialog1;


        /*
         * 
         * 
         * 
         * 
        */
    }
}

