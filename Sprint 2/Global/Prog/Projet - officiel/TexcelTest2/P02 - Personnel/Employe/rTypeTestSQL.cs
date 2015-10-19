using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rTypeTestSQL : Requete
    {
        //          envoye une liste des types de test pour les relier au employe
        static public IQueryable<tblTypeTest> getTypeTest()
        {

            var t =
                from e in db.tblTypeTest
                select e;

            return t;
        }
    }
}
