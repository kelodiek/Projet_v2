namespace Projet
{
    partial class frmDetSysExp
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
            this.rtxtInfos = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtInfos
            // 
            this.rtxtInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtInfos.Location = new System.Drawing.Point(10, 173);
            this.rtxtInfos.MaxLength = 100;
            this.rtxtInfos.Name = "rtxtInfos";
            this.rtxtInfos.Size = new System.Drawing.Size(460, 135);
            this.rtxtInfos.TabIndex = 74;
            this.rtxtInfos.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 20);
            this.Label3.TabIndex = 83;
            this.Label3.Text = "Nom :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 82;
            this.Label2.Text = "Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Identifiant :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 65);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(168, 22);
            this.txtNom.TabIndex = 86;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(112, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 22);
            this.txtCode.TabIndex = 85;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 22);
            this.txtID.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Edition :";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(112, 93);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(285, 22);
            this.txtEdition.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Version :";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(112, 121);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(285, 22);
            this.txtVersion.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Information suplementaire :";
            // 
            // frmDetSysExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtInfos);
            this.Name = "frmDetSysExp";
            this.Text = "Details - Système D\'exploitation";
            this.Controls.SetChildIndex(this.rtxtInfos, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Label2, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtEdition, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtVersion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInfos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtEdition;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtVersion;
        internal System.Windows.Forms.Label label5;
    }
}