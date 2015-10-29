using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.P02___Personnel.Equipe
{
    public partial class frmGesEquipe : frmGestion
    {
        public frmGesEquipe()
        {
            InitializeComponent();

            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(btnAjout_Click);

            ButtonsVisible(true);
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

            //updateDonnees();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            //   afficherDetails();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetEquipe();

            //   frmDetails.txtID.Enabled = false;

            frmDetails.btnActiverModif.Enabled = false;

            frmDetails.ShowDialog();
            // updateDonnees();
        }
        /*
        private void afficherDonnees()
        {
            var lstRows = ctrlPlate.chargerDonnees();
            int index, i = 0;

            foreach (var item in lstRows)
            {
                index = gridPlateforme.Rows.Add(item);

                gridPlateforme.Rows[index].Tag = ctrlPlate.lstPlateforme[i];

                i++;
            }
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
        private void btnDetail_Click()
        {

        }*/
        /*  private void afficherDetails()
          {
              //int index = gridEquipe.SelectedRows.;
              equipe selectE = (plateforme)gridEquipe.SelectedRows[0].Tag;
              var frmDetails = new frmDetEquipe(selectE);

              frmDetails.modifierChamp("m");

              frmDetails.ShowDialog();
              //updateDonnees();
          }*/
        private void gridEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridEquipe.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
