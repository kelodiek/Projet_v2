using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    partial class equipe : tblEquipe
    {
        public List<AllChefEquipe> lstChefEquipe { get; set; }
        public List<tblEmploye> lstEmploye { get; set; }
        public List<tblTypeTest> lstTypeTest { get; set; }

         public void loadBaseDonnee()
         {
             tblTypeTest tmp = new tblTypeTest();
             loadChefEquipe();
             loadProjets();
             tmp.NomTypeTest = "Aucun";
             loadEmployes(tmp);
             loadTests();
             
         }
        //Temporaire en attendant la BD
        public void TempLoad(ComboBox cboxChefEquipe, ComboBox cboxProjet, TreeView lstTreeTypeTest, TreeView lstTreeEmploye)
         {
             cboxProjet.Items.Add("LesSuperMobiles");

         }

        private void loadChefEquipe()
        {
            var lstBrut = rEquipeSQL.getEmployeChefEquipe();
            lstChefEquipe = new List<AllChefEquipe>();

            foreach (var item in lstBrut)
            {
                AllChefEquipe tempItem = (AllChefEquipe)item;
                lstChefEquipe.Add(tempItem);
            }
        }
        private void loadProjets()
        {

        }

        public void loadEmployes(tblTypeTest typeTest)
        {
            IQueryable<tblEmploye> lstBrut;
            lstEmploye = new List<tblEmploye>();

            try
            {
                lstBrut = rEquipeSQL.getListeEmploye();

                foreach (var item in lstBrut)
                {
                    tblEmploye tempItem = (tblEmploye)item;
                    lstEmploye.Add(tempItem);
                }
            }
            catch (Exception)
            {

            }

        }

        private void loadTests()
        {
            IQueryable<tblTypeTest> lstBrut;

            lstBrut = rEquipeSQL.getListeTest();
            lstTypeTest = new List<tblTypeTest>();

            foreach (var item in lstBrut)
            {
                tblTypeTest tempItem = (tblTypeTest)item;
                lstTypeTest.Add(tempItem);
            }
        }

    }
}
