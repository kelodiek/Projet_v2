namespace TexcelTest2
{
    partial class frmGestGenre
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
            this.GridGenre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // GridGenre
            // 
            this.GridGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGenre.Location = new System.Drawing.Point(12, 71);
            this.GridGenre.Name = "GridGenre";
            this.GridGenre.RowTemplate.Height = 24;
            this.GridGenre.Size = new System.Drawing.Size(1058, 369);
            this.GridGenre.TabIndex = 45;
            this.GridGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGenre_CellContentClick);
            // 
            // frmGesGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 500);
            this.Controls.Add(this.GridGenre);
            this.Name = "frmGesGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Genres";
            this.Controls.SetChildIndex(this.GridGenre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridGenre;
    }
}