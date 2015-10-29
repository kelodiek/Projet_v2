using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    static class rEmployeSQL
    {
        static public IQueryable<tblEmploye> getEmploye()
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                from e in bd.tblEmploye
                where e.Statut == "A"
                select e;

            return r;
        }

        static public void addEmploye(Employe settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var ajout = new tblEmploye();
            var lstTypeTest = new List<tblTypeTest>();

            var tt =
                from e in bd.tblTypeTest
                select e;

            int i = 0;
            foreach (tblTypeTest item in tt)
            {
                foreach (TypeTest ty in settings.lstEmTypeTest)
                {
                    if (item.CodeTypeTest == ty.codeTypeTest)
                    {
                        ajout.tblTypeTest.Add(item);
                        i++;
                        break;
                    }
                }
                if (settings.lstEmTypeTest.Count == i)
                    break;
            }

            ajout.IdEmp = settings.idEmp;
            ajout.PrenomEmp = settings.prenomEmp;
            ajout.NomEmp = settings.nomEmp;
            ajout.CourrielEmp = settings.courrielEmp;
            ajout.NoTelPrincipal = settings.noTelPrincipal;
            ajout.NoTelSecondaire = settings.noTelSecondaire;
            ajout.AdressePostale = settings.adressePostale;
            ajout.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            ajout.CompetenceParticuliere = settings.competenceParticuliere;
            ajout.Statut = settings.statut;
            ajout.CommentaireEmp = settings.commentaireEmp;

            bd.tblEmploye.Add(ajout);

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Une erreur est survenue lors de l'ajout du nouvel employe", "Erreur système", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public void setEmploye(Employe settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var lstTypeTest = new List<tblTypeTest>();

            var r =
                (from e in bd.tblEmploye
                 where e.IdEmp == settings.idEmp
                 select e).First();

            var tt =
                from e in bd.tblTypeTest
                select e;

            int i = 0;
            r.tblTypeTest.Clear();
            foreach (tblTypeTest item in tt)
            {
                foreach (TypeTest ty in settings.lstEmTypeTest)
                {
                    if (item.CodeTypeTest == ty.codeTypeTest)
                    {
                        r.tblTypeTest.Add(item);
                        i++;
                        break;
                    }
                }
                if (settings.lstEmTypeTest.Count == i)
                    break;
            }

            r.PrenomEmp = settings.prenomEmp;
            r.NomEmp = settings.nomEmp;
            r.CourrielEmp = settings.courrielEmp;
            r.NoTelPrincipal = settings.noTelPrincipal;
            r.NoTelSecondaire = settings.noTelSecondaire;
            r.AdressePostale = settings.adressePostale;
            r.DateEmbaucheEmp = settings.dateEmbaucheEmp;
            r.CompetenceParticuliere = settings.competenceParticuliere;
            r.CommentaireEmp = settings.commentaireEmp;

            try
            {
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement des modifications", "Erreur système", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public IQueryable<tblEmploye> rechercheEmploye(string cle)
        {
            var bd = new dbProjetE2ProdEntities();

            var d =
                from e in bd.tblEmploye
                where e.Statut == "A" && (e.IdEmp.ToString().Contains(cle) || e.NomEmp.Contains(cle) || e.PrenomEmp.Contains(cle) || (e.DateEmbaucheEmp.ToString()).Contains(cle) || e.CompetenceParticuliere.Contains(cle))
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
