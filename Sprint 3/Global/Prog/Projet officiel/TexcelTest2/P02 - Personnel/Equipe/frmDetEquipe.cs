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
    public partial class frmDetEquipe : frmDetail
    {
        equipe load = new equipe();

        //        NomTest
        Dictionary<string, tblTypeTest> dicTypeTest;
        private List<tblEmploye> lstEmployeEquipe;
        private tblEquipe equipeAModifier;
        frmGesEquipe frmGes;
        bool ModifEnabled;
        private int lvlAcces;

        //      avec authentification **
        public frmDetEquipe(frmGesEquipe frm)
        {
            InitializeComponent();
            lvlAcces = frm.lvlAcces;//      **
            frmGes = frm;
            inifrmDetEquipe();
            btnSupprimer.Enabled = false;

            remplirChefEquipe();
            remplirEmploye();
            remplirTypeTest();
            remplirProjet();
            checkLvlAcces();//      **
        }

        public frmDetEquipe(frmGesEquipe frm, tblEquipe equipeSelect)
        {
            InitializeComponent();
            frmGes = frm;
            inifrmDetEquipe();
            equipeAModifier = equipeSelect;
            lvlAcces = frm.lvlAcces;//      **

            ModifEnabled = false;
            btnActiverModif.Enabled = true;

            foreach (var item in equipeSelect.tblEmploye1)
            {
                TreeNode tmp = new TreeNode();
                tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                tmp.Tag = item;
                lstTreeSelectEmploye.Nodes.Add(tmp);
                lstEmployeEquipe.Add(item);
            }

            foreach (var item in equipeSelect.tblTypeTest)
            {
                TreeNode tmp = new TreeNode();
                tmp.Text = item.NomTypeTest;
                tmp.Tag = item;
                lstTreeSelectTest.Nodes.Add(tmp);
            }



            rTxtCommentaire.Text = equipeSelect.CommentaireEquipe;

            remplirChefEquipe();
            remplirEmploye();
            remplirTypeTest();
            remplirProjet();

            tblEmploye cheftmp = rEquipeSQL.getChefEquipe(equipeSelect.IdChefEquipe);
            cboxChefEquipe.Text = cheftmp.PrenomEmp + " " + cheftmp.NomEmp;
            cboxProjet.Text = equipeSelect.CodeProjet;
            txtNomEquipe.Text = equipeSelect.NomEquipe;

            btnAjoutEmploye.Enabled = false;
            btnAjoutTypeTest.Enabled = false;
            btnEnregistrer.Enabled = false;
            btnRetirerEmploye.Enabled = false;
            btnRetirerTypeTest.Enabled = false;
            cboxChefEquipe.Enabled = false;
            cboxProjet.Enabled = false;
            txtNomEquipe.Enabled = false;
            rTxtCommentaire.Enabled = false;
            checkLvlAcces();//      **
        }

        private void inifrmDetEquipe()
        {

            this.btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(1260, 670);
            this.btnSupprimer.Location = new Point(240, 670);
            this.btnActiverModif.Location = new Point(125, 670);
            this.btnEnregistrer.Location = new Point(10, 670);

            dicTypeTest = new Dictionary<string, tblTypeTest>();
            lstEmployeEquipe = new List<tblEmploye>();
            ModifEnabled = false;

            load.loadBaseDonnee();

            btnAjoutTypeTest.Click += new EventHandler(btnAjoutTypeTest_Click);
            btnRetirerTypeTest.Click += new EventHandler(btnRetirerTypeTest_Click);

            btnAjoutEmploye.Click += new EventHandler(btnAjoutEmploye_Click);
            btnRetirerEmploye.Click += new EventHandler(btnRetirerEmploye_Click);

            btnEnregistrer.Click += new EventHandler(Enregistrer_Click);
            btnActiverModif.Click += new EventHandler(Modifier_Click);

            btnSupprimer.Click += new EventHandler(Suprimer_Click);

            cboxFiltre.SelectedIndexChanged += new EventHandler(cBoxFiltreTest_Change);
        }

        private void btnAjoutTypeTest_Click(object sender, EventArgs e)
        {
            if (lstTreeTypeTest.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeTypeTest.SelectedNode.Text);
                n.Tag = lstTreeTypeTest.SelectedNode.Tag;
                lstTreeSelectTest.Nodes.Add(n);
                lstTreeTypeTest.SelectedNode.Remove();
            }
        }

        private void btnRetirerTypeTest_Click(object sender, EventArgs e)
        {
            if (lstTreeSelectTest.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeSelectTest.SelectedNode.Text);
                n.Tag = lstTreeSelectTest.SelectedNode.Tag;
                lstTreeTypeTest.Nodes.Add(n);
                lstTreeSelectTest.SelectedNode.Remove();
            }
        }

        private void btnAjoutEmploye_Click(object sender, EventArgs e)
        {
            if (lstTreeEmploye.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeEmploye.SelectedNode.Text);
                n.Tag = lstTreeEmploye.SelectedNode.Tag;
                lstTreeSelectEmploye.Nodes.Add(n);

                tblEmploye tmp = (tblEmploye)n.Tag;

                lstEmployeEquipe.Add(tmp);
                lstTreeEmploye.SelectedNode.Remove();
            }

        }

        private void btnRetirerEmploye_Click(object sender, EventArgs e)
        {
            if (lstTreeSelectEmploye.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeSelectEmploye.SelectedNode.Text);
                n.Tag = lstTreeSelectEmploye.SelectedNode.Tag;
                lstTreeEmploye.Nodes.Add(n);
                lstEmployeEquipe.Remove((tblEmploye)n.Tag);
                lstTreeSelectEmploye.SelectedNode.Remove();
            }
        }

        //Pas Ideal aucune maniere de savoir si l'employe est deja dans l'équipe
        private void cBoxFiltreTest_Change(object sender, EventArgs e)
        {
            lstTreeEmploye.Nodes.Clear();
            List<tblEmploye> lstFinale = new List<tblEmploye>();

            if (cboxFiltre.Text != "Aucun")
            {
                foreach (var item in dicTypeTest[cboxFiltre.Text].tblEmploye)
                {
                    lstFinale.Add(item);
                }
                remplirEmploye(lstFinale);
            }
            else
            {
                remplirEmploye();
            }
        }

        private void remplirChefEquipe()
        {
            try
            {
                foreach (var item in load.lstChefEquipe)
                {
                    cboxChefEquipe.Items.Add(item.PrenomEmp + " " + item.NomEmp);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void remplirProjet()
        {
            try
            {
                foreach (var item in load.lstProjet)
                {
                    cboxProjet.Items.Add(item.CodeProjet);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void remplirEmploye()
        {
            try
            {
                foreach (tblEmploye item in load.lstEmploye)
                {
                    if (lstEmployeEquipe.Count != 0)
                    {
                        bool employExiste = false; ;
                        foreach (TreeNode tn in lstTreeSelectEmploye.Nodes)
                        {
                            if (((tblEmploye)(tn.Tag)).IdEmp == item.IdEmp)
                            {
                                employExiste = true;
                            }
                        }
                        if (employExiste == false)
                        {
                            TreeNode tmp = new TreeNode();
                            tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                            tmp.Tag = item;
                            lstTreeEmploye.Nodes.Add(tmp);
                        }
                        //foreach (tblEmploye dejaEmploy in lstEmployeEquipe)
                        //{
                        //    // multiply quand plusieurs dans lstempSelect en a + que 1
                        //     if (item.IdEmp == dejaEmploy.IdEmp)
                        //     {
                        //         TreeNode tmp = new TreeNode();
                        //         tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                        //         tmp.Tag = item;
                        //         lstTreeEmploye.Nodes.Add(tmp);
                        //     }
                        //}

                    }
                    else
                    {
                        TreeNode tmp = new TreeNode();
                        tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                        tmp.Tag = item;
                        lstTreeEmploye.Nodes.Add(tmp);
                    }

                }

            }

            catch (Exception)
            {
                //La liste est vide
            }

        }

        private void remplirEmploye(List<tblEmploye> r)
        {
            try
            {
                foreach (tblEmploye item in r)
                {
                    if (lstEmployeEquipe.Count != 0)
                    {
                        bool employExiste = false; ;
                        foreach (TreeNode tn in lstTreeSelectEmploye.Nodes)
                        {
                            if (((tblEmploye)(tn.Tag)).IdEmp == item.IdEmp)
                            {
                                employExiste = true;
                            }
                        }
                        if (employExiste == false)
                        {
                            TreeNode tmp = new TreeNode();
                            tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                            tmp.Tag = item;
                            lstTreeEmploye.Nodes.Add(tmp);
                        }


                    }
                    else
                    {
                        TreeNode tmp = new TreeNode();
                        tmp.Text = item.PrenomEmp + " " + item.NomEmp;
                        tmp.Tag = item;
                        lstTreeEmploye.Nodes.Add(tmp);
                    }

                }

            }

            catch (Exception)
            {
                //La liste est vide
            }

        }


        private void remplirTypeTest()
        {
            cboxFiltre.Items.Add("Aucun");
            bool testExist = false;
            try
            {
                foreach (tblTypeTest item in load.lstTypeTest)
                {
                    testExist = false;
                    foreach (TreeNode tn in lstTreeSelectTest.Nodes)
                    {
                        if (((tblTypeTest)(tn.Tag)).CodeTypeTest == item.CodeTypeTest)
                        {
                            testExist = true;
                        }
                    }
                    if (testExist == false)
                    {
                        TreeNode tmp = new TreeNode();
                        tmp.Text = item.NomTypeTest;
                        tmp.Tag = item;
                        lstTreeTypeTest.Nodes.Add(tmp);
                    }

                    //TreeNode tmp = new TreeNode();
                    //tmp.Text = item.NomTypeTest;
                    //tmp.Tag = item;

                    cboxFiltre.Items.Add(item.NomTypeTest);
                    //Ajouter au dictionnaire typeTest
                    dicTypeTest.Add(item.NomTypeTest, item);
                    //lstTreeTypeTest.Nodes.Add(tmp);
                }
            }
            catch (Exception)
            {
                //La liste est vide

            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sur de vouloir enregistrer?", "Enregistrer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Enregistrer();
            }
        }

        private void Enregistrer()
        {
            try
            {
                //List<tblEmploye> lstEmploye = new List<tblEmploye>();
                tblEmploye tmpEmp = new tblEmploye();

                List<tblTypeTest> lstTypeTest = new List<tblTypeTest>();

                tblEquipe tmpequipe = new tblEquipe();
                string stringChef;
                AllChefEquipe ChefEquipe = new AllChefEquipe();


                stringChef = cboxChefEquipe.SelectedItem.ToString();

                ChefEquipe = rEquipeSQL.getUNChefEquipe(stringChef);


                tmpequipe.IdChefEquipe = ChefEquipe.IdEmp;
                tmpequipe.NomEquipe = txtNomEquipe.Text;
                tmpequipe.CommentaireEquipe = rTxtCommentaire.Text;
                tmpequipe.CodeProjet = cboxProjet.Text;


                foreach (TreeNode item in lstTreeSelectEmploye.Nodes)
                {
                    tmpEmp = (tblEmploye)item.Tag;
                    tmpequipe.tblEmploye1.Add(tmpEmp);
                }

                foreach (TreeNode item in lstTreeSelectTest.Nodes)
                {
                    tblTypeTest tmpTest = new tblTypeTest();
                    tmpTest = (tblTypeTest)item.Tag;
                    tmpequipe.tblTypeTest.Add(tmpTest);
                }

                int noEquipe;

                if (ModifEnabled == false)
                {
                    tmpequipe.Statut = "A";
                    noEquipe = rEquipeSQL.addEquipe(tmpequipe);
                }
                else
                {
                    noEquipe = equipeAModifier.IdEquipe;
                    tmpequipe.IdEquipe = noEquipe;
                    tmpequipe.Statut = equipeAModifier.Statut;
                    noEquipe = rEquipeSQL.setEquipe(tmpequipe);
                }

                frmGes.afficherDonnees(noEquipe);
                this.Close();

            }

            catch (Exception)
            {
                MessageBox.Show("Il y a eu une erreur lors de l'enregistrement, S.V.P. vérifier que les champs suivant sont bien remplit : Projet, NomEquipe et Chef d'équipe.");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

            ModifEnabled = true;

            btnAjoutEmploye.Enabled = true;
            btnAjoutTypeTest.Enabled = true;
            btnEnregistrer.Enabled = true;
            btnRetirerEmploye.Enabled = true;
            btnRetirerTypeTest.Enabled = true;
            cboxChefEquipe.Enabled = true;
            cboxProjet.Enabled = true;
            txtNomEquipe.Enabled = true;
            rTxtCommentaire.Enabled = true;

        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sur de vouloir effacer l'equipe " + equipeAModifier.NomEquipe + "?", "Effacer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                equipeAModifier.Statut = "D";
                ModifEnabled = true;
                Enregistrer();
            }

            if (frmGes.gridEquipe.Rows.Count != 0)
            {
                frmGes.gridEquipe.CurrentCell = frmGes.gridEquipe.Rows[0].Cells[0];
                frmGes.gridEquipe.Rows[0].Selected = true;
            }
            this.Close();
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
