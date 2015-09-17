using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    formOuvert = new frmGesJeu();
                    break;
                case "btnClassToolStrip":
                    formOuvert = new frmGestClassification();
                    break;
                case "btnGenreToolStrip":
                    formOuvert = new frmGesGenre();
                    break;
                case "btnThemeToolStrip":
                    formOuvert = new frmGestTheme();
                    break;
                case "btnVersionToolStrip":
                    formOuvert = new frmGestVersion();
                    break;
                case "btnModeToolStrip":
                    formOuvert = new frmGesMode();
                    break;
                case "btnDecoToolStrip":
                    formOuvert = new frmGesCon();
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
                btnSupprimer.Visible = false;
                txtRecherche.Visible = false;
                btnRecherche.Visible = false;
            }
            else
            {
                btnAjout.Visible = true;
                btnDetails.Visible = true;
                btnSupprimer.Visible = true;
                txtRecherche.Visible = true;
                btnRecherche.Visible = true;
            }
        }
        private void btnQuitterToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
