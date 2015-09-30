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
    public partial class frmDetOS : frmDetail
    {
        public frmDetOS()
        {
            InitializeComponent();
        }

        private void PopupOS_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Id,Code,Nom,Edition,Version,Infos;
            Id = txtId.Text;
            Code = txtCode.Text;
            Nom = txtNom.Text;
            Edition = txtEdition.Text;
            Version = txtVersion.Text;
            Infos = txtInfos.Text;

            frmDetOS form = new frmDetOS();

            form.txtCode.Text = Code;
            form.txtId.Text = (Convert.ToInt32(Id) + 1).ToString();
            form.txtNom.Text = Nom;
            form.txtEdition.Text = Edition;
            form.txtVersion.Text = Version;
            form.txtInfos.Text = Infos;

            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGesSysExp form = new frmGesSysExp();
            this.Hide();
            form.Closed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
