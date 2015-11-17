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
            var lstBrut = rVersSQL.getAllVersion(idJeu);

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
                rVersSQL.setVersion(v);
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

                rVersSQL.addVersion(VersionAjout);
            }
        }
        public bool verifier(string c)
        {
            var resultat = rVersSQL.srchCodeVersion(c);
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
            rVersSQL.deleteVersion(c);
        }
        public List<version> rechercher(string r,int idjeu)
        {
            List<version> lstVersion = new List<version>();
            foreach (var c in rVersSQL.srchVersion(r,idjeu))
            {
                var vers = new version(c);
                lstVersion.Add(vers);
            }
            return lstVersion;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP09")
                    drLect = true;

                if (item.CodeDroit == "WP09")
                    drEcr = true;

                if (item.CodeDroit == "Admin")
                    return 4;
            }

            if (drLect == true && drEcr == true)
                return 3;
            else if (drLect == false && drEcr == true)
                return 2;
            else if (drLect == true && drEcr == false)
                return 1;

            return 0;
        }
    }
}
