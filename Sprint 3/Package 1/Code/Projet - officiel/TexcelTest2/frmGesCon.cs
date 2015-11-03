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
        public frmGesCon()
        {
            InitializeComponent();
            //pictureBox1.Image = global::Projet.Properties.Resources.Texcel_logo_v2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new frmAccueilAdmin();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
