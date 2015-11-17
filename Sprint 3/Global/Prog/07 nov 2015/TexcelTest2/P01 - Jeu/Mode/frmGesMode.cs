﻿using System;
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
    public partial class frmGesMode : frmGestion
    {
        ctrlMode gestionMode;
        private int lvlAcces;
        //private string NmUser;

        public frmGesMode()
        {
            InitializeComponent();
            gestionMode = new ctrlMode();
            this.btnAjout.Click += new EventHandler(ajoutMode_Click);
            this.btnDetails.Click += new EventHandler(detailsMode_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
            lvlAcces = 3;
            CreerGrid();
            
        }

        public frmGesMode(string _user)
        {
            InitializeComponent();
            gestionMode = new ctrlMode();
            this.btnAjout.Click += new EventHandler(ajoutMode_Click);
            this.btnDetails.Click += new EventHandler(detailsMode_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
            UserNm = _user;
            droitUser();
            CreerGrid();
        }
        
        private void droitUser()
        {
            lvlAcces = gestionMode.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                dataGridMode.Rows.Clear();
            }
        }

        private void CreerGrid()
        {
            DataGridViewColumn column;
            dataGridMode.Columns.Add("IdMode", "ID");
            dataGridMode.Columns.Add("NomMode", "Nom");
            dataGridMode.Columns.Add("DescMode", "Description");

            column = dataGridMode.Columns[0];
            column.Width = 30;
            column = dataGridMode.Columns[1];
            column.Width = 150;
            column = dataGridMode.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridMode.Columns[0].Visible = false;
            if (lvlAcces > 0)
            {
                chargeDonnees();
                if (dataGridMode.RowCount > 0)
                {
                    dataGridMode.Sort(dataGridMode.Columns[1], ListSortDirection.Ascending);
                    dataGridMode.Rows[0].Selected = true;
                    this.Tag = dataGridMode.Rows[0].Cells[1].Value.ToString();
                }
            }
                
        }

        private void chargeDonnees()
        {
            var data = gestionMode.charger();

            foreach (var item in data)
            {
                int rowIndex = dataGridMode.Rows.Add(item);
                dataGridMode.Rows[rowIndex].Tag = item.Last();
            }
        }

        private void ajoutMode_Click(object sender,EventArgs e)
        {
            var detailsMode = new frmDetMode(lvlAcces);

            if (dataGridMode.SelectedRows.Count == 0)
                detailsMode.Tag = "0";
            else
                detailsMode.Tag = this.Tag;

            detailsMode.modifierChamp("a");
            detailsMode.ShowDialog();
            if (detailsMode.Tag.ToString() == "0")
                this.Tag = "0";
            else
                this.Tag = detailsMode.Tag;
            update();
        }
        private void detailsMode_Click(object sender, EventArgs e)
        {
            if (dataGridMode.SelectedRows.Count == 1)
                modifierMode();
        }

        private void modifierMode()
        {
            var detailsMode = new frmDetMode(lvlAcces);
            Mode modSelectionner = new Mode();
            int index = dataGridMode.SelectedRows[0].Index;

            modSelectionner.idMode = Int32.Parse((string)dataGridMode.Rows[index].Cells[0].Value);
            modSelectionner.nomMode = (string)dataGridMode.Rows[index].Cells[1].Value;
            modSelectionner.descMode = (string)dataGridMode.Rows[index].Cells[2].Value;

            detailsMode.Tag = modSelectionner.nomMode;
            detailsMode.modeSelect = modSelectionner;
            detailsMode.modifierChamp("m");
            detailsMode.ShowDialog();
            if (detailsMode.Tag.ToString() == "0")
                this.Tag = "0";
            else
                this.Tag = detailsMode.Tag;
            update();
        }

        private void dataGridMode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridMode.Rows[e.RowIndex].Selected = true;
                this.Tag = dataGridMode.Rows[e.RowIndex].Cells[1].Value.ToString();
                modifierMode();
            }
        }

        private void dataGridMode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridMode.Rows[e.RowIndex].Selected = true;
                this.Tag = dataGridMode.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        public void update()
        {
            gestionMode = new ctrlMode();
            int colum = dataGridMode.SortedColumn.Index;
            ListSortDirection DD = ListSortDirection.Descending;
            if(dataGridMode.SortOrder == SortOrder.Ascending)
                DD = ListSortDirection.Ascending;
            
            dataGridMode.Rows.Clear();
            chargeDonnees();
            dataGridMode.Sort(dataGridMode.Columns[colum], DD);
            int R = RowsByNm(this.Tag.ToString());
            dataGridMode.Rows[R].Cells[1].Selected = true;
            dataGridMode.Rows[R].Selected = true;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces != 0)
                rechercher();
        }

        private void rechercher()
        {
            if (txtRecherche.Text != "")
            {
                dataGridMode.Rows.Clear();
                foreach (Mode m in gestionMode.recherche(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { m.idMode.ToString(), m.nomMode, m.descMode };
                    dataGridMode.Rows.Add(tabTemp);
                }
                if (dataGridMode.RowCount > 0)
                    dataGridMode.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ de recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            dataGridMode.Rows.Clear();
            chargeDonnees();
            txtRecherche.Text = "";
            dataGridMode.Sort(dataGridMode.Columns[1], ListSortDirection.Ascending);
            dataGridMode.Rows[0].Cells[1].Selected = true;
            dataGridMode.Rows[0].Selected = true;
        }

        private int RowsByNm(string _nom)
        {
            if (_nom != "0")
            {
                foreach (DataGridViewRow item in dataGridMode.Rows)
                {
                    if (item.Cells[1].Value.ToString() == _nom)
                        return item.Index;
                }
            }
            return 0;
        }
    }
}
