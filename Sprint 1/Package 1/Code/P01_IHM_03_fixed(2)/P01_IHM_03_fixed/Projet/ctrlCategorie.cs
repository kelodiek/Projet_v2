﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlCategorie : IControle
    {
        private List<Categorie> listCateg;

        public List<Categorie> lstCateg
        {
            get { return listCateg; }
            set { listCateg = value; }
        }

        public ctrlCategorie()
        {
            lstCateg = new List<Categorie>();
        }

        public void ajouter(Categorie categ)
        {
            
        }
        public void supprimer(Categorie categ)
        {

        }

        public void modifier(Categorie categ)
        {

        }

        public bool verifier(Categorie nouvCateg, Categorie ancienCateg)
        {
            return false;
        }

        public List<string[]> charger()
        {
            var lstBrut = RequeteSql.getCategorie();
            var lstRows = new List<string[]>();

            string[] row;

            foreach (var item in lstBrut)
            {
                row = new string[] {item.CodeCategorie,
                    item.DescCategorie,
                    item.ComCategorie};
                lstRows.Add(row);

                listCateg.Add(new Categorie(item));
            }

            return lstRows;
        }
    }
}
