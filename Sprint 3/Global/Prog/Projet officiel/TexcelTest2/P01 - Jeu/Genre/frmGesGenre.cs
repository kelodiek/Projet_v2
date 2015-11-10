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
        private int lvlAcces;

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
            CreerGrid();
            if (GridGenre.RowCount > 0)
            {
                GridGenre.Sort(GridGenre.Columns[1], ListSortDirection.Ascending);
                GridGenre.Rows[0].Selected = true;
                this.Tag = GridGenre.Rows[0].Cells[1].Value.ToString(); 
            }
        }

        public frmGesGenre(string _us)
        {
            InitializeComponent();
            gestionGenre = new ctrlGenre();
            this.btnAjout.Click += new EventHandler(ajoutGenre_click);
            this.btnDetails.Click += new EventHandler(detailsGenre_click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            ButtonsVisible(true);
            CreerGrid();
            if (GridGenre.RowCount > 0)
            {
                GridGenre.Sort(GridGenre.Columns[1], ListSortDirection.Ascending);
                GridGenre.Rows[0].Selected = true;
                this.Tag = GridGenre.Rows[0].Cells[1].Value.ToString(); 
            }
            UserNm = _us;
            droitUser();
        }

        private void droitUser()
        {
            lvlAcces = gestionGenre.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                GridGenre.Rows.Clear();
            }
        }

        private void CreerGrid()
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

            GridGenre.Columns[0].Visible = false;
            chargeDonnees();
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces > 0)
                rechercher();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
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

                if(GridGenre.RowCount > 0)
                    GridGenre.Rows[0].Selected = true;
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
            var detGenre = new frmDetGenre(lvlAcces);
            Genre genreSel = new Genre();
            int index = GridGenre.SelectedRows[0].Index;

            genreSel.idGenre = Int32.Parse((string)GridGenre.Rows[index].Cells[0].Value);
            genreSel.nomGenre = (string)GridGenre.Rows[index].Cells[1].Value;
            genreSel.comGenre = (string)GridGenre.Rows[index].Cells[2].Value;

            detGenre.Tag = genreSel.nomGenre;
            detGenre.genreSelect = genreSel;
            detGenre.modifierChamp("m");
            detGenre.ShowDialog();
            if (detGenre.Tag.ToString() == "0")
                this.Tag = 0;
            else
                this.Tag = detGenre.Tag;
            update();
        }

        private void ajoutGenre_click(object sender, EventArgs e)
        {
            var Details = new frmDetGenre(lvlAcces);

            if (GridGenre.SelectedRows.Count == 0)
                Details.Tag = "0";
            else
                Details.Tag = this.Tag;

            Details.modifierChamp("a");
            Details.ShowDialog();
            if (Details.Tag.ToString() == "0")
                this.Tag = "0";
            else
                this.Tag = Details.Tag;
            update();
        }

        private void GridGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridGenre.Rows[e.RowIndex].Selected = true;
                this.Tag = GridGenre.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void GridGenre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridGenre.Rows[e.RowIndex].Selected = true;
                this.Tag = GridGenre.Rows[e.RowIndex].Cells[1].Value.ToString();
                modifierGenre();
            }
        }

        public void update()
        {
            gestionGenre = new ctrlGenre();
            int colum = GridGenre.SortedColumn.Index;
            ListSortDirection DD = ListSortDirection.Descending;
            if (GridGenre.SortOrder == SortOrder.Ascending)
                DD = ListSortDirection.Ascending;
            
            GridGenre.Rows.Clear();
            chargeDonnees();
            GridGenre.Sort(GridGenre.Columns[colum], DD);
            int R = RowsByNm(this.Tag.ToString());
            GridGenre.Rows[R].Cells[1].Selected = true;
            GridGenre.Rows[R].Selected = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            GridGenre.Rows.Clear();
            chargeDonnees();
            txtRecherche.Text = "";
            GridGenre.Sort(GridGenre.Columns[1], ListSortDirection.Ascending);
            GridGenre.Rows[0].Cells[1].Selected = true;
            GridGenre.Rows[0].Selected = true;
        }

        private int RowsByNm(string _nom)
        {
            if (_nom != "0")
            {
                foreach (DataGridViewRow item in GridGenre.Rows)
                {
                    if (item.Cells[1].Value.ToString() == _nom)
                        return item.Index;
                } 
            }
            return 0;
        }
    }
}
