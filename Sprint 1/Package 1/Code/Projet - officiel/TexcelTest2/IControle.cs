using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    interface IControle
    {
        void ajouter(object o);
        void modifier(object o);
        void supprimer(object o);
        bool verifier(object o, object n);
    }
}
