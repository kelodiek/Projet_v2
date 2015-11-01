using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rComptesSQL
    {    
        /// <summary>
        /// toutes les variables db vont etre a changé pour "dbProjetE2TestEntities"
        /// </summary>
        static public IQueryable<tblUtilisateur> getComptes(int id)
        {
            var db = new dbProjetE2TestEntities();

            var r =
                from c in db.tblUtilisateur
                where c.IdEmp == id
                select c;

            return r;
        }
        static public string[] GetInfoEmploye(int Id)
        {
            var db = new dbProjetE2TestEntities();
            string[] tab = new string[2];

            var r =
                (from c in db.tblEmploye
                where c.IdEmp == Id
                select c.NomEmp).First();
            var b =
                (from c in db.tblEmploye
                 where c.IdEmp == Id
                 select c.PrenomEmp).First();
            tab[0] = r;
            tab[1] = b;

            return tab;
        }
        static public IQueryable<string> getRoles()
        {
            var db = new dbProjetE2TestEntities();

            var r =
                from c in db.tblRole
                select c.NomRole;

            return r;
        }
        static public int GetIdRole(string NomduRole)
        {
            var db = new dbProjetE2TestEntities();

            var r =
                (from c in db.tblRole
                where c.NomRole == NomduRole
                select c.IdRole).First();

            return r;
        }
        static public string GetNomRole(int IdduRole)
        {
            var db = new dbProjetE2TestEntities();

            var r =
                (from c in db.tblRole
                where c.IdRole == IdduRole
                select c.NomRole).First();

            return r;
        }
        static public IQueryable<tblUtilisateur> Recherche(string Recherche)
        {
            var db = new dbProjetE2TestEntities();

            var r = from the in db.tblUtilisateur
                    where (the.NomUtil.Contains(Recherche)) || (the.MotPasUtil.Contains(Recherche))
                    select the;

            return r;
        }
        static public void supprimer(string ID)
        {
            var db = new dbProjetE2TestEntities();

            var r =
                from the in db.tblUtilisateur
                where the.NomUtil == ID
                select the;

            foreach (var item in r)
            {
                item.Actif = "n";
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
        static public void ajouter(Utilisateur u)
        {
            var db = new dbProjetE2TestEntities();
            var add = new tblUtilisateur();

            add.NomUtil = u.NomUtilisateur;
            add.MotPasUtil = u.MotDePasse;
            add.MotPasExpire = u.Expire;
            add.PremiereConex = u.Premiere;
            add.DateModifMotPas = u.DateModifMotPas;
            add.IdEmp = u.Emp;
            add.IdRole = u.Role;
            add.Actif = u.UtilActif;

            db.tblUtilisateur.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void setCompte(Utilisateur u)
        {
            var db = new dbProjetE2TestEntities();
            var i = u.NomUtilisateur;


            var r =
                (from the in db.tblUtilisateur
                 where the.NomUtil == i
                 select the).First();

            r.NomUtil = u.NomUtilisateur;
            r.MotPasUtil = u.MotDePasse;
            r.MotPasExpire = u.Expire;
            r.PremiereConex = u.Premiere;
            r.IdEmp = u.Emp;
            r.IdRole = u.Role;
            r.Actif = u.UtilActif;

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
