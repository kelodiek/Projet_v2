using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projet
{
    class ctrlSysExp
    {
        private List<SystemeExploitation> listSysExp;

        public List<SystemeExploitation> lstSysExp
        {
            get { return listSysExp; }
            set { listSysExp = value; }
        }
        public ctrlSysExp()
        {
            this.listSysExp = new List<SystemeExploitation>();
        }
        public void ajouterSysExp(SystemeExploitation sysExp)
        {
            rSysExpSQL.addSysExp(sysExp);
        }

        public List<string[]> chargerDonnees()
        {
            var lstRows = new List<string[]>();
            var lstBrut = rSysExpSQL.getSysExp();
            string[] row;

            foreach (var item in lstBrut)
            {
                row = new string[] {item.IdSysExp.ToString(),
                    item.CodeSysExp,
                    item.NomSysExp,
                    item.EditionSysExp,
                    item.VersionSysExp,
                    item.InfoSupSysExp, 
                    item.Tag };
                lstRows.Add(row);

                listSysExp.Add(new SystemeExploitation(item));
            }

            return lstRows;
        }

        public List<SystemeExploitation> rechercher(string chaine)
        {
            List<SystemeExploitation> lstSysExp = new List<SystemeExploitation>();
            foreach (var c in rSysExpSQL.srchSysExp(chaine))
            {
                SystemeExploitation sysexp = new SystemeExploitation(c);                
                lstSysExp.Add(sysexp);
            }
            return lstSysExp;
        }
        public void supprimer(List<int> lstID)
        {
            foreach (var item in lstID)
            {
                rSysExpSQL.deleteSysExp(item);
            }
        }
        public void enregistrer(SystemeExploitation sysExp)
        {
            if (sysExp.idSysExp == 0)
            {
                rSysExpSQL.addSysExp(sysExp);
            }
            else
            {
                rSysExpSQL.setSysExp(sysExp);
            }
            
        }

        public bool verifier(SystemeExploitation sysExp, SystemeExploitation ancien)
        {
            string nom,code,edit,version,info;

            nom = sysExp.nomSysExp;
            code = sysExp.CodeSysExp;
            edit = sysExp.editSysExp;
            version = sysExp.versionSysExp;
            info = sysExp.infoSysExp;

            nom.Trim();
            code.Trim();
            edit.Trim();
            version.Trim();

            if (ancien != null)
            {
                if (nom == ancien.nomSysExp && code == ancien.CodeSysExp &&
                edit == ancien.editSysExp && version == ancien.versionSysExp &&
                info == ancien.infoSysExp)
                {
                    return false;
                }
            }
            return true;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP02")//   changer pour RP07
                    drLect = true;

                if (item.CodeDroit == "WP01")//   WP07
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
    }
}
