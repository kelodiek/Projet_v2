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
    partial class frmDetJeu : frmDetail
    {
        private string type;
        ctrlJeu cj;

        public frmDetJeu()
        {
            InitializeComponent();
            this.btnActiverModif.Visible = false;
            this.btnSupprimer.Visible = false;
            type = "ajout";
        }

        public frmDetJeu(Jeu jeu)
        {
            InitializeComponent();
            type = "modif";

            this.txtID.ReadOnly = true;
            txtID.Text = jeu.idJeu.ToString();
            this.txtNom.ReadOnly = true;
            txtNom.Text = jeu.nomJeu;
            this.txtDesc.ReadOnly = true;
            txtDesc.Text = jeu.descJeu;

            this.btnAjoutPlateforme.Enabled = false;
            this.btnRetirerPlateforme.Enabled = false;
            this.btnAjoutTheme.Enabled = false;
            this.btnRetirerTheme.Enabled = false;

            this.cboxCote.Enabled = false;
            this.cboxCote.Text = jeu.coteESRB;
            this.cboxGenre.Enabled = false;
            string nomGenre = "";
            if (jeu.idGenre != 0)
            {
                nomGenre = RequeteSql.rechercheGenre(jeu.idGenre.ToString()).First().NomGenre;
            }
            cboxGenre.Text = nomGenre;
            this.cboxMode.Enabled = false;
            string nomMode = "";
            if (jeu.idMode != 0)
            {
                nomMode = RequeteSql.rechercheMode(jeu.idMode.ToString()).First().NomMode;
            }
            cboxMode.Text = nomMode;
            this.rtxtInfoSup.ReadOnly = true;
            rtxtInfoSup.Text = jeu.infoSupJeu;

            foreach (Theme theme in jeu.lstTheme)
            {
                TreeNode tntemp = tvSelectTheme.Nodes.Add(theme.nomTheme);
                tntemp.Tag = theme;
            }

            foreach (plateforme plate in jeu.lstPlateforme)
            {
                TreeNode tntemp = tvSelectPlateforme.Nodes.Add(plate.nomPlate);
                tntemp.Tag = plate;
            }


            this.btnEnregistrer.Enabled = false;
            this.btnAjoutPlateforme.Enabled = false;
            this.btnAjoutTheme.Enabled = false;

            this.btnActiverModif.Enabled = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void frmDetJeu_Load(object sender, EventArgs e)
        {
            cj = new ctrlJeu();
            this.btnAnnuler.Location = new Point(955, 580);
            this.btnActiverModif.Location = new Point(this.btnActiverModif.Location.X, 580);
            this.btnEnregistrer.Location = new Point(this.btnEnregistrer.Location.X, 580);
            this.btnSupprimer.Location = new Point(this.btnSupprimer.Location.X, 580);
            this.btnCopier.Location = new Point(975, 10);
            this.btnAnnuler.Click += new EventHandler(btnAnnuler_Click);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);

            foreach (var t in RequeteSql.getAllTheme())
            {
                TreeNode tn = tvAllTheme.Nodes.Add(t.NomTheme);
                tn.Tag = t;
            }
            foreach (var p in RequeteSql.getPlateforme())
            {
                TreeNode tn = tvAllPlateforme.Nodes.Add(p.NomPlateforme);
                tn.Tag = p;
            }
            foreach (var g in RequeteSql.getAllGenre())
            {
                cboxGenre.Items.Add(g.NomGenre);
                
            }
            foreach (var m in RequeteSql.getAllMode())
            {
                cboxMode.Items.Add(m.NomMode);
            }
            foreach (var c in rClassificationSQL.getAllClassification())
            {
                cboxCote.Items.Add(c.CoteESRB);
            }
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            this.btnAjoutPlateforme.Enabled = true;
            this.btnAjoutTheme.Enabled = true;
            this.btnRetirerPlateforme.Enabled = true;
            this.btnRetirerTheme.Enabled = true;
            this.rtxtInfoSup.ReadOnly = false;
            this.txtNom.ReadOnly = false;
            this.txtNom.Enabled = true;
            this.txtDesc.ReadOnly = false;
            this.txtDesc.Enabled = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Voulez-vous vraiment supprimer ce jeu?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                try
                {
                    cj.supprimer(Convert.ToInt32(txtID.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Au moins une version est lié à ce jeu, il est donc impossible de le supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

#region btnTreeView
        private void btnAjoutTheme_Click(object sender, EventArgs e)
        {
            if (tvAllTheme.SelectedNode != null)
            {
                TreeNode n = new TreeNode(tvAllTheme.SelectedNode.Text);
                n.Tag = tvAllTheme.SelectedNode.Tag;
                tvSelectTheme.Nodes.Add(n);
                tvAllTheme.SelectedNode.Remove();
            }
        }

        private void btnRetirerTheme_Click(object sender, EventArgs e)
        {
            if (tvSelectTheme.SelectedNode != null)
            {
                TreeNode n = new TreeNode(tvSelectTheme.SelectedNode.Text);
                n.Tag = tvSelectTheme.SelectedNode.Tag;
                tvAllTheme.Nodes.Add(n);
                tvSelectTheme.SelectedNode.Remove();
            }
        }

        private void btnAjoutPlateforme_Click(object sender, EventArgs e)
        {
            if (tvAllPlateforme.SelectedNode != null)
            {
                TreeNode n = new TreeNode(tvAllPlateforme.SelectedNode.Text);
                n.Tag = tvAllPlateforme.SelectedNode.Tag;
                tvSelectPlateforme.Nodes.Add(n);
                tvAllPlateforme.SelectedNode.Remove();
            }
        }

        private void btnRetirerPlateforme_Click(object sender, EventArgs e)
        {
            if (tvSelectPlateforme.SelectedNode != null)
            {
                TreeNode n = new TreeNode(tvSelectPlateforme.SelectedNode.Text);
                n.Tag = tvSelectPlateforme.SelectedNode.Tag;
                tvAllPlateforme.Nodes.Add(n);
                tvSelectPlateforme.SelectedNode.Remove();
            }
        }
#endregion

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "modif":
                    //modifierJeu();
                    break;
                case "ajout":
                    ajout();
                    break;
                case "copie":
                    //enrgCopie();
                    break;
                default:
                    break;
            }
        }

        private void ajout()
        {
            DialogResult r;
            Jeu j = new Jeu();
            List<Theme> lstTheme = new List<Theme>();
            List<plateforme> lstPlateforme = new List<plateforme>();

            if (txtNom.Text.Trim().Length == 0 || txtDesc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Les champs obligatoires ne sont pas bien remplis",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tblJeu nouvJeu = new tblJeu();
                nouvJeu.NomJeu = txtNom.Text.Trim();
                nouvJeu.DescJeu = txtDesc.Text.Trim();
                nouvJeu.CoteESRB = cboxCote.Text.Trim();
                nouvJeu.InfoSupJeu = rtxtInfoSup.Text.Trim();
                nouvJeu.Actif = true;
                if (cboxGenre.Text != "")
                {
                    foreach (var g in RequeteSql.rechercheGenre(cboxGenre.Text))
                    {
                        nouvJeu.IdGenre = g.IdGenre;
                    }
                }
                if (cboxMode.Text != "")
                {
                    foreach (var g in RequeteSql.rechercheMode(cboxMode.Text))
                    {
                        nouvJeu.IdMode = g.IdMode;
                    }
                }

                foreach (TreeNode item in tvSelectTheme.Nodes)
                {
                    Theme temp = new Theme((tblTheme)item.Tag);
                    lstTheme.Add(temp);
                }

                foreach (TreeNode item in tvSelectPlateforme.Nodes)
                {
                    plateforme temp = new plateforme((tblPlateforme)item.Tag);
                    lstPlateforme.Add(temp);
                }

                j = new Jeu(nouvJeu);
                j.lstTheme = lstTheme;
                j.lstPlateforme = lstPlateforme;


                r = MessageBox.Show("Voulez-vous enregistrer?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    cj.ajouter(j);
                    this.Close();
                }
            }


        }
    }
}
