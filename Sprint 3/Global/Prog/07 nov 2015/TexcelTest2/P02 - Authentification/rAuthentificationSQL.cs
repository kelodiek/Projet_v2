using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    /// <summary>
    /// toutes les variables db vont etre a changé pour "dbProjetE2TestEntities"
    /// </summary>
    class rAuthentificationSQL : Requete
    {
        static public IQueryable<tblUtilisateur> VerifierLogin(string Username, string Password)
        {

            var r = from the in db.tblUtilisateur
                    where (the.NomUtil == Username) & (the.MotPasUtil == Password)
                    select the;

            return r;
        }
        static public string PremiereCon(string Username)
        {

            var r = (from the in db.tblUtilisateur
                     where the.NomUtil == Username
                     select the.PremiereConex).First();

            return r;
        }
        static public void VerifierExpiration(string Username)
        {
            var time = (from the in db.tblUtilisateur
                        where the.NomUtil == Username
                        select the.DateModifMotPas).First();

            var temps = DateTime.Now.Subtract((DateTime)time).Days;
            var z = (from the in db.tblUtilisateur
                     where the.NomUtil == Username
                     select the).First();
            if (temps > 180)
            {

                z.MotPasExpire = "o";
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            else if (temps > 170)
            {
                z.MotPasExpire = "b";
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {

                z.MotPasExpire = "n";
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
        static public string MotDePasseExpire(string Username)
        {


            var r = (from the in db.tblUtilisateur
                     where the.NomUtil == Username
                     select the.MotPasExpire).First();

            return r;
        }
        static public Utilisateur SetAttributes(Utilisateur u)
        {
            Utilisateur User = u;

            var r = from the in db.tblUtilisateur
                    where the.NomUtil == User.NomUtilisateur
                    select the;

            foreach (var item in r)
            {
                User = new Utilisateur(item);
            }
            return User;
        }
        static public bool ChangerMDP(Utilisateur u, string NouvMDP)
        {

            var r = (from the in db.tblUtilisateur
                     where the.NomUtil == u.NomUtilisateur
                     select the).First();

            r.MotPasUtil = NouvMDP;
            r.PremiereConex = "n";
            r.MotPasExpire = "n";
            r.DateModifMotPas = DateTime.Now;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        static public string GetRole(int IdRole)
        {

            var r = (from the in db.tblRole
                     where the.IdRole == IdRole
                     select the.NomRole).First();

            return r;
        }



    }
}
