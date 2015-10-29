namespace Projet
{
    partial class frmGestJeu
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
            this.dataGridJeu = new System.Windows.Forms.DataGridView();
            this.btnVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridJeu
            // 
            this.dataGridJeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJeu.Location = new System.Drawing.Point(12, 71);
            this.dataGridJeu.Name = "dataGridJeu";
            this.dataGridJeu.RowTemplate.Height = 24;
            this.dataGridJeu.Size = new System.Drawing.Size(1058, 381);
            this.dataGridJeu.TabIndex = 51;
            // 
            // btnVersion
            // 
            this.btnVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnVersion.Location = new System.Drawing.Point(541, 458);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(140, 35);
            this.btnVersion.TabIndex = 52;
            this.btnVersion.Text = "Afficher Version";
            this.btnVersion.UseVisualStyleBackColor = true;
            // 
            // frmGesJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.btnVersion);
            this.Controls.Add(this.dataGridJeu);
            this.Name = "frmGesJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion - Jeu";
            this.Controls.SetChildIndex(this.dataGridJeu, 0);
            this.Controls.SetChildIndex(this.btnVersion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridJeu;
        private System.Windows.Forms.Button btnVersion;
    }
}