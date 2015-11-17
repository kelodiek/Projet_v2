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
    public partial class frmGesTheme : frmGestion
    {
        private int order,ligneSelect;
        ctrlTheme gestionTheme;
        private int lvlAcces;

        //      avec authentification
        public frmGesTheme(string _us)
        {
            order = 0;
            InitializeComponent();
            gestionTheme = new ctrlTheme();
            btnAjout.Click += new EventHandler(ajoutTheme_Click);
            btnDetails.Click += new EventHandler(detailTheme_Click);
            btnRecherche.Click += new EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
            UserNm = _us;
        }

        private void frmGestTheme_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridTheme.Columns.Add("Id", "ID");
            GridTheme.Columns.Add("NomTheme", "Nom");
            GridTheme.Columns.Add("CommentaireTheme", "Commentaire");

            column = GridTheme.Columns[0];
            column.Visible = false;
            column = GridTheme.Columns[1];
            column.Width = 300;
            column = GridTheme.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chargerDonnees();
            GridTheme.Rows[0].Selected = true;
            GridTheme.Sort(GridTheme.Columns[1], ListSortDirection.Ascending);
            droitUser();
        }

        private void droitUser()
        {
            lvlAcces = gestionTheme.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                GridTheme.Rows.Clear();
            }
        }

        private void chargerDonnees()
        {
            var donnees = gestionTheme.charger();
            
            foreach (var item in donnees)
            {
                int rowIndex = GridTheme.Rows.Add(item);
                GridTheme.Rows[rowIndex].Tag = item.Last();
            }
        }

        private void ajoutTheme_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetTheme(lvlAcces);
            frmDetails.modifierChamp("a");
            frmDetails.ShowDialog();
            update();
            frmDetails.Closed += (s, args) => this.Close();
            if (frmDetails.themeSelect != null)
            {
                int R = gestionTheme.RowsByID(frmDetails.themeSelect.idTheme, GridTheme);
                GridTheme.Rows[R].Cells[1].Selected = true;
                GridTheme.Rows[R].Selected = true;
            }
        }

        private void update()
        {
            GridTheme.Rows.Clear();
            chargerDonnees();
        }

        private void detailTheme_Click(object sender, EventArgs e)
        {
            if (GridTheme.SelectedRows.Count == 1)
            {
                modifierTheme();
            }
            else
            {
                // erreure
            }
        }

        private void modifierTheme()
        {
            var frmDetails = new frmDetTheme(lvlAcces);
            Theme themeSelect = new Theme();
            int index = GridTheme.SelectedRows[0].Index;

            themeSelect.idTheme = Convert.ToInt32(GridTheme.Rows[index].Cells[0].Value);
            themeSelect.nomTheme = (string)GridTheme.Rows[index].Cells[1].Value;
            themeSelect.comTheme = (string)GridTheme.Rows[index].Cells[2].Value;

            frmDetails.themeSelect = themeSelect;
            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
            frmDetails.Closed += (s, args) => this.Close();
            update();
            if (frmDetails.themeSelect.idTheme != themeSelect.idTheme && frmDetails.themeSelect.idTheme != 0)
            {
                int R = gestionTheme.RowsByID(frmDetails.themeSelect.idTheme, GridTheme);
                GridTheme.Rows[R].Cells[1].Selected = true;
                GridTheme.Rows[R].Selected = true;
            }
            else if (frmDetails.themeSelect.idTheme != 0)
            {
                if (GridTheme.RowCount > ligneSelect)
                {
                    GridTheme.Rows[ligneSelect].Cells[1].Selected = true;
                    GridTheme.Rows[ligneSelect].Selected = true; 
                }
                else
                {
                    GridTheme.Rows[ligneSelect - 1].Cells[1].Selected = true;
                    GridTheme.Rows[ligneSelect - 1].Selected = true;
                }
            }
        }

        private void GridTheme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridTheme.Rows[e.RowIndex].Selected = true;
                ligneSelect = e.RowIndex;
                modifierTheme();
            }
        }

        private void GridTheme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridTheme.Rows[e.RowIndex].Selected = true;
                ligneSelect = e.RowIndex;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if(txtRecherche.Text != "")
            {
                GridTheme.Rows.Clear();
                foreach (Theme c in gestionTheme.recherche(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { c.idTheme.ToString(), c.nomTheme, c.comTheme };
                    GridTheme.Rows.Add(tabTemp);
                }
                if (GridTheme.RowCount > 0)
                    GridTheme.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Veuillez entrer une information a rechercher");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            GridTheme.Rows.Clear();
            chargerDonnees();
            txtRecherche.Text = "";
            GridTheme.Sort(GridTheme.Columns[1], ListSortDirection.Ascending);
            //GridTheme.Rows[0].Cells[1].Selected = true;
            GridTheme.Rows[0].Selected = true;
        }

        private void GridTheme_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            order = e.ColumnIndex;
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces > 0)
                btnRecherche.PerformClick();
        }

    }
}
