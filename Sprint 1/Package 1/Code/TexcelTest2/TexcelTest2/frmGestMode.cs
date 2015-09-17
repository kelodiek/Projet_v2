using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexcelTest2
{
    public partial class frmGestMode : frmGestion
    {
        public frmGestMode()
        {
            InitializeComponent();
            this.btnAjout.Click += new EventHandler(ajoutMode_Click);
            this.btnDetails.Click += new EventHandler(detailsMode_Click);
            ButtonsVisible(true);
        }

        private void frmGesMode_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            dataGridMode.Columns.Add("IdMode", "ID");
            dataGridMode.Columns.Add("NomMode", "Nom");
            dataGridMode.Columns.Add("DescMode", "Description");

            column = dataGridMode.Columns[0];
            column.Width = 30;
            column = dataGridMode.Columns[1];
            column.Width = 50;
            column = dataGridMode.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ajoutMode_Click(object sender, EventArgs e)
        {
            var detailsMode = new frmDetMode();

            detailsMode.modifierChamp("a");

            detailsMode.ShowDialog();
        }
        private void detailsMode_Click(object sender, EventArgs e)
        {
            var detailsMode = new frmDetMode();

            detailsMode.modifierChamp("m");

            detailsMode.ShowDialog();
        }
    }
}
