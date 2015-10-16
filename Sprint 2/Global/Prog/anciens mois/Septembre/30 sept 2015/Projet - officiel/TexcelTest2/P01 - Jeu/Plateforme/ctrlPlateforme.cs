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
            var ajout = new tblPlateforme();
            tblSysExp systemp;
            //List<tblPlateforme> lstPlat = new List<tblPlateforme>();
            //lstPlat.Add(ajout);
            //systemp.tblPlateforme = lstPlat;
            ICollection<tblSysExp> lstSysExp = new List<tblSysExp>();

            ajout.CodePlateforme = ((plateforme)o).codePlate;
            ajout.NomPlateforme = ((plateforme)o).nomPlate;
            ajout.CodeCategorie = ((plateforme)o).codeCateg;
            ajout.CPU = ((plateforme)o).cpuPlate;
            ajout.CarteMere = ((plateforme)o).carteMerePlate;
            ajout.RAM = ((plateforme)o).ramPlate;
            ajout.Stockage=((plateforme)o).stockage;
            ajout.DescPlateforme = ((plateforme)o).descPlate;
            ajout.InfoSupPlateforme = ((plateforme)o).infoSupPlate;
            
            var db = new dbProjetE2ProdEntities();
            
            foreach (SystemeExploitation item in ((plateforme)o).lstSysExpPlate)
            {
                systemp = new tblSysExp();
                systemp.CodeSysExp = item.CodeSysExp;
                systemp.EditionSysExp = item.editSysExp;
                systemp.IdSysExp = item.idSysExp;
                systemp.InfoSupSysExp = item.infoSysExp;
                systemp.NomSysExp = item.nomSysExp;
                systemp.Tag = item.tagSysExp;
                systemp.VersionSysExp = item.versionSysExp;
                systemp.IdSysExp = item.idSysExp;
               ajout.tblSysExp.Add(systemp);
               // lstSysExp.Add(systemp);
            }
            //ajout.tblSysExp = lstSysExp;
            db.tblPlateforme.Add(ajout);

            //ajout.tblSysExp = lstSysExp;
            //RequeteSql.addPlateforme(ajout);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void modifier(object o)
        {
            throw new NotImplementedException();
        }

        public void supprimer(object o)
        {
            throw new NotImplementedException();
        }

        public bool verifier(object o, object n)
        {
            throw new NotImplementedException();
        }
        public List<string[]> chargerDonnees()
        {
            string[] row;
            List<string[]> lstRows = new List<string[]>();
            var lstBrut = RequeteSql.getPlateforme();

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
    }
}
