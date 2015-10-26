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
        public string statut;
        public bool annuler { get; set; }

        public frmDetMode()
        {
            InitializeComponent();
            ctrlMo = new ctrlMode();
            ctrlMo.charger();
            this.PositionBtn(260);
            this.txtNom.ReadOnly = false;
            this.rtxtDesc.ReadOnly = false;
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            annuler = true;
        }

        public frmDetMode(Mode M)
        {
            InitializeComponent();
            modeSelect = M;
            ctrlMo = new ctrlMode();
            ctrlMo.charger();
            ctrlMo.Statut = false;
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
            frmCop.remplirChamp();
            frmCop.btnCopier.Enabled = false;
            frmCop.btnSupprimer.Enabled = false;
            frmCop.btnActiverModif.Enabled = false;
            frmCop.txtNom.ReadOnly = false;
            frmCop.rtxtDesc.ReadOnly = false;
            frmCop.statut = "Copie";
            frmCop.ShowDialog();
            if (frmCop.annuler == false)
            {
                this.Tag = frmCop.Tag;
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
                this.Tag = "0";
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

            if (resultVerif)
            {
                resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                if (modeSelect != null && (statut) != "Copie")
                {
                    if (resultEnr == DialogResult.Yes)
                    {
                        enregistrement.idMode = Int32.Parse(txtID.Text.Trim());
                        ctrlMo.modifier(enregistrement);
                        this.Tag = enregistrement.nomMode;
                        this.Close();
                    }
                }
                else
                {
                    if (resultEnr == DialogResult.Yes)
                    {
                        ctrlMo.ajouter(enregistrement);
                        annuler = false;
                        this.Tag = enregistrement.nomMode;
                        this.Close();
                    }
                }
            }
        }

        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
                this.btnSupprimer.Visible = false;
                this.btnCopier.Visible = false;
                ctrlMo.Statut = false;
                modeSelect = null;
            }
            else
            {
                this.txtID.ReadOnly = true;
                this.rtxtDesc.ReadOnly = true;
                this.txtNom.ReadOnly = true;
                this.btnEnregistrer.Enabled = false;
                remplirChamp();
            }
        }

        private void remplirChamp()
        {
            txtID.Text = modeSelect.idMode.ToString();
            txtNom.Text = modeSelect.nomMode;
            rtxtDesc.Text = modeSelect.descMode;
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            this.txtNom.ReadOnly = false;
            this.rtxtDesc.ReadOnly = false;
            this.btnEnregistrer.Enabled = true;
            ((Button)sender).Enabled = false;
        }
    }
}
