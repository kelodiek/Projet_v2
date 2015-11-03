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
    public partial class frmGesCategorie : frmGestion
    {
        ctrlCategorie gestionCateg;
        int Ligne;
        public frmGesCategorie()
        {
            InitializeComponent();
            gestionCateg = new ctrlCategorie();
            this.ButtonsVisible(true);
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(ajoutCategorie_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            Ligne = 0;
        }
        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                recherche();
            }
        }
        private void frmGesCategorie_Load(object sender, EventArgs e)
        {
            var donnees = gestionCateg.charger();
            DataGridViewColumn column;
            gridCateg.Columns.Add("codeCateg", "Code");
            gridCateg.Columns.Add("descCateg", "Description");
            gridCateg.Columns.Add("comCateg", "Commentaire");

            column = gridCateg.Columns[0];
            column.Width = 75;
            column = gridCateg.Columns[1];
            column.Width = 200;
            column = gridCateg.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var item in donnees)
            {
                int rowIndex = gridCateg.Rows.Add(item);
                gridCateg.Rows[rowIndex].Tag = item.Last();
            }
            gridCateg.Sort(gridCateg.Columns[0], ListSortDirection.Ascending);
            gridCateg.Rows[0].Selected = true;
        }
        private void ajoutCategorie_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetCateg();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            update();
            if (frmDetails.categSelect != null)
            {
                int R = gestionCateg.RowsById(frmDetails.categSelect.codeCateg, gridCateg);
                gridCateg.Rows[R].Cells[0].Selected = true;
                gridCateg.Rows[R].Selected = true;
                Ligne = R;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            recherche();
        }
        private void recherche()
        {
            if (txtRecherche.Text != "")
            {
                gridCateg.Rows.Clear();
                foreach (Categorie c in gestionCateg.rechercher(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { c.codeCateg.ToString(), c.descCateg, c.comCateg };
                    int index = gridCateg.Rows.Add(tabTemp);
                }
                Ligne = 0;

                if (gridCateg.RowCount > 0)
                    gridCateg.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Veuillez inscrire une chaine de recherche");
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            afficherDonnees();
            txtRecherche.Text = "";
        }

        private void afficherDonnees()
        {
            gridCateg.Rows.Clear();
            var donnees = gestionCateg.charger();
            foreach (var item in donnees)
            {
                int rowIndex = gridCateg.Rows.Add(item);
                gridCateg.Rows[rowIndex].Tag = item.Last();
            }
            gridCateg.Sort(gridCateg.Columns[0], ListSortDirection.Ascending);
            gridCateg.Rows[Ligne].Cells[0].Selected = true;
            gridCateg.Rows[Ligne].Selected = true;
            //Ligne = 0;
        }
        private void update()
        {
            afficherDonnees();
        }
        public void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridCateg.SelectedRows.Count == 1)
            {
                modifierCateg();
            }

        }
        private void modifierCateg()
        {
            var frmDetails = new frmDetCateg();
            Categorie categSelect = new Categorie();
            int index = gridCateg.SelectedRows[0].Index;

            categSelect.codeCateg = (string)gridCateg.Rows[index].Cells[0].Value;
            categSelect.descCateg = (string)gridCateg.Rows[index].Cells[1].Value;
            categSelect.comCateg = (string)gridCateg.Rows[index].Cells[2].Value;

            frmDetails.categSelect = categSelect;
            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
            update();
            if (frmDetails.categSelect != null)
            {
                int R = gestionCateg.RowsById(frmDetails.categSelect.codeCateg, gridCateg);
                gridCateg.Rows[R].Cells[0].Selected = true;
                gridCateg.Rows[R].Selected = true;
                Ligne = R;
            }
        }

        private void gridCateg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridCateg.Rows[e.RowIndex].Selected = true;
                Ligne = e.RowIndex;
                modifierCateg();
            }
        }

        private void gridCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridCateg.Rows[e.RowIndex].Selected = true;
                Ligne = e.RowIndex;
            }
        }
    }
}
