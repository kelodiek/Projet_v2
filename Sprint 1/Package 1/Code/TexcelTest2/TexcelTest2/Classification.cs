using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexcelTest2
{
    class Classification
    {
        private string CoteESRB, NomESRB, DescESRB;
        public Classification(string cote, string nom, string desc)
        {
            NewClassification(cote, nom, desc);
        }

        private Classification NewClassification(string cote, string nom, string desc){
            this.CoteESRB = cote;
            this.NomESRB = nom;
            this.DescESRB = desc;
            return this;
        }

        public string coteESRB
        {
            get { return CoteESRB; }
            set { CoteESRB = value; }
        }

        public string nomESRB
        {
            get { return NomESRB; }
            set { NomESRB = value; }
        }

        public string descESRB
        {
            get { return DescESRB; }
            set { DescESRB = value; }
        }

    }
}
