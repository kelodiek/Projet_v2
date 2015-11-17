//      Gabriel Simard

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
    public partial class frmGesEmp : frmGestion
    {
        ctrlEmploye gestionEmp;
        bool boutOk;

        public frmGesEmp()
        {
            InitializeComponent();
            gestionEmp = new ctrlEmploye(true);
            chargerColonnes();
            gridEmploye.SortCompare += gridEmploye_SortCompare;     //          Ajout nouveau
            gridEmploye.Sort(gridEmploye.Columns[0], ListSortDirection.Ascending);
            gridEmploye.Rows[0].Selected = true;
            this.Tag = gridEmploye.Rows[0].Tag;
            btnDetails.Visible = true;
            btnRecherche.Visible = true;
            txtRecherche.Visible = true;
            btnX.Visible = true;
            btnDetails.Click += new EventHandler(btnDetails_Click);
            btnRecherche.Click += new EventHandler(btnRecherche_Click);
            btnX.Click += new EventHandler(btnX_Click);
            btnRejet.Click += new EventHandler(btnDesactiver_Click);
            btnRejet.Text = "Désactiver";
            this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
            this.Text = "Texel : Gestion - Employés";
        }

        public frmGesEmp(string nouv)
        {
            InitializeComponent();
            gestionEmp = new ctrlEmploye(false);
            boutOk = false;
            chargerColonnes();
            btnDetails.Visible = false;
            btnAjout.Visible = true;
            btnAjout.Left = btnDetails.Left;
            btnRecherche.Visible = true;
            btnX.Visible = true;
            txtRecherche.Visible = true;
            btnRejet.Text = "Retirer";
            this.Text = "Texel : Gestion - Nouveaux Employés";
        }

        //          créer le tableau gridview et call le charge des données             Ajout nouveau
        private void chargerColonnes()
        {
            DataGridViewColumn column;
            gridEmploye.Columns.Add("IdEmp", "Code d'employe");
            gridEmploye.Columns.Add("PrenomEmp", "Prenom");
            gridEmploye.Columns.Add("NomEmp", "Nom");
            gridEmploye.Columns.Add("CourrielEmp", "Courriel");
            gridEmploye.Columns.Add("TelPrin", "Telephone Principal");
            gridEmploye.Columns.Add("TelSec", "Telephone Secondaire");
            gridEmploye.Columns.Add("AdresEmp", "Adresse postale");
            gridEmploye.Columns.Add("DateEmbaucheEmp", "Date Embauche");

            column = gridEmploye.Columns[0];
            column.Width = 100;
            column.ValueType = typeof(int);
            column = gridEmploye.Columns[1];
            column.Width = 150;
            column = gridEmploye.Columns[2];
            column.Width = 150;
            column = gridEmploye.Columns[3];
            column.Width = 300;
            column = gridEmploye.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column = gridEmploye.Columns[6];
            column.Width = 250;
            column = gridEmploye.Columns[7];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            chargeDonnee();
        }

        private void chargeDonnee()
        {
            var data = gestionEmp.charger();      //              charge les données d'un fichier texte
            int i = 0;
            foreach (var item in data)
            {
                int rowIndex = gridEmploye.Rows.Add(item);
                if (gestionEmp.etat == true)
                    gridEmploye.Rows[rowIndex].Tag = gestionEmp.lstEmploye[i];
                else
                    gridEmploye.Rows[rowIndex].Tag = gestionEmp.lstEmployeNV[i];
                i++;
            }

            if (gestionEmp.etat == false && gestionEmp.lstEmployeNV.Count != 0 && boutOk == false)
            {
                gridEmploye.Sort(gridEmploye.Columns[0], ListSortDirection.Ascending);
                gridEmploye.Rows[0].Selected = true;
                this.Tag = gridEmploye.Rows[0].Tag;
                btnAjout.Click += new EventHandler(btnDetails_Click);
                btnRejet.Click += new EventHandler(btnDesactiver_Click);
                btnRecherche.Click += new EventHandler(btnRecherche_Click);
                btnX.Click += new EventHandler(btnX_Click);
                this.txtRecherche.KeyDown += new KeyEventHandler(txtRecherche_KeyDown);
                gridEmploye.SortCompare += gridEmploye_SortCompare;
                boutOk = true;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridEmploye.SelectedRows.Count == 1)
                modifierEmploye();
        }

        private void gridEmploye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridEmploye.Rows[e.RowIndex].Selected = true;
                this.Tag = gridEmploye.Rows[e.RowIndex].Tag;
                modifierEmploye();
            }
        }

        private void gridEmploye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.Tag = gridEmploye.Rows[e.RowIndex].Tag;
                gridEmploye.Rows[e.RowIndex].Selected = true;
            }
        }

        private void modifierEmploye()
        {
            frmDetEmp detailEmploye;

            if (gestionEmp.etat == true)
            {
                detailEmploye = new frmDetEmp((Employe)this.Tag);
                detailEmploye.ShowDialog();
                if (this.Tag != detailEmploye.Tag)
                    update();
            }
            else
            {
                string[] nEmp = new string[8];
                int index = gridEmploye.SelectedRows[0].Index;
                for (int i = 0; i < 8; i++)
                {
                    nEmp[i] = (string)gridEmploye.SelectedRows[0].Cells[i].Value.ToString();
                }
                detailEmploye = new frmDetEmp(nEmp);
                detailEmploye.ShowDialog();

                if (detailEmploye.Tag.ToString() == "1" && gestionEmp.verifAjout(detailEmploye.empSelect) == true)        //      il est ajouter
                {
                    gestionEmp.supprimer(this.Tag);
                    gridEmploye.Rows.RemoveAt(gridEmploye.SelectedRows[0].Index);
                }

                if (gridEmploye.Rows.Count == 0)
                    this.Close();
                else if(gridEmploye.Rows.Count > index)
                {
                    gridEmploye.Rows[index].Selected = true;
                    //gridEmploye.Rows[0].Cells[0].Selected = true;
                    this.Tag = gridEmploye.Rows[index].Tag;
                }
                else
                {
                    gridEmploye.Rows[index - 1].Selected = true;
                    //gridEmploye.Rows[0].Cells[0].Selected = true;
                    this.Tag = gridEmploye.Rows[index - 1].Tag;
                }
            }
        }

        public void update()
        {
            gestionEmp = new ctrlEmploye(true);

            int Colum = gridEmploye.SortedColumn.Index;
            int Idselect = ((Employe)this.Tag).idEmp;
            ListSortDirection DD = ListSortDirection.Descending;
            if (gridEmploye.SortOrder == SortOrder.Ascending)
                DD = ListSortDirection.Ascending;

            gridEmploye.Rows.Clear();
            chargeDonnee();
            gridEmploye.Sort(gridEmploye.Columns[Colum], DD);

            int R = gestionEmp.RowsById(Idselect, gridEmploye);
            //gridEmploye.Rows[R].Cells[1].Selected = true;
            gridEmploye.Rows[R].Selected = true;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                rechercher();
        }

        //          Recherche de données dans le gridview
        private void rechercher()
        {
            if (txtRecherche.Text != "")
            {
                gridEmploye.Rows.Clear();
                if (gestionEmp.etat == true)
                {
                    
                    foreach (Employe e in gestionEmp.recherche(txtRecherche.Text))
                    {
                        string[] tabTemp = new string[8] { e.idEmp.ToString(), e.prenomEmp, e.nomEmp, e.courrielEmp, e.noTelPrincipal, e.noTelSecondaire, e.adressePostale, e.dateEmbaucheEmp.ToString() };
                        int indexR = gridEmploye.Rows.Add(tabTemp);
                        gridEmploye.Rows[indexR].Tag = e;
                    }

                    if (gridEmploye.RowCount > 0)
                        gridEmploye.Rows[0].Selected = true;
                }
                else   //           affiche ceux que je cherche mais garde quelque part les valeurs qu'il avait avant
                {
                    foreach (string[] e in gestionEmp.rechercheNew(txtRecherche.Text))
                    {
                        int rowIndex = gridEmploye.Rows.Add(e);
                        gridEmploye.Rows[rowIndex].Tag = e;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ de recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //      réinitialisation du tableau gridview
        private void btnX_Click(object sender, EventArgs e)
        {
            gridEmploye.Rows.Clear();
            chargeDonnee();
            txtRecherche.Text = "";
            gridEmploye.Sort(gridEmploye.Columns[0], ListSortDirection.Ascending);
            gridEmploye.Rows[0].Selected = true;
        }

        //      Désactiver ou effacer les employe désiré
        private void btnDesactiver_Click(object sender, EventArgs e)
        {
            if (gridEmploye.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veiller sélectionner un employe à " + btnRejet.Text, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = gridEmploye.SelectedRows[0];
            DialogResult resultEnrg = MessageBox.Show(" Voulez-vous vraiment " + btnRejet.Text + " l'employe suivant ?\n Cet employe ne sera plus jamais disponible par la suite \n ID : " + row.Cells[0].Value.ToString() + "\n Prenom : " + row.Cells[1].Value.ToString() + "\n Nom : " + row.Cells[2].Value.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultEnrg == DialogResult.Yes)
            {
                if (gestionEmp.etat == true)
                {
                    gestionEmp.supprimer(((Employe)this.Tag).idEmp);
                    update();
                }
                else
                {
                    gestionEmp.supprimer(this.Tag);
                    gridEmploye.Rows.RemoveAt(gridEmploye.SelectedRows[0].Index);
                    if (gestionEmp.lstEmployeNV.Count == 0)
                        this.Close();
                    else
                    {
                        btnX.PerformClick();
                        gridEmploye.Rows[0].Selected = true;
                        this.Tag = gridEmploye.Rows[0].Tag;
                    }
                }
            }
        }

        //          Ajout nouveau
        private void gridEmploye_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column == gridEmploye.Columns[0])
            {
                int a = int.Parse(e.CellValue1.ToString()), b = int.Parse(e.CellValue2.ToString());

                // If the cell value is already an integer, just cast it instead of parsing

                e.SortResult = a.CompareTo(b);

                e.Handled = true; 
            }
        }
    }
}
