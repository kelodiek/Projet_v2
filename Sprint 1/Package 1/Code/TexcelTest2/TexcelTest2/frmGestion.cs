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
                    formOuvert = new frmGestPlateforme();
                    break;
                case "btnJeuToolStrip":
                    formOuvert = new frmGestJeu();
                    break;
                case "btnClassToolStrip":
                    formOuvert = new frmGestClassification();
                    break;
                case "btnGenreToolStrip":
                    formOuvert = new frmGestGenre();
                    break;
                case "btnThemeToolStrip":
                    formOuvert = new frmGestTheme();
                    break;
                case "btnVersionToolStrip":
                    formOuvert = new frmGestVersion();
                    break;
                case "btnModeToolStrip":
                    formOuvert = new frmGestMode();
                    break;
                case "btnDecoToolStrip":
                    formOuvert = new frmGestCon();
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
