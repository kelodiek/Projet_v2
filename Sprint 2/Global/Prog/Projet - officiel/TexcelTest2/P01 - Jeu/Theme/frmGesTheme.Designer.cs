namespace Projet
{
    partial class frmGesTheme
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
            this.GridTheme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTheme
            // 
            this.GridTheme.AllowUserToResizeRows = false;
            this.GridTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTheme.Location = new System.Drawing.Point(12, 71);
            this.GridTheme.MultiSelect = false;
            this.GridTheme.Name = "GridTheme";
            this.GridTheme.ReadOnly = true;
            this.GridTheme.RowTemplate.Height = 24;
            this.GridTheme.Size = new System.Drawing.Size(1686, 795);
            this.GridTheme.TabIndex = 50;
            this.GridTheme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTheme_CellClick);
            this.GridTheme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTheme_CellDoubleClick);
            // 
            // frmGesTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.GridTheme);
            this.Name = "frmGesTheme";
            this.Text = "Gestion des Thèmes";
            this.Load += new System.EventHandler(this.frmGestTheme_Load);
            this.Controls.SetChildIndex(this.GridTheme, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridTheme;
    }
}