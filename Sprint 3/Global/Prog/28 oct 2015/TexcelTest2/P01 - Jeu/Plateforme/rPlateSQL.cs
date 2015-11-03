using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class rPlateSQL : Requete
    {
        static public IQueryable<tblPlateforme> getPlateforme()
        {
            var r =
                from c in db.tblPlateforme
                select c;
            return r;
        }
        static public void addPlateforme(tblPlateforme p)
        {
            db.tblPlateforme.Add(p);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static public void deletePlateforme(int code)
        {
            var rPlate =
                (from plate in db.tblPlateforme
                 where plate.IdPlateforme == code
                 select plate).FirstOrDefault<tblPlateforme>();

            deletePlateJeu(code);
            db.tblPlateforme.Remove(rPlate);


            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.InnerException.InnerException.Message);
            }
        }
        static public void deletePlateformeSysExp(int code)
        {
            var rPlate =
                (from plate in db.tblPlateforme
                 where plate.IdPlateforme == code
                 select plate).FirstOrDefault<tblPlateforme>();

            rPlate.tblSysExp.Clear();

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.InnerException.InnerException.Message);
            }
        }
        static public void setPlateforme(tblPlateforme p)
        {
            var rPlate =
                (from plate in db.tblPlateforme
                 where plate.IdPlateforme == p.IdPlateforme
                 select plate).FirstOrDefault<tblPlateforme>();

            rPlate.CarteMere = p.CarteMere;
            rPlate.CodeCategorie = p.CodeCategorie;
            rPlate.CodePlateforme = p.CodePlateforme;
            rPlate.CPU = p.CPU;
            rPlate.DescPlateforme = p.DescPlateforme;
            rPlate.InfoSupPlateforme = p.InfoSupPlateforme;
            rPlate.NomPlateforme = p.NomPlateforme;
            rPlate.RAM = p.RAM;
            rPlate.Stockage = p.Stockage;
            rPlate.tblSysExp.Clear();

            foreach (var item in p.tblSysExp)
            {
                rPlate.tblSysExp.Add(item);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.InnerException.InnerException.Message);
            }
        }
        static private void deletePlateJeu(int id)
        {
            var rPlate =
                (from plate in db.tblPlateforme
                 where plate.IdPlateforme == id
                 select plate).FirstOrDefault<tblPlateforme>();

            rPlate.tblJeu.Clear();

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static public bool checkPlateJeu(int id)
        {
            var rPlate =
                (from plate in db.tblPlateforme
                 where plate.IdPlateforme == id
                 select plate).FirstOrDefault<tblPlateforme>();

            if (rPlate.tblJeu.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public IQueryable<tblPlateforme> srchPlateforme(string chaine)
        {
            var r =
                from plate in db.tblPlateforme
                where plate.Tag.Contains(chaine)
                select plate;

            return r;
        }
    }
}
