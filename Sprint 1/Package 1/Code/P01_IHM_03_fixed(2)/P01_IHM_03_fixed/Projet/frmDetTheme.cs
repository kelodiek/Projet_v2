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
            this.PositionBtn(194);
            ctrltheme = new ctrlTheme();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
        }
        public frmDetTheme(Theme C)
        {
            themeSelect = C;
            InitializeComponent();
            this.PositionBtn(194);
            ctrltheme = new ctrlTheme();
            this.btnEnregistrer.Click += new EventHandler(enregistrer);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
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
                this.txtNom.Enabled = false;
                this.txtId.Enabled = false;
                this.txtCommentaire.Enabled = false;
                remplirChamp();
            }
        }
        private void remplirChamp()
        {
            txtId.Text = themeSelect.idTheme.ToString();
            txtNom.Text = themeSelect.nomTheme;
            txtCommentaire.Text = themeSelect.comTheme;
        }
        public void enregistrer(object sender, EventArgs e)
        {
            Theme enregistrement = new Theme();
            bool resulVerif;
            DialogResult resultEnrg;

            enregistrement.idTheme = Convert.ToInt32(txtId.Text.Trim());
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
                    }

                }
                else
                {
                    MessageBox.Show("Aucune modification n'a été apportée.", "Erreur", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!ctrltheme.testExiste(enregistrement.nomTheme) && txtNom.Text.Trim().Length != 0)
                {
                    resultEnrg = MessageBox.Show("Voulez-vous vraiment enregister?", "Enregistrement", MessageBoxButtons.YesNo);
                    if (resultEnrg == DialogResult.Yes)
                    {
                        ctrltheme.ajouter(enregistrement);
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
                ctrltheme.supprimer(txtNom.Text);
                this.Close();
            }
        }
        private void btnCopier_Click(object sender, EventArgs e)
        {
            Theme info = new Theme();
            frmDetTheme formOuvert;

            info.comTheme = txtCommentaire.Text;
            info.nomTheme = txtNom.Text;


            formOuvert = new frmDetTheme(info);
            formOuvert.Tag = "Copie";
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
