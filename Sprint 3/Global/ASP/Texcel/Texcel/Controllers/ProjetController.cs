using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Texcel.Controllers
{
    public class ProjetController : Controller
    {
        dbProjetE2TestEntities db = new dbProjetE2TestEntities();
        // GET: Projet
        public ActionResult Gestion()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public PartialViewResult getAllProjet()
        {
            tblProjet[] projets = db.tblProjet.ToArray<tblProjet>();
            return PartialView(projets);
        }
        public PartialViewResult selectChefs()
        {
            tblEmploye[] chefPro = db.tblEmploye.ToArray<tblEmploye>();
            return PartialView(chefPro);
        }
        public PartialViewResult selectVersions()
        {
            tblVersion[] versions = db.tblVersion.ToArray<tblVersion>();
            return PartialView(versions);
        }
    }
}