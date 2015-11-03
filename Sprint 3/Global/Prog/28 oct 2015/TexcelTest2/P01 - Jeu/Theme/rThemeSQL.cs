using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rThemeSQL : Requete
    {
        static public IQueryable<tblTheme> getAllTheme()
        {
            var r =
                from c in db.tblTheme
                select c;
            return r;
        }
        static public void setTheme(Theme theme)
        {
            var r =
                (from the in db.tblTheme
                 where the.IdTheme == theme.idTheme
                 select the).First();

            r.NomTheme = theme.nomTheme;
            r.ComTheme = theme.comTheme;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addTheme(Theme theme)
        {
            var add = new tblTheme();

            add.NomTheme = theme.nomTheme;
            add.ComTheme = theme.comTheme;

            db.tblTheme.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteTheme(int idTheme)
        {
            var r =
                from the in db.tblTheme
                where the.IdTheme == idTheme
                select the;

            foreach (var item in r)
            {
                db.tblTheme.Remove(item);
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
        static public IQueryable<tblTheme> srchTheme(string code)
        {
            var r =
                from theme in db.tblTheme
                where theme.NomTheme == code
                select theme;

            return r;
        }
        static public IQueryable<tblTheme> RechercheTheme(string code)
        {

            var r =
                from theme in db.tblTheme
                where theme.NomTheme.Contains(code) || theme.ComTheme.Contains(code) || theme.IdTheme.ToString() == code
                select theme;

            return r;
        }
    }
}
