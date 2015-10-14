using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rEmployeSQL
    {
        static public IQueryable<tblEmploye> getEmploye()
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                from e in bd.tblEmploye
                where e.Statut == "o"
                select e;

            return r;
        }

        //          envoye une liste des types de test pour les relier au employe
        //static public IQueryable<tblTypeTest> getTypeTest()
        //{
        //    var bd = new dbProjetE2ProdEntities();

        //    var t =
        //        from e in bd.tblTypeTest
        //        select e;

        //    return t;
        //}

        static public void addEmploye(Employe settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var add = new tblEmploye();

            add.IdEmp = settings.idEmp;
            add.PrenomEmp = settings.prenomEmp;
            add.NomEmp = settings.nomEmp;
            add.CourrielEmp = settings.courrielEmp;
            add.NoTelPrincipal = settings.noTelPrincipal;
            add.NoTelSecondaire = settings.noTelSecondaire;
            add.AdressePostale = settings.adressePostale;
            add.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            add.CompetenceParticuliere = settings.competenceParticuliere;
            add.Statut = settings.statut;
            add.CommentaireEmp = settings.commentaireEmp;

            bd.tblEmploye.Add(add);

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void setEmploye(Employe settings)
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                (from e in bd.tblEmploye
                 where e.IdEmp == settings.idEmp
                 select e).First();

            r.PrenomEmp = settings.prenomEmp;
            r.NomEmp = settings.nomEmp;
            r.CourrielEmp = settings.courrielEmp;
            r.NoTelPrincipal = settings.noTelPrincipal;
            r.NoTelSecondaire = settings.noTelSecondaire;
            r.AdressePostale = settings.adressePostale;
            r.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            r.CompetenceParticuliere = settings.competenceParticuliere;
            r.CommentaireEmp = settings.commentaireEmp;

            //                  Manque les type de test *********

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public IQueryable<tblEmploye> rechercheEmploye(string cle)
        {
            var bd = new dbProjetE2ProdEntities();

            var d =
                from e in bd.tblEmploye
                where e.IdEmp.ToString().Contains(cle) || e.NomEmp.Contains(cle) || e.PrenomEmp.Contains(cle) || (e.DateEmbaucheEmp.ToString()).Contains(cle) || e.CompetenceParticuliere.Contains(cle)
                select e;

            return d;
        }

        static public void deleteEmploye(int cle)
        {
            var bd = new dbProjetE2ProdEntities();
            var i = cle;

            var r =
                (from e in bd.tblEmploye
                 where e.IdEmp == i
                 select e).First();

            r.Statut = "n";

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
