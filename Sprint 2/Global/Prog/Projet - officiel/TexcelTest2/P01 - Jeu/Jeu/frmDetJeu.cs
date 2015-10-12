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

            //Mettre en ReadOnly
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
            //A changer pour le nom du genre
            cboxGenre.Text = jeu.idGenre.ToString();
            this.cboxMode.Enabled = false;
            //A changer pour le nom du mode
            cboxMode.Text = jeu.idMode.ToString();

            this.rtxtInfoSup.ReadOnly = true;
            rtxtInfoSup.Text = jeu.infoSupJeu;

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

            foreach (var t in RequeteSql.getAllTheme())
            {
                TreeNode tn = tvAllTheme.Nodes.Add(t.NomTheme);
                tn.Tag = t.IdTheme;
            }
            foreach (var p in RequeteSql.getPlateforme())
            {
                TreeNode tn = tvAllPlateforme.Nodes.Add(p.NomPlateforme);
                tn.Tag = p.IdPlateforme;
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

                foreach (var item in tvSelectTheme.Nodes)
                {
                    Theme temp = new Theme();
                    temp.idTheme = Convert.ToInt32(((TreeNode)item).Tag);
                    temp.nomTheme = ((TreeNode)item).Text;
                    foreach (var t in RequeteSql.srchTheme(temp.nomTheme))
                    {
                        temp.comTheme = t.ComTheme;
                    }
                    lstTheme.Add(temp);
                }

                foreach (var item in tvSelectPlateforme.Nodes)
                {
                    plateforme temp = new plateforme();
                    //string chaine =  + "%%" + (((TreeNode)item).Text);
                    foreach (var p in RequeteSql.srchPlateforme(((((TreeNode)item).Tag).ToString())))
                    {
                        if (p.NomPlateforme == ((TreeNode)item).Text)
                        {
                            temp = new plateforme(p);
                        }              
                    }
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
