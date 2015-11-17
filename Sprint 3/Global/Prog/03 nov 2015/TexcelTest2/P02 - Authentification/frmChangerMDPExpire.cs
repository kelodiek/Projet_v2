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
        public frmChangerMDPExpire()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void SetUser(Utilisateur u)
        {
            U = u;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            ctrllogin = new ctrlLogin();
            bool AFonctionner = false;

            if (txtMDP1.Text == txtMDP2.Text)
            {
                AFonctionner = ctrllogin.ChangerMotDePasse(U, txtMDP2.Text);
                if (AFonctionner)
                {
                    MessageBox.Show("Succès de l'enregistrement.");
                    frmGestion formOuvert = new frmGestion();
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
