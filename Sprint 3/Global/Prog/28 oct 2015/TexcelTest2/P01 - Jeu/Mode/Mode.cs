using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Mode
    {
        private int IdMode;
        private string NomMode, DescMode;

        public Mode(int id, string nom, string desc)
        {
            this.IdMode = id;
            this.NomMode = nom;
            this.DescMode = desc;
        }

        public Mode(tblMode mo)
        {
            IdMode = mo.IdMode;
            NomMode = mo.NomMode;
            DescMode = mo.DescMode;
        }

        public Mode()
        {
            IdMode = 0;
            NomMode = "";
            DescMode = "";
        }

        public int idMode
        {
            get { return IdMode; }
            set { IdMode = value; }
        }

        public string nomMode
        {
            get { return NomMode; }
            set { NomMode = value; }
        }

        public string descMode
        {
            get { return DescMode; }
            set { DescMode = value; }
        }
    }
}
