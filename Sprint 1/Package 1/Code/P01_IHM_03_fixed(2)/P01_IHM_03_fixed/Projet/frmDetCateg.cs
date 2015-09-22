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
    public partial class frmDetCateg : frmDetail
    {
        public Categorie categSelect { get; set; }
        private ctrlCategorie ctrlCateg;

        public frmDetCateg()
        {
            InitializeComponent();
            this.PositionBtn(194);
            ctrlCateg = new ctrlCategorie();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
        }
        public frmDetCateg(Categorie C)
        {
            categSelect = C;
            InitializeComponent();
            this.PositionBtn(194);
            ctrlCateg = new ctrlCategorie();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
                categSelect = null;
            }
            else
            {
                this.txtCode.Enabled = false;
                this.txtDesc.Enabled = false;
                this.rtxtCommentaire.Enabled = false;
                remplirChamp();
            }
        }
        private void remplirChamp()
        {
            txtCode.Text = categSelect.codeCateg;
            txtDesc.Text = categSelect.descCateg;
            rtxtCommentaire.Text = categSelect.comCateg;
        }
        public void enregistrer(object sender,EventArgs e)
        {
            Categorie enregistrement = new Categorie();
            bool resultat;

            enregistrement.codeCateg = txtCode.Text.Trim();
            enregistrement.descCateg = txtDesc.Text.Trim();
            enregistrement.comCateg = rtxtCommentaire.Text.Trim();

            resultat = ctrlCateg.verifier(enregistrement, categSelect);
            

  
            if (categSelect != null && ((string)Tag) != "Copie" )
            {
                
                if (resultat)
                {
                    ctrlCateg.modifier(enregistrement);
                    this.Close();
                }
                else
                {
                    // Message d'erreur
                }
            }
            else
            {
                if (!ctrlCateg.testExiste(enregistrement.codeCateg))
                {
                    ctrlCateg.ajouter(enregistrement);
                    this.Close();
                }
                else
                {
                    //erreur
                }
            }
            
        
        }
        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            ctrlCateg.supprimer(txtCode.Text);
        }
        private void btnCopier_Click(object sender, EventArgs e)
        {
            Categorie info = new Categorie();
            frmDetCateg formOuvert;

            info.comCateg = rtxtCommentaire.Text;
            info.descCateg = txtDesc.Text;


            formOuvert = new frmDetCateg(info);
            formOuvert.Tag = "Copie";
            formOuvert.remplirChamp();
            formOuvert.btnCopier.Enabled = false;
            formOuvert.btnSupprimer.Enabled = false;
            formOuvert.btnActiverModif.Enabled = false;
            formOuvert.ShowDialog();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }
    }
}
