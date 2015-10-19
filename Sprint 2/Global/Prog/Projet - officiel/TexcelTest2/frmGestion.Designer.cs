namespace Projet
{
    partial class frmGestion
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuDonneToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSysExpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlateToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCategToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClassToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenreToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SeparatorToolStrip = new System.Windows.Forms.ToolStripSeparator();
            this.btnJeuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuSecuriteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuQuitterToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitterToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDecoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGesEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGesEquipe = new System.Windows.Forms.ToolStripMenuItem();
            this.retourInterfaceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnX = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(945, 458);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(125, 35);
            this.btnDetails.TabIndex = 46;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(814, 458);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(125, 35);
            this.btnAjout.TabIndex = 45;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(26, 40);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(149, 22);
            this.txtRecherche.TabIndex = 48;
            this.txtRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecherche_KeyDown);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(181, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(100, 27);
            this.btnRecherche.TabIndex = 49;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuDonneToolStrip,
            this.btnMenuSecuriteToolStrip,
            this.btnMenuQuitterToolStrip,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 31);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuDonneToolStrip
            // 
            this.btnMenuDonneToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSysExpToolStrip,
            this.btnPlateToolStrip,
            this.btnCategToolStrip,
            this.toolStripSeparator1,
            this.btnClassToolStrip,
            this.btnGenreToolStrip,
            this.btnModeToolStrip,
            this.btnThemeToolStrip,
            this.SeparatorToolStrip,
            this.btnJeuToolStrip});
            this.btnMenuDonneToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuDonneToolStrip.Name = "btnMenuDonneToolStrip";
            this.btnMenuDonneToolStrip.Size = new System.Drawing.Size(89, 27);
            this.btnMenuDonneToolStrip.Text = "Données";
            // 
            // btnSysExpToolStrip
            // 
            this.btnSysExpToolStrip.Name = "btnSysExpToolStrip";
            this.btnSysExpToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnSysExpToolStrip.Text = "Système d\'Exploitation";
            this.btnSysExpToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnPlateToolStrip
            // 
            this.btnPlateToolStrip.Name = "btnPlateToolStrip";
            this.btnPlateToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnPlateToolStrip.Text = "Plateforme";
            this.btnPlateToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnCategToolStrip
            // 
            this.btnCategToolStrip.Name = "btnCategToolStrip";
            this.btnCategToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnCategToolStrip.Text = "Categorie";
            this.btnCategToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // btnClassToolStrip
            // 
            this.btnClassToolStrip.Name = "btnClassToolStrip";
            this.btnClassToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnClassToolStrip.Text = "Classification";
            this.btnClassToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnGenreToolStrip
            // 
            this.btnGenreToolStrip.Name = "btnGenreToolStrip";
            this.btnGenreToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnGenreToolStrip.Text = "Genre";
            this.btnGenreToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnModeToolStrip
            // 
            this.btnModeToolStrip.Name = "btnModeToolStrip";
            this.btnModeToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnModeToolStrip.Text = "Mode";
            this.btnModeToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnThemeToolStrip
            // 
            this.btnThemeToolStrip.Name = "btnThemeToolStrip";
            this.btnThemeToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnThemeToolStrip.Text = "Theme";
            this.btnThemeToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // SeparatorToolStrip
            // 
            this.SeparatorToolStrip.Name = "SeparatorToolStrip";
            this.SeparatorToolStrip.Size = new System.Drawing.Size(249, 6);
            // 
            // btnJeuToolStrip
            // 
            this.btnJeuToolStrip.Name = "btnJeuToolStrip";
            this.btnJeuToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnJeuToolStrip.Text = "Jeu";
            this.btnJeuToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnMenuSecuriteToolStrip
            // 
            this.btnMenuSecuriteToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuSecuriteToolStrip.Name = "btnMenuSecuriteToolStrip";
            this.btnMenuSecuriteToolStrip.Size = new System.Drawing.Size(83, 27);
            this.btnMenuSecuriteToolStrip.Text = "Sécurité";
            // 
            // btnMenuQuitterToolStrip
            // 
            this.btnMenuQuitterToolStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMenuQuitterToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuitterToolStrip,
            this.btnDecoToolStrip});
            this.btnMenuQuitterToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuQuitterToolStrip.Name = "btnMenuQuitterToolStrip";
            this.btnMenuQuitterToolStrip.Size = new System.Drawing.Size(76, 27);
            this.btnMenuQuitterToolStrip.Text = "Quitter";
            // 
            // btnQuitterToolStrip
            // 
            this.btnQuitterToolStrip.Name = "btnQuitterToolStrip";
            this.btnQuitterToolStrip.Size = new System.Drawing.Size(180, 28);
            this.btnQuitterToolStrip.Text = "Quitter";
            this.btnQuitterToolStrip.Click += new System.EventHandler(this.btnQuitterToolStrip_Click);
            // 
            // btnDecoToolStrip
            // 
            this.btnDecoToolStrip.Name = "btnDecoToolStrip";
            this.btnDecoToolStrip.Size = new System.Drawing.Size(180, 28);
            this.btnDecoToolStrip.Text = "Deconnexion";
            this.btnDecoToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGesEquipe,
            this.toolStripGesEmp});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 27);
            this.toolStripMenuItem1.Text = "Personnel";
            // 
            // toolStripGesEmp
            // 
            this.toolStripGesEmp.Name = "toolStripGesEmp";
            this.toolStripGesEmp.Size = new System.Drawing.Size(175, 28);
            this.toolStripGesEmp.Text = "Employe";
            this.toolStripGesEmp.Click += new System.EventHandler(this.toolStripGesEmp_Click);
            // 
            // toolStripGesEquipe
            // 
            this.toolStripGesEquipe.Name = "toolStripGesEquipe";
            this.toolStripGesEquipe.Size = new System.Drawing.Size(175, 28);
            this.toolStripGesEquipe.Text = "Equipe";
            this.toolStripGesEquipe.Click += new System.EventHandler(this.toolStripGesEquipe_Click);
            // 
            // retourInterfaceTestToolStripMenuItem
            // 
            this.retourInterfaceTestToolStripMenuItem.Name = "retourInterfaceTestToolStripMenuItem";
            this.retourInterfaceTestToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(282, 38);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(27, 27);
            this.btnX.TabIndex = 51;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnAjout);
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDetails;
        internal System.Windows.Forms.Button btnAjout;
        internal System.Windows.Forms.TextBox txtRecherche;
        internal System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuDonneToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnSysExpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnPlateToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnClassToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnMenuSecuriteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem retourInterfaceTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuQuitterToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnJeuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnQuitterToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnDecoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnThemeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnModeToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator SeparatorToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnCategToolStrip;
        internal System.Windows.Forms.Button btnX;
        private System.Windows.Forms.ToolStripMenuItem btnGenreToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripGesEmp;
        private System.Windows.Forms.ToolStripMenuItem toolStripGesEquipe;
    }
}