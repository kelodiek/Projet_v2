using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Note a Oli #1:
// Oublie pas de faire les rapport pour chaque truc de gestion de donnees.

//  Pour l'authentification, je vais passer le groupe de l'utilisateur en
//  paramètre des page gestion et créer une fonction qui voie si ce groupe
//  a le droit de lecture et d'écriture pour cette page avec un lvlAcces
//  0 = rien / 1 = lecture / 2 = écriture / 3 = tout / 4 = admin pour certain truc

// Interface de base pour toutes le fenetre
// de Gestion dans la l'administration des donnees.
namespace Projet
{
    public partial class frmGestion : Form
    {
        protected string UserNm;

        public frmGestion()
        {
            InitializeComponent();
            ButtonsVisible(false);
        }

        public frmGestion(string _us, string rol)
        {
            InitializeComponent();
            ButtonsVisible(false);
            UserNm = _us;
            CacheDroit(rol);
        }
        private void donneesToolStrip_Click(object sender, EventArgs e)
        {
            var formOuvert = new Form();
            string nomButton = ((ToolStripMenuItem)sender).Name;

            switch (nomButton)
            {
                case "btnSysExpToolStrip":
                    formOuvert = new frmGesSysExp(UserNm); 
                    break;
                case "btnPlateToolStrip":
                    formOuvert = new frmGesPlateforme(UserNm);
                    break;
                case "btnJeuToolStrip":
                    formOuvert = new frmGestJeu(UserNm);
                    break;
                case "btnClassToolStrip":
                    formOuvert = new frmGesClassification(UserNm);
                    break;
                case "btnGenreToolStrip":
                    formOuvert = new frmGesGenre(UserNm);
                    break;
                case "btnThemeToolStrip":
                    formOuvert = new frmGesTheme(UserNm);
                    break;
                case "btnModeToolStrip":
                    formOuvert = new frmGesMode(UserNm);
                    break;
                case "btnDecoToolStrip":
                    formOuvert = new frmGesCon();
                    break;
                case "btnCategToolStrip":
                    formOuvert = new frmGesCategorie(UserNm);
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

        //          nouveau toutes
        public void VerifierNouveauxEmp()
        {
            bool New = File.Exists(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt"));
            if (New)
            {
                int i = 0;
                string line;
                StreamReader file = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt"));
                while ((line = file.ReadLine()) != null)
                {
                    i++;
                }
                file.Close();
                DialogResult tmp = MessageBox.Show("il y a " + i + " nouveau employe à ajouter dans le système,\n voulez-vous les ajouter maintenant ?", "Nouveau employe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tmp == DialogResult.Yes)
                {
                    var formOuvert = new frmGesEmp(true, UserNm);
                    this.Hide();
                    formOuvert.Show();
                    formOuvert.Closed += (s, args) => this.Close();
                }
            }
        }

        private void CacheDroit(string _rol)
        {
            switch (_rol)
            {
                case "Administrateur": // accès à tout
                    var formOuvert = new frmGesEmp(UserNm);
                    this.Hide();
                    formOuvert.Show();
                    formOuvert.Closed += (s, args) => this.Close();
                    break;
                case "Chef de projet":

                    //var formOuvert1 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert1.Show();
                    //formOuvert1.Closed += (s, args) => this.Close();
                    break;
                case "Chef d’équipe":

                    //var formOuvert2 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert2.Show();
                    //formOuvert2.Closed += (s, args) => this.Close();
                    break;
                case "Testeur":
                    btnCategToolStrip.Visible = false;
                    //var formOuvert6 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert6.Show();
                    //formOuvert6.Closed += (s, args) => this.Close();
                    break;
                case "Agente de bureau":
                    break;
                case "Directeur de compte":

                    //var formOuvert3 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert3.Show();
                    //formOuvert3.Closed += (s, args) => this.Close();
                    break;
                case "PDG":

                    //var formOuvert4 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert4.Show();
                    //formOuvert4.Closed += (s, args) => this.Close();
                    break;
                case "Client":
                    break;
                case "Modérateur du focus groupe":
                    break;
                default:
                    //var formOuvert5 = new frmGesEmp(UserNm);
                    //this.Hide();
                    //formOuvert5.Show();
                    //formOuvert5.Closed += (s, args) => this.Close();
                    break;
            }
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


        private void toolStripGesEmp_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesEmp(UserNm);
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void toolStripGesEquipe_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesEquipe(UserNm);
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesGroupeUser(UserNm);
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void typeDeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formOuvert = new frmGesTypeTest(UserNm);
            this.Hide();
            formOuvert.Show();
            formOuvert.Closed += (s, args) => this.Close();
        }

        protected void disableMenu()
        {
            menuStrip1.Enabled = false;
        }
    }
}
