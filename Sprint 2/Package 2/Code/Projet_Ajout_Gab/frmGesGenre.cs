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
    public partial class frmGesGenre : frmGestion
    {
        ctrlGenre gestionGenre;

        public frmGesGenre()
        {
            InitializeComponent();
            gestionGenre = new ctrlGenre();
            this.btnAjout.Click += new EventHandler(ajoutGenre_click);
            this.btnDetails.Click += new EventHandler(detailsGenre_click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void frmGesGenre_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            GridGenre.Columns.Add("IdGenre", "ID");
            GridGenre.Columns.Add("NomGenre", "Nom");
            GridGenre.Columns.Add("ComGenre", "Commentaire");

            column = GridGenre.Columns[0];
            column.Width = 30;
            column = GridGenre.Columns[1];
            column.Width = 250;
            column = GridGenre.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chargeDonnees();
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                rechercher();
            }
        }

        public void rechercher()
        {
            if (txtRecherche.Text != "")
            {
                GridGenre.Rows.Clear();
                foreach (Genre g in gestionGenre.recherche(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { g.idGenre.ToString(), g.nomGenre, g.comGenre };
                    GridGenre.Rows.Add(tabTemp);
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une information a rechercher");
            }
        }

        private void chargeDonnees()
        {
            var data = gestionGenre.charger();

            foreach (var item in data)
            {
                int rowIndex = GridGenre.Rows.Add(item);
                GridGenre.Rows[rowIndex].Tag = item.Last();
            }
        }

        private void detailsGenre_click(object sender, EventArgs e)
        {
            if (GridGenre.SelectedRows.Count == 1)
                modifierGenre();
        }

        private void modifierGenre()
        {
            var detGenre = new frmDetGenre();
            Genre genreSel = new Genre();
            int index = GridGenre.SelectedRows[0].Index;

            genreSel.idGenre = Int32.Parse((string)GridGenre.Rows[index].Cells[0].Value);
            genreSel.nomGenre = (string)GridGenre.Rows[index].Cells[1].Value;
            genreSel.comGenre = (string)GridGenre.Rows[index].Cells[2].Value;

            detGenre.genreSelect = genreSel;
            detGenre.modifierChamp("m");
            detGenre.ShowDialog();

            update();
        }

        private void ajoutGenre_click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetGenre();

            frmDetails.modifierChamp("a");

            frmDetails.ShowDialog();
            update();
        }

        private void GridGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridGenre.Rows[e.RowIndex].Selected = true;
            }
        }

        private void GridGenre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridGenre.Rows[e.RowIndex].Selected = true;
                modifierGenre();
            }
        }

        public void update()
        {
            gestionGenre = new ctrlGenre();
            var formOuvert = new frmGesGenre();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            GridGenre.Rows.Clear();
            chargeDonnees();
            txtRecherche.Text = "";
        }

    }
}
