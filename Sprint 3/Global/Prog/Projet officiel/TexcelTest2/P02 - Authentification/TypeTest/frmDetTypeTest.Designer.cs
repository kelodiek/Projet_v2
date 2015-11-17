namespace Projet
{
    partial class frmDetTypeTest
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNomTest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObjTest = new System.Windows.Forms.RichTextBox();
            this.txtDescTest = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComTest = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Code de type de test : ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(192, 17);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(143, 22);
            this.txtCode.TabIndex = 1;
            // 
            // txtNomTest
            // 
            this.txtNomTest.Location = new System.Drawing.Point(192, 56);
            this.txtNomTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomTest.MaxLength = 60;
            this.txtNomTest.Name = "txtNomTest";
            this.txtNomTest.ReadOnly = true;
            this.txtNomTest.Size = new System.Drawing.Size(374, 22);
            this.txtNomTest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nom du type de test : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Objectif du type de test : ";
            // 
            // txtObjTest
            // 
            this.txtObjTest.Location = new System.Drawing.Point(12, 119);
            this.txtObjTest.Name = "txtObjTest";
            this.txtObjTest.ReadOnly = true;
            this.txtObjTest.Size = new System.Drawing.Size(356, 327);
            this.txtObjTest.TabIndex = 3;
            this.txtObjTest.Text = "";
            // 
            // txtDescTest
            // 
            this.txtDescTest.Location = new System.Drawing.Point(423, 119);
            this.txtDescTest.Name = "txtDescTest";
            this.txtDescTest.ReadOnly = true;
            this.txtDescTest.Size = new System.Drawing.Size(374, 149);
            this.txtDescTest.TabIndex = 4;
            this.txtDescTest.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(419, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Description du type de test : ";
            // 
            // txtComTest
            // 
            this.txtComTest.Location = new System.Drawing.Point(423, 305);
            this.txtComTest.Name = "txtComTest";
            this.txtComTest.ReadOnly = true;
            this.txtComTest.Size = new System.Drawing.Size(374, 141);
            this.txtComTest.TabIndex = 5;
            this.txtComTest.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(419, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Commentaire du type de test : ";
            // 
            // frmDetTypeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.txtComTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObjTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "frmDetTypeTest";
            this.Text = "Texcel : Détail - Type Test";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNomTest, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtObjTest, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDescTest, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComTest, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNomTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtObjTest;
        private System.Windows.Forms.RichTextBox txtDescTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtComTest;
        private System.Windows.Forms.Label label5;
    }
}