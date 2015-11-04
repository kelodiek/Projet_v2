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
    public partial class frmGesGroupeUser : frmGestion
    {
        ctrlGroupeUser gestionGroupe;

        public frmGesGroupeUser()
        {
            InitializeComponent();
            gestionGroupe = new ctrlGroupeUser();
            chargerColonne();
        }

        private void gridGroupUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridGroupUser.Rows[e.RowIndex].Selected = true;
                this.Tag = gridGroupUser.Rows[e.RowIndex].Tag;
            }
        }

        private void gridGroupUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridGroupUser.Rows[e.RowIndex].Selected = true;
                this.Tag = gridGroupUser.Rows[e.RowIndex].Tag;
                modifierGroupe();
            }
        }

        //      tout les boutons

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                recherche();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            gridGroupUser.Rows.Clear();
            chargeDonnee();
            txtRecherche.Text = "";
            gridGroupUser.Sort(gridGroupUser.Columns[0], ListSortDirection.Ascending);
            if (gridGroupUser.Rows.Count != 0)
                gridGroupUser.Rows[0].Selected = true;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            recherche();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var detail = new frmDetGroupeUser();
            detail.Tag = "0";

            detail.ShowDialog();
            if (detail.Tag.ToString() != "0")
            {
                this.Tag = detail.Tag;
                update();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridGroupUser.SelectedRows.Count == 1)
                modifierGroupe();
        }

        //      toutes les méthodes de gestion de l'interface

        private void chargerColonne()
        {
            DataGridViewColumn column;
            gridGroupUser.Columns.Add("IdGroup", "Numéro de groupe");
            gridGroupUser.Columns.Add("NomGroup", "Nom de groupe");

            column = gridGroupUser.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridGroupUser.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            chargeDonnee();
            chargeObjet();
        }

        private void chargeDonnee()
        {
            var data = gestionGroupe.charger();
            int i = 0;
            foreach (var item in data)
            {
                int rowIndex = gridGroupUser.Rows.Add(item);
                gridGroupUser.Rows[rowIndex].Tag = gestionGroupe.lstGroupeUtil[i];
                i++;
            }
        }

        private void chargeObjet()
        {
            if (gridGroupUser.Rows.Count != 0)
            {
                gridGroupUser.Rows[0].Selected = true;
                this.Tag = gridGroupUser.Rows[0].Tag;
            }
            gridGroupUser.Sort(gridGroupUser.Columns[0], ListSortDirection.Ascending);
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnAjout.Click += new EventHandler(btnAjout_Click);
            btnRecherche.Click += new EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            btnDetails.Visible = true;
            btnAjout.Visible = true;
            btnRecherche.Visible = true;
            txtRecherche.Visible = true;
            btnX.Visible = true;
            this.Text = "Texel : Gestion - Groupe utilisateur";
        }

        private void modifierGroupe()
        {
            frmDetGroupeUser detailGroup = new frmDetGroupeUser((GroupeUtil)this.Tag, true);
            detailGroup.ShowDialog();
            if (detailGroup.Tag.ToString() == "0")
                this.Tag = gridGroupUser.Rows[0].Tag;
            else
                this.Tag = detailGroup.Tag;
            update();
        }

        private void update()
        {
            gestionGroupe = new ctrlGroupeUser();
            int Colum = gridGroupUser.SortedColumn.Index;
            int Idselect = 0;
            if(gridGroupUser.Rows.Count != 0)
                Idselect = ((GroupeUtil)this.Tag).idGroupe;
            ListSortDirection DD = ListSortDirection.Descending;
            if (gridGroupUser.SortOrder == SortOrder.Ascending)
                DD = ListSortDirection.Ascending;

            gridGroupUser.Rows.Clear();
            chargeDonnee();
            gridGroupUser.Sort(gridGroupUser.Columns[Colum], DD);
            int R = gestionGroupe.RowsById(Idselect, gridGroupUser);
            gridGroupUser.Rows[R].Cells[1].Selected = true;         //      utile ?
            gridGroupUser.Rows[R].Selected = true;
        }

        private void recherche()
        {
            if (txtRecherche.Text != "")
            {
                gridGroupUser.Rows.Clear();
                foreach (GroupeUtil g in gestionGroupe.recherche(txtRecherche.Text))
                {
                    string[] tblTmp = new string[2] { g.idGroupe.ToString(), g.nomGroupe };
                    int index = gridGroupUser.Rows.Add(tblTmp);
                    gridGroupUser.Rows[index].Tag = g;
                }

                if (gridGroupUser.Rows.Count != 0)
                {
                    gridGroupUser.Rows[0].Selected = true;
                    this.Tag = gridGroupUser.Rows[0].Tag; 
                }
            }
            else
                MessageBox.Show("Le champ de recherche est vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
