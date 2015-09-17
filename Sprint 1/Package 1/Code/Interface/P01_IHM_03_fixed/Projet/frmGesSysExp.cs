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
    public partial class frmGesSysExp : frmGestion
    {
        public frmGesSysExp()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutSysExp_Click);
            btnDetails.Click += new EventHandler(detailSysExp_Click);
            ButtonsVisible(true);
        }
        private void ajoutSysExp_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetSysExp();

            frmDetails.modifierChamp("a");

            frmDetails.Show();
        }
        private void detailSysExp_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetSysExp();

            frmDetails.modifierChamp("m");

            frmDetails.Show();
        }
    }
}
