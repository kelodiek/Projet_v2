using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//      par Gabriel Simard

namespace Projet
{
    public partial class frmGesTypeTest : frmGestion
    {
        ctrlTypeTest gestionTypeTest;
        TypeTest SelectTypeTest;
        private int lvlAcces;

        public frmGesTypeTest()
        {
            InitializeComponent();
            gestionTypeTest = new ctrlTypeTest();
            chargeColonne();
            chargeObjet();
        }

        //      avec authentification
        public frmGesTypeTest(string _us)
        {
            InitializeComponent();
            gestionTypeTest = new ctrlTypeTest();
            UserNm = _us;
            droitUser();
            chargeObjet();
        }

        private void droitUser()
        {
            lvlAcces = gestionTypeTest.DroitAcces(UserNm);

            if (lvlAcces == 0 || lvlAcces == 1)
                btnAjout.Enabled = false;

            if (lvlAcces == 0)
            {
                btnDetails.Enabled = false;
                btnX.Enabled = false;
                btnRecherche.Enabled = false;
                gridTypeTest.Rows.Clear();
            }

            if (lvlAcces > 0)
                chargeColonne();
        }

        private void chargeObjet()
        {
            if (gridTypeTest.Rows.Count != 0)
            {
                gridTypeTest.Rows[0].Selected = true;
                SelectTypeTest = (TypeTest)gridTypeTest.Rows[0].Tag;
                gridTypeTest.Sort(gridTypeTest.Columns[0], ListSortDirection.Ascending);
            }
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
            this.Text = "Texcel : Gestion - Type test";
        }

        private void chargeColonne()
        {
            DataGridViewColumn column;
            gridTypeTest.Columns.Add("CodeTypeT", "Code type test");
            gridTypeTest.Columns.Add("NomTypeT", "Nom du type test");
            gridTypeTest.Columns.Add("ObjectifTT", "Objectif du type test");
            gridTypeTest.Columns.Add("DescTypeT", "Description du type test");
            gridTypeTest.Columns.Add("ComTypeT", "Commentaire du type test");

            column = gridTypeTest.Columns[0];
            column.Width = 100;
            column = gridTypeTest.Columns[1];
            column.Width = 300;
            column = gridTypeTest.Columns[2];
            column.Width = 500;
            column = gridTypeTest.Columns[3];
            column.Width = 500;
            column = gridTypeTest.Columns[4];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            chargeDonne();
        }

        private void chargeDonne()
        {
            var data = gestionTypeTest.charger();
            int i = 0;
            foreach (var item in data)
            {
                int rowIndex = gridTypeTest.Rows.Add(item);
                gridTypeTest.Rows[rowIndex].Tag = gestionTypeTest.lstTypeTest[i];
                i++;
            }
        }

        private void txtRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && lvlAcces > 0)
                recherche();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            gridTypeTest.Rows.Clear();
            chargeDonne();
            txtRecherche.Text = "";
            gridTypeTest.Sort(gridTypeTest.Columns[0], ListSortDirection.Ascending);
            if (gridTypeTest.RowCount > 0)
            {
                gridTypeTest.Rows[0].Selected = true;
                SelectTypeTest = (TypeTest)gridTypeTest.Rows[0].Tag;
            }    
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            recherche();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var Det = new frmDetTypeTest(lvlAcces);

            Det.ShowDialog();
            if (Det.statut == true)
            {
                SelectTypeTest = Det.TypeSelect;
                update();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridTypeTest.SelectedRows.Count == 1)
                modifierType();
        }

        private void recherche()
        {
            if (txtRecherche.Text != "")
            {
                gridTypeTest.Rows.Clear();
                foreach (TypeTest t in gestionTypeTest.recherche(txtRecherche.Text))
                {
                    string[] tblTmp = new string[] { t.codeTypeTest, t.nomTypeTest, t.objectifTypeTest, t.descTypeTest, t.commentaireTypeTest };
                    int index = gridTypeTest.Rows.Add(tblTmp);
                    gridTypeTest.Rows[index].Tag = t;
                }

                if (gridTypeTest.RowCount != 0)
                {
                    gridTypeTest.Rows[0].Selected = true;
                    SelectTypeTest = (TypeTest)gridTypeTest.Rows[0].Tag;
                }
            }
            else
                MessageBox.Show("Le champ de recherche est vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gridTypeTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridTypeTest.Rows[e.RowIndex].Selected = true;
                SelectTypeTest = (TypeTest)gridTypeTest.Rows[e.RowIndex].Tag;
            }
        }

        private void gridTypeTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridTypeTest.Rows[e.RowIndex].Selected = true;
                SelectTypeTest = (TypeTest)gridTypeTest.Rows[e.RowIndex].Tag;
                modifierType();
            }
        }

        private void modifierType()
        {
            frmDetTypeTest detailTT = new frmDetTypeTest(SelectTypeTest, true, lvlAcces);
            detailTT.ShowDialog();
            
            if(detailTT.statut == true)
            {
                SelectTypeTest = detailTT.TypeSelect;
                update();
            }
            else
            {
                int index = gestionTypeTest.RowByCode(SelectTypeTest.codeTypeTest, gridTypeTest);
                if (gridTypeTest.RowCount > (index + 1))
                    SelectTypeTest = (TypeTest)gridTypeTest.Rows[index + 1].Tag;
                else
                    SelectTypeTest = (TypeTest)gridTypeTest.Rows[index - 1].Tag;
                update();
            }
                
        }

        private void update()
        {
            gestionTypeTest = new ctrlTypeTest();
            int col = gridTypeTest.SortedColumn.Index;
            string codeSel = "";
            if (gridTypeTest.Rows.Count != 0)
                codeSel = SelectTypeTest.codeTypeTest;

            ListSortDirection DD = ListSortDirection.Descending;
            if (gridTypeTest.SortOrder == SortOrder.Ascending)
                DD = ListSortDirection.Ascending;

            gridTypeTest.Rows.Clear();
            chargeDonne();
            gridTypeTest.Sort(gridTypeTest.Columns[col], DD);
            int R = gestionTypeTest.RowByCode(codeSel, gridTypeTest);
            gridTypeTest.Rows[R].Cells[0].Selected = true;
            gridTypeTest.Rows[R].Selected = true;
        }
    }
}
