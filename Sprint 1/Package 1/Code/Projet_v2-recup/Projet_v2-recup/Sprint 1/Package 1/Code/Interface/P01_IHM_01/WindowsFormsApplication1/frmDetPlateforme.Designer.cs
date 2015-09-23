namespace WindowsFormsApplication1
{
    partial class frmDetPlateforme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCopier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnActiverModif = new System.Windows.Forms.Button();
            this.btnAjoutPlateforme = new System.Windows.Forms.Button();
            this.txtInfoSup = new System.Windows.Forms.RichTextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtStokage = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCartemer = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboxOS = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAjoutOS = new System.Windows.Forms.Button();
            this.btnSupprimerOS = new System.Windows.Forms.Button();
            this.btnAfficherPerif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopier
            // 
            this.btnCopier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopier.Location = new System.Drawing.Point(15, 436);
            this.btnCopier.Name = "btnCopier";
            this.btnCopier.Size = new System.Drawing.Size(76, 35);
            this.btnCopier.TabIndex = 62;
            this.btnCopier.Text = "Copier";
            this.btnCopier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(327, 436);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(109, 35);
            this.btnAnnuler.TabIndex = 61;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnActiverModif
            // 
            this.btnActiverModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiverModif.Location = new System.Drawing.Point(212, 436);
            this.btnActiverModif.Name = "btnActiverModif";
            this.btnActiverModif.Size = new System.Drawing.Size(109, 35);
            this.btnActiverModif.TabIndex = 60;
            this.btnActiverModif.Text = "Modifier";
            this.btnActiverModif.UseVisualStyleBackColor = true;
            this.btnActiverModif.Click += new System.EventHandler(this.btnActiverModif_Click);
            // 
            // btnAjoutPlateforme
            // 
            this.btnAjoutPlateforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutPlateforme.Location = new System.Drawing.Point(97, 436);
            this.btnAjoutPlateforme.Name = "btnAjoutPlateforme";
            this.btnAjoutPlateforme.Size = new System.Drawing.Size(109, 35);
            this.btnAjoutPlateforme.TabIndex = 59;
            this.btnAjoutPlateforme.Text = "Enregistrer";
            this.btnAjoutPlateforme.UseVisualStyleBackColor = true;
            // 
            // txtInfoSup
            // 
            this.txtInfoSup.Enabled = false;
            this.txtInfoSup.Location = new System.Drawing.Point(12, 334);
            this.txtInfoSup.Name = "txtInfoSup";
            this.txtInfoSup.Size = new System.Drawing.Size(425, 96);
            this.txtInfoSup.TabIndex = 58;
            this.txtInfoSup.Text = "";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(9, 311);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(223, 20);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "Information Supplementaire :";
            // 
            // txtStokage
            // 
            this.txtStokage.Enabled = false;
            this.txtStokage.Location = new System.Drawing.Point(176, 236);
            this.txtStokage.Name = "txtStokage";
            this.txtStokage.Size = new System.Drawing.Size(213, 22);
            this.txtStokage.TabIndex = 56;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(9, 236);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(161, 20);
            this.Label9.TabIndex = 55;
            this.Label9.Text = "Espace de stokage :";
            // 
            // txtRam
            // 
            this.txtRam.Enabled = false;
            this.txtRam.Location = new System.Drawing.Point(176, 208);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(213, 22);
            this.txtRam.TabIndex = 54;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(9, 208);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(56, 20);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "RAM :";
            // 
            // txtCartemer
            // 
            this.txtCartemer.Enabled = false;
            this.txtCartemer.Location = new System.Drawing.Point(176, 180);
            this.txtCartemer.Name = "txtCartemer";
            this.txtCartemer.Size = new System.Drawing.Size(213, 22);
            this.txtCartemer.TabIndex = 52;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(9, 180);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(103, 20);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Carte Mere :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(9, 122);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(91, 20);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "Categorie :";
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(176, 122);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(159, 24);
            this.ComboBox2.TabIndex = 49;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(9, 92);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 20);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "OS :";
            // 
            // cboxOS
            // 
            this.cboxOS.FormattingEnabled = true;
            this.cboxOS.Location = new System.Drawing.Point(176, 92);
            this.cboxOS.Name = "cboxOS";
            this.cboxOS.Size = new System.Drawing.Size(102, 24);
            this.cboxOS.TabIndex = 47;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(176, 63);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 22);
            this.txtNom.TabIndex = 46;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(9, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 20);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Nom :";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(176, 35);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 22);
            this.txtCode.TabIndex = 44;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(9, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Code :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(176, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 22);
            this.txtID.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Identifiant :";
            // 
            // txtCPU
            // 
            this.txtCPU.Enabled = false;
            this.txtCPU.Location = new System.Drawing.Point(176, 152);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(213, 22);
            this.txtCPU.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "CPU :";
            // 
            // btnAjoutOS
            // 
            this.btnAjoutOS.Enabled = false;
            this.btnAjoutOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutOS.Location = new System.Drawing.Point(284, 92);
            this.btnAjoutOS.Name = "btnAjoutOS";
            this.btnAjoutOS.Size = new System.Drawing.Size(27, 24);
            this.btnAjoutOS.TabIndex = 63;
            this.btnAjoutOS.Text = "+";
            this.btnAjoutOS.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerOS
            // 
            this.btnSupprimerOS.Enabled = false;
            this.btnSupprimerOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerOS.Location = new System.Drawing.Point(317, 92);
            this.btnSupprimerOS.Name = "btnSupprimerOS";
            this.btnSupprimerOS.Size = new System.Drawing.Size(27, 24);
            this.btnSupprimerOS.TabIndex = 64;
            this.btnSupprimerOS.Text = "-";
            this.btnSupprimerOS.UseVisualStyleBackColor = true;
            // 
            // btnAfficherPerif
            // 
            this.btnAfficherPerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherPerif.Location = new System.Drawing.Point(176, 269);
            this.btnAfficherPerif.Name = "btnAfficherPerif";
            this.btnAfficherPerif.Size = new System.Drawing.Size(86, 35);
            this.btnAfficherPerif.TabIndex = 65;
            this.btnAfficherPerif.Text = "Afficher";
            this.btnAfficherPerif.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Peripherique  : ";
            // 
            // frmDetPlateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficherPerif);
            this.Controls.Add(this.btnSupprimerOS);
            this.Controls.Add(this.btnAjoutOS);
            this.Controls.Add(this.btnCopier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnActiverModif);
            this.Controls.Add(this.btnAjoutPlateforme);
            this.Controls.Add(this.txtInfoSup);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtStokage);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtCartemer);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cboxOS);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetPlateforme";
            this.Text = "Details - Plateformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCopier;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.Button btnActiverModif;
        internal System.Windows.Forms.Button btnAjoutPlateforme;
        internal System.Windows.Forms.RichTextBox txtInfoSup;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtStokage;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtRam;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCartemer;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboxOS;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtCPU;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btnAjoutOS;
        internal System.Windows.Forms.Button btnSupprimerOS;
        internal System.Windows.Forms.Button btnAfficherPerif;
        internal System.Windows.Forms.Label label1;
    }
}

