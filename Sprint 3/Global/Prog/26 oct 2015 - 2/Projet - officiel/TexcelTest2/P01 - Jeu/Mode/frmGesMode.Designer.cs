namespace Projet
{
    partial class frmGesMode
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
            this.dataGridMode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMode
            // 
            this.dataGridMode.AllowUserToAddRows = false;
            this.dataGridMode.AllowUserToDeleteRows = false;
            this.dataGridMode.AllowUserToResizeRows = false;
            this.dataGridMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMode.Location = new System.Drawing.Point(12, 71);
            this.dataGridMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMode.MultiSelect = false;
            this.dataGridMode.Name = "dataGridMode";
            this.dataGridMode.ReadOnly = true;
            this.dataGridMode.RowTemplate.Height = 24;
            this.dataGridMode.Size = new System.Drawing.Size(1686, 795);
            this.dataGridMode.TabIndex = 51;
            this.dataGridMode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMode_CellClick);
            this.dataGridMode.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMode_CellDoubleClick);
            // 
            // frmGesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 919);
            this.Controls.Add(this.dataGridMode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGesMode";
            this.Text = "Gestion - Mode";
            this.Controls.SetChildIndex(this.dataGridMode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMode;
    }
}