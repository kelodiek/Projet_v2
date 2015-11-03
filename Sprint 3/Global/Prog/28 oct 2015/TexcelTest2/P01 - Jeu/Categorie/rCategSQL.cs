using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rCategSQL : Requete
    {
        static public IQueryable<tblCategorie> getCategorie()
        {

            var r =
                from c in db.tblCategorie
                select c;

            return r;
        }
        static public void addCateg(Categorie settings)
        {
            var add = new tblCategorie();

            add.CodeCategorie = settings.codeCateg;
            add.ComCategorie = settings.comCateg;
            add.DescCategorie = settings.descCateg;

            db.tblCategorie.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void setCateg(Categorie settings)
        {


            var r =
                (from categ in db.tblCategorie
                 where categ.CodeCategorie == settings.codeCateg
                 select categ).First();

            r.CodeCategorie = settings.codeCateg;
            r.ComCategorie = settings.comCateg;
            r.DescCategorie = settings.descCateg;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteCateg(string code)
        {
            var r =
                from categ in db.tblCategorie
                where categ.CodeCategorie == code
                select categ;

            foreach (var item in r)
            {
                db.tblCategorie.Remove(item);
            }


            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public IQueryable<tblCategorie> srchCategorieAll(string chaine)
        {

            var r =
                from cat in db.tblCategorie
                where cat.CodeCategorie.Contains(chaine) || cat.ComCategorie.Contains(chaine) || cat.DescCategorie.Contains(chaine)
                select cat;

            return r;
        }
        static public IQueryable<tblCategorie> srchCategorie(string code)
        {

            var r =
                from categ in db.tblCategorie
                where categ.CodeCategorie == code
                select categ;

            return r;
        }
    }
}
