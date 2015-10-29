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
    public partial class frmGestTheme : frmGestion
    {
        ctrlTheme gestionTheme;
        public frmGestTheme()
        {
            InitializeComponent();
            gestionTheme = new ctrlTheme();
            btnAjout.Click += new EventHandler(ajoutTheme_Click);
            btnDetails.Click += new EventHandler(detailTheme_Click);
            btnRecherche.Click += new EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            ButtonsVisible(true);
        }
        private void frmGestTheme_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridTheme.Columns.Add("IdTheme", "ID");
            GridTheme.Columns.Add("NomTheme", "Nom");
            GridTheme.Columns.Add("CommentaireTheme", "Commentaire");

            column = GridTheme.Columns[0];
            column.Width = 30;
            column = GridTheme.Columns[1];
            column.Width = 150;
            column = GridTheme.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chargerDonnees();
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
            var frmDetails = new frmDetTheme();

            frmDetails.modifierChamp("a");

            frmDetails.Show();
        }
        private void update()
        {
            gestionTheme = new ctrlTheme();
            var formOuvert = new frmGestTheme();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
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
            var frmDetails = new frmDetTheme();
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
        }
        private void GridTheme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridTheme.Rows[e.RowIndex].Selected = true;
                modifierTheme();
            }
        }

        private void GridTheme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridTheme.Rows[e.RowIndex].Selected = true;
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
        }

    }
}
