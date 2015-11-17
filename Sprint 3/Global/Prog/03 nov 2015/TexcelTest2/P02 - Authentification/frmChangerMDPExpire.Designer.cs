namespace Projet
{
    partial class frmChangerMDPExpire
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMDP2 = new System.Windows.Forms.TextBox();
            this.txtMDP1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrez le nouveau Mot de Passe de nouveau : ";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(56, 154);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(214, 31);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(276, 154);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(217, 31);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "Contacter un Administrateur";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Votre mot de passe est expiré (expire aux 6 mois) ,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMDP2
            // 
            this.txtMDP2.Location = new System.Drawing.Point(353, 114);
            this.txtMDP2.Name = "txtMDP2";
            this.txtMDP2.Size = new System.Drawing.Size(140, 22);
            this.txtMDP2.TabIndex = 2;
            // 
            // txtMDP1
            // 
            this.txtMDP1.Location = new System.Drawing.Point(353, 79);
            this.txtMDP1.Name = "txtMDP1";
            this.txtMDP1.Size = new System.Drawing.Size(140, 22);
            this.txtMDP1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = " veuillez le changer.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrez le Nouveau Mot de Passe : ";
            // 
            // frmChangerMDPExpire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMDP1);
            this.Controls.Add(this.txtMDP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label2);
            this.Name = "frmChangerMDPExpire";
            this.Text = "Mot de passe Expiré";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMDP2;
        private System.Windows.Forms.TextBox txtMDP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

