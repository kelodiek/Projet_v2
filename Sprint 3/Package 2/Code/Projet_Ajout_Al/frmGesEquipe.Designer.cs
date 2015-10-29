namespace Projet
{
    partial class frmGesEquipe
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
            this.gridEquipe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).BeginInit();
            this.SuspendLayout();
            //
            // gridEquipe
            //
            this.gridEquipe.AllowUserToAddRows = false;
            this.gridEquipe.AllowUserToDeleteRows = false;
            this.gridEquipe.AllowUserToResizeRows = false;
            this.gridEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipe.Location = new System.Drawing.Point(9, 71);
            this.gridEquipe.MultiSelect = false;
            this.gridEquipe.Name = "gridPlateforme";
            this.gridEquipe.ReadOnly = true;
            this.gridEquipe.RowTemplate.Height = 24;
            this.gridEquipe.Size = new System.Drawing.Size(1061, 381);
            this.gridEquipe.TabIndex = 50;
            this.gridEquipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipe_CellContentClick);
            // 
            // frmGesEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridEquipe);
            this.Name = "frmGestEquipe";
            this.Text = "Gestion - Equipes";
            this.Load += new System.EventHandler(this.Gestion_des_Equipes_Load);
            this.Controls.SetChildIndex(this.gridEquipe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.DataGridView gridEquipe;
    }
}