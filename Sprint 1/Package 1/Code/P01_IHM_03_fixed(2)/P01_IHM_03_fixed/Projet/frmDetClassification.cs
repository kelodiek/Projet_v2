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
    public partial class frmDetClassification : frmDetail
    {
        ControleClassification cc;
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
            btnActiverModif.Click += new EventHandler(btnActiverModif_Click);
            cc = new ControleClassification();
        }

        public void modifierChamp(string cote, string nom, string desc)
        {
            this.txtCote.ReadOnly = true;
            this.txtDescription.ReadOnly = true;
            this.txtNom.ReadOnly = true;
            txtCote.Text = cote;
            txtNom.Text = nom;
            txtDescription.Text = desc;
            this.btnEnregistrer.Enabled = false;
        }

        public void modifierChamp()
        {          
            this.btnActiverModif.Enabled = false;
            this.btnSupprimer.Enabled = false;
        }

        //Pas encore lié dans le constructeur
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            txtCote.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtNom.ReadOnly = false;
        }

    }
}
