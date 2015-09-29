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
    public partial class frmDetClassification : frmDetail
    {
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"> "a" pour ajouter, "m" pour modification</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.txtCote.Enabled = false;
                this.txtDescription.Enabled = false;
                this.txtNom.Enabled = false;
            }
        }
    }
}
