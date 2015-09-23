namespace TexcelTest2
{
    partial class frmGesSysExp
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
            this.gridSysExp = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridSysExp)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSysExp
            // 
            this.gridSysExp.AllowUserToAddRows = false;
            this.gridSysExp.AllowUserToDeleteRows = false;
            this.gridSysExp.AllowUserToResizeRows = false;
            this.gridSysExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSysExp.Location = new System.Drawing.Point(12, 71);
            this.gridSysExp.Name = "gridSysExp";
            this.gridSysExp.ReadOnly = true;
            this.gridSysExp.RowTemplate.Height = 24;
            this.gridSysExp.Size = new System.Drawing.Size(1058, 381);
            this.gridSysExp.TabIndex = 50;
            this.gridSysExp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSysExp_CellClick);
            this.gridSysExp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSysExp_CellDoubleClick);
            // 
            // frmGesSysExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridSysExp);
            this.Name = "frmGesSysExp";
            this.Text = "Gestion - Systeme Exploitation";
            this.Load += new System.EventHandler(this.frmGesSysExp_Load);
            this.Controls.SetChildIndex(this.gridSysExp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSysExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSysExp;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}