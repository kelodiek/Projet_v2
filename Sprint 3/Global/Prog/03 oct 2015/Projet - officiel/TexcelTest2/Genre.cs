using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Genre
    {
        private int IdGenre;
        private string NomGenre, ComGenre;

        public Genre(int id, string nom, string com)
        {
            NewGenre(id, nom, com);
        }

        private Genre NewGenre(int id, string nom, string com){
            this.IdGenre = id;
            this.NomGenre = nom;
            this.ComGenre = com;
            return this;
        }

        public int idGenre
        {
            get { return IdGenre; }
            set { IdGenre = value; }
        }

        public string nomGenre
        {
            get { return NomGenre; }
            set { NomGenre = value; }
        }

        public string comGenre
        {
            get { return ComGenre; }
            set { ComGenre = value; }
        }

    }
}
