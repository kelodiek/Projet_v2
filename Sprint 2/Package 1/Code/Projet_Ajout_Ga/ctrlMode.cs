﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    class ctrlMode : IControle
    {
        private List<Mode> listMode;

        public List<Mode> lstMode
        {
            get { return listMode; }
            set { listMode = value; }
        }

        public ctrlMode()
        {
            listMode = new List<Mode>();
        }

        public void ajouter(object m)
        {
            RequeteSql.addMode((Mode)m);
        }

        public void modifier(object m)
        {
            RequeteSql.setMode((Mode)m);
        }

        public void supprimer(object m)
        {
            RequeteSql.deleteMode(Int32.Parse(m.ToString()));
        }

        public bool verifier(object m, object o)
        {
            Mode ancien, nouv;
            nouv = (Mode)m;
            ancien = (Mode)o;
            
            if (nouv.nomMode.Length > 10 || nouv.nomMode.Length == 0)
            {
                MessageBox.Show("Votre nom de mode n'est pas valide", "Erreur", MessageBoxButtons.OK);
                return false;
            }

            if (nouv.descMode.Length > 250 || nouv.descMode.Length == 0)
            {
                MessageBox.Show("Votre Description de mode n'est pas valide", "Erreur", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public bool verifSemblable(object m, object o)
        {
            Mode ancien, nouv;
            nouv = (Mode)m;
            ancien = (Mode)o;
            charger();

            foreach (Mode mm in listMode)
            {
                if (mm.nomMode == nouv.nomMode && mm.nomMode == ancien.nomMode)
                {
                    if (mm.descMode == nouv.descMode)
                        MessageBox.Show("Il existe déjà un mode semblable à celui-ci", "Erreur", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Il existe déjà un mode avec ce nom", "Erreur", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        public List<string[]> charger()
        {
            var lstbrut = RequeteSql.getAllMode();
            var lstLigne = new List<string[]>();

            string[] ligne;

            foreach (tblMode item in lstbrut)
            {
                ligne = new string[] { item.IdMode.ToString(), item.NomMode, item.DescMode };
                lstLigne.Add(ligne);

                listMode.Add(new Mode(item));
            }

            return lstLigne;
        }

        public List<Mode> recherche(string cle)
        {
            List<Mode> lstMo = new List<Mode>();

            foreach (var item in RequeteSql.rechercheMode(cle))
            {
                Mode Mo = new Mode(item.IdMode, item.NomMode, item.DescMode);
                lstMo.Add(Mo);
            }
            return lstMo;
        }
    }
}
