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
    public partial class frmDetSysExp : frmDetail
    {
        public frmDetSysExp()
        {
            InitializeComponent();
            this.PositionBtn(315);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">"a" Ajout, "m" Modifier</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.rtxtInfos.Enabled = false;
                this.txtID.Enabled = false;
                this.txtNom.Enabled = false;
                this.txtVersion.Enabled = false;
                this.txtEdition.Enabled = false;
                this.txtCode.Enabled = false;

                this.btnEnregistrer.Enabled = false;
            }
        }
    }
}
