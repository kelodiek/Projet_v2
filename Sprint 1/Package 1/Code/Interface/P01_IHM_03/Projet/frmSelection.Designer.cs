namespace Projet
{
    partial class frmSelection
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstDispo = new System.Windows.Forms.ListBox();
            this.lstSelect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(395, 327);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 30);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(75, 327);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(92, 30);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(325, 23);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 17);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Sélectionnés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Disponibles";
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(243, 182);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(79, 75);
            this.btnRetirer.TabIndex = 11;
            this.btnRetirer.Text = "<";
            this.btnRetirer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(244, 101);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(78, 75);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = ">";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // lstDispo
            // 
            this.lstDispo.FormattingEnabled = true;
            this.lstDispo.ItemHeight = 16;
            this.lstDispo.Location = new System.Drawing.Point(14, 46);
            this.lstDispo.Name = "lstDispo";
            this.lstDispo.Size = new System.Drawing.Size(223, 260);
            this.lstDispo.TabIndex = 9;
            // 
            // lstSelect
            // 
            this.lstSelect.FormattingEnabled = true;
            this.lstSelect.ItemHeight = 16;
            this.lstSelect.Location = new System.Drawing.Point(328, 46);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(223, 260);
            this.lstSelect.TabIndex = 8;
            // 
            // frmCreerGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 380);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lstDispo);
            this.Controls.Add(this.lstSelect);
            this.Name = "frmCreerGenre";
            this.Text = "frmCreer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstDispo;
        private System.Windows.Forms.ListBox lstSelect;
    }
}