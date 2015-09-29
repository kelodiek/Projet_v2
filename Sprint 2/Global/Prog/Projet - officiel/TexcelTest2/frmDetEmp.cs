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
    public partial class frmDetEmp : frmDetail
    {
        public frmDetEmp()
        {
            InitializeComponent();
            btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(840, 658);
            this.btnSupprimer.Location = new Point(721, 658);
            this.btnActiverModif.Location = new Point(610, 658);
            this.btnEnregistrer.Location = new Point(500, 658);

        }
    }
}
