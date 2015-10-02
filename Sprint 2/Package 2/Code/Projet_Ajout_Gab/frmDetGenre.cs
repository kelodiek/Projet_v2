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
        private ctrlGenre ctrlGen;
        public bool annuler { get; set; }

        public frmDetGenre()
        {
            InitializeComponent();
            ctrlGen = new ctrlGenre();
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
            frmCop.Tag = "Copie";
            frmCop.remplirChamp();
            frmCop.btnCopier.Enabled = false;
            frmCop.btnSupprimer.Enabled = false;
            frmCop.btnActiverModif.Enabled = false;
            frmCop.txtNom.ReadOnly = false;
            frmCop.rtxtCom.ReadOnly = false;
            frmCop.ShowDialog();
            if (frmCop.annuler == false)
            {
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
                if (genreSelect != null && ((string)Tag) != "Copie")
                {
                    resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnr == DialogResult.Yes)
                    {
                        enregistrement.idGenre = Int32.Parse(txtId.Text.Trim());
                        ctrlGen.modifier(enregistrement);
                        this.Close();
                    }
                }
                else
                {
                    if (ctrlGen.verifSemblable(enregistrement, genreSelect) == true)
                    {
                        resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer?", "Enregistrement", MessageBoxButtons.YesNo);
                        if (resultEnr == DialogResult.Yes)
                        {
                            ctrlGen.ajouter(enregistrement);
                            annuler = false;
                            this.Close();
                        }
                    }
                }
            }
        }

        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
                genreSelect = null;
            }
            else
            {
                this.rtxtCom.ReadOnly = true;
                this.txtId.ReadOnly = true;
                this.txtNom.ReadOnly = true;
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
            ((Button)sender).Enabled = false;
        }
    }
}
