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
    public partial class frmGesComptes : frmGestion
    {
        ctrlComptes GesComptes;
        public int Idemp;
        public frmGesComptes()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutCompte_Click);
            btnDetails.Click += new EventHandler(detailCompte_Click);
            btnRecherche.Click += new EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            ButtonsVisible(true);
            GesComptes = new ctrlComptes();
            Idemp = 0;
        }

        public void ajoutCompte_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetComptes(Idemp);

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            afficherDonnees();
        }
        private void update()
        {
            GesComptes = new ctrlComptes();
            var formOuvert = new frmGesComptes();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }
        public void detailCompte_Click(object sender, EventArgs e)
        {
            if (gridComptes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Trop de ligne selectionnées.", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                getInfoLigne(gridComptes.SelectedRows[0].Index);
            }
        }
        private void getInfoLigne(int index)
        {
            string[] infoCompte;
            DataGridViewRow row = gridComptes.Rows[index];

            gridComptes.Rows[index].Selected = true;

            infoCompte = new string[] { (string)row.Cells[0].Value, 
                (string)row.Cells[1].Value, 
                (string)row.Cells[2].Value, 
                (string)row.Cells[3].Value, 
                (string)row.Cells[4].Value, 
                (string)row.Cells[5].Value, 
            (string)row.Cells[6].Value,
            (string)row.Cells[7].Value};

            afficherDetails(infoCompte);
            afficherDonnees();
        }
        private void afficherDetails(string[] info)
        {
            var frmDetails = new frmDetComptes(info, Idemp);

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }
        public void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
            {
                gridComptes.Rows.Clear();
                foreach (Utilisateur c in GesComptes.recherche(txtRecherche.Text))
                {
                    string[] tabTemp = new string[8] { c.NomUtilisateur,
                    c.MotDePasse,
                c.Premiere.ToString(),
                c.Expire.ToString(),
                c.DateModifMotPas.ToString(),
                c.Role.ToString() ,
                    c.Emp.ToString(),
                    c.UtilActif.ToString()};
                    int index = gridComptes.Rows.Add(tabTemp);
                }
            }
            else
            {
                MessageBox.Show("Veuillez inscrire un ou plusieurs mot clef pour permettre la recherche.");
            }
        }
        public void btnX_Click(object sender, EventArgs e)
        {
            afficherDonnees();
            txtRecherche.Text = "";
            gridComptes.Rows[1].Selected = true;
            gridComptes.Sort(gridComptes.Columns[1], ListSortDirection.Ascending);
        }
        private void afficherDonnees()
        {
            gridComptes.Rows.Clear();
            var donnees = GesComptes.chargerDonnees(Idemp);
            foreach (var item in donnees)
            {
                int rowIndex = gridComptes.Rows.Add(item);
                gridComptes.Rows[rowIndex].Tag = item.Last();
            }
            gridComptes.Sort(gridComptes.Columns[1], ListSortDirection.Ascending);
            gridComptes.Rows[0].Selected = true;
        }

        private void frmGesComptes_Load(object sender, EventArgs e)
        {
            var donnees = GesComptes.chargerDonnees(Idemp);
            var column = new DataGridViewColumn();


            gridComptes.Columns.Add("NomUtil", "Nom Utilisateur");
            gridComptes.Columns.Add("MotPasUtil", "Mot de Passe");
            gridComptes.Columns.Add("PremiereConex", "Première Connexion");
            gridComptes.Columns.Add("MotPasExpire", "MDP Expiré");
            gridComptes.Columns.Add("DateModifMotPas", "Date Modifier MDP");
            gridComptes.Columns.Add("IdRole", "Rôle");
            gridComptes.Columns.Add("IdEmp", "Code Employe");
            gridComptes.Columns.Add("Actif", "Actif");

            /* DETERMINER LONGUEUR */
            column = gridComptes.Columns[0];
            column.Width = 175;
            column = gridComptes.Columns[1];
            column.Width = 175;
            column = gridComptes.Columns[2];
            column.Width = 100;
            column = gridComptes.Columns[3];
            column.Width = 75;
            column = gridComptes.Columns[4];
            column.Width = 150;
            column = gridComptes.Columns[5];
            column.Width = 75;
            column = gridComptes.Columns[6];
            column.Width = 75;
            column = gridComptes.Columns[7];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            foreach (var item in donnees)
            {
                int rowIndex = gridComptes.Rows.Add(item);
                gridComptes.Rows[rowIndex].Tag = item.Last();
            }
            gridComptes.Sort(gridComptes.Columns[1], ListSortDirection.Ascending);
            gridComptes.Rows[0].Selected = true;
        }
        private void gridComptes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;

                gridComptes.Rows[index].Selected = true;
            }

        }
        private void gridComptes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;

                getInfoLigne(rowIndex);
            }
        }
    }
}
