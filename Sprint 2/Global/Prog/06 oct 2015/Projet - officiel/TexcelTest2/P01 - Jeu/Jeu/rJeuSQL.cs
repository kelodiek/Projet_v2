using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rJeuSQL
    {
        //tblJeu
        static public IQueryable<tblJeu> getAllJeu()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblJeu
                select c;
            return r;
        }

        //static public void setJeu(Jeu jeu)
        //{
        //    var db = new dbProjetE2ProdEntities();


        //    var r =
        //        (from j in db.tblJeu
        //         where j.IdJeu == jeu.idJeu
        //         select j).First();

        //    r.NomJeu = jeu.nomJeu;
        //    r.DescJeu = jeu.descJeu;
        //    r.Actif = jeu.actif;
        //    r.InfoSupJeu = jeu.infoSupJeu;
        //    r.CoteESRB = jeu.coteESRB;
        //    r.IdGenre = jeu.idGenre;
        //    r.IdMode = jeu.idMode;

        //    //Manque le lien aux thèmes

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}

        static public void addJeu(tblJeu p)
        {
            var db = new dbProjetE2ProdEntities();


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
       
    }
}
