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
    public partial class frmGesEquipe : frmGestion
    {
        private ctrlEquipe ctrlGesEquipe;
        public int numEquipe { get; set; }
        public frmGesEquipe()
        {
            InitializeComponent();
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(btnAjout_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            ButtonsVisible(true);
            ctrlGesEquipe = new ctrlEquipe();

        }
        private void Gestion_des_Equipes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            gridEquipe.Columns.Add("Projet", "Projet");
            gridEquipe.Columns.Add("NomEquipe", "Nom Équipe");
            gridEquipe.Columns.Add("NomEmp", "Chef équipe");
            gridEquipe.Columns.Add("Test", "Test");
            gridEquipe.Columns.Add("Testeur", "Testeur");

            column = gridEquipe.Columns[0];
            column.Width = 200;
            column = gridEquipe.Columns[1];
            column.Width = 150;
            column = gridEquipe.Columns[2];
            column.Width = 150;
            column = gridEquipe.Columns[3];
            column.Width = 250;
            column = gridEquipe.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            afficherDonnees(-1);
            gridEquipe.CurrentCell = gridEquipe.Rows[0].Cells[0];
            gridEquipe.Rows[0].Selected = true;

            //updateDonnees();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            afficherDetails();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetEquipe(this);

            //   frmDetails.txtID.Enabled = false;

            frmDetails.btnActiverModif.Enabled = false;

            frmDetails.ShowDialog();
            //updateDonnees();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            gridEquipe.Rows.Clear();

            var lstRows = ctrlGesEquipe.chargerDonnees(rEquipeSQL.Recherche(txtRecherche.Text));
            int index, i = 0;

            foreach (var item in lstRows)
            {
                index = this.gridEquipe.Rows.Add(item);

                try
                {
                    gridEquipe.Rows[index].Tag = ctrlGesEquipe.lstEquipe[i];
                }
                catch (Exception)
                {

                }

                i++;
            }
            if(gridEquipe.Rows.Count != 0)
            {
                gridEquipe.CurrentCell = gridEquipe.Rows[0].Cells[0];
                gridEquipe.Rows[0].Selected = true;            
            }

        }
        
        public void afficherDonnees(int rowSelect)
        {
            gridEquipe.Rows.Clear();

            var lstRows = ctrlGesEquipe.chargerDonnees();

            int index, i = 0;

            foreach (var item in lstRows)
            {
                index = this.gridEquipe.Rows.Add(item);

                try
                {
                gridEquipe.Rows[index].Tag = ctrlGesEquipe.lstEquipe[i];
                }
                catch (Exception )
                {

                }


                i++;
            }

            if (rowSelect != -1)
            {
                int ii;

                foreach (DataGridViewRow item in gridEquipe.Rows)
                {
                    Int32.TryParse(item.Cells[0].Value.ToString(), out ii);

                    if(ii == rowSelect)
                    {
                        gridEquipe.ClearSelection();
                        item.Selected = true;
                        gridEquipe.CurrentCell = item.Cells[0];
                    }
                }
            }

            gridEquipe.Sort(gridEquipe.Columns[1], ListSortDirection.Ascending);
        }

        private void afficherDetails()
        {
            string rowSelect = gridEquipe.SelectedRows[0].Cells[0].Value.ToString();
            int noEquipe;
            tblEquipe eq;

            Int32.TryParse(rowSelect, out noEquipe);

            eq = rEquipeSQL.getEquipe(noEquipe);

            var frmDetails = new frmDetEquipe(this, eq);

            //   frmDetails.txtID.Enabled = false;

            //frmDetails.btnActiverModif.Enabled = false;

            frmDetails.ShowDialog();
            //updateDonnees();

        }
        private void retirerDonnees()
        {
            gridEquipe.Rows.Clear();
        }

        private void updateDonnees()
        {
            retirerDonnees();
            afficherDonnees(-1);
        }
        
        private void gridEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridEquipe.Rows[e.RowIndex].Selected = true;
            }
        }


    }
}
