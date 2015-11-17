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
    public partial class frmDetVersion : frmDetail
    {
        public frmDetVersion()
        {
            InitializeComponent();
            this.PositionBtn(350);
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.txtId.Enabled = false;
                this.txtNom.Enabled = false;
                this.txtCode.Enabled = false;
                this.txtStade.Enabled = false;
                this.rtxtDesc.Enabled = false;
                this.dateSortie.Enabled = false;
                this.dateVersion.Enabled = false;

                this.btnEnregistrer.Enabled = false;
            }
        }

    }
}
