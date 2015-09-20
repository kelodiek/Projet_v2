using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexcelTest2
{
    static class RequeteSql
    {
        //tblClassification
        static public IQueryable<tblClassification> getAllClassification()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblClassification
                select c;
            return r;
        }
        static public void setClassification(Classification classification)
        {
            var db = new dbProjetE2ProdEntities();


            var r =
                (from classif in db.tblClassification
                 where classif.CoteESRB == classification.coteESRB
                 select classif).First();

            r.NomESRB = classification.nomESRB;
            r.DescESRB = classification.descESRB;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addClassification(Classification classification)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblClassification();

            add.CoteESRB = classification.coteESRB;
            add.NomESRB = classification.nomESRB;
            add.DescESRB = classification.descESRB;

            db.tblClassification.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteClassification(string coteESRB)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from classif in db.tblClassification
                where classif.CoteESRB == coteESRB
                select classif;

            foreach (var item in r)
            {
                db.tblClassification.Remove(item);
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

        //tblGenre
        static public IQueryable<tblGenre> getAllGenre()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblGenre
                select c;
            return r;
        }
        static public void setGenre(Genre genre)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                (from gen in db.tblGenre
                 where gen.IdGenre == genre.idGenre
                 select gen).First();

            r.NomGenre = genre.nomGenre;
            r.ComGenre = genre.comGenre;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addGenre(Genre genre)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblGenre();

            add.NomGenre = genre.nomGenre;
            add.ComGenre = genre.comGenre;

            db.tblGenre.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteGenre(int idGenre)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from gen in db.tblGenre
                where gen.IdGenre == idGenre 
                select gen;

            foreach (var item in r)
            {
                db.tblGenre.Remove(item);
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

        //tblMode
        static public IQueryable<tblMode> getAllMode()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblMode
                select c;
            return r;
        }
        static public void setMode(Mode mode)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                (from mod in db.tblMode
                 where mod.IdMode == mode.idMode
                 select mod).First();

            r.NomMode = mode.nomMode;
            r.DescMode = mode.descMode;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addMode(Mode mode)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblMode();

            add.NomMode = mode.nomMode;
            add.DescMode = mode.descMode;

            db.tblMode.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteMode(int idMode)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from mod in db.tblMode
                where mod.IdMode == idMode
                select mod;

            foreach (var item in r)
            {
                db.tblMode.Remove(item);
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

        //tblTheme
        static public IQueryable<tblTheme> getAllTheme()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblTheme
                select c;
            return r;
        }
        static public void setTheme(Theme theme)
        {
            var db = new dbProjetE2ProdEntities();

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
            var db = new dbProjetE2ProdEntities();
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
            var db = new dbProjetE2ProdEntities();

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

        //tblSysExp
        static public IQueryable<tblSysExp> getSysExp()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblSysExp
                select c;

            return r;
        }
        static public void setSysExp(string[] settings)
        {
            var db = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(settings[0]);


            var r =
                (from sysExp in db.tblSysExp
                 where sysExp.IdSysExp == i
                 select sysExp).First();

            r.CodeSysExp = settings[1];
            r.NomSysExp = settings[2];
            r.EditionSysExp = settings[3];
            r.VersionSysExp = settings[4];
            r.InfoSupSysExp = settings[5];

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addSysExp(string[] settings)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblSysExp();

            add.CodeSysExp = settings[1];
            add.NomSysExp = settings[2];
            add.EditionSysExp = settings[3];
            add.VersionSysExp = settings[4];
            add.InfoSupSysExp = settings[5];

            db.tblSysExp.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteSysExp(int ID)
        {
            var db = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(ID);

            var r =
                from sysExp in db.tblSysExp
                where sysExp.IdSysExp == i
                select sysExp;

            foreach (var item in r)
            {
                db.tblSysExp.Remove(item);
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
    }
}
