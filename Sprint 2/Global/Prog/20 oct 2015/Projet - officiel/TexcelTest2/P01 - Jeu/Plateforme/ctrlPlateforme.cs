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
            RequeteSql.addPlateforme(ajout);
        }

        public void modifier(object o)
        {
            var nouv = plateTotblPlate((plateforme)o);
            nouv.IdPlateforme = ((plateforme)o).idPlate;

            RequeteSql.setPlateforme(nouv);
        }

        public bool supprimer(object o)
        {
            if (RequeteSql.checkPlateJeu((int)o))
            {
                return false;
            }
            else
            {
                RequeteSql.deletePlateformeSysExp((int)o);
                RequeteSql.deletePlateforme((int)o);
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
            var lstBrut = RequeteSql.getPlateforme();
            lstPlateforme = new List<plateforme>();

            foreach (var item in lstBrut)
            {
                lstPlateforme.Add(new plateforme(item));

                row = new string[] {item.IdPlateforme.ToString(),
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
    }
}
