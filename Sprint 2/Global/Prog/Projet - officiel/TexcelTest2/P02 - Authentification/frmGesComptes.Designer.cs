namespace Projet
{
    partial class frmGesComptes
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
            this.gridComptes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridComptes
            // 
            this.gridComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComptes.Location = new System.Drawing.Point(26, 85);
            this.gridComptes.Name = "gridComptes";
            this.gridComptes.RowTemplate.Height = 24;
            this.gridComptes.Size = new System.Drawing.Size(1044, 358);
            this.gridComptes.TabIndex = 52;
            this.gridComptes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComptes_CellClick);
            this.gridComptes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComptes_CellDoubleClick);
            // 
            // frmGesComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridComptes);
            this.Name = "frmGesComptes";
            this.Text = "frmGesComptes";
            this.Load += new System.EventHandler(this.frmGesComptes_Load);
            this.Controls.SetChildIndex(this.gridComptes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridComptes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridComptes;
    }
}