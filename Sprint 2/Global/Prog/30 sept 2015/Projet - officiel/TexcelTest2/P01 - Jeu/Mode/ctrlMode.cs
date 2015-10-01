using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (ancien == null)
            {
                return true;
            }

            if (nouv.nomMode == ancien.nomMode && nouv.descMode == ancien.descMode)
            {
                return false;
            }

            if( nouv.nomMode.Length > 10 || nouv.nomMode.Length == 0 ||
                nouv.descMode.Length > 250 || nouv.descMode.Length == 0)
            {
                return false;
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
