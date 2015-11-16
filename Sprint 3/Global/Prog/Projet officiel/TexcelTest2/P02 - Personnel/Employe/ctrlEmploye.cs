using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projet
{
    class ctrlEmploye : IControle
    {
        private List<Employe> listEmploye;
        private List<string[]> listEmployeNV;
        private List<TypeTest> lstTypeT;
        public bool etat { get; set; }  //      true = normal employe existant     false = nouveau employe

        public List<Employe> lstEmploye
        {
            get { return listEmploye; }
            set { listEmploye = value; }
        }
        
        public List<string[]> lstEmployeNV
        {
            get { return listEmployeNV; }
            set { listEmployeNV = value; }
        }

        public ctrlEmploye(bool _e)
        {
            listEmploye = new List<Employe>();
            listEmployeNV = new List<string[]>();
            lstTypeT = new List<TypeTest>();
            etat = _e;
        }

        public void ajouter(object o)
        {
            rEmployeSQL.addEmploye((Employe)o);
        }

        public void modifier(object o)
        {
            rEmployeSQL.setEmploye((Employe)o);
        }

        public void supprimer(object o)         //  Envoie ID de l'employe à désactiver
        {
            if (etat == true)
                rEmployeSQL.deleteEmploye(Convert.ToInt32(o.ToString()));
            else
            {
                string[] tmp = (string[])o;
                string ligne;
                lstEmployeNV.Remove(tmp);
                if (lstEmployeNV.Count == 0)
                    File.Delete(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt"));
                else
                {
                    ligne = tmp[0] + " | " + tmp[1] + " | " + tmp[2] + " | " + tmp[3] + " | " + tmp[4] + " | " + tmp[5] + " | " + tmp[6] + " | " + tmp[7];
                    supprimerLigne((Path.Combine(Environment.CurrentDirectory, @"nouveau.txt")), ligne);
                }
            }       
        }

        public bool verifier(object o, object n)
        {
            Employe ancien, nouv;
            bool resultat = true;
            nouv = (Employe)o;
            if (n != null)
            {
                ancien = (Employe)n;
                bool checkLst = true;
                int i = 0;
                if (nouv.lstEmTypeTest.Count == ancien.lstEmTypeTest.Count)
                {
                    foreach (TypeTest nv in nouv.lstEmTypeTest)
                    {
                        if (nv.codeTypeTest == ancien.lstEmTypeTest[i].codeTypeTest &&
                            nv.nomTypeTest == ancien.lstEmTypeTest[i].nomTypeTest &&
                            nv.descTypeTest == ancien.lstEmTypeTest[i].descTypeTest &&
                            nv.objectifTypeTest == ancien.lstEmTypeTest[i].objectifTypeTest &&
                            nv.commentaireTypeTest == ancien.lstEmTypeTest[i].commentaireTypeTest)
                            i++;
                        else
                        {
                            checkLst = false;
                            break;
                        }
                    } 
                }
                else
                {
                    checkLst = false;
                }

                if (nouv.prenomEmp == ancien.prenomEmp &&
                    nouv.nomEmp == ancien.nomEmp &&
                    nouv.courrielEmp == ancien.courrielEmp &&
                    nouv.noTelPrincipal == ancien.noTelPrincipal &&
                    nouv.adressePostale == ancien.adressePostale &&
                    nouv.dateEmbaucheEmp == ancien.dateEmbaucheEmp &&
                    nouv.competenceParticuliere == ancien.competenceParticuliere &&
                    nouv.commentaireEmp == ancien.commentaireEmp &&
                    checkLst == true)
                {
                    resultat = false;
                    MessageBox.Show("Vous ne pouvez pas enregistrer sans avoir effectuer de changement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (nouv.idEmp == 0 ||
                nouv.prenomEmp.Length > 25 || nouv.prenomEmp.Length == 0 ||
                nouv.nomEmp.Length > 25 || nouv.nomEmp.Length == 0 ||
                nouv.courrielEmp.Length > 45 || nouv.courrielEmp.Length == 0 ||
                nouv.noTelPrincipal.Length > 20 || nouv.noTelPrincipal.Length == 0 ||
                nouv.noTelSecondaire.Length > 20 ||
                nouv.adressePostale.Length > 90 || nouv.adressePostale.Length == 0 ||
                nouv.dateEmbaucheEmp.ToString().Length == 0 ||
                nouv.competenceParticuliere.Length > 400 ||
                nouv.commentaireEmp.Length > 250)
            {
                resultat = false;
                MessageBox.Show("Les données entrées ne sont pas conforme (champs vide ou trop long)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultat;
        }

        public bool verifSemblable(object o)
        {
            Employe nouv;
            nouv = (Employe)o;

            if (lstEmploye.Count == 0)
            {
                var lstBrut = rEmployeSQL.getEmploye();

                foreach (tblEmploye item in lstBrut)
                {
                    lstEmploye.Add(new Employe(item));
                } 
            }

            foreach (Employe e in lstEmploye)
            {
                if (nouv.idEmp == e.idEmp)
                {
                    if (nouv.prenomEmp == e.prenomEmp &&
                        nouv.nomEmp == e.nomEmp &&
                        nouv.courrielEmp == e.courrielEmp &&
                        nouv.noTelPrincipal == e.noTelPrincipal &&
                        nouv.adressePostale == e.adressePostale &&
                        nouv.dateEmbaucheEmp == e.dateEmbaucheEmp)
                        MessageBox.Show("L'employe existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Ce code d'employe est déjà utiliser", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            return true;
        }

        public bool verifAjout(Employe nouv)
        {
            lstEmploye.Clear();
            var lstBrut = rEmployeSQL.getEmploye();

            foreach (tblEmploye item in lstBrut)
            {
                lstEmploye.Add(new Employe(item));
            } 

            foreach (Employe e in lstEmploye)
            {
                if (nouv.idEmp == e.idEmp &&
                    nouv.prenomEmp == e.prenomEmp &&
                    nouv.nomEmp == e.nomEmp &&
                    nouv.courrielEmp == e.courrielEmp &&
                    nouv.noTelPrincipal == e.noTelPrincipal &&
                    nouv.adressePostale == e.adressePostale &&
                    nouv.dateEmbaucheEmp == e.dateEmbaucheEmp)
                        return true;
            }
            return false;
        }

        public List<string[]> charger()
        {
            var lstLigne = new List<string[]>();
            string[] ligne;

            if (etat == true)
            {
                lstEmploye.Clear();
                var lstBrut = rEmployeSQL.getEmploye();
                foreach (tblEmploye item in lstBrut)
                {
                    ligne = new string[] { item.IdEmp.ToString(), item.PrenomEmp.ToString(), item.NomEmp.ToString(), item.CourrielEmp.ToString(), item.NoTelPrincipal.ToString(), item.NoTelSecondaire.ToString(), item.AdressePostale.ToString(), item.DateEmbaucheEmp.ToShortDateString()/*, item.Statut.ToString(), item.CompetenceParticuliere.ToString(), item.CommentaireEmp.ToString() */};
                    lstLigne.Add(ligne);
                    lstEmploye.Add(new Employe(item));
                } 
            }
            else if(File.Exists(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt")))
            {           //      supposé être ... bin\debug\nouveau.txt
                string lineLu;
                string[] tmp = new string[] { "|" };
                List<string> lstBrut = new List<string>();
                lstEmployeNV.Clear();

                System.IO.StreamReader myFile = new System.IO.StreamReader(Path.Combine(Environment.CurrentDirectory, @"nouveau.txt"));/*CurrentDirectory*/
                while ((lineLu = myFile.ReadLine()) != null)
                {
                    lstBrut.Add(lineLu);
                }

                foreach (string item in lstBrut)
                {
                    ligne = item.Split(tmp, 8, StringSplitOptions.None);
                    ligne = new string[] { ligne[0].Trim(), ligne[1].Trim(), ligne[2].Trim(), ligne[3].Trim(), ligne[4].Trim(), ligne[5].Trim(), ligne[6].Trim(), ligne[7].Trim() };
                    lstLigne.Add(ligne);
                    lstEmployeNV.Add(ligne);
                }
                myFile.Close();
            }
            else
            {
                MessageBox.Show("Il n'y a aucun nouvel employe, Ressayer plus tard", "Aucun fichier trouver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lstLigne;
        }

        //          charge la liste de typeTest pour les employes
        public List<TypeTest> chargeTypeT()
        {
            var lstBrut = rTypeTestSQL.getTypeTest();
            
            foreach (tblTypeTest item in lstBrut)
            {
                lstTypeT.Add(new TypeTest(item));
            }

            return lstTypeT;
        }

        public List<Employe> recherche(string cle)
        {
            List<Employe> lstEm = new List<Employe>();

            foreach (var item in rEmployeSQL.rechercheEmploye(cle))
            {
                Employe em = new Employe(item.IdEmp, item.PrenomEmp, item.NomEmp, item.CourrielEmp, item.NoTelPrincipal, item.NoTelSecondaire, item.AdressePostale, item.DateEmbaucheEmp, item.CompetenceParticuliere, item.Statut, item.CommentaireEmp, item);
                lstEm.Add(em);
            }
            return lstEm;
        }

        public List<string[]> rechercheNew(string cle)
        {
            List<string[]> lstEm = new List<string[]>();

            foreach (string[] item in lstEmployeNV)
            {
                for (int i = 0; i < 8; i++)
			    {
			        if (item[i].Contains(cle))
                    {
                        lstEm.Add(item);
                        break;
                    } 
			    }
            }
            return lstEm;
        }

        public int RowsById(int _i, DataGridView _grid)
        {
            if (_i != 0)
            {
                foreach (DataGridViewRow item in _grid.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == _i)
                        return item.Index;
                }
            }
            return 0;
        }

        //      effacer une ligne dans le fichier text des nouveau employe, soit qu'il est ajouter ou retirer
        public void supprimerLigne(string path, string ligne)
        {
            // Path correspond au répertoire de ton fichier!
            string texte = null;
            string ligneActuelle = null;
            StreamReader sr = new StreamReader(path);
            // Ouverture du fichier
            while ((sr.Peek() != -1))
            {
                ligneActuelle = sr.ReadLine();
                if (!(ligneActuelle == ligne))
                {
                    texte = (texte + (ligneActuelle + "\r\n"));
                }
            }
            sr.Close();
            // Ré-écriture du fichier
            StreamWriter sr2 = new StreamWriter(path);
            sr2.Write(texte);
            sr2.Close();
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP10")
                    drLect = true;

                if (item.CodeDroit == "WP10")
                    drEcr = true;

                if (item.CodeDroit == "Admin")
                    return 4;
            }

            if (drLect == true && drEcr == true)
                return 3;
            else if (drLect == false && drEcr == true)
                return 2;
            else if (drLect == true && drEcr == false)
                return 1;

            return 0;
        }
    }
}