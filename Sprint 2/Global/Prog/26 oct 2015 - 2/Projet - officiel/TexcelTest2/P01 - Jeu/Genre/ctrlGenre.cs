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
        public bool Statut;

        public ctrlGenre()
        {
            listGenre = new List<Genre>();
            Statut = true;
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

            if (Statut == false)
            {
                if (ancien != null)
                {
                    if (nouv.nomGenre == ancien.nomGenre)
                    {
                        if (nouv.comGenre == ancien.comGenre)
                            MessageBox.Show("Vous n'avez changer aucun champs, modifier les avant d'enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Vous n'avez changer pas changer le titre du genre, changer le et réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                foreach (Genre gg in listGenre)
                {
                    if (gg.nomGenre == nouv.nomGenre && gg.nomGenre == ancien.nomGenre)
                    {
                        if (gg.comGenre == nouv.comGenre)
                            MessageBox.Show("Il existe déjà un genre semblable à celui-ci", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Il existe déjà un genre avec ce nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }
            }
            else
            {
                if (ancien.comGenre == null)
                    ancien.comGenre = "";

                if (nouv.nomGenre == ancien.nomGenre &&
                nouv.comGenre == ancien.comGenre)
                {
                    MessageBox.Show("Vous ne pouvez enregistrer si vous ne changer pas les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
