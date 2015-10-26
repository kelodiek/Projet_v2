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
    public partial class frmGesProjet : frmGestion
    {
        public frmGesProjet()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutProjet_Click);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnRecherche.Click += new System.EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);

            ButtonsVisible(true);
        }
        public void ajoutProjet_Click(object sender, EventArgs e)
        {

        }
        public void btnDetails_Click(object sender, EventArgs e)
        {

        }
        public void btnRecherche_Click(object sender, EventArgs e)
        {

        }
        public void btnX_Click(object sender, EventArgs e)
        {

        }

    }
}
