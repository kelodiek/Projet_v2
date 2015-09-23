using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexcelTest2
{
    public partial class frmGestClassification : frmGestion
    {
        ControleClassification cc;
        public frmGestClassification()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(btnAjoutClass_Click);
            this.btnDetails.Click += new EventHandler(btnDetailsClass_Click);
            ButtonsVisible(true);
            cc = new ControleClassification();
            chargerColones();
            afficherDonnees();   
        }

        private void chargerColones()
        {
            DataGridViewColumn column;
            GridClassification.Columns.Add("CoteESRB", "Cote");
            GridClassification.Columns.Add("NomESRB", "Nom");
            GridClassification.Columns.Add("DescESRB", "Description");

            DataGridViewRow row = GridClassification.Rows[0];
            row.Height = 30;

            column = GridClassification.Columns[0];
            column.Width = 100;
            column = GridClassification.Columns[1];
            column.Width = 300;
            column = GridClassification.Columns[2];
            column.Width = 300;
        }

        private void afficherDonnees()
        {
            foreach (Classification c in cc.chargerDonnees())
            {
                string[] tabTemp = new string[3]{c.coteESRB, c.nomESRB, c.descESRB};
                GridClassification.Rows.Add(tabTemp);           
            }
        }

        private void btnAjoutClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

            frmDetails.modifierChamp("a");
            frmDetails.btnCopier.Enabled = false;
            frmDetails.ShowDialog();
        }
        private void btnDetailsClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }
    }
}
