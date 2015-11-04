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
    public partial class frmGesCon : Form
    {
        ctrlLogin ctrllogin;
        ctrlComptes ctrlcompte;
        public frmGesCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ctrllogin = new ctrlLogin();
            ctrlcompte = new ctrlComptes();
            string Username, PWD;
            Username = txtUsername.Text;
            PWD = txtMDP.Text;
            bool Valide = false;
            bool Premiere = false;

            string Expire = "";
            Valide = ctrllogin.VerifierUserPWD(Username, PWD);
            //Si Username et Password valides
            if (Valide)
            {
                ctrllogin.SetUserAttributes(); //Donne tous les attributs(PremiereConex,IdRole etc) a l'utilisateur dans ctrl
                ctrllogin.VerifierExpiration();
                Premiere = ctrllogin.PremiereConnexion(Username);
                Expire = ctrllogin.MotDePasseExpire(Username);
                if (Premiere)
                {
                    var form = new frmChangerMDPPremiere();
                    form.SetUser(ctrllogin.user);
                    this.Hide();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                else if (Expire == "o")
                {
                    var form = new frmChangerMDPExpire();
                    form.SetUser(ctrllogin.user);
                    this.Hide();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                else
                {
                    if (Expire == "b")
                    {
                        MessageBox.Show("Votre mot de passe expire bientôt.\nS(moins de 10 jours)");
                    }
                    if (ctrlcompte.GetNomRole(ctrllogin.user.Role) == "Testeur")
                    {
                        //Ouvrir frmTest
                        var form = new frmGestion();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    else if ((ctrlcompte.GetNomRole(ctrllogin.user.Role) == "Administrateur") || (ctrlcompte.GetNomRole(ctrllogin.user.Role) == "Test"))
                    {
                        var form = new frmGestion();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        form.VerifierNouveauxEmp(); 
                    }
                    else
                    {
                        var form = new frmGestion();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    //A continuer pour tous les rôles
                }
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe invalide, veuillez réessayer.");
                txtMDP.Text = "";
            }
        }

        private void btnCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
