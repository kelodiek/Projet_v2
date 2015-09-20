using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexcelTest2
{
    partial class ControleClassification : ControleAdministration
    {
        private Classification classification;
        protected override void creerClassification(string cote, string nom, string desc)
        {
            classification = new Classification(cote, nom, desc);
        }

        protected override bool verifier()
        {
            //base.verifier();


            return true;
        }

        protected override Classification retour()
        {
            //base.retour();
            return classification;

        }

    }
}
