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
    partial class frmChangerMDPExpire : Form
    {
        ctrlLogin ctrllogin;
        Utilisateur U;
        private string uss, RR;
        public frmChangerMDPExpire()
        {
            InitializeComponent();
        }
        //      avec authentification
        public frmChangerMDPExpire(string _us, string rol)
        {
            InitializeComponent();
            uss = _us;
            RR = rol;
        }

        public void SetUser(Utilisateur u)
        {
            U = u;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void txtMDP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                enregistrer();
        }

        private void enregistrer()
        {
            ctrllogin = new ctrlLogin();
            bool AFonctionner = false;

            if (txtMDP1.Text == txtMDP2.Text)
            {
                AFonctionner = ctrllogin.ChangerMotDePasse(U, txtMDP2.Text);
                if (AFonctionner)
                {
                    MessageBox.Show("Succès de l'enregistrement.");
                    frmGestion formOuvert = new frmGestion(uss, RR);
                    this.Hide();
                    formOuvert.Show();
                    formOuvert.Closed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
            else
            {
                MessageBox.Show("Les deux mots de passe ne correspondent pas.");
            }
        }
    }
}
