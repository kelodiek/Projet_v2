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
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            ((Button)sender).Enabled = false;
        }
        protected void PositionBtn(int y)
        {
            this.btnEnregistrer.Location = new System.Drawing.Point(10, y);
            this.btnActiverModif.Location = new System.Drawing.Point(125, y);
            this.btnSupprimer.Location = new System.Drawing.Point(240, y);
            this.btnAnnuler.Location = new System.Drawing.Point(359, y);
        }


    }
}
