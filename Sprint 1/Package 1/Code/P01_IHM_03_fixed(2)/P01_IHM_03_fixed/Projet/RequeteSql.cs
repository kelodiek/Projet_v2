using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    static class RequeteSql
    {
        static public IQueryable<tblClassification> getClassification()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblClassification
                select c;

            return r;
        }
        static public IQueryable<tblSysExp> getSysExp()
        {
            var db = new dbProjetE2ProdEntities();

            var r =
                from c in db.tblSysExp
                select c;

            return r;
        }
        static public void setSysExp(string[] settings)
        {
            var db = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(settings[0]);
            

            var r =
                (from sysExp in db.tblSysExp
                where sysExp.IdSysExp == i
                select sysExp).First();

            r.CodeSysExp = settings[1];
            r.NomSysExp = settings[2];
            r.EditionSysExp = settings[3];
            r.VersionSysExp = settings[4];
            r.InfoSupSysExp = settings[5];
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addSysExp(string[] settings)
        {
            var db = new dbProjetE2ProdEntities();
            var add = new tblSysExp();

            add.CodeSysExp = settings[1];
            add.NomSysExp = settings[2];
            add.EditionSysExp = settings[3];
            add.VersionSysExp = settings[4];
            add.InfoSupSysExp = settings[5];

            db.tblSysExp.Add(add);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deleteSysExp(int ID)
        {
            var db = new dbProjetE2ProdEntities();
            var i = Convert.ToInt32(ID);

            var r =
                from sysExp in db.tblSysExp
                where sysExp.IdSysExp == i
                select sysExp;

            foreach (var item in r)
            {
                db.tblSysExp.Remove(item);
            }
            

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
