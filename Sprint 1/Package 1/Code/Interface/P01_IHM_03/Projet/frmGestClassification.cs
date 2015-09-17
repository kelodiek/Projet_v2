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
    public partial class frmGestClassification : frmGestion
    {
        public frmGestClassification()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(btnAjoutClass_Click);
            this.btnDetails.Click += new EventHandler(btnDetailsClass_Click);
        }

        private void GridClasification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column;
            GridClassification.Columns.Add("CoteESRB", "Cote");
            GridClassification.Columns.Add("NomESRB", "Nom");
            GridClassification.Columns.Add("DescESRB", "Description");

            DataGridViewRow row = GridClassification.Rows[0];
            row.Height = 30;

            column = GridClassification.Columns[0];
            column.Width = 10;
            column = GridClassification.Columns[1];
            column.Width = 30;
            column = GridClassification.Columns[2];
            column.Width = 30;
        }

        private void btnAjoutClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
        }
        private void btnDetailsClass_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetClassification();

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }

    }
}
