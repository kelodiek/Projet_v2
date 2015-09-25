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
        ControleClassification cc;
        public frmGestClassification()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(btnAjoutClass_Click);
            this.btnDetails.Click += new EventHandler(btnDetailsClass_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
            cc = new ControleClassification();
            chargerColones();
            chargerDonnees();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void rechercher()
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
                MessageBox.Show("Veuillez remplir le champ de recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            chargerDonnees();
            txtRecherche.Text = "";
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
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridClassification.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            column = GridClassification.Columns[2];
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
            GridClassification.Sort(GridClassification.Columns[1], ListSortDirection.Ascending);
        }

        private void btnAjoutClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

            frmDetails.modifierChamp();
            frmDetails.btnCopier.Enabled = false;
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
                chargerDonnees();
            }
            else
            {
                MessageBox.Show("Aucune ligne n'a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                    chargerDonnees();
                }
                else
                {
                    MessageBox.Show("Plusieurs lignes ont été sélectionnées", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                rechercher();
            }
        }

    }
}
