using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rGroupeUtilSQL
    {
        public static dbProjetE2ProdEntities db = new dbProjetE2ProdEntities();

        static public IQueryable<tblGroupe> getGroupUtil()
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                from g in bd.tblGroupe
                select g;

            return r;
        }

        static public bool ajouterGroupe(GroupeUtil nouvG)
        {
            var bd = new dbProjetE2ProdEntities();
            var ajout = new tblGroupe();
            var lstUser = new List<tblUtilisateur>();
            var lstDroit = new List<tblDroit>();

            ajout.NomGroupe = nouvG.nomGroupe;

            var u =
                from e in bd.tblUtilisateur
                select e;
            int i = 0;
            foreach (tblUtilisateur item in u)
            {
                foreach (Utilisateur us in nouvG.lstGroupeUser)
                {
                    if (item.NomUtil == us.NomUtilisateur)
                    {
                        ajout.tblUtilisateur.Add(item);
                        i++;
                        break;
                    }
                }
                if (nouvG.lstGroupeUser.Count == i)
                    break;
            }

            var d =
                from e in bd.tblDroit
                select e;
            i = 0;
            foreach (tblDroit item in d)
            {
                foreach (Droit dr in nouvG.lstGroupeDroit)
                {
                    if (item.CodeDroit == dr.codeDroit)
                    {
                        ajout.tblDroit.Add(item);
                        i++;
                        break;
                    }
                }
                if (nouvG.lstGroupeDroit.Count == i)
                    break;
            }

            bd.tblGroupe.Add(ajout);

            try
            {
                bd.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        static public IQueryable<tblGroupe> rechercheGroup(string cle)
        {
            var bd = new dbProjetE2ProdEntities();

            var g =
                from e in bd.tblGroupe
                where e.IdGroupe.ToString().Contains(cle) || e.NomGroupe.Contains(cle)
                select e;

            return g;
        }

        static public bool supprimeGroupe(GroupeUtil Eff)
        {
            var bd = new dbProjetE2ProdEntities();

            var r =
                (from g in bd.tblGroupe
                where g.IdGroupe == Eff.idGroupe
                select g).First();

            bd.tblGroupe.Remove(r);

            try
            {
                bd.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        static public bool setGroup(GroupeUtil settings)
        {
            var bd = new dbProjetE2ProdEntities();
            var lstDroit = new List<tblDroit>();

            var g =
                (from e in bd.tblGroupe
                 where e.IdGroupe == settings.idGroupe
                 select e).First();

            var DR =
                from d in bd.tblDroit
                select d;

            int i = 0;
            g.tblDroit.Clear();
            foreach (tblDroit item in DR)
            {
                foreach (Droit it in settings.lstGroupeDroit)
                {
                    if (item.CodeDroit == it.codeDroit)
                    {
                        g.tblDroit.Add(item);
                        i++;
                        break;
                    }
                }
                if (settings.lstGroupeDroit.Count == i)
                    break;
            }

            g.NomGroupe = settings.nomGroupe;

            try
            {
                bd.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        static public IQueryable<tblDroit> getAllDroit()
        {
            var bd = new dbProjetE2ProdEntities();

            var d =
                from t in bd.tblDroit
                select t;

            return d;
        }
    }
}
