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
            RequeteSql.addSysExp(sysExp);
        }

        public List<string[]> chargerDonnees()
        {
            var lstRows = new List<string[]>();
            var lstBrut = RequeteSql.getSysExp();
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
        public void supprimer(List<int> lstID)
        {
            foreach (var item in lstID)
            {
                RequeteSql.deleteSysExp(item);
            }
        }
        public void enregistrer(SystemeExploitation sysExp)
        {
            if (sysExp.idSysExp == 0)
            {
                RequeteSql.addSysExp(sysExp);
            }
            else
            {
                RequeteSql.setSysExp(sysExp);
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

            if (nom == ancien.nomSysExp && code == ancien.CodeSysExp &&
                edit == ancien.editSysExp && version == ancien.versionSysExp && 
                info == ancien.infoSysExp)
            {
                return false;
            }

            return true;
        }
    }
}
