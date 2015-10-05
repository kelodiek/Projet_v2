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
    public partial class frmGesMode : frmGestion
    {
        ctrlMode gestionMode;
        public frmGesMode()
        {
            InitializeComponent();
            gestionMode = new ctrlMode();
            this.btnAjout.Click += new EventHandler(ajoutMode_Click);
            this.btnDetails.Click += new EventHandler(detailsMode_Click);
            this.btnRecherche.Click += new EventHandler(btnRecherche_Click);
            this.btnX.Click += new EventHandler(btnX_Click);
            ButtonsVisible(true);
        }

        private void frmGesMode_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            dataGridMode.Columns.Add("IdMode", "ID");
            dataGridMode.Columns.Add("NomMode", "Nom");
            dataGridMode.Columns.Add("DescMode", "Description");

            column = dataGridMode.Columns[0];
            column.Width = 30;
            column = dataGridMode.Columns[1];
            column.Width = 50;
            column = dataGridMode.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chargeDonnees();
        }

        private void chargeDonnees()
        {
            var data = gestionMode.charger();

            foreach (var item in data)
            {
                int rowIndex = dataGridMode.Rows.Add(item);
                dataGridMode.Rows[rowIndex].Tag = item.Last();
            }
        }

        private void ajoutMode_Click(object sender,EventArgs e)
        {
            var detailsMode = new frmDetMode();

            detailsMode.modifierChamp("a");

            detailsMode.ShowDialog();
            update();
        }
        private void detailsMode_Click(object sender, EventArgs e)
        {
            if (dataGridMode.SelectedRows.Count == 1)
                modifierMode();
        }

        private void modifierMode()
        {
            var detailsMode = new frmDetMode();
            Mode modSelectionner = new Mode();
            int index = dataGridMode.SelectedRows[0].Index;

            modSelectionner.idMode = Int32.Parse((string)dataGridMode.Rows[index].Cells[0].Value);
            modSelectionner.nomMode = (string)dataGridMode.Rows[index].Cells[1].Value;
            modSelectionner.descMode = (string)dataGridMode.Rows[index].Cells[2].Value;

            detailsMode.modeSelect = modSelectionner;
            detailsMode.modifierChamp("m");

            detailsMode.ShowDialog();
            update();
        }

        private void dataGridMode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridMode.Rows[e.RowIndex].Selected = true;
                modifierMode();
            }
        }

        private void dataGridMode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridMode.Rows[e.RowIndex].Selected = true;
            }
        }

        public void update()
        {
            gestionMode = new ctrlMode();
            var formOuvert = new frmGesMode();
            formOuvert.Show();
            this.Hide();
            formOuvert.Closed += (s, args) => this.Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
            {
                dataGridMode.Rows.Clear();
                foreach (Mode m in gestionMode.recherche(txtRecherche.Text))
                {
                    string[] tabTemp = new string[3] { m.idMode.ToString(), m.nomMode, m.descMode };
                    dataGridMode.Rows.Add(tabTemp);
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une information a rechercher");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            dataGridMode.Rows.Clear();
            chargeDonnees();
            txtRecherche.Text = "";
        }
    }
}
