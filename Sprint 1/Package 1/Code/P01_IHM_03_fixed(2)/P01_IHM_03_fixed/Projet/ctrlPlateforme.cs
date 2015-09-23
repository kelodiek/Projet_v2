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
            throw new NotImplementedException();
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
