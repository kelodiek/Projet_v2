namespace Projet
{
    partial class frmGesCategorie
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
            this.gridCateg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCateg)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCateg
            // 
            this.gridCateg.AllowUserToAddRows = false;
            this.gridCateg.AllowUserToDeleteRows = false;
            this.gridCateg.AllowUserToResizeRows = false;
            this.gridCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCateg.Location = new System.Drawing.Point(12, 72);
            this.gridCateg.Name = "gridCateg";
            this.gridCateg.RowTemplate.Height = 24;
            this.gridCateg.Size = new System.Drawing.Size(1058, 380);
            this.gridCateg.TabIndex = 51;
            // 
            // frmGesCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridCateg);
            this.Name = "frmGesCategorie";
            this.Text = "frmGesCategorie";
            this.Load += new System.EventHandler(this.frmGesCategorie_Load);
            this.Controls.SetChildIndex(this.gridCateg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridCateg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCateg;
    }
}