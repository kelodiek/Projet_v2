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
    public partial class frmGestJeu : frmGestion
    {
        ctrlJeu cj;
        int tri, presentRow;
        public frmGestJeu()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutJeu_Click);
            this.btnDetails.Click += new EventHandler(detailsJeu_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            //MANQUE DES ASSOCIATIONS D'ÉVÉNEMENTS

            ButtonsVisible(true);
            tri = 0;
            presentRow = 0;
            cj = new ctrlJeu();
            chargerColonnes();
            chargerDonnees();
        }

        private void chargerColonnes()
        {
            DataGridViewColumn Column;

            dataGridJeu.Columns.Add("Nom", "Nom");
            dataGridJeu.Columns.Add("Desc", "Description");
            dataGridJeu.Columns.Add("Info", "Informations supplémentaires");
            dataGridJeu.Columns.Add("Cote", "Thème");
            dataGridJeu.Columns.Add("Genre", "Genre");
            dataGridJeu.Columns.Add("Mode", "Mode");

            Column = dataGridJeu.Columns[0];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[1];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[2];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[3];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            Column = dataGridJeu.Columns[4];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[5];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void chargerDonnees()
        {
            dataGridJeu.Rows.Clear();
            foreach (Jeu j in cj.chargerDonnees())
            {
                string[] tabTemp = new string[] { j.nomJeu, j.descJeu, j.infoSupJeu, j.coteESRB, Convert.ToString(j.idGenre), Convert.ToString(j.idMode) };
                dataGridJeu.Rows.Add(tabTemp);
            }
            dataGridJeu.Sort(dataGridJeu.Columns[tri], ListSortDirection.Ascending);
            if (dataGridJeu.Rows.Count != presentRow)
            {
                dataGridJeu.Rows[presentRow].Selected = true;
            }
            else
            {
                dataGridJeu.Rows[0].Selected = true;
            }
        }

        public void detailsJeu_Click(object sender, EventArgs e)
        {
            //Caller new form avec parametre de celui cliquer
            var frmDetails = new frmDetJeu();

            frmDetails.ShowDialog();
        }
        public void ajoutJeu_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetJeu();

            frmDetails.ShowDialog();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void rechercher()
        {
            //if (txtRecherche.Text != "")
            //{
            //    GridClassification.Rows.Clear();
            //    foreach (Classification c in cc.rechercher(txtRecherche.Text))
            //    {
            //        string[] tabTemp = new string[3] { c.coteESRB, c.nomESRB, c.descESRB };
            //        GridClassification.Rows.Add(tabTemp);
            //    }
            //}
            //else
            //{
            //    //Message d'erreur de champ vide
            //    MessageBox.Show("Veuillez remplir le champ de recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            chargerDonnees();
            txtRecherche.Text = "";
        }

        //TODO
        private void btnDetailsJeu_Click(object sender, EventArgs e)
        {

            //if (GridClassification.SelectedRows.Count == 1)
            //{
            //    var frmDetails = new frmDetClassification();

            //    frmDetails.modifierChamp(GridClassification.SelectedCells[0].Value.ToString(), GridClassification.SelectedCells[1].Value.ToString(), GridClassification.SelectedCells[2].Value.ToString());

            //    frmDetails.ShowDialog();
            //    chargerDonnees();
            //}
            //else
            //{
            //    MessageBox.Show("Aucune ligne n'a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //TODO
        private void GridClassification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                presentRow = e.RowIndex;
                dataGridJeu.Rows[e.RowIndex].Selected = true;
                if (dataGridJeu.SelectedRows.Count == 1)
                {
                    //var frmDetails = new frmDetClassification();

                    //frmDetails.modifierChamp(GridClassification.SelectedCells[0].Value.ToString(), GridClassification.SelectedCells[1].Value.ToString(), GridClassification.SelectedCells[2].Value.ToString());

                    //frmDetails.ShowDialog();
                    //chargerDonnees();
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
                presentRow = e.RowIndex;
                dataGridJeu.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                rechercher();
            }
        }

        private void GridClassification_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tri = e.ColumnIndex;
        }
    }
}
