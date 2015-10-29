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

        public void supprimer(string cote)
        {
            try
            {
                RequeteSql.deleteClassification(cote);
            }
            catch (Exception)
            {
                throw new Exception("Erreur lors de la suppression");
            }
        }

        public void modifier(Classification classif)
        {
            try
            {
                RequeteSql.setClassification(classif);
            }
            catch (Exception)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
        }

        public void ajouter(Classification classif)
        {
            try
            {
                RequeteSql.addClassification(classif);
            }
            catch (Exception)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
        }

        public bool verifier(Classification ancien, Classification nouv, bool modif)
        {
            //true = demande d'enregistrer
            //false = aucun changement
            if (modif == false)
            {
                try
                {
                    foreach (var c in RequeteSql.srchCoteClassification(nouv.coteESRB))
                    {
                        return false;
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    foreach (var c in RequeteSql.srchCoteClassification(nouv.coteESRB))
                    {
                        if (c.NomESRB == nouv.nomESRB && c.DescESRB == nouv.descESRB)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            
        }




        public List<Classification> rechercher(string chaine)
        {
            List<Classification> lstClassification = new List<Classification>();
            foreach (var c in RequeteSql.srchClassification(chaine))
            {
                Classification classif = new Classification(c.CoteESRB, c.NomESRB, c.DescESRB);
                lstClassification.Add(classif);
            }
            return lstClassification;
        }

        public bool testExiste(string cote)
        {
            IQueryable<tblClassification> lstClassif = RequeteSql.srchCoteClassification(cote);

            int qte = lstClassif.Count<tblClassification>();

            if (qte != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
