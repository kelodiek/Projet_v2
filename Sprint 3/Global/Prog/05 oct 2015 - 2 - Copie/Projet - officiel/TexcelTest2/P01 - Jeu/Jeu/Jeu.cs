﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    partial class Jeu
    {

        private int IdJeu, IdGenre, IdMode;
        private string NomJeu, DescJeu, InfoSupJeu, Tag, CoteESRB;
        private bool Actif;
        public List<Theme> lstTheme { get; set; }

        public Jeu(int idJeu, string nomJeu, string descJeu, bool actif, string infoSupJeu, string tag, string coteESRB, int idGenre, int idMode, List<Theme> lstThemeTemp)
        {
            IdJeu = idJeu;
            NomJeu = nomJeu;
            DescJeu = descJeu;
            Actif = actif;
            InfoSupJeu = infoSupJeu;
            Tag = tag;
            CoteESRB = coteESRB;
            IdGenre = idGenre;
            IdMode = idMode;
            if (lstThemeTemp != null)
            {
                lstTheme = lstThemeTemp;
            }
            else
            {
                lstTheme = new List<Theme>();
            }
        }
        public Jeu(tblJeu j)
        {
            IdJeu = j.IdJeu;
            NomJeu = j.NomJeu;
            DescJeu = j.DescJeu;
            Actif = j.Actif;
            InfoSupJeu = j.InfoSupJeu;
            Tag = j.Tag;
            CoteESRB = j.CoteESRB;
            IdGenre = (int)j.IdGenre;
            IdMode = (int)j.IdMode;
            lstTheme = new List<Theme>();
            foreach (var item in j.tblTheme)
            {
                lstTheme.Add(new Theme(item));
            }
            
        }

       

        public int idJeu
        {
            get { return IdJeu; }
            set { IdJeu = value; }
        }



        public string nomJeu
        {
            get { return NomJeu; }
            set { NomJeu = value; }
        }

        public string descJeu
        {
            get { return DescJeu; }
            set { DescJeu = value; }
        }

        public bool actif
        {
            get { return Actif; }
            set { Actif = value; }
        }

        public string infoSupJeu
        {
            get { return InfoSupJeu; }
            set { InfoSupJeu = value; }
        }

        public string tag
        {
            get { return Tag; }
            set { Tag = value; }
        }

        public string coteESRB
        {
            get { return CoteESRB; }
            set { CoteESRB = value; }
        }

        public int idGenre
        {
            get { return IdGenre; }
            set { IdGenre = value; }
        }

        public int idMode
        {
            get { return IdMode; }
            set { IdMode = value; }
        }

    }
}
