using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexcelTest2
{
    class Mode
    {
        private int IdMode;
        private string NomMode, DescMode;

        public Mode(int id, string nom, string desc)
        {
            NewMode(id, nom, desc);
        }

        private Mode NewMode(int id, string nom, string desc){
            this.IdMode = id;
            this.NomMode = nom;
            this.DescMode = desc;
            return this;
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
