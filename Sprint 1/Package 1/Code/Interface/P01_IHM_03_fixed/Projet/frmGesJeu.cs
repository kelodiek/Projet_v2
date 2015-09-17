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
    public partial class frmGesJeu : frmGestion
    {
        public frmGesJeu()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutJeu_Click);
            this.btnDetails.Click += new EventHandler(detailsJeu_Click);
            ButtonsVisible(true);
        }

        private void frmGesJeu_Load(object sender, EventArgs e)
        {
            DataGridViewColumn Column;

            dataGridJeu.Columns.Add("Nom", "Nom");
            dataGridJeu.Columns.Add("Date", "Date de Sortie");
            dataGridJeu.Columns.Add("Genre", "Genres");
            dataGridJeu.Columns.Add("Theme", "Thème");
            dataGridJeu.Columns.Add("Mode", "Mode");

            Column = dataGridJeu.Columns[0];
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column = dataGridJeu.Columns[1];
            Column.Width = 150;
            Column = dataGridJeu.Columns[2];
            Column.Width = 300;
            Column = dataGridJeu.Columns[3];
            Column.Width = 300;
            Column = dataGridJeu.Columns[4];
            Column.Width = 150;
        }
        public void detailsJeu_Click(object sender,EventArgs e)
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
