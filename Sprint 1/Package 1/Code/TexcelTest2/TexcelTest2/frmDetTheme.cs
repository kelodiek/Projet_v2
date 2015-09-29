using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexcelTest2
{
    public partial class frmDetTheme : frmDetail
    {
        public frmDetTheme()
        {
            InitializeComponent();
            this.PositionBtn(140);
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

                this.btnEnregistrer.Enabled = false;
            }
        }
    }
}
