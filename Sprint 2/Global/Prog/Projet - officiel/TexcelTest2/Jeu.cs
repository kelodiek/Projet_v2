using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    partial class Jeu
    {
        //Constructeur à faire

        private int IdJeu;

        public int idJeu
        {
            get { return IdJeu; }
            set { IdJeu = value; }
        }

        private string NomJeu;

        public string nomJeu
        {
            get { return NomJeu; }
            set { NomJeu = value; }
        }
        private string DescJeu;

        public string descJeu
        {
            get { return DescJeu; }
            set { DescJeu = value; }
        }

        private int Actif;

        public int actif
        {
            get { return Actif; }
            set { Actif = value; }
        }

        private string InfoSupJeu;

        public string infoSupJeu
        {
            get { return InfoSupJeu; }
            set { InfoSupJeu = value; }
        }

        private string Tag;

        public string tag
        {
            get { return Tag; }
            set { Tag = value; }
        }


        private string CoteESRB;

        public string coteESRB
        {
            get { return CoteESRB; }
            set { CoteESRB = value; }
        }

        private int IdGenre;

        public int idGenre
        {
            get { return IdGenre; }
            set { IdGenre = value; }
        }

        private int IdMode;

        public int idMode
        {
            get { return IdMode; }
            set { IdMode = value; }
        }

    }
}
