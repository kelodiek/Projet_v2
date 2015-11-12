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
    public partial class frmGesSysExp : frmGestion
    {
        ctrlSysExp gestionSysteme;
        int sortColumn;
        string nouvRowId;
        private int lvlAcces;
        public frmGesSysExp()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutSysExp_Click);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnRecherche.Click += new System.EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);

            sortColumn = 1;
            ButtonsVisible(true);
            gestionSysteme = new ctrlSysExp();
        }

        public frmGesSysExp(string _us)
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutSysExp_Click);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnRecherche.Click += new System.EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);

            sortColumn = 1;
            ButtonsVisible(true);
            gestionSysteme = new ctrlSysExp();
            UserNm = _us;
        }

        private void droitUser()
        {
            lvlAcces = gestionSysteme.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                gridSysExp.Rows.Clear();
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            recherche();
        }
        private void recherche()
        {
            if (txtRecherche.Text.Trim() != "")
            {
                gridSysExp.Rows.Clear();
                foreach (SystemeExploitation c in gestionSysteme.rechercher(txtRecherche.Text))
                {
                    string[] tabTemp = new string[6] { c.idSysExp.ToString(), c.CodeSysExp, c.nomSysExp, c.editSysExp, c.versionSysExp, c.infoSysExp };
                    int index = gridSysExp.Rows.Add(tabTemp);
                    gridSysExp.Rows[index].Tag = c.tagSysExp;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ.");
            }
        }
        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces > 0)
            {
                recherche();
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            afficherDonnees();
            txtRecherche.Text = "";
        }
        private void ajoutSysExp_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetSysExp(lvlAcces);

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            afficherDonnees();
            selectLigne(nouvRowId);
        }

        private void afficherDonnees()
        {
            gridSysExp.Rows.Clear();
            var donnees = gestionSysteme.chargerDonnees();
            foreach (var item in donnees)
            {
                int rowIndex = gridSysExp.Rows.Add(item);
                gridSysExp.Rows[rowIndex].Tag = item.Last();
            }
            nouvRowId = (string)gridSysExp.Rows[gridSysExp.Rows.Count - 1].Cells[0].Value;
            gridSysExp.Sort(gridSysExp.Columns[sortColumn], ListSortDirection.Ascending);
        }

        private void frmGesSysExp_Load(object sender, EventArgs e)
        {
            var column = new DataGridViewColumn();

            gridSysExp.Columns.Add("id", "ID");
            gridSysExp.Columns.Add("code", "Code");
            gridSysExp.Columns.Add("nom", "Nom");
            gridSysExp.Columns.Add("edit", "Edition");
            gridSysExp.Columns.Add("vers", "Version");
            gridSysExp.Columns.Add("info", "Info. Suplementaire");

            column = gridSysExp.Columns[0];
            column.Width = 50;
            column = gridSysExp.Columns[1];
            column.Width = 100;
            column = gridSysExp.Columns[2];
            column.Width = 150;
            column = gridSysExp.Columns[3];
            column.Width = 150;
            column = gridSysExp.Columns[4];
            column.Width = 150;
            column = gridSysExp.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            afficherDonnees();
            droitUser();
        }

        private void gridSysExp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;

                gridSysExp.Rows[index].Selected = true;
            }

        }
        private void afficherDetails(string[] info)
        {
            string rowSelect = gridSysExp.SelectedRows[0].Cells[0].Value.ToString();
            var frmDetails = new frmDetSysExp(info, lvlAcces);

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
            afficherDonnees();
            selectLigne(rowSelect);
        }

        private void gridSysExp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;

                gridSysExp.Rows[rowIndex].Selected = true;

                getInfoLigne(rowIndex);
            }
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridSysExp.SelectedRows.Count != 1)
            {
                MessageBox.Show("Trop de ligne selectionner.", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                getInfoLigne(gridSysExp.SelectedRows[0].Index);
            }

        }
        private void getInfoLigne(int index)
        {
            string[] infoSysExp;
            DataGridViewRow row = gridSysExp.Rows[index];

            gridSysExp.Rows[index].Selected = true;

            infoSysExp = new string[] { (string)row.Cells[0].Value, 
                (string)row.Cells[1].Value, 
                (string)row.Cells[2].Value, 
                (string)row.Cells[3].Value, 
                (string)row.Cells[4].Value, 
                (string)row.Cells[5].Value };

            afficherDetails(infoSysExp);
        }

        private void gridSysExp_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sortColumn = e.ColumnIndex;
        }
        private void selectLigne(string id)
        {
            foreach (DataGridViewRow row in gridSysExp.Rows)
            {
                if ((string)row.Cells[0].Value == id)
                {
                    gridSysExp.Rows[row.Index].Selected = true;
                    gridSysExp.CurrentCell = gridSysExp.Rows[row.Index].Cells[0];
                }
            }
        }

    }
}
