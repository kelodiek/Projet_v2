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
    public partial class frmDetClassification : frmDetail
    {
        Classification classification;
        ControleClassification cc;
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
            btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            cc = new ControleClassification();
        }

        private void enregistrer(object sender, EventArgs e)
        {
            //Categorie enregistrement = new Categorie();
            //bool resulVerif;
            //DialogResult resultEnrg;

            //enregistrement.codeCateg = txtCode.Text.Trim();
            //enregistrement.descCateg = txtDesc.Text.Trim();
            //enregistrement.comCateg = rtxtCommentaire.Text.Trim();

            //resulVerif = ctrlCateg.verifier(enregistrement, categSelect);
            

  
            //if (categSelect != null && ((string)Tag) != "Copie" )
            //{
                
            //    if (resulVerif)
            //    {
            //        resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
            //        if (resultEnrg == DialogResult.Yes)
            //        {
            //            ctrlCateg.modifier(enregistrement);
            //            this.Close();
            //        }
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK);
            //    }
            //}
            //else
            //{
            //    if (!ctrlCateg.testExiste(enregistrement.codeCateg) && txtCode.Text.Trim().Length != 0)
            //    {
            //        resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
            //        if (resultEnrg == DialogResult.Yes)
            //        {
            //            ctrlCateg.ajouter(enregistrement);
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Une categorie avec ce code existe deja ou le code est trop court.", "Erreur", MessageBoxButtons.OK);
            //    }
            //}
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        //Pas encore lié dans le constructeur
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            txtCote.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtNom.ReadOnly = false;
        }


        public EventHandler btnCopier_Click { get; set; }
    }
}
