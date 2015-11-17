namespace Projet
{
    partial class frmDetEquipe
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
            this.lblProjet = new System.Windows.Forms.Label();
            this.lblNomEquipe = new System.Windows.Forms.Label();
            this.lblChefEquipe = new System.Windows.Forms.Label();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.cboxProjet = new System.Windows.Forms.ComboBox();
            this.cboxFiltre = new System.Windows.Forms.ComboBox();
            this.cboxChefEquipe = new System.Windows.Forms.ComboBox();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.rTxtCommentaire = new System.Windows.Forms.RichTextBox();
            this.btnRetirerTypeTest = new System.Windows.Forms.Button();
            this.btnAjoutTypeTest = new System.Windows.Forms.Button();
            this.btnRetirerEmploye = new System.Windows.Forms.Button();
            this.btnAjoutEmploye = new System.Windows.Forms.Button();
            this.gboxTypeTest = new System.Windows.Forms.GroupBox();
            this.lblSelectTypeTest = new System.Windows.Forms.Label();
            this.lblTypeTest = new System.Windows.Forms.Label();
            this.lstTreeSelectTest = new System.Windows.Forms.TreeView();
            this.lstTreeTypeTest = new System.Windows.Forms.TreeView();
            this.gboxEmploye = new System.Windows.Forms.GroupBox();
            this.lblSelectEmp = new System.Windows.Forms.Label();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lstTreeSelectEmploye = new System.Windows.Forms.TreeView();
            this.lstTreeEmploye = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxTypeTest.SuspendLayout();
            this.gboxEmploye.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Location = new System.Drawing.Point(29, 33);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(53, 17);
            this.lblProjet.TabIndex = 68;
            this.lblProjet.Text = "Projet :";
            // 
            // lblNomEquipe
            // 
            this.lblNomEquipe.AutoSize = true;
            this.lblNomEquipe.Location = new System.Drawing.Point(29, 63);
            this.lblNomEquipe.Name = "lblNomEquipe";
            this.lblNomEquipe.Size = new System.Drawing.Size(93, 17);
            this.lblNomEquipe.TabIndex = 69;
            this.lblNomEquipe.Text = "Nom Équipe :";
            // 
            // lblChefEquipe
            // 
            this.lblChefEquipe.AutoSize = true;
            this.lblChefEquipe.Location = new System.Drawing.Point(29, 91);
            this.lblChefEquipe.Name = "lblChefEquipe";
            this.lblChefEquipe.Size = new System.Drawing.Size(103, 17);
            this.lblChefEquipe.TabIndex = 70;
            this.lblChefEquipe.Text = "Chef d\'équipe :";
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Location = new System.Drawing.Point(6, 31);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(155, 17);
            this.lblFiltre.TabIndex = 73;
            this.lblFiltre.Text = "Filtre par Type de test :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(489, 248);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(103, 17);
            this.lblCommentaire.TabIndex = 74;
            this.lblCommentaire.Text = "Commentaire : ";
            // 
            // cboxProjet
            // 
            this.cboxProjet.FormattingEnabled = true;
            this.cboxProjet.Location = new System.Drawing.Point(88, 30);
            this.cboxProjet.Name = "cboxProjet";
            this.cboxProjet.Size = new System.Drawing.Size(218, 24);
            this.cboxProjet.TabIndex = 1;
            // 
            // cboxFiltre
            // 
            this.cboxFiltre.FormattingEnabled = true;
            this.cboxFiltre.Location = new System.Drawing.Point(167, 28);
            this.cboxFiltre.Name = "cboxFiltre";
            this.cboxFiltre.Size = new System.Drawing.Size(136, 24);
            this.cboxFiltre.TabIndex = 6;
            this.cboxFiltre.Text = "Aucun";
            // 
            // cboxChefEquipe
            // 
            this.cboxChefEquipe.FormattingEnabled = true;
            this.cboxChefEquipe.Location = new System.Drawing.Point(138, 88);
            this.cboxChefEquipe.Name = "cboxChefEquipe";
            this.cboxChefEquipe.Size = new System.Drawing.Size(204, 24);
            this.cboxChefEquipe.TabIndex = 3;
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(128, 60);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(214, 22);
            this.txtNomEquipe.TabIndex = 2;
            // 
            // rTxtCommentaire
            // 
            this.rTxtCommentaire.Location = new System.Drawing.Point(488, 268);
            this.rTxtCommentaire.Name = "rTxtCommentaire";
            this.rTxtCommentaire.Size = new System.Drawing.Size(459, 77);
            this.rTxtCommentaire.TabIndex = 9;
            this.rTxtCommentaire.Text = "";
            // 
            // btnRetirerTypeTest
            // 
            this.btnRetirerTypeTest.Location = new System.Drawing.Point(193, 129);
            this.btnRetirerTypeTest.Name = "btnRetirerTypeTest";
            this.btnRetirerTypeTest.Size = new System.Drawing.Size(55, 55);
            this.btnRetirerTypeTest.TabIndex = 5;
            this.btnRetirerTypeTest.Text = "<<";
            this.btnRetirerTypeTest.UseVisualStyleBackColor = true;
            // 
            // btnAjoutTypeTest
            // 
            this.btnAjoutTypeTest.Location = new System.Drawing.Point(193, 46);
            this.btnAjoutTypeTest.Name = "btnAjoutTypeTest";
            this.btnAjoutTypeTest.Size = new System.Drawing.Size(55, 55);
            this.btnAjoutTypeTest.TabIndex = 4;
            this.btnAjoutTypeTest.Text = ">>";
            this.btnAjoutTypeTest.UseVisualStyleBackColor = true;
            // 
            // btnRetirerEmploye
            // 
            this.btnRetirerEmploye.Location = new System.Drawing.Point(208, 161);
            this.btnRetirerEmploye.Name = "btnRetirerEmploye";
            this.btnRetirerEmploye.Size = new System.Drawing.Size(55, 55);
            this.btnRetirerEmploye.TabIndex = 8;
            this.btnRetirerEmploye.Text = "<<";
            this.btnRetirerEmploye.UseVisualStyleBackColor = true;
            // 
            // btnAjoutEmploye
            // 
            this.btnAjoutEmploye.Location = new System.Drawing.Point(208, 78);
            this.btnAjoutEmploye.Name = "btnAjoutEmploye";
            this.btnAjoutEmploye.Size = new System.Drawing.Size(55, 55);
            this.btnAjoutEmploye.TabIndex = 7;
            this.btnAjoutEmploye.Text = ">>";
            this.btnAjoutEmploye.UseVisualStyleBackColor = true;
            // 
            // gboxTypeTest
            // 
            this.gboxTypeTest.Controls.Add(this.lblSelectTypeTest);
            this.gboxTypeTest.Controls.Add(this.lblTypeTest);
            this.gboxTypeTest.Controls.Add(this.lstTreeSelectTest);
            this.gboxTypeTest.Controls.Add(this.lstTreeTypeTest);
            this.gboxTypeTest.Controls.Add(this.btnRetirerTypeTest);
            this.gboxTypeTest.Controls.Add(this.btnAjoutTypeTest);
            this.gboxTypeTest.Location = new System.Drawing.Point(15, 161);
            this.gboxTypeTest.Name = "gboxTypeTest";
            this.gboxTypeTest.Size = new System.Drawing.Size(456, 193);
            this.gboxTypeTest.TabIndex = 88;
            this.gboxTypeTest.TabStop = false;
            this.gboxTypeTest.Text = "Informations des types de test";
            // 
            // lblSelectTypeTest
            // 
            this.lblSelectTypeTest.AutoSize = true;
            this.lblSelectTypeTest.Location = new System.Drawing.Point(291, 26);
            this.lblSelectTypeTest.Name = "lblSelectTypeTest";
            this.lblSelectTypeTest.Size = new System.Drawing.Size(78, 17);
            this.lblSelectTypeTest.TabIndex = 89;
            this.lblSelectTypeTest.Text = "Sélection : ";
            // 
            // lblTypeTest
            // 
            this.lblTypeTest.AutoSize = true;
            this.lblTypeTest.Location = new System.Drawing.Point(6, 26);
            this.lblTypeTest.Name = "lblTypeTest";
            this.lblTypeTest.Size = new System.Drawing.Size(80, 17);
            this.lblTypeTest.TabIndex = 88;
            this.lblTypeTest.Text = "Type Test :";
            // 
            // lstTreeSelectTest
            // 
            this.lstTreeSelectTest.HideSelection = false;
            this.lstTreeSelectTest.Location = new System.Drawing.Point(254, 46);
            this.lstTreeSelectTest.Name = "lstTreeSelectTest";
            this.lstTreeSelectTest.Size = new System.Drawing.Size(186, 138);
            this.lstTreeSelectTest.TabIndex = 87;
            // 
            // lstTreeTypeTest
            // 
            this.lstTreeTypeTest.HideSelection = false;
            this.lstTreeTypeTest.Location = new System.Drawing.Point(8, 46);
            this.lstTreeTypeTest.Name = "lstTreeTypeTest";
            this.lstTreeTypeTest.Size = new System.Drawing.Size(179, 138);
            this.lstTreeTypeTest.TabIndex = 86;
            // 
            // gboxEmploye
            // 
            this.gboxEmploye.Controls.Add(this.lblSelectEmp);
            this.gboxEmploye.Controls.Add(this.lblEmploye);
            this.gboxEmploye.Controls.Add(this.lstTreeSelectEmploye);
            this.gboxEmploye.Controls.Add(this.lstTreeEmploye);
            this.gboxEmploye.Controls.Add(this.btnRetirerEmploye);
            this.gboxEmploye.Controls.Add(this.btnAjoutEmploye);
            this.gboxEmploye.Controls.Add(this.cboxFiltre);
            this.gboxEmploye.Controls.Add(this.lblFiltre);
            this.gboxEmploye.Location = new System.Drawing.Point(483, 12);
            this.gboxEmploye.Name = "gboxEmploye";
            this.gboxEmploye.Size = new System.Drawing.Size(467, 233);
            this.gboxEmploye.TabIndex = 89;
            this.gboxEmploye.TabStop = false;
            this.gboxEmploye.Text = "Informations des employés";
            // 
            // lblSelectEmp
            // 
            this.lblSelectEmp.AutoSize = true;
            this.lblSelectEmp.Location = new System.Drawing.Point(291, 58);
            this.lblSelectEmp.Name = "lblSelectEmp";
            this.lblSelectEmp.Size = new System.Drawing.Size(74, 17);
            this.lblSelectEmp.TabIndex = 91;
            this.lblSelectEmp.Text = "Sélection :";
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(6, 58);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(74, 17);
            this.lblEmploye.TabIndex = 90;
            this.lblEmploye.Text = "Employé : ";
            // 
            // lstTreeSelectEmploye
            // 
            this.lstTreeSelectEmploye.HideSelection = false;
            this.lstTreeSelectEmploye.Location = new System.Drawing.Point(269, 78);
            this.lstTreeSelectEmploye.Name = "lstTreeSelectEmploye";
            this.lstTreeSelectEmploye.Size = new System.Drawing.Size(186, 138);
            this.lstTreeSelectEmploye.TabIndex = 89;
            // 
            // lstTreeEmploye
            // 
            this.lstTreeEmploye.HideSelection = false;
            this.lstTreeEmploye.Location = new System.Drawing.Point(8, 78);
            this.lstTreeEmploye.Name = "lstTreeEmploye";
            this.lstTreeEmploye.Size = new System.Drawing.Size(194, 138);
            this.lstTreeEmploye.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxProjet);
            this.groupBox1.Controls.Add(this.lblProjet);
            this.groupBox1.Controls.Add(this.lblNomEquipe);
            this.groupBox1.Controls.Add(this.lblChefEquipe);
            this.groupBox1.Controls.Add(this.txtNomEquipe);
            this.groupBox1.Controls.Add(this.cboxChefEquipe);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 143);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de l\'équipe";
            // 
            // frmDetEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxEmploye);
            this.Controls.Add(this.gboxTypeTest);
            this.Controls.Add(this.rTxtCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Name = "frmDetEquipe";
            this.Text = "Texcel - Détails - Équipe";
            this.Controls.SetChildIndex(this.lblCommentaire, 0);
            this.Controls.SetChildIndex(this.rTxtCommentaire, 0);
            this.Controls.SetChildIndex(this.gboxTypeTest, 0);
            this.Controls.SetChildIndex(this.gboxEmploye, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gboxTypeTest.ResumeLayout(false);
            this.gboxTypeTest.PerformLayout();
            this.gboxEmploye.ResumeLayout(false);
            this.gboxEmploye.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.Label lblNomEquipe;
        private System.Windows.Forms.Label lblChefEquipe;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.ComboBox cboxProjet;
        private System.Windows.Forms.ComboBox cboxFiltre;
        private System.Windows.Forms.ComboBox cboxChefEquipe;
        private System.Windows.Forms.TextBox txtNomEquipe;
        internal System.Windows.Forms.RichTextBox rTxtCommentaire;
        private System.Windows.Forms.Button btnRetirerTypeTest;
        private System.Windows.Forms.Button btnAjoutTypeTest;
        private System.Windows.Forms.Button btnRetirerEmploye;
        private System.Windows.Forms.Button btnAjoutEmploye;
        private System.Windows.Forms.GroupBox gboxTypeTest;
        private System.Windows.Forms.GroupBox gboxEmploye;
        private System.Windows.Forms.TreeView lstTreeSelectTest;
        private System.Windows.Forms.TreeView lstTreeTypeTest;
        private System.Windows.Forms.TreeView lstTreeSelectEmploye;
        private System.Windows.Forms.TreeView lstTreeEmploye;
        private System.Windows.Forms.Label lblSelectTypeTest;
        private System.Windows.Forms.Label lblTypeTest;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblSelectEmp;
        private System.Windows.Forms.GroupBox groupBox1;
    }

    //partial class frmDetEquipe
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    /// Required method for Designer support - do not modify
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.components = new System.ComponentModel.Container();
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.Text = "frmDetEquipe";
    //    }

    //    #endregion
    //}
}