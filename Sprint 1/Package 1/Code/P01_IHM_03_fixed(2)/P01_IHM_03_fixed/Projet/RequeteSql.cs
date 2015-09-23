using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class RequeteSql
    {
<<<<<<< HEAD
        // Systeme d'exploitation
=======
        static public IQueryable<tblClassification> getClassification()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblClassification
                select c;

            return r;
        }
>>>>>>> parent of 26a6505... Ajout de mes trucs
        static public IQueryable<tblSysExp> getSysExp()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblSysExp
                select c;

            return r;
        }
        static public void setSysExp(SystemeExploitation settings)
        {
            var db = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(settings.idSysExp);
            

            var r =
                (from sysExp in db.tblSysExp
                where sysExp.IdSysExp == i
                select sysExp).First();

            r.CodeSysExp = settings.CodeSysExp;
            r.NomSysExp = settings.nomSysExp;
            r.EditionSysExp = settings.editSysExp;
            r.VersionSysExp = settings.versionSysExp;
            r.InfoSupSysExp = settings.infoSysExp;
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Ajouter un nouveau systeme d'exploitation.
        /// </summary>
        /// <param name="settings">code,nom,edition,version,info supplementaire</param>
        static public void addSysExp(SystemeExploitation settings)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblSysExp();

            add.CodeSysExp = settings.CodeSysExp;
            add.NomSysExp = settings.nomSysExp;
            add.EditionSysExp = settings.editSysExp;
            add.VersionSysExp = settings.versionSysExp;
            add.InfoSupSysExp = settings.infoSysExp;

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
        // Categorie
        static public IQueryable<tblCategorie> getCategorie()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblCategorie
                select c;

            return r;
        }
        static public void addCateg(Categorie settings)
        {
            var db = new dbProjetE2ProdEntities();
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
            var db = new dbProjetE2ProdEntities();


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
            var db = new dbProjetE2ProdEntities();

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
        static public IQueryable<tblCategorie> srchCategorie(string code)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from categ in db.tblCategorie
                where categ.CodeCategorie == code
                select categ;

            return r;
        }
<<<<<<< HEAD
        static public IQueryable<tblTheme> srchTheme(string code)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from theme in db.tblTheme
                where theme.NomTheme == code
                select theme;

            return r;
        }

        static public IQueryable<tblTheme> RechercheTheme(string code)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from theme in db.tblTheme
                where theme.NomTheme.Contains(code) || theme.ComTheme.Contains(code) || theme.IdTheme.ToString() == code
                select theme;

            return r;
        }

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
        static public IQueryable<tblClassification> srchClassification(string chaine)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from classif in db.tblClassification
                where classif.CoteESRB.Contains(chaine) || classif.NomESRB.Contains(chaine) || classif.DescESRB.Contains(chaine)
                select classif;

            return r;
        }

        static public IQueryable<tblClassification> srchCoteClassification(string cote)
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from classif in db.tblClassification
                where classif.CoteESRB == cote
                select classif;

            return r;
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

        // Plateforme
        static public IQueryable<tblPlateforme> getPlateforme()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblPlateforme
                select c;
            return r;
        }
        static public void addPlateforme(tblPlateforme p)
        {
            var db = new dbProjetE2ProdEntities();

            //db.tblPlateforme.Add();
        }
=======
>>>>>>> parent of 26a6505... Ajout de mes trucs
    }
}
