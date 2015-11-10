using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                row = new string[] {
                    item.IdTheme.ToString(),
                    item.NomTheme,
                    item.ComTheme};
                lstRows.Add(row);

                listTheme.Add(new Theme(item));
            }

            return lstRows;
        }

        public int RowsByID(int id, DataGridView _data)
        {
            if (id != 0)
            {
                foreach (DataGridViewRow item in _data.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == id)
                        return item.Index;
                }
            }
            return 0;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP02")//   changer pour RP08
                    drLect = true;

                if (item.CodeDroit == "WP01")//   WP08
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
