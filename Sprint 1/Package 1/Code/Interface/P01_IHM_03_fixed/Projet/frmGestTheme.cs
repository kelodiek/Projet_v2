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
    public partial class frmGestTheme : frmGestion
    {
        public frmGestTheme()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutTheme_Click);
            btnDetails.Click += new EventHandler(detailTheme_Click);
            ButtonsVisible(true);
        }
        private void ajoutTheme_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetTheme();

            frmDetails.modifierChamp("a");

            frmDetails.Show();
        }
        private void detailTheme_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetTheme();

            frmDetails.modifierChamp("m");

            frmDetails.Show();
        }

        private void frmGestTheme_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridTheme.Columns.Add("IdTheme", "ID");
            GridTheme.Columns.Add("CodeTheme", "Code");
            GridTheme.Columns.Add("NomTheme", "Nom");

            column = GridTheme.Columns[0];
            column.Width = 30;
            column = GridTheme.Columns[1];
            column.Width = 50;
            column = GridTheme.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
