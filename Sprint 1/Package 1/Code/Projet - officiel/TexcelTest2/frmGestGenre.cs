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
    public partial class frmGesGenre : frmGestion
    {
        public frmGesGenre()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutGenre_click);
            this.btnDetails.Click += new EventHandler(detailsGenre_click);
            ButtonsVisible(true);
        }

        private void frmGesGenre_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridGenre.Columns.Add("IdGenre", "ID");
            GridGenre.Columns.Add("CodeGenre", "Code");
            GridGenre.Columns.Add("NomGenre", "Nom");

            DataGridViewRow row = GridGenre.Rows[0];
            row.Height = 30;

            column = GridGenre.Columns[0];
            column.Width = 10;
            column = GridGenre.Columns[1];
            column.Width = 30;
            column = GridGenre.Columns[2];
            column.Width = 30;
        }
        private void detailsGenre_click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetGenre();

            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
        }
        private void ajoutGenre_click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetGenre();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
        }
    }
}
