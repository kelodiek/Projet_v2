namespace Projet
{
    partial class frmGesGroupeUser
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
            this.gridGroupUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupUser
            // 
            this.gridGroupUser.AllowUserToAddRows = false;
            this.gridGroupUser.AllowUserToDeleteRows = false;
            this.gridGroupUser.AllowUserToResizeRows = false;
            this.gridGroupUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGroupUser.Location = new System.Drawing.Point(12, 71);
            this.gridGroupUser.MultiSelect = false;
            this.gridGroupUser.Name = "gridGroupUser";
            this.gridGroupUser.ReadOnly = true;
            this.gridGroupUser.RowTemplate.Height = 24;
            this.gridGroupUser.Size = new System.Drawing.Size(1058, 381);
            this.gridGroupUser.TabIndex = 53;
            this.gridGroupUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGroupUser_CellClick);
            this.gridGroupUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGroupUser_CellDoubleClick);
            // 
            // frmGesGroupeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.gridGroupUser);
            this.Name = "frmGesGroupeUser";
            this.Text = "frmGesGroupeUser";
            this.Controls.SetChildIndex(this.gridGroupUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGroupUser;
    }
}