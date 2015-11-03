using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Droit
    {
        private string CodeDroit, DescDroit;
        private List<GroupeUtil> ListDroitGroupe;

        public Droit()
        {
            CodeDroit = "";
            DescDroit = "";
            ListDroitGroupe = new List<GroupeUtil>();
        }

        public Droit(tblDroit dd)
        {
            CodeDroit = dd.CodeDroit;
            DescDroit = dd.DescDroit;
            ListDroitGroupe = new List<GroupeUtil>();
            //foreach (tblGroupe item in dd.tblGroupe)
            //{
            //    GroupeUtil tmp = new GroupeUtil(item);
            //    ListDroitGroupe.Add(tmp);
            //}
        }

        public string codeDroit
        {
            get { return CodeDroit; }
            set { CodeDroit = value; }
        }

        public string descDroit
        {
            get { return DescDroit; }
            set { DescDroit = value; }
        }

        public List<GroupeUtil> lstDroitGroupe
        {
            get { return ListDroitGroupe; }
            set { ListDroitGroupe = value; }
        }
    }
}
