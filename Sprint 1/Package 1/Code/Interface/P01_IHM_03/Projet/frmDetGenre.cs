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
    public partial class frmDetGenre : frmDetail
    {
        public frmDetGenre()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">"a" Ajouter,"m" Modifier</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.txtCode.Enabled = false;
                this.txtId.Enabled = false;
                this.txtNom.Enabled = false;
            }
        }
    }
}
