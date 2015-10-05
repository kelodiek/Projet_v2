using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Trouver comment arranger ça:
using Projet.P02___Personnel.Employe;
using Projet.P02___Personnel.Equipe;
// Note a Oli #1:
// Oublie pas de faire les rapport pour chaque truc de gestion de donnees.


// Interface de base pour toutes le fenetre
// de Gestion dans la l'administration des donnees.
namespace Projet
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
            ButtonsVisible(false);
        }
        private void donneesToolStrip_Click(object sender, EventArgs e)
        {
            var formOuvert = new Form();
            string nomButton = ((ToolStripMenuItem)sender).Name;

            switch (nomButton)
            {
                case "btnSysExpToolStrip":
                    formOuvert = new frmGesSysExp(); 
                    break;
                case "btnPlateToolStrip":
                    formOuvert = new frmGesPlateforme();
                    break;
                case "btnJeuToolStrip":
                    formOuvert = new frmGestJeu();
                    break;
                case "btnClassToolStrip":
                    formOuvert = new frmGesClassification();
                    break;
                case "btnGenreToolStrip":
                    formOuvert = new frmGesGenre();
                    break;
                case "btnThemeToolStrip":
                    formOuvert = new frmGesTheme();
                    break;
                case "btnVersionToolStrip":
                    formOuvert = new frmGesVersion();
                    break;
                case "btnModeToolStrip":
                    formOuvert = new frmGesMode();
                    break;
                case "btnDecoToolStrip":
                    formOuvert = new frmGesCon();
                    break;
                case "btnCategToolStrip":
                    formOuvert = new frmGesCategorie();
                    break;
                default:
                    break;
            }
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();

        }
        protected void ButtonsVisible(bool Visible)
        {
            if (!Visible)
            {
                btnAjout.Visible = false;
                btnDetails.Visible = false;
                txtRecherche.Visible = false;
                btnRecherche.Visible = false;
                btnX.Visible = false;
            }
            else
            {
                btnAjout.Visible = true;
                btnDetails.Visible = true;
                txtRecherche.Visible = true;
                btnRecherche.Visible = true;
                btnX.Visible = true;
            }
        }
        private void btnQuitterToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void toolStripDetEmp_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmDetEmp();
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void toolStripGesEmp_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesEmp();
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void toolStripDetEquipe_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmDetEquipe();
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void toolStripGesEquipe_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesEquipe();
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

    }
}
