using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rJeuSQL
    {
        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

        //tblJeu
        static public IQueryable<tblJeu> getAllJeu()
        {
            var r =
                from c in db.tblJeu
                select c;
            return r;
        }

        static public void setJeu(tblJeu jeu)
        {
            var r =
                (from j in db.tblJeu
                 where j.IdJeu == jeu.IdJeu
                 select j).First();

            r.NomJeu = jeu.NomJeu;
            r.DescJeu = jeu.DescJeu;
            r.Actif = jeu.Actif;
            r.InfoSupJeu = jeu.InfoSupJeu;
            r.CoteESRB = jeu.CoteESRB;
            r.IdGenre = jeu.IdGenre;
            r.IdMode = jeu.IdMode;

            r.tblTheme.Clear();
            foreach (var item in jeu.tblTheme)
            {
                r.tblTheme.Add(item);
            }

            r.tblPlateforme.Clear();
            foreach (var item in jeu.tblPlateforme)
            {
                r.tblPlateforme.Add(item);
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

        static public void addJeu(tblJeu p)
        {
            //Pas sur de la requête sauf que le else fonctionne
            if (p.tblTheme.Count > 0)
            {
                foreach (tblTheme tblThemeTemp in p.tblTheme)
                {
                    db.tblJeu.Add(p);
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
            else
            {
                db.tblJeu.Add(p);
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

        static public IQueryable<tblJeu> srchIdJeu(int id)
        {
            var r =
                from jeu in db.tblJeu
                where jeu.IdJeu == id
                select jeu;

            return r;
        }

        static public IQueryable<tblJeu> srchJeu(string chaine)
        {
            var r =
                from jeu in db.tblJeu
                where jeu.Tag.Contains(chaine)
                select jeu;

            return r;
        }

        static public void deleteJeu(int id)
        {
            var rJeu =
                (from jeu in db.tblJeu
                 where jeu.IdJeu == id
                 select jeu).FirstOrDefault<tblJeu>();

            rJeu.tblTheme.Clear();
            rJeu.tblPlateforme.Clear();
            db.tblJeu.Remove(rJeu);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }

}
