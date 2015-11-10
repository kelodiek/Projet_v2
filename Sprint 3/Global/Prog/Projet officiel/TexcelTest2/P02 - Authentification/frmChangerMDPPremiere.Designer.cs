namespace Projet
{
    partial class frmChangerMDPPremiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMDP1 = new System.Windows.Forms.TextBox();
            this.txtMDP2 = new System.Windows.Forms.TextBox();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez entrez votre Mot de Passe personnalisé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Veuillez noter que celui-ci expire après 6 mois)";
            // 
            // txtMDP1
            // 
            this.txtMDP1.Location = new System.Drawing.Point(291, 76);
            this.txtMDP1.Name = "txtMDP1";
            this.txtMDP1.Size = new System.Drawing.Size(140, 22);
            this.txtMDP1.TabIndex = 1;
            // 
            // txtMDP2
            // 
            this.txtMDP2.Location = new System.Drawing.Point(291, 111);
            this.txtMDP2.Name = "txtMDP2";
            this.txtMDP2.Size = new System.Drawing.Size(140, 22);
            this.txtMDP2.TabIndex = 2;
            this.txtMDP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMDP2_KeyDown);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(272, 154);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(217, 31);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "Contacter un Administrateur";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(52, 154);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(214, 31);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Entrez le Mot de Passe de nouveau : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entrez le Nouveau Mot de Passe : ";
            // 
            // frmChangerMDPPremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 199);
            this.Controls.Add(this.txtMDP1);
            this.Controls.Add(this.txtMDP2);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangerMDPPremiere";
            this.Text = "Changer Mot de Passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMDP1;
        private System.Windows.Forms.TextBox txtMDP2;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}