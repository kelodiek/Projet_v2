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
    public partial class frmDetTheme : frmDetail
    {
        public Theme themeSelect { get; set; }
        private ctrlTheme ctrltheme;

        public frmDetTheme()
        {
            InitializeComponent();
            this.PositionBtn(140);
            ctrltheme = new ctrlTheme();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModification_Click);
            this.txtId.Enabled = false;
        }
        public frmDetTheme(Theme C)
        {
            themeSelect = C;
            InitializeComponent();
            this.PositionBtn(140);
            ctrltheme = new ctrlTheme();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModification_Click);
            this.txtId.Enabled = false;
        }
        public void btnActiverModification_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if((item == txtId) || (item == btnActiverModif))
                {
                    item.Enabled = false;
                }
                else
                {
                    item.Enabled = true;
                }
            }
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
                themeSelect = null;
            }
            else
            {
                btnEnregistrer.Enabled = false;
                this.txtNom.Enabled = false;
                this.txtCommentaire.Enabled = false;
                remplirChamp();
            }
        }

        private void remplirChamp()
        {
            txtId.Text = themeSelect.idTheme.ToString();
            txtNom.Text = themeSelect.nomTheme;
            txtCommentaire.Text = themeSelect.comTheme;
            this.txtId.Enabled = false;
        }
        public void enregistrer(object sender, EventArgs e)
        {
            Theme enregistrement = new Theme();
            bool resulVerif;
            DialogResult resultEnrg;

            if (txtId.Text.Trim() == "")
            {
                enregistrement.idTheme = CompterNb();
            }
            else
            {
                enregistrement.idTheme = Convert.ToInt32(txtId.Text.Trim());
            }
            enregistrement.nomTheme = txtNom.Text.Trim();
            enregistrement.comTheme = txtCommentaire.Text.Trim();

            resulVerif = ctrltheme.verifier(enregistrement, themeSelect);



            if (themeSelect != null && ((string)Tag) != "Copie")
            {

                if (resulVerif)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrltheme.modifier(enregistrement);
                        this.Close();
                        frmGestTheme frm = new frmGestTheme();
                        frm.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (txtNom.Text.Trim().Length != 0)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrltheme.ajouter(enregistrement);
                        this.Close();
                        frmGestTheme frm = new frmGestTheme();
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Une categorie avec ce code existe deja ou le code est trop court.", "Erreur", MessageBoxButtons.OK);
                }
            }

        }
        public int CompterNb()
        {
            List<string[]> lstTheme = new List<string[]>();
            int Cpt = 0;

            lstTheme = ctrltheme.charger();
            foreach (var item in lstTheme)
            {
                Cpt++;
            }
            return Cpt + 1;
        }
        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer?", "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                Theme t = new Theme();
                t.idTheme = Convert.ToInt32(txtId.Text);
                t.nomTheme = txtNom.Text;
                t.comTheme = txtCommentaire.Text;
                ctrltheme.supprimer(t);
                this.Close();
            }
        }
        private void btnCopier_Click(object sender, EventArgs e)
        {
            Theme info = new Theme();
            frmDetTheme formOuvert;

            info.idTheme = CompterNb();
            info.comTheme = txtCommentaire.Text;
            info.nomTheme = txtNom.Text;


            formOuvert = new frmDetTheme(info);
            formOuvert.Tag = "Copie";
            formOuvert.remplirChamp();
            formOuvert.btnCopier.Enabled = false;
            formOuvert.btnSupprimer.Enabled = false;
            formOuvert.btnActiverModif.Enabled = false;
            formOuvert.txtId.Text = "";
            formOuvert.ShowDialog();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }

       
    }
}
