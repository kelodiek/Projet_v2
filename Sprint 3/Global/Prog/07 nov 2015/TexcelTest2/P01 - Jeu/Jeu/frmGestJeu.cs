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
        private int lvlAcces;
        public frmGestJeu()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutJeu_Click);
            this.btnDetails.Click += new EventHandler(detailsJeu_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            
            ButtonsVisible(true);
            tri = 0;
            presentRow = 0;
            cj = new ctrlJeu();
            chargerColonnes();
            chargerDonnees();
            lvlAcces = 3;
        }
        //      avec authentification
        public frmGestJeu(string _us)
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutJeu_Click);
            this.btnDetails.Click += new EventHandler(detailsJeu_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);

            ButtonsVisible(true);
            tri = 0;
            presentRow = 0;
            cj = new ctrlJeu();
            UserNm = _us;
            droitUser();
        }

        private void droitUser()
        {
            lvlAcces = cj.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                btnVersion.Enabled = false;
                dataGridJeu.Rows.Clear();
            }

            if (lvlAcces > 0)
            {
                chargerColonnes();
                chargerDonnees();
            }
        }

        private void chargerColonnes()
        {
            DataGridViewColumn Column;

            dataGridJeu.Columns.Add("Nom", "Nom");
            dataGridJeu.Columns.Add("Desc", "Description");
            dataGridJeu.Columns.Add("Cote", "Cote");
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
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void chargerDonnees()
        {
            dataGridJeu.Rows.Clear();
            foreach (Jeu j in cj.chargerDonnees())
            {
                string nomGenre = "";
                if (j.idGenre != 0)
                {
                    nomGenre = rGenreSQL.rechercheGenre(j.idGenre.ToString()).First().NomGenre;
                }
                string nomMode = "";
                if (j.idMode != 0)
                {
                    nomMode = rModeSQL.rechercheMode(j.idMode.ToString()).First().NomMode;
                }   
                    
                string[] tabTemp = new string[] { j.nomJeu, j.descJeu, j.coteESRB, nomGenre, nomMode };
                int tempRow = dataGridJeu.Rows.Add(tabTemp);
                dataGridJeu.Rows[tempRow].Tag = j.idJeu;
            }
            dataGridJeu.Sort(dataGridJeu.Columns[tri], ListSortDirection.Ascending);
            if (dataGridJeu.Rows.Count != presentRow)
            {
                dataGridJeu.Rows[presentRow].Selected = true;
                dataGridJeu.CurrentCell = dataGridJeu.Rows[presentRow].Cells[0];
            }
            else
            {
                dataGridJeu.Rows[0].Selected = true;
            }
        }

        private void chargerDonnees(string NOMJEU)
        {
            DataGridViewRow dtvr = null;
            dataGridJeu.Rows.Clear();
            foreach (Jeu j in cj.chargerDonnees())
            {
                string nomGenre = "";
                if (j.idGenre != 0)
                {
                    nomGenre = rGenreSQL.rechercheGenre(j.idGenre.ToString()).First().NomGenre;
                }
                string nomMode = "";
                if (j.idMode != 0)
                {
                    nomMode = rModeSQL.rechercheMode(j.idMode.ToString()).First().NomMode;
                }

                string[] tabTemp = new string[] { j.nomJeu, j.descJeu, j.coteESRB, nomGenre, nomMode };
                int tempRow = dataGridJeu.Rows.Add(tabTemp);
                if (j.nomJeu == NOMJEU)
                {
                   dtvr = dataGridJeu.Rows[tempRow];
                }
                dataGridJeu.Rows[tempRow].Tag = j.idJeu;
            }
            dataGridJeu.Sort(dataGridJeu.Columns[tri], ListSortDirection.Ascending);
            if (dtvr != null)
            {
                presentRow = dataGridJeu.Rows.IndexOf(dtvr);
            }
            dataGridJeu.Rows[presentRow].Selected = true;
            dataGridJeu.CurrentCell = dataGridJeu.Rows[presentRow].Cells[0];
        }

        public void detailsJeu_Click(object sender, EventArgs e)
        {
            if (dataGridJeu.SelectedRows.Count == 1)
            {
                var frmDetails = new frmDetJeu(rJeuSQL.srchIdJeu(Convert.ToInt32(dataGridJeu.Rows[presentRow].Tag)).First(), lvlAcces);

                frmDetails.ShowDialog();
                chargerDonnees();
            }
            else
            {
                MessageBox.Show("Plusieurs lignes ont été sélectionnées", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ajoutJeu_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetJeu(lvlAcces);
            
            frmDetails.ShowDialog();
            chargerDonnees(frmDetails.nomJeu);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void rechercher()
        {
            if (txtRecherche.Text != "")
            {
                dataGridJeu.Rows.Clear();
                foreach (Jeu j in cj.rechercher(txtRecherche.Text))
                {
                    string nomGenre = "";
                    if (j.idGenre != 0)
                    {
                        nomGenre = rGenreSQL.rechercheGenre(j.idGenre.ToString()).First().NomGenre;
                    }
                    string nomMode = "";
                    if (j.idMode != 0)
                    {
                        nomMode = rModeSQL.rechercheMode(j.idMode.ToString()).First().NomMode;
                    }

                    string[] tabTemp = new string[] { j.nomJeu, j.descJeu, j.infoSupJeu, j.coteESRB, nomGenre, nomMode };
                    dataGridJeu.Rows.Add(tabTemp);
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


        private void dataGridJeu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                presentRow = e.RowIndex;
                dataGridJeu.Rows[e.RowIndex].Selected = true;
                if (dataGridJeu.SelectedRows.Count == 1)
                {
                    var frmDetails = new frmDetJeu(rJeuSQL.srchIdJeu(Convert.ToInt32(dataGridJeu.Rows[e.RowIndex].Tag)).First(), lvlAcces);

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
                presentRow = e.RowIndex;
                dataGridJeu.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces > 0)
            {
                rechercher();
            }
        }

        private void dataGridJeu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tri = e.ColumnIndex;
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            frmGesVersion frm = new frmGesVersion(Convert.ToInt32(dataGridJeu.Rows[presentRow].Tag), lvlAcces);
            frm.ShowDialog();
        }
    }
}
