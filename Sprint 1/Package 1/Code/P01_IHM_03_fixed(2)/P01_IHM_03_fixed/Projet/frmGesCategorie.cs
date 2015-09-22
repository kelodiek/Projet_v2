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
            this.btnDetails.Click += new EventHandler(btnDetails_Click);
            this.btnAjout.Click += new EventHandler(ajoutCategorie_Click);
        }

        private void frmGesCategorie_Load(object sender, EventArgs e)
        {
            var donnees = gestionCateg.charger();
            DataGridViewColumn column;
            gridCateg.Columns.Add("codeCateg", "Code");
            gridCateg.Columns.Add("descCateg", "Description");
            gridCateg.Columns.Add("comCateg", "Commentaire");

            column = gridCateg.Columns[0];
            column.Width = 75;
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
        public void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridCateg.SelectedRows.Count == 1)
            {
                modifierCateg();
            }
            else
            {
                // erreure
            }
            
        }
        private void modifierCateg() 
        {
            var frmDetails = new frmDetCateg();
            Categorie categSelect = new Categorie();
            int index = gridCateg.SelectedRows[0].Index;

            categSelect.codeCateg = (string)gridCateg.Rows[index].Cells[0].Value;
            categSelect.descCateg = (string)gridCateg.Rows[index].Cells[1].Value;
            categSelect.comCateg = (string)gridCateg.Rows[index].Cells[2].Value;

            frmDetails.categSelect = categSelect;
            frmDetails.modifierChamp("m");

            frmDetails.ShowDialog();
            update();
        }

        private void gridCateg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridCateg.Rows[e.RowIndex].Selected = true;
                modifierCateg();
            }
        }

        private void gridCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridCateg.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
