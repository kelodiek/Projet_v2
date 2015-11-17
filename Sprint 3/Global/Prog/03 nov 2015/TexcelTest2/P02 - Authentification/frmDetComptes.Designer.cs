namespace Projet
{
    partial class frmDetComptes : frmDetail
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
        /// 
        private void InitializeComponent()
        {
            this.txtNomUtil = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtPremiere = new System.Windows.Forms.ComboBox();
            this.txtExpire = new System.Windows.Forms.ComboBox();
            this.dateTimeModif = new System.Windows.Forms.DateTimePicker();
            this.txtActif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdRole = new System.Windows.Forms.ComboBox();
            this.txtIdEmp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNomUtil
            // 
            this.txtNomUtil.Location = new System.Drawing.Point(182, 40);
            this.txtNomUtil.Name = "txtNomUtil";
            this.txtNomUtil.Size = new System.Drawing.Size(150, 22);
            this.txtNomUtil.TabIndex = 1;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(182, 85);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(250, 22);
            this.txtMDP.TabIndex = 2;
            // 
            // txtPremiere
            // 
            this.txtPremiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPremiere.FormattingEnabled = true;
            this.txtPremiere.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.txtPremiere.Location = new System.Drawing.Point(182, 129);
            this.txtPremiere.Name = "txtPremiere";
            this.txtPremiere.Size = new System.Drawing.Size(55, 24);
            this.txtPremiere.TabIndex = 3;
            // 
            // txtExpire
            // 
            this.txtExpire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtExpire.FormattingEnabled = true;
            this.txtExpire.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.txtExpire.Location = new System.Drawing.Point(182, 177);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(55, 24);
            this.txtExpire.TabIndex = 4;
            // 
            // dateTimeModif
            // 
            this.dateTimeModif.Location = new System.Drawing.Point(182, 227);
            this.dateTimeModif.Name = "dateTimeModif";
            this.dateTimeModif.Size = new System.Drawing.Size(200, 22);
            this.dateTimeModif.TabIndex = 5;
            // 
            // txtActif
            // 
            this.txtActif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtActif.FormattingEnabled = true;
            this.txtActif.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.txtActif.Location = new System.Drawing.Point(182, 370);
            this.txtActif.Name = "txtActif";
            this.txtActif.Size = new System.Drawing.Size(50, 24);
            this.txtActif.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nom d\'Utilisateur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mot de Passe : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Première Connexion : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "Mot de Passe Expiré : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Date de modification : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Id Role : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Code Employé : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "du Mot De Passe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Actif : ";
            // 
            // txtIdRole
            // 
            this.txtIdRole.FormattingEnabled = true;
            this.txtIdRole.Location = new System.Drawing.Point(180, 282);
            this.txtIdRole.Name = "txtIdRole";
            this.txtIdRole.Size = new System.Drawing.Size(100, 24);
            this.txtIdRole.TabIndex = 6;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(180, 330);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(50, 24);
            this.txtIdEmp.TabIndex = 7;
            // 
            // frmDetComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 437);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.txtIdRole);
            this.Controls.Add(this.txtActif);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeModif);
            this.Controls.Add(this.txtExpire);
            this.Controls.Add(this.txtPremiere);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtNomUtil);
            this.Name = "frmDetComptes";
            this.Text = "Details - Utilisateur";
            this.Load += new System.EventHandler(this.frmDetComptes_Load);
            this.Controls.SetChildIndex(this.txtNomUtil, 0);
            this.Controls.SetChildIndex(this.txtMDP, 0);
            this.Controls.SetChildIndex(this.txtPremiere, 0);
            this.Controls.SetChildIndex(this.txtExpire, 0);
            this.Controls.SetChildIndex(this.dateTimeModif, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtActif, 0);
            this.Controls.SetChildIndex(this.txtIdRole, 0);
            this.Controls.SetChildIndex(this.txtIdEmp, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtNomUtil;
        internal System.Windows.Forms.ComboBox txtActif;
        internal System.Windows.Forms.TextBox txtMDP;
        internal System.Windows.Forms.ComboBox txtPremiere;
        internal System.Windows.Forms.ComboBox txtExpire;
        internal System.Windows.Forms.DateTimePicker dateTimeModif;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox txtIdRole;
        internal System.Windows.Forms.ComboBox txtIdEmp;
    }
}