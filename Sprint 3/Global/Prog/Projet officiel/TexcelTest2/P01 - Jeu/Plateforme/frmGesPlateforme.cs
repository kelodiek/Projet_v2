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
    public partial class frmGesPlateforme : frmGestion
    {
        ctrlPlateforme ctrlPlate;
        string rowId;
        int sortColumn;
        private int lvlAcces;
        public frmGesPlateforme()
        {
            InitializeComponent();

            ctrlPlate = new ctrlPlateforme();
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(btnAjout_Click);
            
            ButtonsVisible(true);

        }
        //      avec authentification
        public frmGesPlateforme(string _us)
        {
            InitializeComponent();

            ctrlPlate = new ctrlPlateforme();
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(btnAjout_Click);

            ButtonsVisible(true);
            UserNm = _us;
            
        }

        private void Gestion_des_Plateformes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            gridPlateforme.Columns.Add("Code", "Code");
            gridPlateforme.Columns.Add("Nom", "Nom");
            gridPlateforme.Columns.Add("Categ", "Catégorie");
            gridPlateforme.Columns.Add("Desc", "Description");

            column = gridPlateforme.Columns[0];
            column.Width = 100;
            column = gridPlateforme.Columns[1];
            column.Width = 100;
            column = gridPlateforme.Columns[2];
            column.Width = 150;
            column = gridPlateforme.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            updateDonnees();
            gridPlateforme.Rows[1].Selected = true;
            droitUser();
        }

        private void droitUser()
        {
            lvlAcces = ctrlPlate.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                gridPlateforme.Rows.Clear();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            afficherDetails();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetPlateforme(lvlAcces);

            frmDetails.txtID.Enabled = false;

            frmDetails.btnActiverModif.Enabled = false;
            frmDetails.modifierChamp("a");
            frmDetails.ShowDialog();
            updateDonnees();
        }

        private void afficherDonnees()
        {
            var lstRows = ctrlPlate.chargerDonnees();
            int index,i = 0;

            foreach (var item in lstRows)
            {
                index = gridPlateforme.Rows.Add(item);

                gridPlateforme.Rows[index].Tag = ctrlPlate.lstPlateforme[i];

                i++;
            }
            rowId = (string)gridPlateforme.Rows[gridPlateforme.Rows.Count - 1].Cells[0].Value;
            gridPlateforme.Sort(gridPlateforme.Columns[sortColumn], ListSortDirection.Ascending);
        }
        private void retirerDonnees()
        {
            gridPlateforme.Rows.Clear();
        }

        private void updateDonnees()
        {
            retirerDonnees();
            afficherDonnees();
        }

        private void afficherDetails()
        {
            string rowSelect = gridPlateforme.SelectedRows[0].Cells[0].Value.ToString();
            plateforme selectP = (plateforme)gridPlateforme.SelectedRows[0].Tag;
            var frmDetails = new frmDetPlateforme(selectP, lvlAcces);

            frmDetails.modifierChamp("m");
            frmDetails.ShowDialog();
            updateDonnees();
            selectLigne(rowSelect);
        }

        private void gridPlateforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridPlateforme.Rows[e.RowIndex].Selected = true;
            }
        }
        private void selectLigne(string id)
        {
            foreach (DataGridViewRow row in gridPlateforme.Rows)
            {
                if ((string)row.Cells[0].Value == id)
                {
                    gridPlateforme.Rows[row.Index].Selected = true;
                    gridPlateforme.CurrentCell = gridPlateforme.Rows[row.Index].Cells[0];
                }
            }
        }

        private void gridPlateforme_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sortColumn = e.ColumnIndex;
        }

        private void gridPlateforme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridPlateforme.Rows[e.RowIndex].Selected = true;

                afficherDetails();
            }
        }
    }
}
