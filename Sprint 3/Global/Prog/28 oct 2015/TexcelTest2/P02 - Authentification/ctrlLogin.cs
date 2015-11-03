using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlLogin
    {
        public Utilisateur user;
        public ctrlLogin()
        {
        }
        public bool VerifierUserPWD(string Username,string Password)
        {
            bool Valide;
            IQueryable<tblUtilisateur> Luser;
            Luser = rAuthentificationSQL.VerifierLogin(Username,Password);
            Valide = Luser.Any();
            if(Valide)
            {
                user = new Utilisateur(Username, Password);
            }
            return Valide;
        }
        public bool PremiereConnexion(string Username)
        {
            bool Premiere = false;
            string result = "";
            result = rAuthentificationSQL.PremiereCon(Username);
            if(result == "o")
            {
                Premiere = true;
            }
            return Premiere;
        }
        public string MotDePasseExpire(string Username)
        {
            string result = "";
            result = rAuthentificationSQL.MotDePasseExpire(Username);
            return result;
           
        }
        public void SetUserAttributes()
        {
            user = rAuthentificationSQL.SetAttributes(user);
        }
        public bool ChangerMotDePasse(Utilisateur u,string NouvMDP)
        {
            return rAuthentificationSQL.ChangerMDP(u,NouvMDP);
        }
        public void VerifierExpiration() 
        {
            rAuthentificationSQL.VerifierExpiration(user.NomUtilisateur);
        }
        public string GetRole(int IdRole)
        {
            return rAuthentificationSQL.GetRole(IdRole);
        }
         

    }
}
