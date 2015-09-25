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
                throw new Exception("problem on delete");
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
                throw new Exception("Save failure");
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
                throw new Exception("Save failure");
            }
        }

        public bool verifier(Classification ancien, Classification nouv)
        {

            if (ancien == null && nouv.coteESRB == "")
            {
                return true;
            }
            else if (nouv.coteESRB == ancien.coteESRB && 
                nouv.nomESRB == ancien.nomESRB && 
                nouv.descESRB == ancien.descESRB)
            {
                return false;
            }
            else if (nouv.coteESRB.Length > 7 || nouv.coteESRB.Length == 0 ||
                nouv.nomESRB.Length > 150 || nouv.nomESRB.Length == 0 ||
                nouv.descESRB.Length > 40 || nouv.descESRB.Length == 0)
            {
                return false;
            }

            return true;
        }

        //Je sais pas c'est quoi ste méthode la  mais elle est dans les DS
        protected override object retour()
        {
            //base.retour();
            return classification;

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
