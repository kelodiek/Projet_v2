using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlVersion
    {
        public List<version> lstVersion { get; set; }
        public ctrlVersion() 
        {
            lstVersion = new List<version>();
        }

        public List<string[]> chargeDonnees(int idJeu)
        {
            List<string[]> lstRows = new List<string[]>();
            var lstBrut = RequeteSql.getAllVersion(idJeu);

            foreach (var item in lstBrut)
            {
                lstRows.Add(new string[] { item.CodeVersion,
                    item.NomVersion,
                    item.DescVersion,
                    item.StadeDeveloppement,
                    item.DateVersion.ToShortDateString(),
                    ((DateTime)item.DateSortiePrevue).ToShortDateString()});

                lstVersion.Add(new version(item));
            }

            return lstRows;
        }
        public bool verifier(version nouv,version ancien)
        {
            
            if (ancien == null)
            {
                return false;  
            }
            else
            {
                return true;
            }
        }
        public bool verifier(string n, string c)
        {
            string code = c.Trim();
            string nom = n.Trim();
            if (code.Length != 0 && code.Length < 10 && nom.Length != 0 && nom.Length < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void enregistrer(string te,version v)
        {
            tblVersion VersionAjout;
            if (te == "m")
            {
                RequeteSql.setVersion(v);
            }
            if (te == "a")
            {
                VersionAjout = new tblVersion();
                VersionAjout.CodeVersion = v.codeVersion;
                VersionAjout.DateSortiePrevue = v.dateSortie;
                VersionAjout.DateVersion = v.dateVersion;
                VersionAjout.DescVersion = v.descVersion;
                VersionAjout.IdJeu = v.idJeu;
                VersionAjout.NomVersion = v.nomVersion;
                VersionAjout.StadeDeveloppement = v.stadeVersion;

                RequeteSql.addVersion(VersionAjout);
            }
        }
        public bool verifier(string c)
        {
            var resultat = RequeteSql.srchCodeVersion(c);
            if (resultat.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void supprimer(string c)
        {
            RequeteSql.deleteVersion(c);
        }
        public List<version> rechercher(string r,int idjeu)
        {
            List<version> lstVersion = new List<version>();
            foreach (var c in RequeteSql.srchVersion(r,idjeu))
            {
                var vers = new version(c);
                lstVersion.Add(vers);
            }
            return lstVersion;
        }
    }
}
