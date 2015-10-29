using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.P02___Personnel.Equipe
{
    public partial class frmDetEquipe : frmDetail
    {
        public frmDetEquipe()
        {
            InitializeComponent();
            this.btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(841, 360);
            this.btnSupprimer.Location = new Point(240, 360);
            this.btnActiverModif.Location = new Point(125, 360);
            this.btnEnregistrer.Location = new Point(10, 360);
        }
    }
}
