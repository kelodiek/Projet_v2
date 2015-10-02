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
    public partial class frmGesEmploye : frmGestion
    {
        public frmGesEmploye()
        {
            InitializeComponent();
            chargerColones();
            btnDetails.Visible = true;
            btnRecherche.Visible = true;
            txtRecherche.Visible = true;

            btnDetails.Click += new EventHandler(btnDetails_Click);
            this.Text = "Texel : Gestion - Employés";
        }

        public frmGesEmploye(string nouv)
        {
            InitializeComponent();
            chargerColones();
            btnDetails.Visible = false;
            btnAjout.Visible = true;
            btnAjout.Left = btnDetails.Left;
            btnRecherche.Visible = true;
            txtRecherche.Visible = true;

            btnDetails.Click += new EventHandler(btnDetails_Click);
            this.Text = "Texel : Gestion - Nouveaux Employés";
        }


        private void chargerColones()
        {
            DataGridViewColumn column;
            gridEmploye.Columns.Add("PrenomEmp", "Prenom");
            gridEmploye.Columns.Add("NomEmp", "Nom");
            gridEmploye.Columns.Add("CourrielEmp", "Courriel");
            gridEmploye.Columns.Add("TelPrin", "Telephone Principal");
            gridEmploye.Columns.Add("TelPrin", "Telephone Secondaire");
            gridEmploye.Columns.Add("DateEmbaucheEmp", "Date Embauche");
            gridEmploye.Columns.Add("CommentaireEmp", "Commentaire");

            //DataGridViewRow row = GridClassification.Rows[0];
            //row.Height = 30;
            column = gridEmploye.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[6];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmDetEmploye detEmploye = new frmDetEmploye();
            detEmploye.ShowDialog();
        }

    }
}
