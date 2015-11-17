﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlComptes
    {
        private List<Utilisateur> lstComptes;
        public ctrlComptes()
        {
            lstComptes = new List<Utilisateur>();
        }
        public List<Utilisateur> lstCompte
        {
            get { return lstComptes; }
            set { lstComptes = value; }
        }
        public List<string[]> chargerDonnees(int id)
        {
            var lstRows = new List<string[]>();
            var lstBrut = rComptesSQL.getComptes(id);
            string[] row;

            foreach (var item in lstBrut)
            {

                row = new string[] {item.NomUtil,
                    item.MotPasUtil,
                item.PremiereConex.ToString(),
                item.MotPasExpire.ToString(),
                item.DateModifMotPas.Value.Date.ToString(),
                item.IdRole.ToString(),
                item.IdEmp.ToString(),
                    item.Actif.ToString()};
                lstRows.Add(row);

                lstComptes.Add(new Utilisateur(item));
            }


            return lstRows;
        }

        public List<Utilisateur> recherche(string txt)
        {
            List<Utilisateur> lstComptes = new List<Utilisateur>();
            foreach (var r in rComptesSQL.Recherche(txt))
            {
                Utilisateur u = new Utilisateur(r);
                lstComptes.Add(u);
            }
            return lstComptes;
        }
        public void supprimer(List<string> lstID)
        {
            foreach (var item in lstID)
            {
                rComptesSQL.supprimer(item);
            }
        }
        public void ajouter(Utilisateur u)
        {
            rComptesSQL.ajouter(u);
        }
        public void enregistrer(Utilisateur u, int Id)
        {
            if (rComptesSQL.getComptes(Id).Any())
            {
                rComptesSQL.ajouter(u);
            }
            else
            {
                rComptesSQL.setCompte(u);
            }

        }
        public int GetIdRole(string role)
        {
            return rComptesSQL.GetIdRole(role);
        }
        public string GetNomRole(int role)
        {
            return rComptesSQL.GetNomRole(role);
        }
        public string[] GetInfoEmp(int emp)
        {
            return rComptesSQL.GetInfoEmploye(emp);
        }
        public List<string> GetRoles()
        {
            List<string> lst = new List<string>();
            lst.AddRange(rComptesSQL.getRoles());
            return lst;
        }
        public bool verifier(Utilisateur user, Utilisateur ancien)
        {
            string nom, mdp;
            int idrole, idemp;
            string premiere, expire;
            DateTime datemodif;

            nom = user.NomUtilisateur;
            mdp = user.MotDePasse;
            premiere = user.Premiere;
            expire = user.Expire;
            datemodif = user.DateModifMotPas;
            idrole = user.Role;
            idemp = user.Emp;


            if (ancien != null)
            {
                if (nom == ancien.NomUtilisateur && mdp == ancien.MotDePasse &&
                premiere == ancien.Premiere && expire == ancien.Expire &&
                datemodif == ancien.DateModifMotPas && idrole == ancien.Role && idemp == ancien.Emp)
                {
                    return false;
                }
            }


            return true;
        }
    }
}
