using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//          Vrai forme de Gestion de Version
//          revue par Gabriel


namespace Projet
{
    public partial class frmGesVersion : frmGestion
    {
        ctrlVersion ctrlVers;
        public int idJeu { get; set; }
        private int lvlAcces, presentRow;

        public frmGesVersion()
        {
            InitializeComponent();

            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(ajoutVersion_Click);
            this.btnRecherche.Click += new EventHandler(btnRechercher_click);
            this.btnX.Click += new EventHandler(btnX_click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);

            ButtonsVisible(true);
            disableMenu();

            ctrlVers = new ctrlVersion();
            idJeu = 3;
        }

        public frmGesVersion(int Id, int lvlA)
        {
            InitializeComponent();

            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(ajoutVersion_Click);
            this.btnRecherche.Click += new EventHandler(btnRechercher_click);
            this.btnX.Click += new EventHandler(btnX_click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);

            ButtonsVisible(true);
            disableMenu();

            ctrlVers = new ctrlVersion();
            idJeu = Id;
            lvlAcces = lvlA;
        }

        // cree les colonne et affiche les donnees
        private void frmGesVersion_Load(object sender, EventArgs e)
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
            droitUser();
        }

        private void droitUser()
        {
            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                gridVersion.Rows.Clear();
            }
        }

        private void ajoutVersion_Click(object sender, EventArgs e)
        {
            var detailsVersion = new frmDetVersion(idJeu, lvlAcces);

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

            if (gridVersion.RowCount > 0)
            {
                gridVersion.Rows[0].Cells[0].Selected = true;
                gridVersion.Rows[0].Selected = true;
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
            gridVersion.Rows[presentRow].Cells[0].Selected = true;
            gridVersion.Rows[presentRow].Selected = true;
        }
        // affiche les details de la version selectionner
        private void afficherDetails()
        {
            if (gridVersion.SelectedRows.Count > 0)
            {
                version selectV = (version)gridVersion.SelectedRows[0].Tag;
                var frmDetails = new frmDetVersion(selectV, lvlAcces);

                frmDetails.modifierChamp("m");

                frmDetails.ShowDialog();
                updateDonnees(); 
            }
        }
        // selectionne la ligne entiere en cas de click
        private void gridVersion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridVersion.Rows[e.RowIndex].Selected = true;
                presentRow = e.RowIndex;
            }
        }
        // selectionne la ligne entiere en cas de double click
        private void gridVersion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridVersion.Rows[e.RowIndex].Selected = true;
                presentRow = e.RowIndex;
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

                if (gridVersion.RowCount > 0)
                {
                    gridVersion.Rows[0].Cells[0].Selected = true;
                    gridVersion.Rows[0].Selected = true;
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

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces != 0)
                rechercher();
        }
    }
}
