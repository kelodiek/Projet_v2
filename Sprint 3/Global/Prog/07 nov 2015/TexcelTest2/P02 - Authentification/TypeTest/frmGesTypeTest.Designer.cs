namespace Projet
{
    partial class frmGesTypeTest
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
            this.gridTypeTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeTest)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTypeTest
            // 
            this.gridTypeTest.AllowUserToAddRows = false;
            this.gridTypeTest.AllowUserToDeleteRows = false;
            this.gridTypeTest.AllowUserToResizeRows = false;
            this.gridTypeTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTypeTest.Location = new System.Drawing.Point(12, 71);
            this.gridTypeTest.MultiSelect = false;
            this.gridTypeTest.Name = "gridTypeTest";
            this.gridTypeTest.ReadOnly = true;
            this.gridTypeTest.RowTemplate.Height = 24;
            this.gridTypeTest.Size = new System.Drawing.Size(1686, 795);
            this.gridTypeTest.TabIndex = 54;
            this.gridTypeTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTypeTest_CellClick);
            this.gridTypeTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTypeTest_CellDoubleClick);
            // 
            // frmGesTypeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.gridTypeTest);
            this.Name = "frmGesTypeTest";
            this.Text = "frmGesTypeTest";
            this.Controls.SetChildIndex(this.gridTypeTest, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTypeTest;
    }
}