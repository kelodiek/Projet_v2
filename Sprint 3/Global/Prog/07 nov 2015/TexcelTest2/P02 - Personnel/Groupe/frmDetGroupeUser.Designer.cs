namespace Projet
{
    partial class frmDetGroupeUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tvLstDr = new System.Windows.Forms.TreeView();
            this.tvGroupDr = new System.Windows.Forms.TreeView();
            this.btnAddDr = new System.Windows.Forms.Button();
            this.btnDeletDr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Identifiant : ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(128, 53);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(219, 22);
            this.txtNom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Liste des droits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(536, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Droit du groupe";
            // 
            // tvLstDr
            // 
            this.tvLstDr.Enabled = false;
            this.tvLstDr.Location = new System.Drawing.Point(19, 126);
            this.tvLstDr.Margin = new System.Windows.Forms.Padding(4);
            this.tvLstDr.Name = "tvLstDr";
            this.tvLstDr.Size = new System.Drawing.Size(376, 205);
            this.tvLstDr.TabIndex = 3;
            // 
            // tvGroupDr
            // 
            this.tvGroupDr.Enabled = false;
            this.tvGroupDr.Location = new System.Drawing.Point(540, 126);
            this.tvGroupDr.Margin = new System.Windows.Forms.Padding(4);
            this.tvGroupDr.Name = "tvGroupDr";
            this.tvGroupDr.Size = new System.Drawing.Size(376, 205);
            this.tvGroupDr.TabIndex = 6;
            // 
            // btnAddDr
            // 
            this.btnAddDr.Enabled = false;
            this.btnAddDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDr.Location = new System.Drawing.Point(423, 146);
            this.btnAddDr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDr.Name = "btnAddDr";
            this.btnAddDr.Size = new System.Drawing.Size(72, 76);
            this.btnAddDr.TabIndex = 4;
            this.btnAddDr.Text = ">>>>";
            this.btnAddDr.UseVisualStyleBackColor = true;
            this.btnAddDr.Click += new System.EventHandler(this.btnAddDr_Click);
            // 
            // btnDeletDr
            // 
            this.btnDeletDr.Enabled = false;
            this.btnDeletDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletDr.Location = new System.Drawing.Point(423, 229);
            this.btnDeletDr.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletDr.Name = "btnDeletDr";
            this.btnDeletDr.Size = new System.Drawing.Size(72, 76);
            this.btnDeletDr.TabIndex = 5;
            this.btnDeletDr.Text = "<<<<";
            this.btnDeletDr.UseVisualStyleBackColor = true;
            this.btnDeletDr.Click += new System.EventHandler(this.btnDeletDr_Click);
            // 
            // frmDetGroupeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 395);
            this.Controls.Add(this.btnDeletDr);
            this.Controls.Add(this.btnAddDr);
            this.Controls.Add(this.tvGroupDr);
            this.Controls.Add(this.tvLstDr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetGroupeUser";
            this.Text = "frmDetGroupeUser";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tvLstDr, 0);
            this.Controls.SetChildIndex(this.tvGroupDr, 0);
            this.Controls.SetChildIndex(this.btnAddDr, 0);
            this.Controls.SetChildIndex(this.btnDeletDr, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvLstDr;
        private System.Windows.Forms.TreeView tvGroupDr;
        private System.Windows.Forms.Button btnAddDr;
        private System.Windows.Forms.Button btnDeletDr;
    }
}