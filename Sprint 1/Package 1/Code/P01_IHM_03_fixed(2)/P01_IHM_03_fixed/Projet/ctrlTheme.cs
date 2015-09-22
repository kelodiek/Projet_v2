using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlTheme : IControle
    {
        private List<Theme> listTheme;

        public List<Theme> lstTheme
        {
            get { return listTheme; }
            set { listTheme = value; }
        }

        public ctrlTheme()
        {
            lstTheme = new List<Theme>();
        }

        public void ajouter(object o)
        {
            RequeteSql.addTheme((Theme)o);
        }
        public void supprimer(object o)
        {
            RequeteSql.deleteTheme((int)o);
        }

        public void modifier(object o)
        {
            RequeteSql.setTheme((Theme)o);
        }

        public bool verifier(object o, object n)
        {
            Theme nouv, ancien;

            nouv = (Theme)o;
            ancien = (Theme)n;

            if (ancien == null)
            {
                return true;
            }
            if (nouv.idTheme == ancien.idTheme &&
                nouv.comTheme == ancien.comTheme &&
                nouv.nomTheme == ancien.nomTheme)
            {
                return false;
            }
            if (nouv.comTheme.Length > 150 || nouv.comTheme.Length == 0 ||
                nouv.nomTheme.Length > 40 || nouv.nomTheme.Length == 0)
            {
                return false;
            }

            return true;
        }

        public List<string[]> charger()
        {
            var lstBrut = RequeteSql.getAllTheme();
            var lstRows = new List<string[]>();

            string[] row;

            foreach (tblTheme item in lstBrut)
            {
                row = new string[] {item.IdTheme.ToString(),
                    item.NomTheme,
                    item.ComTheme};
                lstRows.Add(row);

                listTheme.Add(new Theme(item));
            }

            return lstRows;
        }
        public bool testExiste(string code)
        {
            IQueryable<tblTheme> lstTheme = RequeteSql.srchTheme(code);

            int qte = lstTheme.Count<tblTheme>();

            if (qte != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
