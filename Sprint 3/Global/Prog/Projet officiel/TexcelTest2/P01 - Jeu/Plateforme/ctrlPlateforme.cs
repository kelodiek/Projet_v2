using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlPlateforme : IControle
    {
        public List<plateforme> lstPlateforme { get; set; }
        public ctrlPlateforme()
        {
            lstPlateforme = new List<plateforme>();
        }
        public void ajouter(object o)
        {
            var ajout = plateTotblPlate((plateforme)o);
            rPlateSQL.addPlateforme(ajout);
        }

        public void modifier(object o)
        {
            var nouv = plateTotblPlate((plateforme)o);
            nouv.IdPlateforme = ((plateforme)o).idPlate;

            rPlateSQL.setPlateforme(nouv);
        }

        public bool supprimer(object o)
        {
            if (rPlateSQL.checkPlateJeu((int)o))
            {
                return false;
            }
            else
            {
                rPlateSQL.deletePlateformeSysExp((int)o);
                rPlateSQL.deletePlateforme((int)o);
                return true;
            }
        }

        public bool verifier(object o, object n)
        {
            plateforme ancien, nouv;

            ancien = (plateforme)o;
            nouv = (plateforme)o;

            if (ancien.codePlate == nouv.codePlate && ancien.nomPlate == nouv.nomPlate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<string[]> chargerDonnees()
        {
            string[] row;
            List<string[]> lstRows = new List<string[]>();
            var lstBrut = rPlateSQL.getPlateforme();
            lstPlateforme = new List<plateforme>();

            foreach (var item in lstBrut)
            {
                lstPlateforme.Add(new plateforme(item));

                row = new string[] {
                    item.CodePlateforme,
                    item.NomPlateforme,
                    item.CodeCategorie,
                    item.DescPlateforme};
                lstRows.Add(row);
            }
            
            return lstRows;
        }
        private tblPlateforme plateTotblPlate(plateforme p)
        {
            tblSysExp systemp = new tblSysExp();
            tblPlateforme tblP = new tblPlateforme();

            tblP.IdPlateforme = p.idPlate;
            tblP.CodePlateforme = p.codePlate;
            tblP.NomPlateforme = p.nomPlate;
            tblP.CodeCategorie = p.codeCateg;
            tblP.CPU = p.cpuPlate;
            tblP.CarteMere = p.carteMerePlate;
            tblP.RAM = p.ramPlate;
            tblP.Stockage = p.stockage;
            tblP.DescPlateforme = p.descPlate;
            tblP.InfoSupPlateforme = p.infoSupPlate;

            foreach (SystemeExploitation item in p.lstSysExpPlate)
            {
                systemp = new tblSysExp();
                systemp.CodeSysExp = item.CodeSysExp;
                systemp.EditionSysExp = item.editSysExp;
                systemp.IdSysExp = item.idSysExp;
                systemp.InfoSupSysExp = item.infoSysExp;
                systemp.NomSysExp = item.nomSysExp;
                systemp.Tag = item.tagSysExp;
                systemp.VersionSysExp = item.versionSysExp;
                tblP.tblSysExp.Add(systemp);
            }
            return tblP;
        }

        void IControle.supprimer(object o)
        {
            throw new NotImplementedException();
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP06")
                    drLect = true;

                if (item.CodeDroit == "WP06")
                    drEcr = true;

                if (item.CodeDroit == "Admin")
                    return 3;
            }

            if (drLect == true && drEcr == true)
                return 3;
            else if (drLect == false && drEcr == true)
                return 2;
            else if (drLect == true && drEcr == false)
                return 1;

            return 0;
        }

        public List<plateforme> recherche(string cle)
        {
            List<plateforme> lstRP = new List<plateforme>();

            foreach (var item in rPlateSQL.srchPlateforme(cle))
            {
                plateforme temp = new plateforme(item);
                lstRP.Add(temp);
            }
            return lstRP;
        }
    }
}
