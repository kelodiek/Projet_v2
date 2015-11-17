using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Texcel.Controllers
{
    public class CasTestController : Controller
    {
        dbProjetE2TestEntities db = new dbProjetE2TestEntities();
        // GET: CasTest
        public ActionResult Gestion()
        {
            return View();
        }
        // GET: CasTest/Details
        public ActionResult Details()
        {
            return View();
        }
        public PartialViewResult getAllCasTest()
        {
            tblCasTest[] casTests = db.tblCasTest.ToArray<tblCasTest>();
            return PartialView(casTests);
        }

        

    }
}