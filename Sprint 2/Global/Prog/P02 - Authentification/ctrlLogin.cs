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
            Premiere = rAuthentificationSQL.PremiereCon(Username);
            return Premiere;
        }
        public bool MotDePasseExpire(string Username)
        {
            bool Expire = false;
            Expire = rAuthentificationSQL.MotDePasseExpire(Username);
            return Expire;
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
