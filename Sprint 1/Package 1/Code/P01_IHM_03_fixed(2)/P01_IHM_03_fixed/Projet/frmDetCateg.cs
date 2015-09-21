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
    public partial class frmDetCateg : frmDetail
    {
        private Categorie categSelectionner;

        public Categorie CategSelect
        {
            get { return categSelectionner; }
            set { categSelectionner = value; }
        }

        public frmDetCateg()
        {
            InitializeComponent();
            this.PositionBtn(194);
        }
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.txtCode.Enabled = false;
                this.txtDesc.Enabled = false;
                this.rtxtCommentaire.Enabled = false;
                remplirChamp();
            }
        }
        private void remplirChamp()
        {
            txtCode.Text = categSelectionner.codeCateg;
            txtDesc.Text = categSelectionner.descCateg;
            rtxtCommentaire.Text = categSelectionner.comCateg;
        }
    }
}
