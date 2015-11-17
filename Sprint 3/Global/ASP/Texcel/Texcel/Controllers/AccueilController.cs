using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Texcel.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Billet
        public ActionResult Index()
        {
            return View();
            
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }
    }
}