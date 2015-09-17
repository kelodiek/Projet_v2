using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDetPlateforme : Form
    {
        public frmDetPlateforme()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActiverModif_Click(object sender, EventArgs e)
        {
            txtCartemer.Enabled = true;
            txtCode.Enabled = true;
            txtCPU.Enabled = true;
            txtID.Enabled = true;
            txtInfoSup.Enabled = true;
            txtNom.Enabled = true;
            txtRam.Enabled = true;
            txtStokage.Enabled = true;

            btnAjoutOS.Enabled = true;
            btnSupprimerOS.Enabled = true;
        }
    }
}
