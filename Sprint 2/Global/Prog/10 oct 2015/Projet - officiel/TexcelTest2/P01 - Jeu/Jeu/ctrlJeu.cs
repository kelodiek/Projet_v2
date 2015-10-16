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

        private tblJeu jeuToTblJeu(Jeu p)
        {
            tblJeu jeu = new tblJeu();
            tblTheme theme = new tblTheme();
            tblPlateforme plate = new tblPlateforme();

            jeu.IdJeu = p.idJeu;
            jeu.NomJeu = p.nomJeu;
            jeu.DescJeu = p.descJeu;
            jeu.CoteESRB = p.coteESRB;
            jeu.IdGenre = p.idGenre;
            jeu.IdMode = p.idMode;
            jeu.InfoSupJeu = p.infoSupJeu;
            

            foreach (Theme item in p.lstTheme)
            {
                theme = new tblTheme();
                theme.IdTheme = item.idTheme;
                jeu.tblTheme.Add(theme);
            }
            foreach (plateforme item in p.lstPlateforme)
            {
                plate = new tblPlateforme();
                plate.IdPlateforme = item.idPlate;
                jeu.tblPlateforme.Add(plate);
            }
            return jeu;
        }

        public void ajouter(Jeu j)
        {
            var ajout = jeuToTblJeu(j);
            try
            {
                rJeuSQL.addJeu(ajout);
            }
            catch (Exception)
            {
                throw new Exception("dshfdhfisknfkjseh");
            }
        }
    }
}
