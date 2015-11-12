using System;
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
        public bool Statut;

        public ctrlMode()
        {
            listMode = new List<Mode>();
            Statut = true;
        }

        public void ajouter(object m)
        {
            rModeSQL.addMode((Mode)m);
        }

        public void modifier(object m)
        {
            rModeSQL.setMode((Mode)m);
        }

        public void supprimer(object m)
        {
            rModeSQL.deleteMode(Int32.Parse(m.ToString()));
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

            if (Statut == false)
            {
                if (ancien != null)
                {
                    if (nouv.nomMode == ancien.nomMode)
                    {
                        if(nouv.descMode == ancien.descMode)
                            MessageBox.Show("Vous n'avez changer aucun champs, modifier les avant d'enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Vous n'avez changer pas changer le titre du mode, changer le et réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                foreach (Mode mm in listMode)
                {
                    if (mm.nomMode == nouv.nomMode && mm.nomMode == ancien.nomMode)
                    {
                        if (mm.descMode == nouv.descMode)
                            MessageBox.Show("Il existe déjà un mode semblable à celui-ci", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Il existe déjà un mode avec ce nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                if (ancien.descMode == null)
                    ancien.descMode = "";

                if(nouv.nomMode == ancien.nomMode &&
                    nouv.descMode == ancien.descMode)
                {
                    MessageBox.Show("Vous ne pouvez enregistrer si vous ne changer pas les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
            var lstbrut = rModeSQL.getAllMode();
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

            foreach (var item in rModeSQL.rechercheMode(cle))
            {
                Mode Mo = new Mode(item.IdMode, item.NomMode, item.DescMode);
                lstMo.Add(Mo);
            }
            return lstMo;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP05")
                    drLect = true;

                if (item.CodeDroit == "WP05")
                    drEcr = true;

                if (item.CodeDroit == "Admin")
                    return 3;
            }

            if (drLect == true && drEcr == true)
                return 3;
            else if (drLect == false && drEcr == true)
                return 2;
            else if (drLect == true && drEcr == false)
                return 1;

            return 0;
        }
    }
}
