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
            this.gridEmploye.Size = new System.Drawing.Size(1058, 381);
            this.gridEmploye.TabIndex = 52;
            // 
            // frmGesEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridEmploye);
            this.Name = "frmGesEmp";
            this.Text = "frmGesEmp";
            this.Controls.SetChildIndex(this.gridEmploye, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmploye;
    }
}