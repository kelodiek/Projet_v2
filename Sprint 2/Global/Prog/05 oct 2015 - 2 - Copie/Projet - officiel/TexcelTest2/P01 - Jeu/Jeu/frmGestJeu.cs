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
    public partial class frmGestJeu : frmGestion
    {
        ctrlJeu cj;
        int tri, presentRow;
        public frmGestJeu()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutJeu_Click);
            this.btnDetails.Click += new EventHandler(detailsJeu_Click);
            ButtonsVisible(true);
            tri = 0;
            presentRow = 0;
            cj = new ctrlJeu();
            chargerColonnes();
        }

        private void chargerColonnes()
        {
            DataGridViewColumn Column;

            dataGridJeu.Columns.Add("Nom", "Nom");
            dataGridJeu.Columns.Add("Desc", "Description");
            dataGridJeu.Columns.Add("Info", "Informations supplémentaires");
            dataGridJeu.Columns.Add("Cote", "Thème");
            dataGridJeu.Columns.Add("Genre", "Genre");
            dataGridJeu.Columns.Add("Mode", "Mode");

            Column = dataGridJeu.Columns[0];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[1];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[2];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[3];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            Column = dataGridJeu.Columns[4];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column = dataGridJeu.Columns[5];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void chargerDonnees()
        {
            dataGridJeu.Rows.Clear();
            foreach (Jeu j in cj.chargerDonnees())
            {
                string[] tabTemp = new string[] { j.nomJeu, j.descJeu, j.infoSupJeu, j.coteESRB, Convert.ToString(j.idGenre), Convert.ToString(j.idMode) };
                dataGridJeu.Rows.Add(tabTemp);
            }
            dataGridJeu.Sort(dataGridJeu.Columns[tri], ListSortDirection.Ascending);
            if (dataGridJeu.Rows.Count != presentRow)
            {
                dataGridJeu.Rows[presentRow].Selected = true;
            }
            else
            {
                dataGridJeu.Rows[0].Selected = true;
            }
        }

        public void detailsJeu_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetJeu();

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }
        public void ajoutJeu_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetJeu();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
        }
    }
}
