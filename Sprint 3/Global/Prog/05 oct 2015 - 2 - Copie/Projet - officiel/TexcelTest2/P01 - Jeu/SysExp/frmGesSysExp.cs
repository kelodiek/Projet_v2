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
        public frmGesSysExp()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutSysExp_Click);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnRecherche.Click += new System.EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);

            ButtonsVisible(true);
            gestionSysteme = new ctrlSysExp();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
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
                MessageBox.Show("Veuillez inscrire une chaine de recherche");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            afficherDonnees();
            txtRecherche.Text = "";
        }
        private void ajoutSysExp_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetSysExp();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            update();
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
            gridSysExp.Sort(gridSysExp.Columns[1], ListSortDirection.Ascending);
        }

        private void frmGesSysExp_Load(object sender, EventArgs e)
        {
            var donnees = gestionSysteme.chargerDonnees();
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


            foreach (var item in donnees)
            {
                int rowIndex = gridSysExp.Rows.Add(item);
                gridSysExp.Rows[rowIndex].Tag = item.Last();
            }
            gridSysExp.Sort(gridSysExp.Columns[1], ListSortDirection.Ascending);
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
            var frmDetails = new frmDetSysExp(info);

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }

        private void gridSysExp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;

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
            update();
        }
        private void update()
        {
            gestionSysteme = new ctrlSysExp();
            var formOuvert = new frmGesSysExp();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }


    }
}
