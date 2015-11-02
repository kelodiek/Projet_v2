using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace Projet
{
    class rEquipeSQL:Requete
    {

        static public IQueryable<tblEmploye> getListeEmploye()
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from v in db.tblEmploye
                where v.Statut == "A"
                select v;

            return r;
        }

        static public IQueryable<tblTypeTest> getListeTest()
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from v in db.tblTypeTest
                select v;

            return r;
        }

        static public IQueryable<tblEquipe> getListeEquipe()
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from v in db.tblEquipe
                where v.Statut == "A"
                select v;

            return r;
        }


        static public IQueryable<AllChefEquipe> getEmployeChefEquipe()
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from v in db.AllChefEquipe
                where v.Statut == "A"
                select v;

            return r;
        }

        static public tblEquipe getEquipe(int noEquipe)
        {
            var r =
            from v in db.tblEquipe
            where v.IdEquipe == noEquipe
            select v;

            return r.First();
        }

        static public int addEquipe(tblEquipe settings)
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();
            int i;

            db.tblEquipe.Add(settings);


            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

            }

            i = settings.IdEquipe;

            return i;
        }

        static public int setEquipe(tblEquipe settings)
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();
            tblEquipe unEquipe = new tblEquipe();

            var r =
                from eq in db.tblEquipe
                where eq.IdEquipe == settings.IdEquipe
                select eq;

            unEquipe = r.First();

            unEquipe.CodeProjet = settings.CodeProjet;
            unEquipe.IdChefEquipe = settings.IdChefEquipe;
            unEquipe.NomEquipe = settings.NomEquipe;
            unEquipe.Statut = settings.Statut;
            unEquipe.CommentaireEquipe = settings.CommentaireEquipe;

            unEquipe.tblEmploye1.Clear();

            foreach (var item in settings.tblEmploye1)
            {
                unEquipe.tblEmploye1.Add(item);
            }

            unEquipe.tblTypeTest.Clear();

            foreach (var item in settings.tblTypeTest)
            {
                unEquipe.tblTypeTest.Add(item);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return unEquipe.IdEquipe;
        }

        static public void deleteEquipe(equipe settings)
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from eq in db.tblEquipe
                where eq.IdEquipe == settings.IdEquipe
                select eq;

            foreach (var item in r)
            {
                db.tblEquipe.Remove(item);
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

        static public tblEmploye getChefEquipe(int id)
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from cf in db.tblEmploye
                where cf.IdEmp == id
                select cf;

            return r.First();
        }
        static public IQueryable<tblTypeTest> getListTestEquipe(string codeEquipe)
        {
            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from t in db.tblTypeTest
                where t.CodeTypeTest == codeEquipe
                select t;

            return r;
        }

        static public AllChefEquipe getUNChefEquipe(string nomChef)
        {
            string[] allString = nomChef.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string Nom;
            string Prenom;
            Prenom = allString[0];
            Nom = allString[1];

            //        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

            var r =
                from t in db.AllChefEquipe
                where t.PrenomEmp == Prenom && t.NomEmp == Nom
                select t;

            return r.First(); ;
        }

        static public IQueryable<tblEquipe> Recherche(string textRecherche)
        {
                var r =
                from t in db.tblEquipe
                where t.NomEquipe.Contains(textRecherche) || t.CodeProjet.Contains(textRecherche)
                select t;

                return r;
        }

        static public IQueryable<tblProjet> getProjet()
        {
            var r =
            from t in db.tblProjet
            select t;

            return r;
        }



    }
}
