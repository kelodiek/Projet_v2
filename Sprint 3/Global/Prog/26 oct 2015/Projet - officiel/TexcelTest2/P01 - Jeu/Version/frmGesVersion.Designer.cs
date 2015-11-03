namespace Projet
{
    partial class frmGesVersion
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
            this.GridVersion.Size = new System.Drawing.Size(1686, 795);
            this.GridVersion.TabIndex = 55;
            // 
            // frmGesVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.GridVersion);
            this.Name = "frmGesVersion";
            this.Text = "Gestion - Version";
            this.Controls.SetChildIndex(this.GridVersion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridVersion;
    }
}