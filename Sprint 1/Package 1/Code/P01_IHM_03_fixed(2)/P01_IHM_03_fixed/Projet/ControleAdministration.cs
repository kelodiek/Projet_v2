using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    abstract class ControleAdministration
    {

        public abstract void creer(string a, string b, string c);

        public abstract void enregistrer(string a, string b, string c);

        protected abstract bool verifier();

        //protected abstract void rechercher(string chaine);

        protected abstract object retour();
        
    }
}
