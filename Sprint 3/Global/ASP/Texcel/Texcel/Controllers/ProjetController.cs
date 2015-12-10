using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

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
            tblProjet[] projets;
            using (var db = new dbProjetE2TestEntities())
            {
                projets = db.tblProjet.ToArray<tblProjet>();
            }
            
            return PartialView(projets);
        }
        public PartialViewResult selectChefs()
        {

            tblEmploye[] chefPro;
            using (var db = new dbProjetE2TestEntities())
            {
                chefPro = db.tblEmploye.ToArray<tblEmploye>();
            }
            ViewBag.idPro = "test";
            return PartialView(chefPro);
        }
        public PartialViewResult selectVersions()
        {
            tblVersion[] versions;
            using (var db = new dbProjetE2TestEntities())
            {
                versions = db.tblVersion.ToArray<tblVersion>();
            }
            return PartialView(versions);
        }
        /// <summary>
        /// Enregistre le projet si il y'a une modif ou si il est nouveau
        /// </summary>
        /// <param name="values">0 = nouv , 1 = modif</param>
        /// <returns>retourne si il y'a une erreur dans les infos du projet</returns>
        public string EnrProjet(List<String> values)
        {
            tblProjet projet = new tblProjet();
            int idToParse,code;
            DateTime dateToParse;

            Int32.TryParse(values[0].Trim(), out code);
            try
            {
                if (rqtSQL.checkProjet(values[1].Trim()) != null && code == 0)
                {
                    return "Un projet avec ce code existe deja.";
                }
                else
                {
                    projet.CodeProjet = values[1].Trim();
                }
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
            if (!Int32.TryParse(values[2].Trim(), out idToParse))
            {
                return "Numero de chef de projet non valide.";
            }
            else
            {
                projet.IdChefProjet = idToParse;
            }
            projet.TitreProjet = values[3].Trim();
            if (rqtSQL.checkVersion(values[4].Trim()) == null)
            {
                return "Une version de jeu avec ce code n'existe pas : " + values[4];
            }
            else
            {
                projet.CodeVersion = values[4].Trim();
            }
            if (!DateTime.TryParse(values[5].Trim(), out dateToParse))
            {
                return "Date non valide.";
            }
            else
            {
                projet.DateCreation = dateToParse;
            }
            if (!DateTime.TryParse(values[6].Trim(), out dateToParse))
            {
                return "Date non valide.";
            }
            else
            {
                projet.DateEcheance = dateToParse;
            }
            projet.DescProjet = values[7].Trim();
            projet.ObjectifProjet = values[9].Trim();
            projet.Autre = values[8].Trim();
            try
            {
                if (code == 0)
                {
                    rqtSQL.enregistrer(1, projet);
                }
                else
                {
                    rqtSQL.modifier(1, projet);
                }
            }
            catch (NullReferenceException e)
            {
                return "erreur enr. : " + e.Message;
            }
            catch (ArgumentException e)
            {
                return "erreur enr. : " + e.Message;
            }
            return null;
        }
    }

}