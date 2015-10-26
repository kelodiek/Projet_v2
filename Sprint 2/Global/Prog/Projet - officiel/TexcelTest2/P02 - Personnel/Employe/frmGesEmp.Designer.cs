namespace Projet
{
    partial class frmGesEmp
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
            this.gridEmploye = new System.Windows.Forms.DataGridView();
            this.btnRejet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmploye
            // 
            this.gridEmploye.AllowUserToAddRows = false;
            this.gridEmploye.AllowUserToDeleteRows = false;
            this.gridEmploye.AllowUserToResizeRows = false;
            this.gridEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmploye.Location = new System.Drawing.Point(12, 71);
            this.gridEmploye.MultiSelect = false;
            this.gridEmploye.Name = "gridEmploye";
            this.gridEmploye.ReadOnly = true;
            this.gridEmploye.RowTemplate.Height = 24;
            this.gridEmploye.Size = new System.Drawing.Size(1686, 795);
            this.gridEmploye.TabIndex = 52;
            this.gridEmploye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmploye_CellClick);
            this.gridEmploye.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmploye_CellDoubleClick);
            // 
            // btnRejet
            // 
            this.btnRejet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnRejet.Location = new System.Drawing.Point(1311, 872);
            this.btnRejet.Name = "btnRejet";
            this.btnRejet.Size = new System.Drawing.Size(125, 35);
            this.btnRejet.TabIndex = 54;
            this.btnRejet.Text = "Désactiver";
            this.btnRejet.UseVisualStyleBackColor = true;
            // 
            // frmGesEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.btnRejet);
            this.Controls.Add(this.gridEmploye);
            this.Name = "frmGesEmp";
            this.Text = "frmGesEmp";
            this.Controls.SetChildIndex(this.gridEmploye, 0);
            this.Controls.SetChildIndex(this.btnRejet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmploye;
        private System.Windows.Forms.Button btnRejet;
    }
}