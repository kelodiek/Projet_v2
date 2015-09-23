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
    public partial class frmGestClassification : frmGestion
    {
        public frmGestClassification()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(btnAjoutClass_Click);
            this.btnDetails.Click += new EventHandler(btnDetailsClass_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            ButtonsVisible(true);
<<<<<<< HEAD
            cc = new ControleClassification();
            chargerColones();
            chargerDonnees();   
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
            {
                GridClassification.Rows.Clear();
                foreach (Classification c in cc.rechercher(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { c.coteESRB, c.nomESRB, c.descESRB };
                    GridClassification.Rows.Add(tabTemp);
                }
            }
            else
            {
                //Message d'erreur de champ vide
                MessageBox.Show("YAY");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            chargerDonnees();
            txtRecherche.Text = "";
        }
        private void chargerColones()
=======
        }

        private void GridClasification_CellContentClick(object sender, DataGridViewCellEventArgs e)
>>>>>>> parent of 26a6505... Ajout de mes trucs
        {
            DataGridViewColumn column;
            GridClassification.Columns.Add("CoteESRB", "Cote");
            GridClassification.Columns.Add("NomESRB", "Nom");
            GridClassification.Columns.Add("DescESRB", "Description");

            DataGridViewRow row = GridClassification.Rows[0];
            row.Height = 30;

            column = GridClassification.Columns[0];
            column.Width = 10;
            column = GridClassification.Columns[1];
            column.Width = 30;
            column = GridClassification.Columns[2];
<<<<<<< HEAD
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void chargerDonnees()
        {
            GridClassification.Rows.Clear();
            foreach (Classification c in cc.chargerDonnees())
            {
                string[] tabTemp = new string[3]{c.coteESRB, c.nomESRB, c.descESRB};
                GridClassification.Rows.Add(tabTemp);           
            }
=======
            column.Width = 30;
>>>>>>> parent of 26a6505... Ajout de mes trucs
        }

        private void btnAjoutClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

<<<<<<< HEAD
            frmDetails.modifierChamp();
            frmDetails.btnCopier.Enabled = false;
=======
            frmDetails.modifierChamp("a");

>>>>>>> parent of 26a6505... Ajout de mes trucs
            frmDetails.ShowDialog();
            chargerDonnees();
        }
        private void btnDetailsClass_Click(object sender, EventArgs e)
        {

            if (GridClassification.SelectedRows.Count == 1)
            {
                var frmDetails = new frmDetClassification();

                frmDetails.modifierChamp(GridClassification.SelectedCells[0].Value.ToString(), GridClassification.SelectedCells[1].Value.ToString(), GridClassification.SelectedCells[2].Value.ToString());

                frmDetails.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("erreur");
            }
        }

<<<<<<< HEAD
        private void GridClassification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridClassification.Rows[e.RowIndex].Selected = true;
                if (GridClassification.SelectedRows.Count == 1)
                {
                    var frmDetails = new frmDetClassification();

                    frmDetails.modifierChamp(GridClassification.SelectedCells[0].Value.ToString(), GridClassification.SelectedCells[1].Value.ToString(), GridClassification.SelectedCells[2].Value.ToString());

                    frmDetails.ShowDialog();

                }
                else
                {
                    MessageBox.Show("erreur");
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridClassification.Rows[e.RowIndex].Selected = true;
            }
        }


=======
>>>>>>> parent of 26a6505... Ajout de mes trucs
    }
}
