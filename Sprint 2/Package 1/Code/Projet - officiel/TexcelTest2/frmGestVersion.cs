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
        public frmGestVersion()
        {
            InitializeComponent();

            btnDetails.Click += new EventHandler(detailVersion_Click);
            btnAjout.Click += new EventHandler(ajoutVersion_Click);

            ButtonsVisible(true);
        }

        private void frmGestVersion_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridVersion.Columns.Add("IdJeu", "ID");
            GridVersion.Columns.Add("CodeVersion", "Code");
            GridVersion.Columns.Add("NomVersion", "Nom");
            GridVersion.Columns.Add("DescVersion", "Description de la Version");
            GridVersion.Columns.Add("StadeDeveloppement", "Stade");
            GridVersion.Columns.Add("DateVersion", "Date de la Version");
            GridVersion.Columns.Add("DateSortiePrevue", "Date de Sortie Prévue");

            column = GridVersion.Columns[0];
            column.Width = 30;
            column = GridVersion.Columns[1];
            column.Width = 50;
            column = GridVersion.Columns[2];
            column.Width = 100;
            column = GridVersion.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column = GridVersion.Columns[4];
            column.Width = 100;
            column = GridVersion.Columns[5];
            column.Width = 100;
            column = GridVersion.Columns[6];
            column.Width = 100;
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
