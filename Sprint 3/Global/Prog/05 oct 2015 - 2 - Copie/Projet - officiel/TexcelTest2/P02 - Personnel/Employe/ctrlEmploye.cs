using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.P02___Personnel.Employe
{
    class ctrlEmploye : IControle
    {
        private List<Employe> listEmploye;

        public List<Employe> lstEmploye
        {
            get { return listEmploye; }
            set { listEmploye = value; }
        }

        public ctrlEmploye()
        {
            listEmploye = new List<Employe>();
        }

        public void ajouter(object o)
        {
            rEmployeSQL.addEmploye((Employe)o);
        }

        public void modifier(object o)
        {
            rEmployeSQL.setEmploye((Employe)o);
        }

        public void supprimer(object o)         //  Envoie ID de l'employe à désactiver
        {
            rEmployeSQL.deleteEmploye(Convert.ToInt32(o.ToString()));
        }

        public bool verifier(object o, object n)
        {
            Employe ancien, nouv;
            nouv = (Employe)o;
            ancien = (Employe)n;

            if (ancien == null)
                return true;

            if (true)
            {
                return false;
            }

            return true;
        }

        public List<string[]> charger()
        {
            var lstBrut = rEmployeSQL.getEmploye();
            var lstLigne = new List<string[]>();

            string[] ligne;

            foreach (tblEmploye item in lstBrut)
            {
                //ligne = new string[] { item.IdEmp.ToString(), item.PrenomEmp.ToString(), item.NomEmp.ToString(), item.CourrielEmp.ToString(), item.NoTelPrincipal.ToString(), item.NoTelSecondaire.ToString(), item.AdressePostale.ToString(), item.DateEmbaucheEmp.ToString(), item.Actif.ToString(), item.CompetenceParticuliere.ToString(), item.CommentaireEmp.ToString()};
                lstLigne.Add(ligne);
                lstEmploye.Add(new Employe(item));
            }

            return lstLigne;
        }

        public List<Employe> recherche(string cle)
        {
            List<Employe> lstEm = new List<Employe>();

            foreach (var item in rEmployeSQL.rechercheEmploye(cle))
            {
                //Employe em = new Employe( item.IdEmp, item.PrenomEmp, item.NomEmp, item.CourrielEmp, item.NoTelPrincipal, item.NoTelSecondaire, item.AdressePostale, item.DateEmbaucheEmp, item.Actif, item.CompetenceParticuliere, item.CommentaireEmp);
                //lstEm.Add(em);
            }
            return lstEm;
        }
    }
}
