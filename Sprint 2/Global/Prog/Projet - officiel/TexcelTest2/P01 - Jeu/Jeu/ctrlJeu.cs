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
            tblSysExp systemp = new tblSysExp();

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
                theme = rThemeSQL.RechercheTheme(item.idTheme.ToString()).First();
                jeu.tblTheme.Add(theme);
            }
            foreach (plateforme item in p.lstPlateforme)
            {
                plate = new tblPlateforme();
                plate.IdPlateforme = item.idPlate;
                plate.CodePlateforme = item.codePlate;
                plate.NomPlateforme = item.nomPlate;
                plate.CodeCategorie = item.codeCateg;
                plate.CPU = item.cpuPlate;
                plate.CarteMere = item.carteMerePlate;
                plate.RAM = item.ramPlate;
                plate.Stockage = item.stockage;
                plate.DescPlateforme = item.descPlate;
                plate.InfoSupPlateforme = item.infoSupPlate;

                foreach (SystemeExploitation item2 in item.lstSysExpPlate)
                {
                    systemp = new tblSysExp();
                    systemp.CodeSysExp = item2.CodeSysExp;
                    systemp.EditionSysExp = item2.editSysExp;
                    systemp.IdSysExp = item2.idSysExp;
                    systemp.InfoSupSysExp = item2.infoSysExp;
                    systemp.NomSysExp = item2.nomSysExp;
                    systemp.Tag = item2.tagSysExp;
                    systemp.VersionSysExp = item2.versionSysExp;
                    plate.tblSysExp.Add(systemp);
                }
            }
            return jeu;
        }

        public void modifier(tblJeu j)
        {
            rJeuSQL.setJeu(j);
        }

        public void ajouter(tblJeu j)
        {
            try
            {
                rJeuSQL.addJeu(j);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void supprimer(int id)
        {
            try
            {
                rJeuSQL.deleteJeu(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Jeu> rechercher(string chaine)
        {
            List<Jeu> lstJeu = new List<Jeu>();
            foreach (var j in rJeuSQL.srchJeu(chaine))
            {
                Jeu jeu = new Jeu(j);
                lstJeu.Add(jeu);
            }
            return lstJeu;
        }
    }
}
