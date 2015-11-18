using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class GroupeUtil
    {
        private int IdGroupe;
        private string NomGroupe;
        private List<Utilisateur> ListGroupeUser;
        private List<Droit> ListGroupeDroit;

        public GroupeUtil()
        {
            IdGroupe = 0;
            NomGroupe = "";
            ListGroupeUser = new List<Utilisateur>();
            ListGroupeDroit = new List<Droit>();
        }

        public GroupeUtil(tblGroupe gp)
        {
            IdGroupe = gp.IdGroupe;
            NomGroupe = gp.NomGroupe;
            ListGroupeUser = new List<Utilisateur>();
            foreach (tblUtilisateur user in gp.tblUtilisateur)
            {
                Utilisateur temp = new Utilisateur(user);
                ListGroupeUser.Add(temp);
            }

            ListGroupeDroit = new List<Droit>();
            foreach (tblDroit d in gp.tblDroit)
            {
                Droit tempD = new Droit(d);
                ListGroupeDroit.Add(tempD);
            }
        }

        public int idGroupe
        {
            get { return IdGroupe; }
            set { IdGroupe = value; }
        }

        public string nomGroupe
        {
            get { return NomGroupe; }
            set { NomGroupe = value; }
        }

        public List<Utilisateur> lstGroupeUser
        {
            get { return ListGroupeUser; }
            set { ListGroupeUser = value; }
        }

        public List<Droit> lstGroupeDroit
        {
            get { return ListGroupeDroit; }
            set { ListGroupeDroit = value; }
        }
    }
}
