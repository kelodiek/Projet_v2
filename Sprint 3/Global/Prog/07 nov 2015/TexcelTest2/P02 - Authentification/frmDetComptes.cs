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
    public partial class frmDetComptes : frmDetail
    {
        public string[] copie { get; set; }
        public string[] infoCompte { get; set; }
        private ctrlComptes GesComptes;
        public int Idemp;

        private Utilisateur ancienCompte;
        public bool annuler { get; set; }
        public frmDetComptes(int Id)
        {
            InitializeComponent();
            this.PositionBtn(400);
            this.btnActiverModif.Click += new EventHandler(activerModif_Click);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnCopier.Enabled = false;
            GesComptes = new ctrlComptes();
            annuler = true;
            Idemp = Id;

        }
        public frmDetComptes(string[] info, int Id)
        {
            InitializeComponent();
            this.PositionBtn(400);
            this.btnActiverModif.Click += new EventHandler(activerModif_Click);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            txtNomUtil.Text = info[0];
            infoCompte = info;
            GesComptes = new ctrlComptes();
            annuler = true;
            ancienCompte = new Utilisateur();
            Idemp = Id;
        }
        public void frmDetComptes_Load(object sender, EventArgs e)
        {
            if (txtIdEmp.Text != "")
            {
                string[] lst = GesComptes.GetInfoEmp(Convert.ToInt32(txtIdEmp.Text));
                string Tool = lst[1] + " " + lst[0];
                ToolTip infoEmp = new ToolTip();
                infoEmp.AutoPopDelay = 5000;
                infoEmp.InitialDelay = 1000;
                infoEmp.ReshowDelay = 500;
                infoEmp.ShowAlways = true;
                infoEmp.SetToolTip(this.txtIdEmp, Tool);
            }
            foreach (var item in GesComptes.GetRoles())
            {
                txtIdRole.Items.Add(item);
            }
            txtIdEmp.Text = Idemp.ToString();
            txtIdEmp.Enabled = false;
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnSupprimer.Enabled = false;
                this.btnActiverModif.Enabled = false;
            }
            else
            {
                this.txtNomUtil.Enabled = false;
                this.txtMDP.Enabled = false;
                this.txtPremiere.Enabled = false;
                this.txtExpire.Enabled = false;
                this.dateTimeModif.Enabled = false;
                this.txtIdRole.Enabled = false;
                this.txtIdEmp.Enabled = false;
                this.txtActif.Enabled = false;

                this.btnEnregistrer.Enabled = false;
                remplirChamp();
            }
        }
        private string ValeurCombo(string valeur)
        {
            if (valeur == "o")
            {
                return "Oui";
            }
            else if (valeur == "n")
            {
                return "Non";
            }
            else
            {
                return valeur;
            }
        }
        //Get valeur depuis la collection des combobox pour les setter selon ce qui est dans infoCompte
        private void remplirChamp()
        {
            ctrlComptes ctrlcompte = new ctrlComptes();
            txtNomUtil.Text = infoCompte[0];
            txtMDP.Text = infoCompte[1];
            txtPremiere.Text = ValeurCombo(infoCompte[2]);
            txtExpire.Text = ValeurCombo(infoCompte[3]);
            dateTimeModif.Value = Convert.ToDateTime(infoCompte[4]);
            txtIdRole.Text = GesComptes.GetNomRole(Convert.ToInt32(infoCompte[5]));
            txtIdEmp.Text = Idemp.ToString();
            txtActif.Text = ValeurCombo(infoCompte[7]);

            ancienCompte.NomUtilisateur = txtNomUtil.Text;
            if (txtNomUtil.Text.Length != 0)
            {
                ancienCompte.NomUtilisateur = txtNomUtil.Text;
            }
            ancienCompte.MotDePasse = txtMDP.Text;
            ancienCompte.Premiere = txtPremiere.Text;
            ancienCompte.Expire = txtExpire.Text;
            ancienCompte.DateModifMotPas = dateTimeModif.Value;
            ancienCompte.Role = Convert.ToInt32(ctrlcompte.GetIdRole(txtIdRole.Text));
            ancienCompte.Emp = Convert.ToInt32(txtIdEmp.Text);
            ancienCompte.UtilActif = txtActif.Text;
        }

        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo);


            if (resultat == DialogResult.Yes)
            {
                string NomUtil = txtNomUtil.Text;

                rComptesSQL.supprimer(NomUtil);

                this.Close();
            }
        }
        public void activerModif_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            this.btnActiverModif.Enabled = false;
        }
        public void btnEnregistrer_Click(object sender, EventArgs e)
        {
            DialogResult resultat;
            var nouvCompte = new Utilisateur();

            nouvCompte.NomUtilisateur = txtNomUtil.Text;
            nouvCompte.MotDePasse = txtMDP.Text;
            nouvCompte.Emp = Convert.ToInt32(txtIdEmp.Text);
            nouvCompte.DateModifMotPas = dateTimeModif.Value;
            nouvCompte.Expire = txtExpire.Text;
            nouvCompte.Premiere = txtPremiere.Text;
            nouvCompte.Role = GesComptes.GetIdRole(txtIdRole.Text);
            nouvCompte.UtilActif = txtActif.Text;

            if (!GesComptes.verifier(nouvCompte, ancienCompte))
            {
                MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                if ((txtNomUtil.TextLength > 40) || (txtNomUtil.TextLength < 1))
                {
                    MessageBox.Show("Veuillez remplir les champs correctement.", "Erreur", MessageBoxButtons.OK);
                }
                else
                {
                    resultat = MessageBox.Show("Voulez-vous vraiment Enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        GesComptes.enregistrer(nouvCompte, Idemp);
                        this.Close();
                    }
                }
            }
        }
        public void btnCopier_Click(object sender, EventArgs e)
        {
            var info = new string[] { txtNomUtil.Text, txtMDP.Text, txtPremiere.Text, txtExpire.Text, dateTimeModif.Value.ToString(), txtIdRole.Text, txtIdEmp.Text, txtActif.Text };

            var formOuvert = new frmDetComptes(info, Idemp);
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
