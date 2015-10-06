using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rAuthentificationSQL
    {
        static public IQueryable<tblUtilisateur> VerifierLogin(string Username,string Password)
        {
            var db = new dbProjetE2ProdEntities();

            var r = from the in db.tblUtilisateur
                    where (the.NomUtil == Username) & (the.MotPasUtil == Password)
                    select the; 
          
            return r; 
        }
        static public bool PremiereCon(string Username)
        {
            var db = new dbProjetE2ProdEntities();
            bool Premiere = false;

            var r = from the in db.tblUtilisateur
                    where the.NomUtil == Username
                    select the.PremiereConex;
            foreach (var item in r)
            {
                Premiere = item;
            }
            return Premiere;
        }
        static public void VerifierExpiration(string Username)
        {
            var db = new dbProjetE2ProdEntities();
            var time = (from the in db.tblUtilisateur
                        where the.NomUtil == Username
                        select the.DateModifMotPas).First();

            var temps = DateTime.Now.Subtract((DateTime)time).Days;
            var z = (from the in db.tblUtilisateur
                     where the.NomUtil == Username
                     select the).First();
            if (temps > 180)
            {
                
                z.MotPasExpire = true;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    
                }
                
            }
            else
            {
               
                z.MotPasExpire = false;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                }
            }
        }
        static public bool MotDePasseExpire(string Username)
        {
            var db = new dbProjetE2ProdEntities();
            bool Expire = false;
            

            var r = from the in db.tblUtilisateur
                    where the.NomUtil == Username
                    select the.MotPasExpire;

            foreach (var item in r)
            {
                Expire = item;
            }
            return Expire;
        }
        static public Utilisateur SetAttributes(Utilisateur u)
        {
            Utilisateur User = u;
            var db = new dbProjetE2ProdEntities();

            var r = from the in db.tblUtilisateur
                    where the.NomUtil == User.NomUtilisateur
                    select the;

            foreach (var item in r)
	        {		 
                User = new Utilisateur(item);
	        }
            return User;
        }
        static public bool ChangerMDP(Utilisateur u,string NouvMDP)
        {
            var db = new dbProjetE2ProdEntities();

            var r = (from the in db.tblUtilisateur
                    where the.NomUtil == u.NomUtilisateur
                    select the).First();

            r.MotPasUtil = NouvMDP;
            r.PremiereConex = false;
            r.MotPasExpire = false;
            r.DateModifMotPas = DateTime.Now;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        
        static public string GetRole(int IdRole)
        {
            var db = new dbProjetE2ProdEntities();

            var r = (from the in db.tblRole
                    where the.IdRole == IdRole
                    select the.NomRole).First();

            return r;
        }
         


    }
}
