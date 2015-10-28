using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Utilisateur
    {
        private string NomUtil, MotPasUtil,PremiereConex, MotPasExpire,Actif;
        private int IdRole, IdEmp;
        public DateTime DateModifMotPas;
        public Utilisateur()
        {

        }
        public string UtilActif
        {
            get { return Actif; }
            set
            {
                if (value == "Oui")
                {
                    Actif = "o";
                }
                else
                {
                    Actif = "n";
                }
            }
        }
        public Utilisateur(string nom,string mdp)
        {
            this.NomUtil = nom;
            this.MotPasUtil = mdp;
        }
        public int Emp
        {
            get { return IdEmp; }
            set { IdEmp = value; }
        }
        public string Premiere
        {
            get { return PremiereConex; }
            set {
                if (value == "Oui")
                {
                    PremiereConex = "o";
                } 
                else
                {
                    PremiereConex = "n";
                }
            }
        }
        public string Expire
        {
            get { return MotPasExpire; }
            set
            {
                if (value == "Oui")
                {
                    MotPasExpire = "o";
                }
                else
                {
                    MotPasExpire = "n";
                }
            }
        }
        public int Role
        {
            get { return IdRole; }
            set { IdRole = value; }
        }
        public string MotDePasse
        {
            get { return MotPasUtil; }
            set { MotPasUtil = value; }
        }
        public Utilisateur(tblUtilisateur u)
        {
            this.NomUtil = u.NomUtil;
            this.MotPasUtil = u.MotPasUtil;
            this.PremiereConex = u.PremiereConex;
            this.MotPasExpire = u.MotPasExpire;
            this.IdRole = u.IdRole;
            this.IdEmp = u.IdEmp;
            this.DateModifMotPas = (DateTime)u.DateModifMotPas;
            this.Actif = u.Actif;
        }
        public void SetAttributes(string Prem,string MdpExpire,int Role, int Emp, DateTime date)
        {
            this.PremiereConex = Prem;
            this.MotPasExpire = MdpExpire;
            this.IdEmp = Emp;
            this.IdRole = Role;
            this.DateModifMotPas = date.Date;
            this.Actif = "o";
        }

        public string NomUtilisateur 
        {
            get { return NomUtil; }
            set { NomUtil = value; }
        }
    }
}
