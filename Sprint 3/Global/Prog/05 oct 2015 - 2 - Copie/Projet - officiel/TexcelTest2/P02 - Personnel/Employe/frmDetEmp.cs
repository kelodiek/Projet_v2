using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.P02___Personnel.Employe
{
    public partial class frmDetEmp : frmDetail
    {
        //private Employe empSelect { get; set; }
        //private ctrlEmploye ctrlEm;

        public frmDetEmp()
        {
            InitializeComponent();
            //ctrlEm = new ctrlEmploye();
            btnCopier.Visible = false;
            this.btnAnnuler.Location = new Point(784, 477);
            this.btnEnregistrer.Location = new Point(10, 477);
            this.btnActiverModif.Location = new Point(125, 477);
            this.btnSupprimer.Location = new Point(240, 477);
        }

        //public frmDetEmp(Employe E)
        //{
        //    InitializeComponent();
        //    ctrlEm = new ctrlEmploye();
        //    btnCopier.Visible = false;
        //    this.btnAnnuler.Location = new Point(784, 477);
        //    this.btnEnregistrer.Location = new Point(10, 477);
        //    this.btnActiverModif.Location = new Point(125, 477);
        //    this.btnSupprimer.Location = new Point(240, 477);
        //}
    }
}
