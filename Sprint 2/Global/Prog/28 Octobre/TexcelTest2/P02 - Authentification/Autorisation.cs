//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Projet
//{
//    //REGARDE LES AUTHORISATIONS / ROLES
//    //RETOURS :
//    //R = LECTURE SEULEMENT
//    //RW = LECTURE ET ÉCRITURE
//    //N = ACCÈS REFUSÉ
//    public static class Autorisation
//    {
//        private static int Grp;
//        public Autorisation(string Username)
//        {
//            var db = new dbProjetE2ProdEntities();

//            var r = from the in db.tblUtilisateur
//                    where (the.NomUtil == Username) 
//                    select the.IdRole;
//            foreach (var item in r)
//            {
//                Grp = item;
//            }
//        }

//        public static string GetAutorisation(System.Windows.Forms.Form f)
//        {
//            switch(Grp)
//            {
//                case 1: return GetAdmin(f);
//                    break;
//                case 2: return GetTesteur(f);
//                    break;
//                case 3: return GetDirecteur(f);
//                    break;
//                case 4: return GetChefProjet(f);
//                    break;
//                case 5: return GetChefEquipe(f);
//                    break;
//                default : return false;
//                    break;
//            }
//        }

//        public static string GetAdmin(System.Windows.Forms.Form f)
//        {
//            return "RW";
//        }
//        public static string GetTesteur(System.Windows.Forms.Form f)
//        {
//            var r = f.Tag.ToString();

//            if((r == "Console") || (r == "Projet"))
//            {
//                return "N";
//            }
//            else
//            {
//                return "RW";
//            }
//        }
//    }
//}
