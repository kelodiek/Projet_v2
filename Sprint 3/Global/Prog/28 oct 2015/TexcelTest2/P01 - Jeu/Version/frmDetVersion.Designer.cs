namespace Projet
{
    partial class frmDetVersion
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateVersion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateSortie = new System.Windows.Forms.DateTimePicker();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.checkValide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(129, 65);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(263, 22);
            this.txtNom.TabIndex = 102;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(129, 37);
            this.txtCode.MaxLength = 30;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(219, 22);
            this.txtCode.TabIndex = 101;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 9);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Nom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Code : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Identifiant : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Description : ";
            // 
            // txtStade
            // 
            this.txtStade.Location = new System.Drawing.Point(129, 93);
            this.txtStade.MaxLength = 50;
            this.txtStade.Name = "txtStade";
            this.txtStade.Size = new System.Drawing.Size(263, 22);
            this.txtStade.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Stade : ";
            // 
            // dateVersion
            // 
            this.dateVersion.Location = new System.Drawing.Point(140, 282);
            this.dateVersion.Name = "dateVersion";
            this.dateVersion.Size = new System.Drawing.Size(162, 22);
            this.dateVersion.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "Date Version : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Date Sortie : ";
            // 
            // dateSortie
            // 
            this.dateSortie.Location = new System.Drawing.Point(140, 313);
            this.dateSortie.Name = "dateSortie";
            this.dateSortie.Size = new System.Drawing.Size(162, 22);
            this.dateSortie.TabIndex = 109;
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(16, 145);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(457, 131);
            this.rtxtDesc.TabIndex = 112;
            this.rtxtDesc.Text = "";
            // 
            // checkValide
            // 
            this.checkValide.AutoSize = true;
            this.checkValide.Location = new System.Drawing.Point(308, 313);
            this.checkValide.Name = "checkValide";
            this.checkValide.Size = new System.Drawing.Size(155, 21);
            this.checkValide.TabIndex = 113;
            this.checkValide.Text = "Enregistrer cet date";
            this.checkValide.UseVisualStyleBackColor = true;
            // 
            // frmDetVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 388);
            this.Controls.Add(this.checkValide);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateSortie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateVersion);
            this.Controls.Add(this.txtStade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetVersion";
            this.Text = "Détails - Version";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtStade, 0);
            this.Controls.SetChildIndex(this.dateVersion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dateSortie, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.rtxtDesc, 0);
            this.Controls.SetChildIndex(this.checkValide, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateSortie;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.CheckBox checkValide;
    }
}