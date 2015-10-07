using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.P02___Personnel.Employe
{
    static class rEmployeSQL
    {
        static public IQueryable<tblMode> getEmploye()
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                from e in bd.tblMode
                //where e.Actif == 1
                select e;

            return r;
        }

        static public void addEmploye(Mode settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var add = new tblMode();

            // add.PrenomEmp = settings.prenomEmp;
            // add.NomEmp = settings.nomEmp;
            // add.CourrielEmp = settings.courrielEmp;
            // add.NoTelPrincipal = settings.noTelPrincipal;
            // add.NoTelSecondaire = settings.noTelSecondaire;
            // add.AdressePostale = settings.adressePostale;
            // add.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            // add.CompetenceParticuliere = settings.competenceParticuliere;
            // add.Actif = settings.actif;
            // add.CommentaireEmp = settings.commentaireEmp;

            bd.tblMode.Add(add);

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public void setEmploye(Mode settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(settings.idMode);

            var r =
                (from e in bd.tblMode
                 where e.IdMode == i
                 select e).First();

            // r.PrenomEmp = settings.prenomEmp;
            // r.NomEmp = settings.nomEmp;
            // r.CourrielEmp = settings.courrielEmp;
            // r.NoTelPrincipal = settings.noTelPrincipal;
            // r.NoTelSecondaire = settings.noTelSecondaire;
            // r.AdressePostale = settings.adressePostale;
            // r.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            // r.CompetenceParticuliere = settings.competenceParticuliere;
            // r.CommentaireEmp = settings.commentaireEmp;

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public IQueryable<tblMode> rechercheEmploye(string cle)
        {
            var bd = new dbProjetE2ProdEntities();

            var d =
                from e in bd.tblMode
                //where e.              ???????? recherche dans toutes les champs ou dans quelques uns ????????????
                select e;

            return d;
        }

        static public void deleteEmploye(int cle)
        {
            var bd = new dbProjetE2ProdEntities();
            var i = cle;

            var r =
                (from e in bd.tblMode
                 where e.IdMode == i
                 select e).First();

            // r.Actif = 0;

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
