using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class TypeTest
    {
        private string CodeTypeTest, NomTypeTest, ObjectifTypeTest, DescTypeTest, CommentaireTypeTest;

        public TypeTest()
        {
            CodeTypeTest = "";
            NomTypeTest = "";
            ObjectifTypeTest = "";
            DescTypeTest = "";
            CommentaireTypeTest = "";
        }

        public TypeTest(string _cod, string _nm, string _ob, string _desc, string _com)
        {
            CodeTypeTest = _cod;
            NomTypeTest = _nm;
            ObjectifTypeTest = _ob;
            DescTypeTest = _desc;
            CommentaireTypeTest = _com;
        }

        public TypeTest(tblTypeTest _type)
        {
            CodeTypeTest = _type.CodeTypeTest;
            NomTypeTest = _type.NomTypeTest;
            ObjectifTypeTest = _type.ObjectifTypeTest;
            DescTypeTest = _type.DescTypeTest;
            CommentaireTypeTest = _type.CommentaireTest;
        }

        public string codeTypeTest 
        {
            get { return CodeTypeTest; }
            set { CodeTypeTest = value; }
        }

        public string nomTypeTest 
        {
            get { return NomTypeTest; }
            set { NomTypeTest = value; }
        }

        public string objectifTypeTest
        {
            get { return ObjectifTypeTest; }
            set { ObjectifTypeTest = value; }
        }

        public string descTypeTest
        {
            get { return DescTypeTest; }
            set { DescTypeTest = value; }
        }

        public string commentaireTypeTest
        {
            get { return CommentaireTypeTest; }
            set { CommentaireTypeTest = value; }
        }
    }
}
