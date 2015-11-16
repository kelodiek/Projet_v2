using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class ctrlEquipe : IControle
    {
        public List<equipe> lstEquipe { get; set; }
        public ctrlEquipe()
        {
            lstEquipe = new List<equipe>();
        }
        public void ajouter(object o)
        {
            //rEquipeSQL.addEquipe((equipe)o);
        }
        public void modifier(object o)
        {
            rEquipeSQL.setEquipe((equipe)o);
        }
        public void supprimer(object o)
        {
            rEquipeSQL.deleteEquipe((equipe)o);
        }
        public bool verifier(object o, object n)
        {
            return true;
        }

        public List<string[]> chargerDonnees()
        {
            string[] row;
            List<string[]> lstRows = new List<string[]>();
            var lstBrut = rEquipeSQL.getListeEquipe();
            lstEquipe = new List<equipe>();
            tblEmploye chef = new tblEmploye();
            tblTypeTest t = new tblTypeTest();
            List<tblTypeTest> lstTypeTest = new List<tblTypeTest>();


            foreach (var item in lstBrut)
            {
                //lstEquipe.Add(new equipe(item));

                chef = rEquipeSQL.getChefEquipe(item.IdChefEquipe);
                //test = rEquipeSQL.getListTestEquipe(item.tblTypeTest);

                //lstTypeTest = item.tblTypeTest.ToList<tblTypeTest>();
                //t = lstTypeTest.First();

                //string n = test(item.tblTypeTest);

                string n = "";
                int i = 0;
                foreach (var temp in item.tblTypeTest)
                {
                    if (i == 0)
                    {
                        n = temp.NomTypeTest;
                    }
                    else
                    {

                    }
                    i++;
                }

                string e = "";
                i = 0;
                foreach (var temp in item.tblEmploye1)
                {
                    if (i == 0)
                    {
                        e = temp.PrenomEmp + " " + temp.NomEmp;
                    }
                    else
                    {

                    }
                    i++;
                }

                row = new string[] {
                    item.CodeProjet,
                    item.IdEquipe.ToString(),
                    item.NomEquipe,
                    chef.PrenomEmp + " " + chef.NomEmp,
                    n,
                    e};

                lstRows.Add(row);

            }

            return lstRows;
        }

        public List<string[]> chargerDonnees(IQueryable<tblEquipe> lstBrut)
        {
            string[] row;
            List<string[]> lstRows = new List<string[]>();
            lstEquipe = new List<equipe>();
            tblEmploye chef = new tblEmploye();
            tblTypeTest t = new tblTypeTest();
            List<tblTypeTest> lstTypeTest = new List<tblTypeTest>();


            foreach (var item in lstBrut)
            {
                //lstEquipe.Add(new equipe(item));

                chef = rEquipeSQL.getChefEquipe(item.IdChefEquipe);
                //test = rEquipeSQL.getListTestEquipe(item.tblTypeTest);

                //lstTypeTest = item.tblTypeTest.ToList<tblTypeTest>();
                //t = lstTypeTest.First();

                //string n = test(item.tblTypeTest);

                string n = "";
                int i = 0;
                foreach (var temp in item.tblTypeTest)
                {
                    if (i == 0)
                    {
                        n = temp.NomTypeTest;
                    }
                    else
                    {

                    }
                    i++;
                }

                string e = "";
                i = 0;
                foreach (var temp in item.tblEmploye1)
                {
                    if (i == 0)
                    {
                        e = temp.PrenomEmp + " " + temp.NomEmp;
                    }
                    else
                    {

                    }
                    i++;
                }

                row = new string[] {
                    item.CodeProjet,
                    item.IdEquipe.ToString(),
                    item.NomEquipe,
                    chef.PrenomEmp + " " + chef.NomEmp,
                    n,
                    e};

                lstRows.Add(row);

            }

            return lstRows;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP02")//   changer pour RP11
                    drLect = true;

                if (item.CodeDroit == "WP01")//   WP11
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
