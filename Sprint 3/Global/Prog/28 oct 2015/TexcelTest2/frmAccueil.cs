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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPopupAccueil form = new frmPopupAccueil();
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
            frmPopupAccueil f = new frmPopupAccueil();
            f.Show();
            f.Activate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmPopupAccueil f = new frmPopupAccueil();
            f.Show();
        }
    }
}
