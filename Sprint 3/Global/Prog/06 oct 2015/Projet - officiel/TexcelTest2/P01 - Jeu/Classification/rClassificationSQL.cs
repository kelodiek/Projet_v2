using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rClassificationSQL
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
    }
}
