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
    public partial class frmDetTypeTest : frmDetail
    {
        private ctrlTypeTest gestionTypeTest;
        public bool statut { get; set; }
        public TypeTest TypeSelect { get; set; }
        private int lvlAcces;

        //                      Avec authentification
        //      ajouter nouveau
        public frmDetTypeTest(int lvla)
        {
            InitializeComponent();
            statut = false;
            chargeDetail();
            lvlAcces = lvla;
            checkLvlAcces();
        }

        //      modifier, copier, supprimer     true = modif    false = copie   si copie enregistré change en true
        public frmDetTypeTest(TypeTest _t, bool _s, int lvla)
        {
            InitializeComponent();
            statut = _s;
            chargeDetail();
            chargeTypeTest(_t);
            lvlAcces = lvla;
            checkLvlAcces();
        }


        private void chargeDetail()
        {
            gestionTypeTest = new ctrlTypeTest();
            btnCopier.Location = new Point(717, 12);
            this.PositionBtn(460);

            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);

            if (statut == true)
                btnEnregistrer.Enabled = false;
            else
            {
                btnCopier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnActiverModif.Enabled = false;
                txtCode.ReadOnly = false;
                txtNomTest.ReadOnly = false;
                txtObjTest.ReadOnly = false;
                txtDescTest.ReadOnly = false;
                txtComTest.ReadOnly = false;
            }
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            //txtCode.ReadOnly = false;
            txtNomTest.ReadOnly = false;
            txtObjTest.ReadOnly = false;
            txtDescTest.ReadOnly = false;
            txtComTest.ReadOnly = false;
            btnActiverModif.Enabled = false;
            btnEnregistrer.Enabled = true;
        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            frmDetTypeTest frmCop;
            TypeTest cop = TypeSelect;
            cop.codeTypeTest = "";

            frmCop = new frmDetTypeTest(cop, false, lvlAcces);
            frmCop.ShowDialog();
            if (frmCop.statut == true)
            {
                TypeSelect = frmCop.TypeSelect;
                this.Close();
            }
            frmCop.Closed += (s, args) => this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer ce Type de test ? \n Ce type de test ne sera plus jamais disponible \n Code : " + txtCode.Text + "\n nom : " + txtNomTest.Text, "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                gestionTypeTest.supprimer(TypeSelect);
                statut = false;
                this.Close();
            }   
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TypeTest enregistrement = new TypeTest();
            DialogResult resultEnr;

            enregistrement.codeTypeTest = txtCode.Text;
            enregistrement.nomTypeTest = txtNomTest.Text;
            enregistrement.objectifTypeTest = txtObjTest.Text;
            enregistrement.descTypeTest = txtDescTest.Text;
            enregistrement.commentaireTypeTest = txtComTest.Text;

            resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultEnr == DialogResult.Yes && gestionTypeTest.veriflongueur(enregistrement) == true)
            {
                if (TypeSelect != null && statut == true)//     modif typeselect celui de base ; statut == true
                {
                    if (gestionTypeTest.verifier(enregistrement, TypeSelect) == true)
                    {
                        gestionTypeTest.modifier(enregistrement);
                        TypeSelect = enregistrement;
                        this.Close();
                    }
                }
                else // ajout nouveau ou copie
                {
                    if (gestionTypeTest.verifAjout(enregistrement) == true)
                    {
                        gestionTypeTest.ajouter(enregistrement);
                        statut = true;
                        TypeSelect = enregistrement;
                        this.Close();
                    }
                }
            }

        }

        private void chargeTypeTest(TypeTest _t)
        {
            TypeSelect = _t;
            txtCode.Text = _t.codeTypeTest;
            txtNomTest.Text = _t.nomTypeTest;
            txtObjTest.Text = _t.objectifTypeTest;
            txtDescTest.Text = _t.descTypeTest;
            txtComTest.Text = _t.commentaireTypeTest;
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
