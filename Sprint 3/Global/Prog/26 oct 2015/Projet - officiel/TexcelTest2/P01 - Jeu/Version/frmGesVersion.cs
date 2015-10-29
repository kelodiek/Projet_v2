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
    public partial class frmGesVersion : frmGestion
    {
        ctrlVersion cv;
        int idJeu;
        public frmGesVersion(int id)
        {
            cv = new ctrlVersion();
            InitializeComponent();
            idJeu = id;
            
            btnDetails.Click += new EventHandler(detailVersion_Click);
            btnAjout.Click += new EventHandler(ajoutVersion_Click);
            
            ButtonsVisible(true);

            chargerColonnes();
            afficherDonnees();

        }

        private void afficherDonnees()
        {
            List<string[]> lstRows = cv.chargeDonnees(idJeu);
            int index, i = 0;

            foreach (var item in lstRows)
            {
                index = GridVersion.Rows.Add(item);

                //GridVersion.Rows[index].Tag = cv.lstPlateforme[i];

                i++;
            }
        }

        private void chargerColonnes()
        {
            DataGridViewColumn column;
            GridVersion.Columns.Add("CodeVersion", "Code");
            GridVersion.Columns.Add("NomVersion", "Nom");
            GridVersion.Columns.Add("DescVersion", "Description de la Version");
            GridVersion.Columns.Add("StadeDeveloppement", "Stade");
            GridVersion.Columns.Add("DateVersion", "Date de la Version");
            GridVersion.Columns.Add("DateSortiePrevue", "Date de Sortie Prévue");

            column = GridVersion.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridVersion.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridVersion.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridVersion.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridVersion.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = GridVersion.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ajoutVersion_Click(object sender, EventArgs e)
        {
            var detailsVersion = new frmDetVersion();

            detailsVersion.modifierChamp("a");

            detailsVersion.ShowDialog();
        }
        private void detailVersion_Click(object sender, EventArgs e)
        {
            var detailsVersion = new frmDetVersion();

            detailsVersion.modifierChamp("m");

            detailsVersion.ShowDialog();
        }
    }
}
