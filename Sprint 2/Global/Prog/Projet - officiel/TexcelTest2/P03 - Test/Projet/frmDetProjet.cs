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
    public partial class frmDetProjet : frmDetail
    {
        public frmDetProjet()
        {
            InitializeComponent();
            this.btnActiverModif.Click += new EventHandler(activerModif_Click);
            this.btnEnregistrer.Click += new EventHandler(btnEnregistrer_Click);
            this.btnCopier.Click += new EventHandler(btnCopier_Click);
            this.btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(1294, 660);
        }

        public void activerModif_Click(object sender, EventArgs e)
        {

        }
        public void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
        public void btnCopier_Click(object sender, EventArgs e)
        {

        }

        private void frmDetProjet_Load(object sender, EventArgs e)
        {

        }

        private void gridEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
