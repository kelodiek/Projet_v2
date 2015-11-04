using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rSysExpSQL : Requete
    {
        static public IQueryable<tblSysExp> getSysExp()
        {
            var r =
                from c in db.tblSysExp
                select c;

            return r;
        }
        static public void setSysExp(SystemeExploitation settings)
        {
            var i = Convert.ToInt32(settings.idSysExp);


            var r =
                (from sysExp in db.tblSysExp
                 where sysExp.IdSysExp == i
                 select sysExp).First();

            r.CodeSysExp = settings.CodeSysExp;
            r.NomSysExp = settings.nomSysExp;
            r.EditionSysExp = settings.editSysExp;
            r.VersionSysExp = settings.versionSysExp;
            r.InfoSupSysExp = settings.infoSysExp;

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void addSysExp(SystemeExploitation settings)
        {
            var add = new tblSysExp();

            add.CodeSysExp = settings.CodeSysExp;
            add.NomSysExp = settings.nomSysExp;
            add.EditionSysExp = settings.editSysExp;
            add.VersionSysExp = settings.versionSysExp;
            add.InfoSupSysExp = settings.infoSysExp;

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
        static public IQueryable<tblSysExp> srchSysExp(string chaine)
        {

            var r =
                from sysexp in db.tblSysExp
                where sysexp.Tag.Contains(chaine)
                select sysexp;

            return r;
        }
    }
}
