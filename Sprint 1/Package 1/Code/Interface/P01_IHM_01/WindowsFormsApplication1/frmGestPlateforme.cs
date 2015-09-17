using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Gestion_des_Plateformes : Form
    {
        public Gestion_des_Plateformes()
        {
            InitializeComponent();
        }

        private void Gestion_des_Plateformes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;
            //DataGridViewButtonColumn BColumn = new DataGridViewButtonColumn();

            //BColumn.Text = "SUPPRIMER";
            //BColumn.UseColumnTextForButtonValue = true;

            DataGridView1.Columns.Add("ID","ID");
            DataGridView1.Columns.Add("Code", "Code");
            DataGridView1.Columns.Add("Nom", "Nom");
            DataGridView1.Columns.Add("Categ", "Catégorie");
            DataGridView1.Columns.Add("OS", "OS");
            //DataGridView1.Columns.Add(BColumn);

            DataGridViewRow row = DataGridView1.Rows[0];
            row.Height = 30;

            column = DataGridView1.Columns[0];
            column.Width = 50;
            column = DataGridView1.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            scolumn = DataGridView1.Columns[3];
            column.Width = 150;
            column = DataGridView1.Columns[4];
            column.Width = 150;
        }

        private void btnAjoutPlateforme_Click(object sender, EventArgs e)
        {
            frmDetPlateforme form = new frmDetPlateforme();

            form.ShowDialog();
        }
    }
}
