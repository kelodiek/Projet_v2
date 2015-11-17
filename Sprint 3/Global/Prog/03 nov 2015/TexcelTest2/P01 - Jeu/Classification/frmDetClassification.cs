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
        ctrlClassification cc;
        bool modif;
        public string cote;
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
            btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            this.btnEnregistrer.Click += new EventHandler(enregistrer_click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnAnnuler.Click += new EventHandler(btnAnnuler_Click);
            btnCopier.Visible = false;
            cc = new ctrlClassification();
            ancien = null;
            cote = null;
            modif = false;
        }

        public frmDetClassification(Classification anc)
        {
            ancien = anc;
            new frmDetClassification();

        }

        private void enregistrer()
        {
            bool resulVerif;
            DialogResult resultEnrg;

            Classification enregistrement = new Classification(txtCote.Text.Trim(), txtNom.Text.Trim(), txtDescription.Text.Trim());

            resulVerif = cc.verifier(ancien, enregistrement, modif);

            if (modif == true)
            {
                if (resulVerif)
                {
                    if (txtCote.Text.Trim().Length != 0 && txtDescription.Text.Trim().Length != 0 && txtNom.Text.Trim().Length != 0)
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
                                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Les champs sont mal remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!cc.testExiste(enregistrement.coteESRB) && txtCote.Text.Trim().Length != 0 && txtDescription.Text.Trim().Length != 0 && txtNom.Text.Trim().Length != 0)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        try
                        {
                            cc.ajouter(enregistrement);
                            cote = enregistrement.coteESRB;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                    }
                }
                else
                {
                    if (txtCote.Text.Trim().Length != 0 && txtDescription.Text.Trim().Length != 0 && txtNom.Text.Trim().Length != 0)
                    {
                        MessageBox.Show("Les champs sont mal remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Une classification avec ce code existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void enregistrer_click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("voulez vous vraiment supprimer la classification suivante ? \n Code : " + txtCote.Text + "\n Nom : " + txtNom.Text + "\n Description : " + txtDescription.Text, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                cc.supprimer(txtCote.Text);
                this.Close();
            }
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
            modif = true;
        }


        private void btnCopier_Click(object sender, EventArgs e)
        {
            //Pas dans classification
        }


    }
}
