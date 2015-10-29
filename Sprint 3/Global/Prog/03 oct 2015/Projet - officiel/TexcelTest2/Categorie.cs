using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Categorie
    {
        private string code;

        public string codeCateg
        {
            get { return code; }
            set { code = value; }
        }

        private string description;

        public string descCateg
        {
            get { return description; }
            set { description = value; }
        }

        private string commentaire;

        public string comCateg
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public Categorie()
        {
            code = "";
            description = "";
            commentaire = "";
        }
        public Categorie(tblCategorie categ)
        {
            code = categ.CodeCategorie;
            description = categ.DescCategorie;
            commentaire = categ.ComCategorie;
        }
    }
}
