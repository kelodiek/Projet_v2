﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexcelTest2
{
    public partial class frmGesSysExp : frmGestion
    {
        public frmGesSysExp()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutSysExp_Click);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnSupprimer.Click += new EventHandler(btnSupprimmer_Click);
            btnRecherche.Click += new System.EventHandler(btnRecherche_Click);

            ButtonsVisible(true);
            gestionSysteme = new SystemeExploitation();
        }
        private void ajoutSysExp_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetSysExp();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            update();
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
        }

        private void gridSysExp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;

            //gridSysExp.Rows[index].Selected = true;
        }
        private void afficherDetails(string[] info)
        {
            var frmDetails = new frmDetSysExp(info);

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }

        private void gridSysExp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            getInfoLigne(rowIndex);
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
        private void btnSupprimmer_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo);


            if (resultat == DialogResult.Yes)
            {
                List<int> lstIndex = new List<int>();
                int id;

                foreach (DataGridViewCell item in gridSysExp.SelectedCells)
                {
                    if (lstIndex.Count != 0)
                    {
                        id = Convert.ToInt32(gridSysExp.Rows[item.RowIndex].Cells[0].Value);
                        if (id != lstIndex.Last())
                        {
                            lstIndex.Add(Convert.ToInt32(gridSysExp.Rows[item.RowIndex].Cells[0].Value));
                        }
                    }
                    else
                    {
                        lstIndex.Add(Convert.ToInt32(gridSysExp.Rows[item.RowIndex].Cells[0].Value));
                    }
                }
                gestionSysteme.supprimer(lstIndex);
                update();
            }
        }
        private void update()
        {
            gestionSysteme = new SystemeExploitation();
            var formOuvert = new frmGesSysExp();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            //Pas acces à la recherche
        }
    }
}
