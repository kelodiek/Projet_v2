using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    partial class frmDetClassification : frmDetail
    {
        Classification classification, ancien;
        ControleClassification cc;
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
            btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnAnnuler.Click += new EventHandler(btnAnnuler_Click);
            btnCopier.Visible = false;
            cc = new ControleClassification();
            ancien = null;
        }

        public frmDetClassification(Classification anc)
        {
            ancien = anc;
            new frmDetClassification();

        }

        private void enregistrer(object sender, EventArgs e)
        {
            bool resulVerif;
            DialogResult resultEnrg;


            Classification enregistrement = new Classification(txtCote.Text.Trim(), txtNom.Text.Trim(), txtDescription.Text.Trim());

            resulVerif = cc.verifier(ancien, enregistrement);



            if (ancien == null && ((string)Tag) != "Copie")
            {

                if (resulVerif)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        try
                        {
                            cc.modifier(enregistrement);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!cc.testExiste(enregistrement.coteESRB) && txtCote.Text.Trim().Length != 0)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        try
                        {
                            cc.ajouter(enregistrement);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Une classification avec ce code existe deja ou la cote est trop court.", "Erreur", MessageBoxButtons.OK);
                }
            }
            
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cc.supprimer(txtCote.Text);
            this.Close();
        }

        public void modifierChamp(string cote, string nom, string desc)
        {
            this.txtCote.ReadOnly = true;
            this.txtDescription.ReadOnly = true;
            this.txtNom.ReadOnly = true;
            txtCote.Text = cote;
            txtNom.Text = nom;
            txtDescription.Text = desc;
            this.btnEnregistrer.Enabled = false;
            classification = new Classification(cote, nom, desc);
        }

        public void modifierChamp()
        {          
            this.btnActiverModif.Enabled = false;
            this.btnSupprimer.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            txtCote.ReadOnly = true;
            txtDescription.ReadOnly = false;
            txtNom.ReadOnly = false;
        }


        private void btnCopier_Click(object sender, EventArgs e)
        {
            //Pas dans classification
        }
    }
}
