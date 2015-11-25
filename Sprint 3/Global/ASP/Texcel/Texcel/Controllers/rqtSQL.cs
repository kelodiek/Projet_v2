using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Texcel.Controllers
{
    static public class rqtSQL
    {
        private static dbProjetE2TestEntities db = new dbProjetE2TestEntities();

        public static tblProjet checkProjet(string code)
        {
            tblProjet Pro = new tblProjet();
            IEnumerable<tblProjet> r;
            int count = 0;
            using (var db = new dbProjetE2TestEntities())
            {
                r = from p in db.tblProjet
                        where p.CodeProjet == code
                        select p;
                if (r.Count() != 0)
                {
                    Pro = r.First();
                }
                count = r.Count();
            }
            if (count != 0)
            {
                return Pro;
            }
            else
            {
                return null;
            }
        }
        public static tblVersion checkVersion(string code)
        {
            tblVersion Ver = new tblVersion();
            IEnumerable<tblVersion> r;
            int count = 0;
            using (var db = new dbProjetE2TestEntities())
            { 
                r = from p in db.tblVersion
                    where p.CodeVersion == code
                    select p;
                if (r.Count() != 0)
                {
                    Ver = r.First();
                }
                count = r.Count();
            }
            if (count != 0)
            {
                return Ver;
            }
            else
            {
                return null;
            }  
        }
        /// <summary>
        /// Redirige l'enregistrement vers la bonne methode
        /// </summary>
        /// <param name="code">1 = Projet</param>
        /// <param name="enr">objet a enregistrer</param>
        public static void enregistrer(int code, object enr)
        {
            switch (code)
            {
                case 1: addProjet((tblProjet)enr);
                    break;
                default:
                    throw new System.ArgumentException("Code invalide : " + code,"code");
            }
        }
        private static void addProjet(tblProjet p)
        {
            using (var db = new dbProjetE2TestEntities())
            {
                try
                {
                    db.tblProjet.Add(p);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    
                    throw;
                }
                
            }
        }
        /// <summary>
        /// Redirige la modification vers la bonne methode
        /// </summary>
        /// <param name="code">1,11 = Projet</param>
        /// <param name="enr">objet a enregistrer</param>
        public static void modifier(int code, object enr)
        {
            switch (code)
            {
                case 1: setProjet((tblProjet)enr);
                    break;
                default:
                    throw new System.ArgumentException("Code invalide : " + code, "code");
            }
        }
        private static void setProjet(tblProjet p)
        {
            var r = (from P in db.tblProjet
                    where P.CodeProjet == p.CodeProjet
                    select P).First();

            r.CodeVersion = p.CodeVersion;
            r.DateCreation = p.DateCreation;
            r.DateEcheance = p.DateEcheance;
            r.DescProjet = p.DescProjet;
            r.IdChefProjet = p.IdChefProjet;
            r.ObjectifProjet = p.ObjectifProjet;
            r.TitreProjet = p.TitreProjet;

            db.SaveChanges();
        }
        //Suppression vas devoir etre refaite, la db est pas fini
    }
}