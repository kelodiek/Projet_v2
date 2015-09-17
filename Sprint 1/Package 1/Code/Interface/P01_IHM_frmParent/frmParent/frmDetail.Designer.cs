namespace frmParent
{
    partial class frmDetail
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
            this.SuspendLayout();
            // 
            // btnCopier
            // 
            this.btnCopier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopier.Location = new System.Drawing.Point(17, 428);
            this.btnCopier.Name = "btnCopier";
            this.btnCopier.Size = new System.Drawing.Size(76, 35);
            this.btnCopier.TabIndex = 66;
            this.btnCopier.Text = "Copier";
            this.btnCopier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(329, 428);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(109, 35);
            this.btnAnnuler.TabIndex = 65;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnActiverModif
            // 
            this.btnActiverModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiverModif.Location = new System.Drawing.Point(214, 428);
            this.btnActiverModif.Name = "btnActiverModif";
            this.btnActiverModif.Size = new System.Drawing.Size(109, 35);
            this.btnActiverModif.TabIndex = 64;
            this.btnActiverModif.Text = "Modifier";
            this.btnActiverModif.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPlateforme
            // 
            this.btnAjoutPlateforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutPlateforme.Location = new System.Drawing.Point(99, 428);
            this.btnAjoutPlateforme.Name = "btnAjoutPlateforme";
            this.btnAjoutPlateforme.Size = new System.Drawing.Size(109, 35);
            this.btnAjoutPlateforme.TabIndex = 63;
            this.btnAjoutPlateforme.Text = "Enregistrer";
            this.btnAjoutPlateforme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 475);
            this.Controls.Add(this.btnCopier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnActiverModif);
            this.Controls.Add(this.btnAjoutPlateforme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnCopier;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.Button btnActiverModif;
        internal System.Windows.Forms.Button btnAjoutPlateforme;
    }
}

