namespace Projet
{
    partial class frmGesPlateforme
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
            this.gridPlateforme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlateforme)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPlateforme
            // 
            this.gridPlateforme.AllowUserToAddRows = false;
            this.gridPlateforme.AllowUserToDeleteRows = false;
            this.gridPlateforme.AllowUserToResizeRows = false;
            this.gridPlateforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlateforme.Location = new System.Drawing.Point(9, 71);
            this.gridPlateforme.MultiSelect = false;
            this.gridPlateforme.Name = "gridPlateforme";
            this.gridPlateforme.ReadOnly = true;
            this.gridPlateforme.RowTemplate.Height = 24;
            this.gridPlateforme.Size = new System.Drawing.Size(1061, 381);
            this.gridPlateforme.TabIndex = 50;
            this.gridPlateforme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPlateforme_CellContentClick);
            this.gridPlateforme.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPlateforme_ColumnHeaderMouseClick);
            // 
            // frmGesPlateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridPlateforme);
            this.Name = "frmGesPlateforme";
            this.Text = "Gestion - Plateformes";
            this.Load += new System.EventHandler(this.Gestion_des_Plateformes_Load);
            this.Controls.SetChildIndex(this.gridPlateforme, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlateforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView gridPlateforme;

    }
}