﻿using System;
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
    public partial class frmDetPlateforme : frmDetail
    {
        public frmDetPlateforme()
        {
            InitializeComponent();

            btnAnnuler.Click += new EventHandler(btnAnnuler_Click);
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutSysExp_Click(object sender, EventArgs e)
        {

        }
    }
}
