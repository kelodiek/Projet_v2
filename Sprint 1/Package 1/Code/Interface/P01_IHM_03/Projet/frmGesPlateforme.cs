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
    public partial class frmGesPlateforme : frmGestion
    {
        public frmGesPlateforme()
        {
            InitializeComponent();

            this.btnDetails.Click += new EventHandler(btnDetails_Click);

            this.btnAjout.Click += new EventHandler(btnAjout_Click);
        }

        private void Gestion_des_Plateformes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            DataGridView1.Columns.Add("ID","ID");
            DataGridView1.Columns.Add("Code", "Code");
            DataGridView1.Columns.Add("Nom", "Nom");
            DataGridView1.Columns.Add("Categ", "Catégorie");
            DataGridView1.Columns.Add("OS", "OS");
            DataGridView1.Columns.Add("Desc", "Description");

            column = DataGridView1.Columns[0];
            column.Width = 50;
            column = DataGridView1.Columns[1];
            column.Width = 50;
            column = DataGridView1.Columns[2];
            column.Width = 150;
            column = DataGridView1.Columns[3];
            column.Width = 150;
            column = DataGridView1.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetPlateforme();

            frmDetails.txtID.Enabled = false;
            frmDetails.txtCode.Enabled = false;
            frmDetails.txtCartemere.Enabled = false;
            frmDetails.txtCPU.Enabled = false;
            frmDetails.txtNom.Enabled = false;
            frmDetails.txtRam.Enabled = false;
            frmDetails.txtStockage.Enabled = false;
            frmDetails.rTxtDesc.Enabled = false;
            frmDetails.rTxtInfoSup.Enabled = false;

            frmDetails.cboxCateg.Enabled = false;

            frmDetails.btnAjoutOS.Enabled = false;
            frmDetails.btnEnregistrer.Enabled = false;

            frmDetails.ShowDialog();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetPlateforme();
            
            frmDetails.txtID.Enabled = false;

            frmDetails.btnActiverModif.Enabled = false;
            frmDetails.btnActiverModif.Visible = false;

            frmDetails.ShowDialog();
        }
    }
}
