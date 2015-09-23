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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Popup_Accueil form = new Popup_Accueil();
            form.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
        }



        private void consoleAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccueilAdmin form = new frmAccueilAdmin();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }


        private void treeView2_Click(object sender, EventArgs e)
        {
            Popup_Accueil f = new Popup_Accueil();
            f.Show();
            f.Activate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Popup_Accueil f = new Popup_Accueil();
            f.Show();
        }
    }
}
