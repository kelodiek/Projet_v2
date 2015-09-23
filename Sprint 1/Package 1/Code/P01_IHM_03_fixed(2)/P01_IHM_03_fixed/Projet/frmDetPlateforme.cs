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
    public partial class frmDetPlateforme : frmDetail
    {
        private List<Categorie> lstCateg;
        private List<SystemeExploitation> lstSysExp;
        private plateforme selectPlate;

        public frmDetPlateforme()
        {
            InitializeComponent();

            loadList();

            ajusterForm();
        }
        public frmDetPlateforme(plateforme p)
        {
            InitializeComponent();

            selectPlate = p;

            loadList();

            loadDetail();
            ajusterForm();
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutSysExp_Click(object sender, EventArgs e)
        {
            if (lstTreeSysExp.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeSysExp.SelectedNode.Text);
                n.Tag = lstTreeSysExp.SelectedNode.Tag;
                lstTreeSelect.Nodes.Add(n);
                lstTreeSysExp.SelectedNode.Remove();
            }
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnSupprimer.Enabled = false;
                this.btnActiverModif.Enabled = false;
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
                this.btnActiverModif.Enabled = true;
                this.btnSupprimer.Enabled = true;
            }
            
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            foreach (Control item in groupBox1.Controls)
            {
                item.Enabled = true;
            }
            foreach (Control item in groupBox2.Controls)
            {
                item.Enabled = true;
            }
            foreach (Control item in groupBox3.Controls)
            {
                item.Enabled = true;
            }
            this.btnActiverModif.Enabled = false;
            this.txtID.Enabled = false;
        }
        private void ajusterForm()
        {
            this.btnCopier.Location = new Point(812, 12);
            this.PositionBtn(514);
            this.btnAnnuler.Location = new Point(797, 514);

            btnAnnuler.Click += new EventHandler(btnAnnuler_Click);
            btnActiverModif.Click += new EventHandler(btnModifier_Click);
        }
        private void loadDetail()
        {
            Categorie categSelect = new Categorie((RequeteSql.srchCategorie(selectPlate.codeCateg)).First());
            // Obligatoire
            this.txtID.Text = selectPlate.idPlate.ToString();
            this.txtCode.Text = selectPlate.codePlate;
            this.txtNom.Text = selectPlate.nomPlate;
            foreach (var item in cboxCateg.Items)
            {
                if (item == categSelect)
                {
                    cboxCateg.SelectedItem = item;
                }
            }
            // Facultatif
        }
        private void loadList()
        {
            TreeNode  item = new TreeNode();
            var sysExpBrut = RequeteSql.getSysExp();
            var categBrut = RequeteSql.getCategorie();

            foreach (var sysExp in sysExpBrut)
            {
                item = new TreeNode();
                item.Text = sysExp.CodeSysExp;
                item.Tag = new SystemeExploitation(sysExp);
                lstTreeSysExp.Nodes.Add(item);
            }

            foreach (var categ in categBrut)
            {
                cboxCateg.Items.Add(new Categorie(categ));
                cboxCateg.DisplayMember = "codeCateg";
            }
        }

        private void frmDetPlateforme_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAjout_Click(object sender, EventArgs e) 
        {
            var nouvPlat = new plateforme();
            var lstSysExp = new List<SystemeExploitation>();

            if (txtCode.Text.Trim().Length == 0 || txtNom.Text.Trim().Length == 0 || cboxCateg.SelectedItem == null)
            {
                //erreur
            }
            else
            {
                nouvPlat.codePlate = txtCode.Text.Trim();
                nouvPlat.nomPlate = txtNom.Text.Trim();
                nouvPlat.codeCateg = ((Categorie)cboxCateg.SelectedItem).codeCateg;
                nouvPlat.cpuPlate = txtCPU.Text.Trim();
                nouvPlat.carteMerePlate = txtCartemere.Text.Trim();
                nouvPlat.ramPlate = txtRam.Text.Trim();
                nouvPlat.stockage = txtStockage.Text.Trim();
                nouvPlat.infoSupPlate = rTxtInfoSup.Text.Trim();
                nouvPlat.descPlate = rTxtDesc.Text.Trim();

                foreach (var item in lstTreeSelect.Nodes)
                {
                    lstSysExp.Add(((SystemeExploitation)((TreeNode)item).Tag));
                }

                nouvPlat.lstSysExpPlate = lstSysExp;
            }
        }

        private void btnRetirerSysExp_Click(object sender, EventArgs e)
        {
            if (lstTreeSelect.SelectedNode != null)
            {
                TreeNode n = new TreeNode(lstTreeSelect.SelectedNode.Text);
                n.Tag = lstTreeSelect.SelectedNode.Tag;
                lstTreeSysExp.Nodes.Add(n);
                lstTreeSelect.SelectedNode.Remove();
            }
        }

    }
}
