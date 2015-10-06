using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Utilisateur
    {
        private string NomUtil, MotPasUtil;
        private bool PremiereConnex, MotPasExpire;
        private int IdRole, IdEmp;
        private DateTime DateModifMotPas;
        public Utilisateur(string nom,string mdp)
        {
            this.NomUtil = nom;
            this.MotPasUtil = mdp;
        }
        public int Role
        {
            get { return IdRole; }
        }
        public Utilisateur(tblUtilisateur u)
        {
            this.NomUtil = u.NomUtil;
            this.MotPasUtil = u.MotPasUtil;
            this.PremiereConnex = Convert.ToBoolean(u.PremiereConex);
            this.MotPasExpire = Convert.ToBoolean(u.MotPasExpire);
            this.IdRole = u.IdRole;
            this.IdEmp = u.IdEmp;
            this.DateModifMotPas = (DateTime)u.DateModifMotPas;

        }
        public void SetAttributes(bool Prem,bool MdpExpire,int Role, int Emp, DateTime date)
        {
            this.PremiereConnex = Prem;
            this.MotPasExpire = MdpExpire;
            this.IdEmp = Emp;
            this.IdRole = Role;
            this.DateModifMotPas = date;
        }

        public string NomUtilisateur 
        {
            get { return NomUtil; }
        }
    }
}
