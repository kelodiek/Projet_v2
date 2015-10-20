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
    public partial class frmDetCasTest : frmDetail
    {
        public frmDetCasTest()
        {
            InitializeComponent();
            this.btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(822, 658);
        }
    }
}
