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
    public partial class frmGestVersion : frmGestion
    {
        ctrlVersion ctrlVers;
        public int idJeu { get; set; }
        public frmGestVersion()
        {
            InitializeComponent();

            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(ajoutVersion_Click);
            this.btnRecherche.Click += new EventHandler(btnRechercher_click);
            this.btnX.Click += new EventHandler(btnX_click);

            ButtonsVisible(true);

            ctrlVers = new ctrlVersion();
            idJeu = 3;
        }
        // cree les colonne et affiche les donnees
        private void frmGestVersion_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            gridVersion.Columns.Add("CodeVersion", "Code");
            gridVersion.Columns.Add("NomVersion", "Nom");
            gridVersion.Columns.Add("DescVersion", "Description de la Version");
            gridVersion.Columns.Add("StadeDeveloppement", "Stade");
            gridVersion.Columns.Add("DateVersion", "Date de la Version");
            gridVersion.Columns.Add("DateSortiePrevue", "Date de Sortie Prévue");

            column = gridVersion.Columns[0];
            column.Width = 100;
            column = gridVersion.Columns[1];
            column.Width = 150;
            column = gridVersion.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column = gridVersion.Columns[3];
            column.Width = 150;
            column = gridVersion.Columns[4];
            column.Width = 100;
            column = gridVersion.Columns[5];
            column.Width = 100;

            afficherDonnees();
        }
        private void ajoutVersion_Click(object sender, EventArgs e)
        {
            var detailsVersion = new frmDetVersion(idJeu);

            detailsVersion.modifierChamp("a");

            detailsVersion.ShowDialog();
            updateDonnees();
        }
        private void afficherDonnees()
        {
            var lstRows = ctrlVers.chargeDonnees(idJeu);
            int index,i=0;

            foreach (var item in lstRows)
            {
                index = gridVersion.Rows.Add(item);
                gridVersion.Rows[index].Tag = ctrlVers.lstVersion[i];
                i++;
            }
        }
        private void retirerDonnees()
        {
            gridVersion.Rows.Clear();
        }
        // supprime et recharge les info dans le datagrid
        private void updateDonnees() 
        {
            retirerDonnees();
            afficherDonnees();
        }
        // affiche les details de la version selectionner
        private void afficherDetails()
        {
            version selectV = (version)gridVersion.SelectedRows[0].Tag;
            var frmDetails = new frmDetVersion(selectV);

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
            updateDonnees();
        }
        // selectionne la ligne entiere en cas de click
        private void gridVersion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridVersion.Rows[e.RowIndex].Selected = true;
            }
        }
        // selectionne la ligne entiere en cas de double click
        private void gridVersion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridVersion.Rows[e.RowIndex].Selected = true;
                afficherDetails();
            }
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            afficherDetails();
        }
        public void btnRechercher_click(object sender, EventArgs e)
        {
            rechercher();
        }
        private void rechercher()
        {
            if (txtRecherche.Text != "")
            {
                retirerDonnees();
                foreach (version item in ctrlVers.rechercher(txtRecherche.Text,idJeu))
                {
                    gridVersion.Rows.Add(new string[] { item.codeVersion,
                        item.nomVersion,
                        item.descVersion,
                        item.stadeVersion,
                        item.dateVersion.ToShortDateString(),
                        ((DateTime)item.dateSortie).ToShortDateString()});
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ de recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnX_click(object sender, EventArgs e)
        {
            updateDonnees();
            txtRecherche.Text = "";
        }
    }
}
