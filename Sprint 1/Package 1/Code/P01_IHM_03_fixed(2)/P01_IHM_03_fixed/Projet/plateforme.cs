using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class plateforme
    {
        public int idPlate { get; set; }
        public string codePlate { get; set; }
        public string nomPlate { get; set; }
        public string cpuPlate { get; set; }
        public string carteMerePlate { get; set; }
        public string ramPlate { get; set; }
        public string stockage { get; set; }
        public string descPlate { get; set; }
        public string infoSupPlate { get; set; }
        public string tagPlate { get; set; }
        public string codeCateg { get; set; }
        public List<SystemeExploitation> lstSysExpPlate { get; set; }

        public plateforme()
        {
            idPlate = 0;
            codePlate = "";
            nomPlate = "";
            cpuPlate = "";
            carteMerePlate = "";
            ramPlate = "";
            stockage = "";
            descPlate = "";
            infoSupPlate = "";
            tagPlate = "";
            codeCateg = "";
            lstSysExpPlate = new List<SystemeExploitation>();
        }
        public plateforme(tblPlateforme p)
        {
            idPlate = p.IdPlateforme;
            codePlate = p.CodePlateforme;
            nomPlate = p.NomPlateforme;
            cpuPlate = p.CPU;
            carteMerePlate = p.CarteMere;
            ramPlate = p.RAM;
            stockage = p.Stockage;
            descPlate = p.DescPlateforme;
            infoSupPlate = p.InfoSupPlateforme;
            tagPlate = p.Tag;
            codeCateg = "";
            lstSysExpPlate = new List<SystemeExploitation>();

            foreach (var item in p.tblSysExp)
            {
                lstSysExpPlate.Add(new SystemeExploitation(item));
            }
            
        }
    }
}
