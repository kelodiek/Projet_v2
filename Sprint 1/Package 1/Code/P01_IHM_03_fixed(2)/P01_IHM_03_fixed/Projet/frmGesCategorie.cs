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
    public partial class frmGesCategorie : frmGestion
    {
        ctrlCategorie gestionCateg;
        public frmGesCategorie()
        {
            InitializeComponent();
            gestionCateg = new ctrlCategorie();
            this.ButtonsVisible(true);
        }

        private void frmGesCategorie_Load(object sender, EventArgs e)
        {
            var donnees = gestionCateg.chargerCateg();
            DataGridViewColumn column;
            gridCateg.Columns.Add("codeCateg", "Code");
            gridCateg.Columns.Add("descCateg", "Description");
            gridCateg.Columns.Add("comCateg", "Commentaire");

            column = gridCateg.Columns[0];
            column.Width = 50;
            column = gridCateg.Columns[1];
            column.Width = 200;
            column = gridCateg.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var item in donnees)
            {
                int rowIndex = gridCateg.Rows.Add(item);
                gridCateg.Rows[rowIndex].Tag = item.Last();
            }
        }
        private void ajoutCategorie_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetCateg();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            update();
        }
        private void update()
        {
            gestionCateg = new ctrlCategorie();
            var formOuvert = new frmGesCategorie();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }
    }
}
