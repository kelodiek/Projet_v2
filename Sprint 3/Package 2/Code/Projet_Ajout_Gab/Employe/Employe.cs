using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Employe
    {
        private int IdEmp;
        private string PrenomEmp, NomEmp, CourrielEmp, NoTelPrincipal, NoTelSecondaire, AdressePostale, CompetenceParticuliere, Statut, CommentaireEmp;
        private DateTime DateEmbaucheEmp;
        //private tblEmploye TblE;
        private List<TypeTest> LstEmTypeTest;

        public Employe()
        {
            IdEmp = 0;
            PrenomEmp = "";
            NomEmp = "";
            CourrielEmp = "";
            NoTelPrincipal = "";
            NoTelSecondaire = "";
            AdressePostale = "";
            DateEmbaucheEmp = DateTime.Now;
            CompetenceParticuliere = "";
            Statut = "n";
            CommentaireEmp = "";
            //TblE = null;
            LstEmTypeTest = new List<TypeTest>();
        }

        public Employe(int _id, string _pre, string _nom, string _cou, string _telP, string _telS, string _adre, DateTime _dat, string _comp, string _sta, string _comm, tblEmploye _emp)
        {
            IdEmp = _id;
            PrenomEmp = _pre;
            NomEmp = _nom;
            CourrielEmp = _cou;
            NoTelPrincipal = _telP;
            NoTelSecondaire = _telS;
            AdressePostale = _adre;
            DateEmbaucheEmp = _dat;
            CompetenceParticuliere = _comp;
            Statut = _sta;
            CommentaireEmp = _comm;
            //TblE = _emp;
            LstEmTypeTest = new List<TypeTest>();
        }

        public Employe(tblEmploye _emp)
        {
            IdEmp = _emp.IdEmp;
            PrenomEmp = _emp.PrenomEmp;
            NomEmp = _emp.NomEmp;
            CourrielEmp = _emp.CourrielEmp;
            NoTelPrincipal = _emp.NoTelPrincipal;
            NoTelSecondaire = _emp.NoTelSecondaire;
            AdressePostale = _emp.AdressePostale;
            DateEmbaucheEmp = _emp.DateEmbaucheEmp;
            CompetenceParticuliere = _emp.CompetenceParticuliere;
            Statut = _emp.Statut;
            CommentaireEmp = _emp.CommentaireEmp;
            //TblE = _emp;
            LstEmTypeTest = new List<TypeTest>();
            foreach (tblTypeTest item in _emp.tblTypeTest)
            {
                TypeTest tt = new TypeTest(item);
                LstEmTypeTest.Add(tt);
            }
        }

        public int idEmp 
        {
            get { return IdEmp; }
            set { IdEmp = value; }
        }

        public string prenomEmp
        {
            get { return PrenomEmp; }
            set { PrenomEmp = value; }
        }

        public string nomEmp
        {
            get { return NomEmp; }
            set { NomEmp = value; }
        }

        public string courrielEmp
        {
            get { return CourrielEmp; }
            set { CourrielEmp = value; }
        }

        public string noTelPrincipal
        {
            get { return NoTelPrincipal; }
            set { NoTelPrincipal = value; }
        }

        public string noTelSecondaire
        {
            get { return NoTelSecondaire; }
            set { NoTelSecondaire = value; }
        }

        public string adressePostale
        {
            get { return AdressePostale; }
            set { AdressePostale = value; }
        }

        public DateTime dateEmbaucheEmp
        {
            get { return DateEmbaucheEmp; }
            set { DateEmbaucheEmp = value; }
        }

        public string competenceParticuliere
        {
            get { return CompetenceParticuliere; }
            set { CompetenceParticuliere = value; }
        }

        public string statut
        {
            get { return Statut; }
            set { Statut = value; }
        }

        public string commentaireEmp
        {
            get { return CommentaireEmp; }
            set { CommentaireEmp = value; }
        }

        //public tblEmploye tblE
        //{
        //    get { return TblE; }
        //    set { TblE = value; }
        //}

        public List<TypeTest> lstEmTypeTest
        {
            get { return LstEmTypeTest; }
            set { LstEmTypeTest = value; }
        }
    }
}
