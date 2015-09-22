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
    public partial class frmDetClassification : frmDetail
    {
        ControleClassification cc;
        public frmDetClassification()
        {
            InitializeComponent();
            this.PositionBtn(144);
            cc = new ControleClassification();
        }

        public void modifierChamp(string cote, string nom, string desc)
        {
            this.txtCote.ReadOnly = true;
            this.txtDescription.ReadOnly = true;
            this.txtNom.ReadOnly = true;
            txtCote.Text = cote;
            txtNom.Text = nom;
            txtDescription.Text = desc;
        }

        public void modifierChamp()
        {          
            this.btnActiverModif.Visible = false;
        }
    }
}
