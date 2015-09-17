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
    public partial class frmDetSysExp : frmDetail
    {
        public string[] copie { get; set; }
        public string[] infoSysExp { get; set; }

        public frmDetSysExp()
        {
            InitializeComponent();
            this.PositionBtn(315);
            this.btnActiverModif.Click += new EventHandler(activerModif);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
        }
        public frmDetSysExp(string[] info)
        {
            InitializeComponent();
            this.PositionBtn(315);
            this.btnActiverModif.Click += new EventHandler(activerModif);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            txtNom.Text = info[2];
            infoSysExp = info;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">"a" Ajout, "m" Modifier</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnSupprimer.Enabled = false;
                this.btnActiverModif.Enabled = false;
            }
            else
            {
                this.rtxtInfos.Enabled = false;
                this.txtID.Enabled = false;
                this.txtNom.Enabled = false;
                this.txtVersion.Enabled = false;
                this.txtEdition.Enabled = false;
                this.txtCode.Enabled = false;

                this.btnEnregistrer.Enabled = false;
                remplirChamp();
            }
        }
        private void remplirChamp()
        {
            txtID.Text = infoSysExp[0];
            txtCode.Text = infoSysExp[1];
            txtNom.Text = infoSysExp[2];
            txtEdition.Text = infoSysExp[3];
            txtVersion.Text = infoSysExp[4];
            rtxtInfos.Text = infoSysExp[5];
        }

        private void activerModif(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            this.btnActiverModif.Enabled = false;
            this.txtID.Enabled = false;
            this.btnSupprimer.Enabled = false;
        }
        public string[] enregistrer()
        {
            string[] nouvInfo;

            nouvInfo = new string[] { txtID.Text,txtCode.Text,txtNom.Text,txtEdition.Text,txtVersion.Text,rtxtInfos.Text};

            return nouvInfo;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Voulez-vous vraiment Enregistrer ?", "Enregistrement", MessageBoxButtons.YesNo);


            if (resultat == DialogResult.Yes)
            {
                string[] info;

                var nom = txtNom.Text.Trim();
                var code = txtCode.Text.Trim();
                var edit = txtEdition.Text.Trim();

                if (nom.Length == 0 || code.Length == 0 || edit.Length == 0)
                {
                    MessageBox.Show("Veuillez remplir les champs correctement.", "Erreur", MessageBoxButtons.OK);
                }
                else
                {
                    info = enregistrer();
                    if (txtID.Text.Length == 0)
                    {
                        RequeteSql.addSysExp(info);
                    }
                    else
                    {
                        RequeteSql.setSysExp(info);
                    }
                    this.Close();

                }
            }
            
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo);


            if (resultat == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtID.Text);

                RequeteSql.deleteSysExp(id);

                this.Close();
            }
            
        }
        private void btnCopier_Click(object sender, EventArgs e)
        {
            var info = new string[]{"",txtCode.Text,txtNom.Text,txtEdition.Text,txtVersion.Text,rtxtInfos.Text};

            var formOuvert = new frmDetSysExp(info);
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
