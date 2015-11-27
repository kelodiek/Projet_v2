using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Texcel.Models;

namespace Texcel.Controllers
{
    public class RechercheController : Controller
    {
        dbProjetE2TestEntities TestBD = new dbProjetE2TestEntities();
        RequeteRechercheSQL ResearchSQL = new RequeteRechercheSQL();
        // GET: Recherche
        public ActionResult RechercheSimple()
        {
            return View();
        }
        public PartialViewResult GetFiltre1()
        {
            tblFiltre1[] Filtre = TestBD.tblFiltre1.ToArray<tblFiltre1>();
            return PartialView(Filtre);
        }
        public PartialViewResult GetFiltre2()
        {
            tblFiltre2[] Filtre = TestBD.tblFiltre2.ToArray<tblFiltre2>();
            return PartialView(Filtre);
        }
        public PartialViewResult GetFiltre3()
        {
            tblFiltre3[] Filtre = TestBD.tblFiltre3.ToArray<tblFiltre3>();
            return PartialView(Filtre);
        }
        public PartialViewResult GetProjet()
        {
            tblProjet[] projets = TestBD.tblProjet.ToArray<tblProjet>();
            return PartialView(projets);
        }
        public PartialViewResult GetJeu()
        {
            tblJeu[] jeux = TestBD.tblJeu.ToArray<tblJeu>();
            return PartialView(jeux);
        }
        public PartialViewResult GetCasTest()
        {
            tblCasTest[] CasTests = TestBD.tblCasTest.ToArray<tblCasTest>();
            return PartialView(CasTests);
        }
        public PartialViewResult GetEmploye()
        {
            tblEmploye[] projets = TestBD.tblEmploye.ToArray<tblEmploye>();
            return PartialView(projets);
        }
        public PartialViewResult GetEquipe()
        {
            tblEquipe[] projets = TestBD.tblEquipe.ToArray<tblEquipe>();
            return PartialView(projets);
        }

        public PartialViewResult GetVersion()
        {
            tblVersion[] CasTests = TestBD.tblVersion.ToArray<tblVersion>();
            return PartialView(CasTests);
        }
        public PartialViewResult GetPlateforme()
        {
            tblPlateforme[] projets = TestBD.tblPlateforme.ToArray<tblPlateforme>();
            return PartialView(projets);
        }
        public PartialViewResult GetTypeTest()
        {
            tblTypeTest[] projets = TestBD.tblTypeTest.ToArray<tblTypeTest>();
            return PartialView(projets);
        }
    }
}