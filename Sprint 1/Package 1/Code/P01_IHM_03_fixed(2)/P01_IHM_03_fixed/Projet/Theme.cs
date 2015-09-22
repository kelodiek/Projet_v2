﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Theme
    {
        private int IdTheme;
        private string NomTheme, ComTheme;

        public Theme(int id, string nom, string com)
        {
            NewTheme(id, nom, com);
        }

        private Theme NewTheme(int id, string nom, string com){
            this.IdTheme = id;
            this.NomTheme = nom;
            this.ComTheme = com;
            return this;
        }

        public int idTheme
        {
            get { return IdTheme; }
            set { IdTheme = value; }
        }

        public string nomTheme
        {
            get { return NomTheme; }
            set { NomTheme = value; }
        }

        public string comTheme
        {
            get { return ComTheme; }
            set { ComTheme = value; }
        }
    }
}
