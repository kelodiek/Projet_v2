namespace Projet
{
    partial class frmDetOS
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfos = new System.Windows.Forms.RichTextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(76, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Édition : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(76, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Version : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Informations";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtInfos
            // 
            this.txtInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInfos.Location = new System.Drawing.Point(10, 538);
            this.txtInfos.MaxLength = 100;
            this.txtInfos.Name = "txtInfos";
            this.txtInfos.Size = new System.Drawing.Size(510, 114);
            this.txtInfos.TabIndex = 7;
            this.txtInfos.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(191, 136);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(115, 30);
            this.txtCode.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(186, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(23, 25);
            this.txtId.TabIndex = 12;
            this.txtId.Text = "1";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(191, 185);
            this.txtNom.MaxLength = 25;
            this.txtNom.Name = "txtNom";
            this.txtNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNom.Size = new System.Drawing.Size(281, 30);
            this.txtNom.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(186, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Supplémentaires : ";
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(191, 238);
            this.txtEdition.MaxLength = 40;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEdition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEdition.Size = new System.Drawing.Size(450, 30);
            this.txtEdition.TabIndex = 17;
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(191, 296);
            this.txtVersion.MaxLength = 40;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVersion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVersion.Size = new System.Drawing.Size(450, 30);
            this.txtVersion.TabIndex = 18;
            // 
            // frmDetOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 705);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtInfos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmDetOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Détails";
            this.Load += new System.EventHandler(this.PopupOS_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtInfos, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtEdition, 0);
            this.Controls.SetChildIndex(this.txtVersion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtInfos;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtVersion;
    }
}