using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class version
    {
        public int idJeu { get; set; }
        public string codeVersion { get; set; }
        public string nomVersion { get; set; }
        public string stadeVersion { get; set; }
        public string descVersion { get; set; }
        public DateTime dateVersion { get; set; }
        public DateTime dateSortie { get; set; }
        public version()
        {
            idJeu = 0;
            codeVersion = "";
            nomVersion = "";
            stadeVersion = "";
            descVersion = "";
            dateVersion = DateTime.Now;
            dateSortie = DateTime.Now;
        }
        public version(tblVersion v)
        {
            idJeu = v.IdJeu;
            codeVersion = v.CodeVersion;
            nomVersion = v.NomVersion;
            stadeVersion = v.StadeDeveloppement;
            descVersion = v.DescVersion;
            dateVersion = v.DateVersion;
            if (v.DateSortiePrevue != null)
            {
                dateSortie = (DateTime)v.DateSortiePrevue;
            }
            else
            {
                dateSortie = DateTime.Now;
            }
            
        }
    }
}
