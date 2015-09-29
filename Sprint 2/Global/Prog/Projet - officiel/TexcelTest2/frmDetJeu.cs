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
    public partial class frmDetJeu : frmDetail
    {
        public frmDetJeu()
        {
            InitializeComponent();
        }

        private void btnAjoutGenre_Click(object sender, EventArgs e)
        {
            frmSelection f = new frmSelection();
            f.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">"a" Ajout,"m" Modifier</param>
        public void modifierChamp(string code)
        {
            if (code == "a")
            {
                this.btnActiverModif.Visible = false;
            }
            else
            {
                this.rtxtDesc.Enabled = false;
                this.txtID.Enabled = false;
                this.txtNom.Enabled = false;
                this.dateSortie.Enabled = false;
                this.rtxtInfoSup.Enabled = false;
                this.cboxGenre.Enabled = false;
                this.cboxMode.Enabled = false;

                this.btnEnregistrer.Enabled = false;
                this.btnAjoutPlateforme.Enabled = false;
                this.btnAjoutTheme.Enabled = false;
            }
            // Quand tu vas retrouver ca Olivier tu t'arrangera pour utiliser ca pis modifier 
            // les parties de modification en consequence(si tu le fait pas t'es juste une grosse 
            // vache pis tu peux aller chier)

            //foreach (Control item in this.Controls)
            //{
            //    item.Enabled = false;
            //}
        }
    }
}
