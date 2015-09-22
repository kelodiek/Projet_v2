using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    partial class ControleClassification : ControleAdministration
    {
        private Classification classification;
        public override void creer(string cote, string nom, string desc)
        {
            classification = new Classification(cote, nom, desc);
        }

        public List<Classification> chargerDonnees()
        {
            List<Classification> lstClassification = new List<Classification>();
            foreach (var c in RequeteSql.getAllClassification())
            {
                Classification classif = new Classification(c.CoteESRB, c.NomESRB, c.DescESRB);
                lstClassification.Add(classif);
            }
            return lstClassification;
        }

        protected override bool verifier()
        {
            //base.verifier();


            return true;
        }

        //Je sais pas c'est quoi ste méthode la  mais elle est dans les DS
        protected override object retour()
        {
            //base.retour();
            return classification;

        }

    }
}
