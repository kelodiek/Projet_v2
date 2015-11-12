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
        public bool annuler { get; set; }
        private int lvlAcces;

        //      avec authentification

        public frmDetCateg(int lvla)
        {
            categSelect = null;
            InitializeComponent();
            this.PositionBtn(194);
            ctrlCateg = new ctrlCategorie();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            //this.btnCopier.Enabled = false;
            annuler = true;
            lvlAcces = lvla;
            checkLvlAcces();
        }

        public frmDetCateg(Categorie C, int lvla)
        {
            categSelect = C;
            InitializeComponent();
            this.PositionBtn(194);
            ctrlCateg = new ctrlCategorie();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            annuler = true;
            lvlAcces = lvla;
            checkLvlAcces();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">a = ajouter, m = modifier</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
                btnCopier.Visible = false;
                categSelect = null;
            }
            else
            {
                this.txtCode.Enabled = false;
                this.txtDesc.Enabled = false;
                this.rtxtCommentaire.Enabled = false;
                //this.btnCopier.Enabled = true;
                this.btnEnregistrer.Enabled = false;

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
            bool resulVerif;
            DialogResult resultEnrg;

            enregistrement.codeCateg = txtCode.Text.Trim();
            enregistrement.descCateg = txtDesc.Text.Trim();
            enregistrement.comCateg = rtxtCommentaire.Text.Trim();

            resulVerif = ctrlCateg.verifier(enregistrement, categSelect);
            

  
            if (categSelect == null && ((string)Tag) != "Copie" )
            {
                
                if (resulVerif)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrlCateg.ajouter(enregistrement);
                        categSelect = enregistrement;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les champs correctement.", "Erreur", MessageBoxButtons.OK);
                }
            }
            else if (categSelect != null && ((string)Tag) != "Copie")
            {

                if (resulVerif)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrlCateg.modifier(enregistrement);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les champs correctement.", "Erreur", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!ctrlCateg.testExiste(enregistrement.codeCateg) && txtCode.Text.Trim().Length != 0)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrlCateg.ajouter(enregistrement);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Une categorie avec ce code existe deja ou le code est trop court.", "Erreur", MessageBoxButtons.OK);
                }
            }
            
        
        }
        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                ctrlCateg.supprimer(txtCode.Text);
                this.Close();
            }
        }
        private void btnCopier_Click(object sender, EventArgs e)
        {
            Categorie info = new Categorie();
            frmDetCateg formOuvert;

            info.comCateg = rtxtCommentaire.Text;
            info.descCateg = txtDesc.Text;


            formOuvert = new frmDetCateg(info, lvlAcces);
            formOuvert.Tag = "Copie";
            formOuvert.remplirChamp();
            formOuvert.btnCopier.Enabled = false;
            formOuvert.btnSupprimer.Enabled = false;
            formOuvert.btnActiverModif.Enabled = false;
            formOuvert.ShowDialog();
            if (annuler == false)
            {
                this.Close();   
            }
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void checkLvlAcces()
        {
            if (lvlAcces == 1)
            {
                btnActiverModif.Enabled = false;
                btnCopier.Enabled = false;
                btnEnregistrer.Enabled = false;
                btnSupprimer.Enabled = false;
            }
        }
    }
}
