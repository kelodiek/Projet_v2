using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rVersSQL :Requete
    {
        static public IQueryable<tblVersion> getAllVersion(int idJeu)
        {
            var r =
                from c in db.tblVersion
                where c.tblJeu.IdJeu == idJeu
                select c;
            return r;
        }
        static public void setVersion(version vers)
        {
            var r =
                (from v in db.tblVersion
                 where v.CodeVersion == vers.codeVersion
                 select v).First();

            r.DateSortiePrevue = vers.dateSortie;
            r.DateVersion = vers.dateVersion;
            r.DescVersion = vers.descVersion;
            r.IdJeu = vers.idJeu;
            r.NomVersion = vers.nomVersion;
            r.StadeDeveloppement = vers.stadeVersion;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public IQueryable<tblVersion> srchCodeVersion(string code)
        {
            var r =
                from v in db.tblVersion
                where v.CodeVersion == code
                select v;

            return r;
        }
        static public void addVersion(tblVersion v)
        {
            db.tblVersion.Add(v);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteVersion(string code)
        {
            var r =
                from v in db.tblVersion
                where v.CodeVersion == code
                select v;

            foreach (var item in r)
            {
                db.tblVersion.Remove(item);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public IQueryable<tblVersion> srchVersion(string c, int id)
        {
            var r =
                from v in db.tblVersion
                where v.Tag.Contains(c) && v.IdJeu == id
                select v;

            return r;
        }
    }
}
