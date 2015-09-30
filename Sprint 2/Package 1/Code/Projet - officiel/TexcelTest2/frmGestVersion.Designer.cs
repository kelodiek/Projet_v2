namespace Projet
{
    partial class frmGestVersion
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
            this.GridVersion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVersion
            // 
            this.GridVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVersion.Location = new System.Drawing.Point(13, 68);
            this.GridVersion.Name = "GridVersion";
            this.GridVersion.RowTemplate.Height = 24;
            this.GridVersion.Size = new System.Drawing.Size(1057, 384);
            this.GridVersion.TabIndex = 55;
            // 
            // frmGestVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 500);
            this.Controls.Add(this.GridVersion);
            this.Name = "frmGestVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion - Version";
            this.Load += new System.EventHandler(this.frmGestVersion_Load);
            this.Controls.SetChildIndex(this.GridVersion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridVersion;
    }
}