using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class rTypeTestSQL
    {
        //          envoye une liste des types de test pour les relier au employe
        static public IQueryable<tblTypeTest> getTypeTest()
        {
            var bd = new dbProjetE2ProdEntities();

            var t =
                from e in bd.tblTypeTest
                select e;

            return t;
        }
    }
}
