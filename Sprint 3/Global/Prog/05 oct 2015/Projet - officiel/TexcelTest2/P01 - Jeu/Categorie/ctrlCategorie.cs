using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            RequeteSql.addCateg((Categorie)o);
        }
        public void supprimer(object o)
        {
            RequeteSql.deleteCateg((string)o);
        }

        public void modifier(object o)
        {
            RequeteSql.setCateg((Categorie)o);
        }

        public bool verifier(object o, object n)
        {
            Categorie nouv, ancien;
            bool result = true;

            nouv = (Categorie)o;
            ancien = (Categorie)n;

            if (ancien == null && nouv.codeCateg == "")
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
                nouv.comCateg.Length > 150 || nouv.comCateg.Length == 0 ||
                nouv.descCateg.Length > 40 || nouv.descCateg.Length == 0)
            {
                result = false;
            }

            return result;
        }

        public List<Categorie> rechercher(string chaine)
        {
            List<Categorie> lstCat = new List<Categorie>();
            foreach (var c in RequeteSql.srchCategorieAll(chaine))
            {
                Categorie cat = new Categorie(c);
                lstCat.Add(cat);
            }
            return lstCat;
        }

        public List<string[]> charger()
        {
            var lstBrut = RequeteSql.getCategorie();
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
            IQueryable<tblCategorie> lstCateg = RequeteSql.srchCategorie(code);

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
    }
}
