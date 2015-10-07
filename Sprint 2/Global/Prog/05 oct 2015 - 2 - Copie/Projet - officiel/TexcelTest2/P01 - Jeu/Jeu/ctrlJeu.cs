using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlJeu
    {
        public List<Jeu> chargerDonnees()
        {
            List<Jeu> lstJeu = new List<Jeu>();
            foreach (var j in rJeuSQL.getAllJeu())
            {
                Jeu jeu = new Jeu(j);
                lstJeu.Add(jeu);
            }
            return lstJeu;
        }
    }
}
