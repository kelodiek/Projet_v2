using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet;

namespace Projet
{
    public partial class frmDetEmp : frmDetail
    {
        public Employe empSelect { get; set; }
        private ctrlEmploye ctrlEm;

        //      Employe existant
        public frmDetEmp(Employe E)
        {
            InitializeComponent();
            ctrlEm = new ctrlEmploye(true);
            btnCopier.Visible = false;
            btnSupprimer.Visible = false;
            btnEnregistrer.Enabled = false;
            this.btnAnnuler.Location = new Point(784, 477);
            this.btnEnregistrer.Location = new Point(10, 477);
            this.btnActiverModif.Location = new Point(125, 477);
            this.btnSupprimer.Location = new Point(240, 477);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            chargeEmp(E);
            ChargeTypeTest();
        }

        //      Nouveau employe
        public frmDetEmp(string[] _nEmp)
        {
            InitializeComponent();
            ctrlEm = new ctrlEmploye(false);
            btnCopier.Visible = false;
            btnActiverModif.Visible = false;
            btnSupprimer.Visible = false;
            this.btnAnnuler.Location = new Point(784, 477);
            this.btnEnregistrer.Location = new Point(10, 477);
            this.btnActiverModif.Location = new Point(125, 477);
            this.btnSupprimer.Location = new Point(240, 477);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            ChargeTypeTest();
            ActiverModif();
            txtId.ReadOnly = false;
            txtId.Text = _nEmp[0];
            txtPrenom.Text = _nEmp[1];
            txtNom.Text = _nEmp[2];
            txtCourriel.Text = _nEmp[3];
            txtTelPrinc.Text = _nEmp[4];
            txtTelSec.Text = _nEmp[5];
            txtAdresPost.Text = _nEmp[6];
            dateEmbauche.Value = Convert.ToDateTime(_nEmp[7]);
            this.Tag = _nEmp;
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            ActiverModif();
        }

        private void ActiverModif()
        {
            txtPrenom.ReadOnly = false;
            txtNom.ReadOnly = false;
            txtCourriel.ReadOnly = false;
            txtTelPrinc.ReadOnly = false;
            txtTelSec.ReadOnly = false;
            txtAdresPost.ReadOnly = false;
            dateEmbauche.Enabled = true;
            txtCompetencePart.ReadOnly = false;
            txtCommentaire.ReadOnly = false;
            chkLstTypeTest.Enabled = true;
            btnActiverModif.Enabled = false;
            btnEnregistrer.Enabled = true;
        }

        private void ChargeTypeTest()
        {
            List<TypeTest> lstType = ctrlEm.chargeTypeT();
            chkLstTypeTest.Tag = lstType;
            foreach (TypeTest t in lstType)
            {
                chkLstTypeTest.Items.Add(t.nomTypeTest);
            }
            //      coche le test que l'utilisateur peu faire
            if (ctrlEm.etat == true)
            {
                foreach (TypeTest item in lstType)
                {
                    foreach (TypeTest i in empSelect.lstEmTypeTest)
                    {
                        if (item.codeTypeTest == i.codeTypeTest)
                            chkLstTypeTest.SetItemChecked(lstType.IndexOf(item), true);
                    }
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Employe enregistrement = new Employe();
            DialogResult resultEnr;
            int NoId;

            bool result = Int32.TryParse(txtId.Text, out NoId);
            if (result == false)
            {
                MessageBox.Show("Le code d'utilisateur est contient des valeur invalide (seulement des chiffres)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enregistrement.idEmp = Int32.Parse(txtId.Text.Trim());
            enregistrement.prenomEmp = txtPrenom.Text.Trim();
            enregistrement.nomEmp = txtNom.Text.Trim();
            enregistrement.courrielEmp = txtCourriel.Text.Trim();
            enregistrement.noTelPrincipal = txtTelPrinc.Text.Trim();
            enregistrement.noTelSecondaire = txtTelSec.Text.Trim();
            enregistrement.adressePostale = txtAdresPost.Text.Trim();
            enregistrement.dateEmbaucheEmp = dateEmbauche.Value;
            enregistrement.competenceParticuliere = txtCompetencePart.Text.Trim();
            enregistrement.statut = "A";
            enregistrement.commentaireEmp = txtCommentaire.Text.Trim();

            foreach (var item in chkLstTypeTest.CheckedItems)
            {
                enregistrement.lstEmTypeTest.Add((TypeTest)((List<TypeTest>)chkLstTypeTest.Tag).ElementAt(chkLstTypeTest.Items.IndexOf(item)));
            }

            if (ctrlEm.etat == true)
            {
                // modifier
                if (ctrlEm.verifier(enregistrement, this.Tag) == true)
                {
                    resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnr == DialogResult.Yes)
                    {
                        ctrlEm.modifier(enregistrement);
                        this.Tag = enregistrement;
                        this.Close();
                    }
                }
            }
            else
            {
                // ajouter
                if (ctrlEm.verifier(enregistrement, null) == true && ctrlEm.verifSemblable(enregistrement) == true)
                {
                    resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnr == DialogResult.Yes)
                    {
                        ctrlEm.ajouter(enregistrement);
                        empSelect = enregistrement;
                        this.Tag = "1";
                        this.Close();
                    }
                }
            }
        }

        private void chargeEmp(Employe _e)
        {
            txtId.Text = _e.idEmp.ToString();
            txtPrenom.Text = _e.prenomEmp;
            txtNom.Text = _e.nomEmp;
            txtCourriel.Text = _e.courrielEmp;
            txtTelPrinc.Text = _e.noTelPrincipal;
            txtTelSec.Text = _e.noTelSecondaire;
            txtAdresPost.Text = _e.adressePostale;
            dateEmbauche.Value = _e.dateEmbaucheEmp;
            txtCompetencePart.Text = _e.competenceParticuliere;
            txtCommentaire.Text = _e.commentaireEmp;
            empSelect = _e;
            this.Tag = _e;
        }
    }
}
