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
    public partial class frmDetVersion : frmDetail
    {
        private version selectVers;
        private ctrlVersion ctrlVers;
        private string typeDetail;
        private int IDJeu;
        private int lvlAcces;

        public frmDetVersion()
        {
            loadFrmGeneral();
            typeDetail = "nouveau";
            selectVers = new version();
        }
        //public frmDetVersion(int id)
        //{
        //    loadFrmGeneral();
        //    typeDetail = "nouveau";
        //    IDJeu = id;
        //    selectVers = new version();
        //    txtId.Text = IDJeu.ToString();
        //}
        public frmDetVersion(version v)
        {
            loadFrmGeneral();
            typeDetail = "modification";
            selectVers = v;
            loadInfo();
            this.btnActiverModif.Click += new EventHandler(activerModif);
        }


        //      avec authentification
        public frmDetVersion(int id, int lvla)
        {
            loadFrmGeneral();
            typeDetail = "nouveau";
            IDJeu = id;
            selectVers = new version();
            txtId.Text = IDJeu.ToString();
            lvlAcces = lvla;
        }
        public frmDetVersion(version v, int lvla)
        {
            loadFrmGeneral();
            typeDetail = "modification";
            selectVers = v;
            loadInfo();
            this.btnActiverModif.Click += new EventHandler(activerModif);
            lvlAcces = lvla;
        }

        // Load les trucs de base presente dans chacune des possibilités de formes
        private void loadFrmGeneral() 
        {
            InitializeComponent();
            this.PositionBtn(350);
            ctrlVers = new ctrlVersion();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
        }
        // Type la forme si elle est pour un ajout, une modification ou si c'est le cas, une copie.
        public void setTypeDetail(string type)
        {
            typeDetail = type;
        }
        // Modifie l'interface si la forme est pour ajouter ou modifier
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Enabled = false;
                this.txtId.ReadOnly = true;
            }
            else
            {
                this.txtId.ReadOnly = true;
                this.txtNom.ReadOnly = true;
                this.txtCode.ReadOnly = true;
                this.txtStade.ReadOnly = true;
                this.rtxtDesc.ReadOnly = true;
                this.dateSortie.Enabled = false;
                this.dateVersion.Enabled = false;

                this.btnEnregistrer.Enabled = false;
            }
            this.btnCopier.Enabled = false;

            checkLvlAcces();
        }
        // Charge les info de la version dans l'interface
        private void loadInfo()
        {
            txtId.Text = selectVers.idJeu.ToString();
            txtNom.Text = selectVers.nomVersion;
            txtCode.Text = selectVers.codeVersion;
            txtStade.Text = selectVers.stadeVersion;
            rtxtDesc.Text = selectVers.descVersion;
            dateSortie.Value = selectVers.dateSortie;
            dateVersion.Value = selectVers.dateVersion;
        }
        // Active les champs modifiable dans la forme detail
        private void activerModif(object sender, EventArgs e)
        {
            this.txtNom.ReadOnly = false;
            this.txtStade.ReadOnly = false;
            this.rtxtDesc.ReadOnly = false;
            this.dateSortie.Enabled = true;
            this.dateVersion.Enabled = true;

            this.btnEnregistrer.Enabled = true;
            this.btnActiverModif.Enabled = false;
        }
        // Methode employer pour determiner le type d'enregistrement, 
        // genre un modification pis un ajout C'est different, pis une copie aussi
        private void enregistrer(object sender, EventArgs e)
        {
            bool resultat;
            var nouvVersion = new version();
            nouvVersion.codeVersion = txtCode.Text;
            nouvVersion.dateSortie = dateSortie.Value;
            nouvVersion.dateVersion = dateVersion.Value;
            nouvVersion.descVersion = rtxtDesc.Text;
            nouvVersion.idJeu = IDJeu;
            nouvVersion.nomVersion = txtNom.Text;
            nouvVersion.stadeVersion = txtStade.Text;

            if (typeDetail == "modification")
            {
                // Enregistrement de modification
                resultat = ctrlVers.verifier(txtNom.Text.Trim(), txtCode.Text.Trim());
                if (resultat)
                {
                    if (MessageBox.Show("Voulez-vous enregistrer?","Enregistrement",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ctrlVers.enregistrer("m", nouvVersion);
                        this.Close();
                    }
                }
            }
            if (typeDetail == "nouveau")
            {
                // enregistrement de nouveau
                if (ctrlVers.verifier(txtCode.Text.Trim()))
                {
                    MessageBox.Show("Une version avec ce meme code existe.", "Erreur", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Voulez-vous enregistrer?", "Enregistrement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ctrlVers.enregistrer("a", nouvVersion);
                        this.Close();
                    }
                }
            }
        }
        // c'est pomal claire comme methode ca
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous supprimer?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ctrlVers.supprimer(txtCode.Text);
                this.Close();  
            }
        }

        //      bloque les boutons de modification si l'utilisateur n'a pas le niveau d'accès pour écrire
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
