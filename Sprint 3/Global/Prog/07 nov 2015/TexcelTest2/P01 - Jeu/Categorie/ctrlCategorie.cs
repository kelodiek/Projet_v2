using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    class ctrlCategorie : IControle
    {
        private List<Categorie> listCateg;

        public List<Categorie> lstCateg
        {
            get { return listCateg; }
            set { listCateg = value; }
        }

        public ctrlCategorie()
        {
            lstCateg = new List<Categorie>();
        }

        public void ajouter(object o)
        {
            rCategSQL.addCateg((Categorie)o);
        }
        public void supprimer(object o)
        {
            rCategSQL.deleteCateg((string)o);
        }

        public void modifier(object o)
        {
            rCategSQL.setCateg((Categorie)o);
        }

        public bool verifier(object o, object n)
        {
            Categorie nouv, ancien;
            bool result = true;

            nouv = (Categorie)o;
            ancien = (Categorie)n;

            if (ancien == null)
            {
                result = true;
            }
            else
            {
                if (nouv.codeCateg == ancien.codeCateg &&
                    nouv.comCateg == ancien.comCateg &&
                    nouv.descCateg == ancien.descCateg)
                {
                    result = false;
                }
            }
            if (nouv.codeCateg.Length > 7 || nouv.codeCateg.Length == 0 ||
                nouv.comCateg.Length > 150 ||
                nouv.descCateg.Length > 40 || nouv.descCateg.Length == 0)
            {
                result = false;
            }

            return result;
        }

        public List<Categorie> rechercher(string chaine)
        {
            List<Categorie> lstCat = new List<Categorie>();
            foreach (var c in rCategSQL.srchCategorieAll(chaine))
            {
                Categorie cat = new Categorie(c);
                lstCat.Add(cat);
            }
            return lstCat;
        }

        public List<string[]> charger()
        {
            var lstBrut = rCategSQL.getCategorie();
            var lstRows = new List<string[]>();

            string[] row;

            foreach (tblCategorie item in lstBrut)
            {
                row = new string[] {item.CodeCategorie,
                    item.DescCategorie,
                    item.ComCategorie};
                lstRows.Add(row);

                listCateg.Add(new Categorie(item));
            }

            return lstRows;
        }
        public bool testExiste(string code)
        {
            IQueryable<tblCategorie> lstCateg = rCategSQL.srchCategorie(code);

            int qte = lstCateg.Count<tblCategorie>();

            if (qte != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int RowsById(string id, DataGridView data)
        {
            if (id != "")
            {
                foreach (DataGridViewRow item in data.Rows)
                {
                    if (item.Cells[0].Value.ToString() == id)
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
                if (item.CodeDroit == "RP02")//   changer pour RP02
                    drLect = true;

                if (item.CodeDroit == "WP01")//   WP02
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
