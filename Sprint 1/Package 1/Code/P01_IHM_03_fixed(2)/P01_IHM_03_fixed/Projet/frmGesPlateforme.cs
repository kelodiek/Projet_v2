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
        ctrlPlateforme ctrlPlate;
        public frmGesPlateforme()
        {
            InitializeComponent();

            ctrlPlate = new ctrlPlateforme();
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(btnAjout_Click);
            
            ButtonsVisible(true);
        }

        private void Gestion_des_Plateformes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            gridPlateforme.Columns.Add("ID","ID");
            gridPlateforme.Columns.Add("Code", "Code");
            gridPlateforme.Columns.Add("Nom", "Nom");
            gridPlateforme.Columns.Add("Categ", "Catégorie");
            gridPlateforme.Columns.Add("Desc", "Description");

            column = gridPlateforme.Columns[0];
            column.Width = 50;
            column = gridPlateforme.Columns[1];
            column.Width = 100;
            column = gridPlateforme.Columns[2];
            column.Width = 150;
            column = gridPlateforme.Columns[3];
            column.Width = 150;
            column = gridPlateforme.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            updateDonnees();
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

            //frmDetails.btnAjoutOS.Enabled = false;
            frmDetails.btnEnregistrer.Enabled = false;

            frmDetails.ShowDialog();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetPlateforme();

            frmDetails.txtID.Enabled = false;

            frmDetails.btnActiverModif.Enabled = false;

            frmDetails.ShowDialog();
        }

        private void afficherDonnees()
        {
            var lstRows = ctrlPlate.chargerDonnees();

            foreach (var item in lstRows)
            {
                gridPlateforme.Rows.Add(item);
            }
        }
        private void retirerDonnees()
        {
            gridPlateforme.Rows.Clear();
        }

        private void updateDonnees()
        {
            retirerDonnees();
            afficherDonnees();
        }
    }
}
