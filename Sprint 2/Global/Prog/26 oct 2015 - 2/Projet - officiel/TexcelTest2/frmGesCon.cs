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

namespace Projet
{
    public partial class frmGesCon : Form
    {
        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();
        public frmGesCon()
        {
            InitializeComponent();
            pictureBox1.Image = global::Projet.Properties.Resources.Texcel_logo_v2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt")))
            {
                DialogResult tmp = MessageBox.Show("il y a de nouveau employe à ajouter dans le système, voulez-vous les ajouter maintenant ?", "Nouveau employe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tmp == DialogResult.Yes)
                {
                    var formOuvert = new frmGesEmp("nouv");
                    this.Hide();
                    formOuvert.Show();
                    formOuvert.Closed += (s, args) => this.Close();
                }
                else
                {
                    var form = new frmAccueilAdmin();
                    this.Hide();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
            }
            else
            {
                var form = new frmAccueilAdmin();
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
}
