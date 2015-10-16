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
    public partial class frmDetMode : frmDetail
    {
        public Mode modeSelect { get; set; }
        private ctrlMode ctrlMo;
        public bool annuler { get; set; }

        public frmDetMode()
        {
            InitializeComponent();
            ctrlMo = new ctrlMode();
            this.PositionBtn(260);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            annuler = true;
        }

        public frmDetMode(Mode M)
        {
            InitializeComponent();
            modeSelect = M;
            ctrlMo = new ctrlMode();
            this.PositionBtn(260);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            annuler = true;
        }

        public void btnCopier_Click(object sender, EventArgs e)
        {
            Mode cop = new Mode();
            frmDetMode frmCop;

            cop.nomMode = txtNom.Text;
            cop.descMode = rtxtDesc.Text;

            frmCop = new frmDetMode(cop);
            frmCop.Tag = "Copie";
            frmCop.remplirChamp();
            frmCop.btnCopier.Enabled = false;
            frmCop.btnSupprimer.Enabled = false;
            frmCop.btnActiverModif.Enabled = false;
            frmCop.ShowDialog();
            if (frmCop.annuler == false)
            {
                this.Close();
            }
            frmCop.Closed += (s, args) => this.Close();
            
        }

        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                ctrlMo.supprimer(txtID.Text);
                this.Close();
            }
        }

        public void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Mode enregistrement = new Mode();
            bool resultVerif;
            DialogResult resultEnr;

            enregistrement.nomMode = txtNom.Text.Trim();
            enregistrement.descMode = rtxtDesc.Text.Trim();

            resultVerif = ctrlMo.verifier(enregistrement, modeSelect);

            if (modeSelect != null && ((string)Tag) != "Copie")
            {
                if (resultVerif)
                {
                    resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnr == DialogResult.Yes)
                    {
                        ctrlMo.modifier(enregistrement);
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
                resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                if (resultEnr == DialogResult.Yes)
                {
                    ctrlMo.ajouter(enregistrement);
                    annuler = false;
                    this.Close();
                }
            }
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
                this.txtID.Enabled = false;
                modeSelect = null;
            }
            else
            {
                this.txtID.Enabled = false;           
                this.rtxtDesc.Enabled = false;
                this.txtNom.Enabled = false;
                remplirChamp();
            }
        }

        private void remplirChamp()
        {
            txtID.Text = modeSelect.idMode.ToString();
            txtNom.Text = modeSelect.nomMode;
            rtxtDesc.Text = modeSelect.descMode;
        }
    }
}
