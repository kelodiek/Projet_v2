using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Texcel.Models;
using System.IO;

namespace Texcel.Controllers
{
    public class CasTestController : Controller
    {
        // GET: CasTest

        dbProjetE2TestEntities db = new dbProjetE2TestEntities();
        string chemin;

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult getCasTest()
        {
            tblCasTest[] casTests = db.tblCasTest.ToArray<tblCasTest>();
            return PartialView(casTests);
        }

        //public ActionResult EnrCasTest(string titreCas, string codeCas, string codeProjet, string codeTypeTest, DateTime dateCreation, DateTime DateEcheance, string descCas, string descDifficulte, int idAuteur, string infoSup, string objectifCas, string prioriteCas)
        //{


        //    return View();
        //}

        public JsonResult EnrCasTest(List<String> values)
        {
            int IdAuteur;
            Int32.TryParse(values[8],out IdAuteur);
            string resultat;

            tblCasTest temp = new tblCasTest();

            try
            {
               temp.TitreCas = values[0].Trim();
               temp.CodeCas = values[1].Trim();
               //temp.CodeProjet = values[2].Trim();
               //temp.CodeTypeTest = values[3].Trim();
               temp.DateCreation = Convert.ToDateTime(values[4]);
               temp.DateEcheance = Convert.ToDateTime(values[5]);
               temp.DescCas = values[6].Trim();
               temp.DifficulteCas = values[7].Trim();
               temp.IdAuteur = IdAuteur;
               temp.InfoSupCas = values[9].Trim();
               temp.ObjectifCas = values[10].Trim();
               temp.PrioriteCas = values[11].Trim();
               temp.StatutCas = "A";

               temp.CodeTypeTest = "QuEst";
               temp.CodeProjet = "PHalo5Beta";

               db.tblCasTest.Add(temp);

                   db.SaveChanges();
                   resultat = "Enregistrement réussi avec succès!";
            }
            catch (Exception)
            {
                resultat = "Il y a eu une erreur lors de l'enregistrement, les chmps sont t'ils remplient correctement?";
            }


            return Json(new { Result = String.Format(resultat)});
        }

        public void DesacCasTest(List<String> values)
        {
            tblCasTest Cas = new tblCasTest();
            string temp = values[0];
            temp = temp.Trim();

            var r =
            from t in db.tblCasTest
            where t.CodeCas == temp
            select t;


            foreach (var item in r)
            {
                Cas = item;
            }

            Cas.StatutCas = "Effacer";
            db.SaveChanges();
            //return Json(new { Result = String.Format("Fist item in list: '{0}'", values[0]) });
        }

        public void EffCasTest(List<String> values)
        {
            tblCasTest Cas = new tblCasTest();
            string temp = values[0];
            temp = temp.Trim();

            var r =
            from t in db.tblCasTest
            where t.CodeCas == temp
            select t;

            foreach (tblCasTest item in r)
            {
                Cas = item;
            }

            db.tblCasTest.Remove(Cas);
            db.SaveChanges();
            //return Json(new { Result = String.Format("Fist item in list: '{0}'", values[0]) });
        }

        public ActionResult getlstFichierCasTest()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] files = Directory.GetFiles(path + "\\CasTest");
            List<string> NomFiles = new List<string>();

            chemin = path;

            foreach (string file in files)
            {
                NomFiles.Add(Path.GetFileName(file));
            }

            return PartialView(files);
            
        }

        public void openFichierCasTest(List<String> values)
        {
            string path = values[0];
            System.Diagnostics.Process.Start(path);
        }

        public void openFolder(List<String> values)
        {
            string path = values[0];
            
            System.IO.File.Create(path);
        }

        //[HttpPost]
        public ActionResult SaveFile(HttpPostedFileBase file)
        {

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                //var path = Path.Combine(Server.MapPath("\\SaveCasTest\\"), fileName);
                var path = Path.Combine("C:\\Users\\Utilisateur\\Documents" + "\\CasTest\\", fileName);
                //string targetFolder = HttpContext.Server.MapPath(chemin);
                //string targetPath = Path.Combine(targetFolder, file.FileName);

                file.SaveAs(path);
            }

            return RedirectToAction("Details");
        }

        //[HttpPost]
        //public ActionResult Index(HttpPostedFileBase file)
        //{
        //    if (file != null && file.ContentLength > 0)
        //        try
        //        {
        //            string path = Path.Combine(Server.MapPath("~/Images"),
        //                                       Path.GetFileName(file.FileName));
        //            file.SaveAs(path);
        //            ViewBag.Message = "File uploaded successfully";
        //        }
        //        catch (Exception ex)
        //        {
        //            ViewBag.Message = "ERROR:" + ex.Message.ToString();
        //        }
        //    else
        //    {
        //        ViewBag.Message = "You have not specified a file.";
        //    }
        //    return View();
        //}
    }
}