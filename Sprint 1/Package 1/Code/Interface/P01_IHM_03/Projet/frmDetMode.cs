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
    public partial class frmDetMode : frmDetail
    {
        public frmDetMode()
        {
            InitializeComponent();
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.txtID.Enabled = false;
                this.rtxtDesc.Enabled = false;
                this.txtNom.Enabled = false;
            }
        }
    }
}
