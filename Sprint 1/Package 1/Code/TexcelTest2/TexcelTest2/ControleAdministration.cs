using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexcelTest2
{
    abstract class ControleAdministration
    {

        //PAS SUR DU CONTENU
        //risque de changer quand on va voir quon a coder la même chose plusieurs fois
        //base.creer(); = exemple
        public abstract void creer(string a, string b, string c);

        //public abstract List<object> chargerDonnees();

        protected abstract bool verifier();

        protected abstract object retour();
        
    }
}
