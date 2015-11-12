using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rTypeTestSQL : Requete
    {
        //          envoye une liste des types de test pour les relier au employe
        static public IQueryable<tblTypeTest> getTypeTest()
        {
            var t =
                from e in db.tblTypeTest
                select e;

            return t;
        }

        static public IQueryable<tblTypeTest> rechercheTypeTest(string cle)
        {
            var t =
                from e in db.tblTypeTest
                where e.CodeTypeTest.Contains(cle) || e.NomTypeTest.Contains(cle) || e.ObjectifTypeTest.Contains(cle) || e.DescTypeTest.Contains(cle)
                select e;

            return t;
        }

        static public bool setTypeTest(TypeTest settings)
        {
            var r =
                (from e in db.tblTypeTest
                where e.CodeTypeTest == settings.codeTypeTest
                select e).First();

            r.NomTypeTest = settings.nomTypeTest;
            r.ObjectifTypeTest = settings.objectifTypeTest;
            r.DescTypeTest = settings.descTypeTest;
            r.CommentaireTest = settings.commentaireTypeTest;

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        static public bool AjouterTypeTest(TypeTest settings)
        {
            var ajout = new tblTypeTest();

            ajout.CodeTypeTest = settings.codeTypeTest;
            ajout.NomTypeTest = settings.nomTypeTest;
            ajout.ObjectifTypeTest = settings.objectifTypeTest;
            ajout.DescTypeTest = settings.descTypeTest;
            ajout.CommentaireTest = settings.commentaireTypeTest;

            db.tblTypeTest.Add(ajout);

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        static public bool SupprimerTypeTest(TypeTest Effacer)
        {
            var F =
                (from d in db.tblTypeTest
                 where d.CodeTypeTest == Effacer.codeTypeTest
                 select d).First();

            db.tblTypeTest.Remove(F);

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
