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
    public partial class frmDetGroupeUser : frmDetail
    {
        private ctrlGroupeUser gestionGroupe;
        private GroupeUtil groupeSelect;
        private bool statut;
        private int lvlAcces;

        //                  Avec authentification
        //          Ajout tout vide
        public frmDetGroupeUser(int lvla)
        {
            InitializeComponent();
            statut = false;
            lvlAcces = lvla;
            chargeDet();
            gestionGroupe.chargeDr(tvLstDr, tvGroupDr, null);
        }

        //          Modif d'un existant ou copie ?    true modif    false copie   si copie enregistré change en true
        public frmDetGroupeUser(GroupeUtil _group, bool st, int lvla)
        {
            InitializeComponent();
            statut = st;
            lvlAcces = lvla;
            chargeDet();
            loadGroupe(_group);
            gestionGroupe.chargeDr(tvLstDr, tvGroupDr, _group);
        }

        private void chargeDet()
        {
            gestionGroupe = new ctrlGroupeUser();
            this.btnCopier.Location = new Point(850, 12);
            this.PositionBtn(350);
            //this.btnAnnuler.Location = new Point(315, 280);
            //this.btnEnregistrer.Location = new Point(10, 280);
            //this.btnActiverModif.Location = new Point(100, 280);
            //this.btnSupprimer.Location = new Point(190, 280);

            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnActiverModif.Click += new EventHandler(btnActiverModif_Click);

            this.Text = "Texel : Détail - Groupe d'utilisateur";

            if (statut == true)
            {
                btnEnregistrer.Enabled = false;
            }
            else
            {
                btnCopier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnActiverModif.Enabled = false;
                txtNom.ReadOnly = false;
                btnAddDr.Enabled = true;
                btnDeletDr.Enabled = true;
                tvLstDr.Enabled = true;
                tvGroupDr.Enabled = true;
            }
            checkLvlAcces();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            txtNom.ReadOnly = false;
            btnAddDr.Enabled = true;
            btnDeletDr.Enabled = true;
            tvLstDr.Enabled = true;
            tvGroupDr.Enabled = true;
            btnEnregistrer.Enabled = true;
            btnActiverModif.Enabled = false;
        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            frmDetGroupeUser frmCop;
            GroupeUtil cop = groupeSelect;
            cop.idGroupe = 0;

            frmCop = new frmDetGroupeUser(cop, false, lvlAcces);
            frmCop.ShowDialog();
            if (frmCop.statut == true)
            {
                this.Tag = frmCop.Tag;
                this.Close();
            }
            frmCop.Closed += (s, args) => this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult resultEnrg = MessageBox.Show("Voulez-vous vraiment supprimer ce groupe ?\n Ce groupe ne sera plus jamais disponible \n Id : " + txtId.Text + "\n Nom : " + txtNom.Text, "Suppression", MessageBoxButtons.YesNo);
            if (resultEnrg == DialogResult.Yes)
            {
                gestionGroupe.supprimer(groupeSelect);
                this.Tag = "0";
                this.Close();
            }   
        }

        //      si copie enregistre réussit, change statut à true
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            GroupeUtil enregistrement = new GroupeUtil();
            bool resultVerif;
            DialogResult resultEnr;

            enregistrement.nomGroupe = txtNom.Text;
            foreach (TreeNode item in tvGroupDr.Nodes)
            {
                enregistrement.lstGroupeDroit.Add((Droit)item.Tag);
            }

            resultVerif = gestionGroupe.verifier(enregistrement, groupeSelect);

            if (resultVerif == true)
            {
                resultEnr = MessageBox.Show("Voulez-vous vraiment enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo);
                if (resultEnr == DialogResult.Yes)
                {
                    if (this.Tag.ToString() != "0" && statut != false) //   modification
                    {
                        foreach (Utilisateur uti in groupeSelect.lstGroupeUser)
                        {
                            enregistrement.lstGroupeUser.Add(uti);
                        }
                        enregistrement.idGroupe = Int32.Parse(txtId.Text.Trim());
                        gestionGroupe.modifier(enregistrement);
                        this.Tag = enregistrement;
                        this.Close();
                    }
                    else  //        ajout
                    {
                        gestionGroupe.ajouter(enregistrement);
                        statut = true;
                        this.Tag = enregistrement;
                        this.Close();
                    }
                }
            }
        }

        private void btnAddDr_Click(object sender, EventArgs e)
        {
            if (tvLstDr.SelectedNode != null)
            {
                TreeNode tmp = new TreeNode(tvLstDr.SelectedNode.Text);
                tmp.Name = tvLstDr.SelectedNode.Name;
                tmp.Tag = tvLstDr.SelectedNode.Tag;
                tvGroupDr.Nodes.Add(tmp);
                tvLstDr.SelectedNode.Remove();
            }
        }

        private void btnDeletDr_Click(object sender, EventArgs e)
        {
            if (tvGroupDr.SelectedNode != null)
            {
                TreeNode tmp = new TreeNode(tvGroupDr.SelectedNode.Text);
                tmp.Name = tvGroupDr.SelectedNode.Text;
                tmp.Tag = tvGroupDr.SelectedNode.Tag;
                tvLstDr.Nodes.Add(tmp);
                tvGroupDr.SelectedNode.Remove();
            }
        }

        private void loadGroupe(GroupeUtil _gu)
        {
            this.Tag = _gu;
            groupeSelect = _gu;
            txtId.Text = _gu.idGroupe.ToString();
            txtNom.Text = _gu.nomGroupe;
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
