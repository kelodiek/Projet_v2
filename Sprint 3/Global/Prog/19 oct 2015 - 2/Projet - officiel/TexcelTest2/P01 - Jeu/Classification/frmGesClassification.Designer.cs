namespace Projet
{
    partial class frmGesClassification
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
            this.GridClassification = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridClassification)).BeginInit();
            this.SuspendLayout();
            // 
            // GridClassification
            // 
            this.GridClassification.AllowUserToAddRows = false;
            this.GridClassification.AllowUserToResizeRows = false;
            this.GridClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClassification.Location = new System.Drawing.Point(12, 71);
            this.GridClassification.MultiSelect = false;
            this.GridClassification.Name = "GridClassification";
            this.GridClassification.ReadOnly = true;
            this.GridClassification.RowTemplate.Height = 24;
            this.GridClassification.Size = new System.Drawing.Size(1058, 375);
            this.GridClassification.TabIndex = 60;
            this.GridClassification.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.GridClassification.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClassification_CellDoubleClick);
            this.GridClassification.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridClassification_ColumnHeaderMouseClick);
            // 
            // frmGestClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 500);
            this.Controls.Add(this.GridClassification);
            this.Name = "frmGestClassification";
            this.Text = "Texcel - Gestion des Classifications";
            this.Controls.SetChildIndex(this.GridClassification, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridClassification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridClassification;
    }
}