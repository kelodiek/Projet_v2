using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    class ctrlGenre : IControle
    {
        private List<Genre> listGenre;

        public List<Genre> lstGenre
        {
            get { return listGenre; }
            set { listGenre = value; }
        }

        public ctrlGenre()
        {
            listGenre = new List<Genre>();
        }

        public void ajouter(object o)
        {
            RequeteSql.addGenre((Genre)o);
        }

        public void modifier(object o)
        {
            RequeteSql.setGenre((Genre)o);
        }

        public void supprimer(object o)
        {
            RequeteSql.deleteGenre(Int32.Parse(o.ToString()));
        }

        public bool verifier(object o, object n)
        {
            Genre ancien, nouv;
            nouv = (Genre)o;
            ancien = (Genre)n;

            if (nouv.nomGenre.Length > 35 || nouv.nomGenre.Length == 0)
            {
                MessageBox.Show("Votre nom de genre n'est pas valide", "Erreur", MessageBoxButtons.OK);
                return false;
            }

            if (nouv.comGenre.Length > 250)
            {
                MessageBox.Show("Votre commentaire de genre est trop long", "Erreur", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public bool verifSemblable(object o, object n)
        {
            Genre ancien, nouv;
            nouv = (Genre)o;
            ancien = (Genre)n;
            charger();

            foreach (Genre gg in listGenre)
            {
                if (gg.nomGenre == nouv.nomGenre && gg.nomGenre == ancien.nomGenre)
                {
                    if (gg.comGenre == nouv.comGenre)
                        MessageBox.Show("Il existe déjà un genre semblable à celui-ci", "Erreur", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Il existe déjà un genre avec ce nom", "Erreur", MessageBoxButtons.OK);

                    return false;
                }
            }
            return true;
        }

        public List<string[]> charger()
        {
            var lstBrut = RequeteSql.getAllGenre();
            var lstLigne = new List<string[]>();

            string[] ligne;

            foreach (tblGenre item in lstBrut)
            {
                ligne = new string[] { item.IdGenre.ToString(), item.NomGenre, item.ComGenre };
                lstLigne.Add(ligne);

                listGenre.Add(new Genre(item));
            }

            return lstLigne;
        }

        public List<Genre> recherche(string cle)
        {
            List<Genre> lstGe = new List<Genre>();

            foreach (var item in RequeteSql.rechercheGenre(cle))
            {
                Genre ge = new Genre(item.IdGenre, item.NomGenre, item.ComGenre);
                lstGe.Add(ge);
            }
            return lstGe;
        }
    }
}
