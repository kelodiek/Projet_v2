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
            this.gridVersion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVersion
            // 
            this.gridVersion.AllowUserToAddRows = false;
            this.gridVersion.AllowUserToDeleteRows = false;
            this.gridVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVersion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridVersion.Location = new System.Drawing.Point(13, 68);
            this.gridVersion.MultiSelect = false;
            this.gridVersion.Name = "gridVersion";
            this.gridVersion.RowTemplate.Height = 24;
            this.gridVersion.Size = new System.Drawing.Size(1686, 795);
            this.gridVersion.TabIndex = 55;
            this.gridVersion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVersion_CellContentClick);
            this.gridVersion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVersion_CellContentDoubleClick);
            // 
            // frmGesVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.gridVersion);
            this.Name = "frmGesVersion";
            this.Text = "Gestion - Version";
            this.Load += new System.EventHandler(this.frmGesVersion_Load);
            this.Controls.SetChildIndex(this.gridVersion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView gridVersion;
    }
}