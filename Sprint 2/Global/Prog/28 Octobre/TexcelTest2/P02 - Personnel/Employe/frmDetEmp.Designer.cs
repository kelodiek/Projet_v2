namespace Projet
{
    partial class frmDetEmp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.txtAdresPost = new System.Windows.Forms.TextBox();
            this.txtTelSec = new System.Windows.Forms.TextBox();
            this.txtTelPrinc = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompetencePart = new System.Windows.Forms.TextBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkLstTypeTest = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateEmbauche);
            this.groupBox1.Controls.Add(this.txtAdresPost);
            this.groupBox1.Controls.Add(this.txtTelSec);
            this.groupBox1.Controls.Add(this.txtTelPrinc);
            this.groupBox1.Controls.Add(this.txtCourriel);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 173);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations personnelles";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 24);
            this.txtId.MaxLength = 25;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(141, 22);
            this.txtId.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Code Employe: ";
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.Enabled = false;
            this.dateEmbauche.Location = new System.Drawing.Point(528, 139);
            this.dateEmbauche.Name = "dateEmbauche";
            this.dateEmbauche.Size = new System.Drawing.Size(200, 22);
            this.dateEmbauche.TabIndex = 8;
            // 
            // txtAdresPost
            // 
            this.txtAdresPost.Location = new System.Drawing.Point(531, 88);
            this.txtAdresPost.MaxLength = 95;
            this.txtAdresPost.Multiline = true;
            this.txtAdresPost.Name = "txtAdresPost";
            this.txtAdresPost.ReadOnly = true;
            this.txtAdresPost.Size = new System.Drawing.Size(330, 45);
            this.txtAdresPost.TabIndex = 7;
            // 
            // txtTelSec
            // 
            this.txtTelSec.Location = new System.Drawing.Point(571, 55);
            this.txtTelSec.MaxLength = 20;
            this.txtTelSec.Name = "txtTelSec";
            this.txtTelSec.ReadOnly = true;
            this.txtTelSec.Size = new System.Drawing.Size(157, 22);
            this.txtTelSec.TabIndex = 6;
            // 
            // txtTelPrinc
            // 
            this.txtTelPrinc.Location = new System.Drawing.Point(571, 24);
            this.txtTelPrinc.MaxLength = 20;
            this.txtTelPrinc.Name = "txtTelPrinc";
            this.txtTelPrinc.ReadOnly = true;
            this.txtTelPrinc.Size = new System.Drawing.Size(146, 22);
            this.txtTelPrinc.TabIndex = 5;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(77, 119);
            this.txtCourriel.MaxLength = 45;
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.ReadOnly = true;
            this.txtCourriel.Size = new System.Drawing.Size(328, 22);
            this.txtCourriel.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(77, 86);
            this.txtNom.MaxLength = 25;
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(183, 22);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(77, 58);
            this.txtPrenom.MaxLength = 25;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(183, 22);
            this.txtPrenom.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nom: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Courriel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphone principal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone secondaire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date embauche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse postale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom: ";
            // 
            // txtCompetencePart
            // 
            this.txtCompetencePart.Location = new System.Drawing.Point(435, 211);
            this.txtCompetencePart.Multiline = true;
            this.txtCompetencePart.Name = "txtCompetencePart";
            this.txtCompetencePart.ReadOnly = true;
            this.txtCompetencePart.Size = new System.Drawing.Size(460, 138);
            this.txtCompetencePart.TabIndex = 10;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(432, 372);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.ReadOnly = true;
            this.txtCommentaire.Size = new System.Drawing.Size(460, 98);
            this.txtCommentaire.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Compétences particulières:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Commentaires:";
            // 
            // chkLstTypeTest
            // 
            this.chkLstTypeTest.CheckOnClick = true;
            this.chkLstTypeTest.Enabled = false;
            this.chkLstTypeTest.FormattingEnabled = true;
            this.chkLstTypeTest.Location = new System.Drawing.Point(12, 211);
            this.chkLstTypeTest.Name = "chkLstTypeTest";
            this.chkLstTypeTest.Size = new System.Drawing.Size(414, 259);
            this.chkLstTypeTest.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Types tests:";
            // 
            // frmDetEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 522);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkLstTypeTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtCompetencePart);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDetEmp";
            this.Text = "Texcel - Détails - Employé";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCompetencePart, 0);
            this.Controls.SetChildIndex(this.txtCommentaire, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.chkLstTypeTest, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresPost;
        private System.Windows.Forms.TextBox txtTelSec;
        private System.Windows.Forms.TextBox txtTelPrinc;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompetencePart;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox chkLstTypeTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateEmbauche;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
    }
}