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
    public partial class frmDetGenre : frmDetail
    {
        public Genre genreSelect { get; set; }
        public string statut;
        private ctrlGenre ctrlGen;
        public bool annuler { get; set; }

        public frmDetGenre()
        {
            InitializeComponent();
            ctrlGen = new ctrlGenre();
            ctrlGen.charger();
            this.PositionBtn(260);
            this.txtNom.ReadOnly = false;
            this.rtxtCom.ReadOnly = false;
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            annuler = true;
        }

        public frmDetGenre(Genre G)
        {
            InitializeComponent();
            genreSelect = G;
            ctrlGen = new ctrlGenre();
            ctrlGen.charger();
            ctrlGen.Statut = false;
            this.PositionBtn(260);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            
            annuler = true;
        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            Genre cop = new Genre();
            frmDetGenre frmCop;

            cop.nomGenre = txtNom.Text;
            cop.comGenre = rtxtCom.Text;

            frmCop = new frmDetGenre(cop);
            frmCop.remplirChamp();
            frmCop.btnCopier.Enabled = false;
            frmCop.btnSupprimer.Enabled = false;
            frmCop.btnActiverModif.Enabled = false;
            frmCop.txtNom.ReadOnly = false;
            frmCop.rtxtCom.ReadOnly = false;
            frmCop.statut = "Copie";
            frmCop.ShowDialog();
            if (frmCop.annuler == false)
            {
                this.Tag = frmCop.Tag;
                this.Close();
            }
            frmCop.Closed += (s, args) => this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                ctrlGen.supprimer(txtId.Text);
                this.Tag = "0";
                this.Close();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Genre enregistrement = new Genre();
            bool resultVerif;
            DialogResult resultEnr;

            enregistrement.nomGenre = txtNom.Text.Trim();
            enregistrement.comGenre = rtxtCom.Text.Trim();

            resultVerif = ctrlGen.verifier(enregistrement, genreSelect);

            if (resultVerif)
            {
                resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                if (genreSelect != null && statut != "Copie")
                {
                    if (resultEnr == DialogResult.Yes)
                    {
                        enregistrement.idGenre = Int32.Parse(txtId.Text.Trim());
                        ctrlGen.modifier(enregistrement);
                        this.Tag = enregistrement.nomGenre;
                        this.Close();
                    }
                }
                else
                {
                    if (resultEnr == DialogResult.Yes)
                    {
                        ctrlGen.ajouter(enregistrement);
                        annuler = false;
                        this.Tag = enregistrement.nomGenre;
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
                ctrlGen.Statut = false;
                genreSelect = null;
            }
            else
            {
                this.rtxtCom.ReadOnly = true;
                this.txtId.ReadOnly = true;
                this.txtNom.ReadOnly = true;
                this.btnEnregistrer.Enabled = false;
                remplirChamp();
            }
        }

        private void remplirChamp()
        {
            txtId.Text = genreSelect.idGenre.ToString();
            txtNom.Text = genreSelect.nomGenre;
            rtxtCom.Text = genreSelect.comGenre;
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            this.txtNom.ReadOnly = false;
            this.rtxtCom.ReadOnly = false;
            this.btnEnregistrer.Enabled = true;
            ((Button)sender).Enabled = false;
        }
    }
}
