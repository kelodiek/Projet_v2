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
            rThemeSQL.addTheme((Theme)o);
        }
        public void supprimer(object o)
        {
            Theme t = (Theme)o;
            rThemeSQL.deleteTheme(Convert.ToInt32(t.idTheme));
        }

        public void modifier(object o)
        {
            rThemeSQL.setTheme((Theme)o);
        }
        public List<Theme> recherche(string Key)
        {
            List<Theme> lstTheme = new List<Theme>();
            foreach (var c in rThemeSQL.RechercheTheme(Key))
            {
                Theme theme = new Theme(c.IdTheme, c.NomTheme, c.ComTheme);
                lstTheme.Add(theme);
            }
            return lstTheme;
        }
        public bool verifier(object o, object n)
        {
            Theme nouv, ancien;

            nouv = (Theme)o;
            ancien = (Theme)n;


            if (nouv.nomTheme.Length > 40 || nouv.nomTheme.Length == 0)
            {
                return false;
            }

            return true;
        }

        public List<string[]> charger()
        {
            var lstBrut = rThemeSQL.getAllTheme();
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


    }
}
