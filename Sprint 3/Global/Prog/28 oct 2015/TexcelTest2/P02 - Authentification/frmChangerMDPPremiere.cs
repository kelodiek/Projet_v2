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
    partial class frmChangerMDPPremiere : Form
    {
        ctrlLogin ctrllogin;
        Utilisateur U;
        public frmChangerMDPPremiere()
        {
            InitializeComponent();
        }
        public void SetUser(Utilisateur u)
        {
            U = u;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            ctrllogin = new ctrlLogin();
            bool AFonctionner = false;

            if(txtMDP1.Text == txtMDP2.Text)
            {
                AFonctionner = ctrllogin.ChangerMotDePasse(U, txtMDP2.Text);
                if(AFonctionner)
                {
                    MessageBox.Show("Succès de l'enregistrement.");
                    frmGestion formOuvert = new frmGestion();
                    formOuvert.ShowDialog();
                    this.Hide();
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
