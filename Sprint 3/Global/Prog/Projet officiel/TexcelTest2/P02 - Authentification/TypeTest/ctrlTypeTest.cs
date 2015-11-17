using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public class ctrlTypeTest : IControle
    {
        private List<TypeTest> listTypeTest;

        public ctrlTypeTest()
        {
            listTypeTest = new List<TypeTest>();
        }

        public List<TypeTest> lstTypeTest
        {
            get { return listTypeTest; }
            set { listTypeTest = value; }
        }

        public void ajouter(object o)
        {
            if(rTypeTestSQL.AjouterTypeTest((TypeTest)o) == true)
                MessageBox.Show("Le type de test a été créé", "Ajout réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("Le type de test n'a pas été créé", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void modifier(object o)
        {
            if(rTypeTestSQL.setTypeTest((TypeTest)o) == true)
                MessageBox.Show("L'enregistrement a été effectué", "Enregistrement réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("L'enregistrement n'a pas été effectué", "Enregistrement échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void supprimer(object o)
        {
            if(rTypeTestSQL.SupprimerTypeTest((TypeTest)o) == true)
                MessageBox.Show("Le Type de test été supprimé", "Suppresion réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("Le Type de test n'a pas été supprimer, il existe encore utiliser ailleur.", "Suppresion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool verifier(object o, object n) // verifie les modif
        {
            TypeTest ancien, nouv;
            nouv = (TypeTest)o;
            ancien = (TypeTest)n;
            var lstBrut = rTypeTestSQL.getTypeTest();
            
            if (nouv.codeTypeTest == ancien.codeTypeTest &&
                nouv.nomTypeTest == ancien.nomTypeTest &&
                nouv.objectifTypeTest == ancien.objectifTypeTest &&
                nouv.descTypeTest == ancien.descTypeTest &&
                nouv.commentaireTypeTest == ancien.commentaireTypeTest)
            {
                MessageBox.Show("Vous ne pouvez pas enregistrer sans avoir effectuer de changement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool verifAjout(TypeTest nouv) // verifie ajout
        {
            var lstBrut = rTypeTestSQL.getTypeTest();

            foreach (tblTypeTest item in lstBrut)
            {
                if (nouv.codeTypeTest == item.CodeTypeTest)
                {
                    if (nouv.nomTypeTest == item.NomTypeTest &&
                        nouv.objectifTypeTest == item.ObjectifTypeTest &&
                        nouv.descTypeTest == item.DescTypeTest &&
                        nouv.commentaireTypeTest == item.CommentaireTest)
                    {
                        MessageBox.Show("Vous ne pouvez pas enregistrer sans avoir effectuer de changement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Vous devez changer le code de type de test pour enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public bool veriflongueur(object o)
        {
            TypeTest nouv;
            nouv = (TypeTest)o;

            if (nouv.codeTypeTest.Length == 0)
            {
                MessageBox.Show("Le champs Code de type test ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nouv.codeTypeTest.Length > 5)
            {
                MessageBox.Show("Le champs Code de type test ne doit pas dépasser 5 caractère", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.nomTypeTest.Length == 0)
            {
                MessageBox.Show("Le champs Nom de type test ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (nouv.nomTypeTest.Length > 50)
            {
                MessageBox.Show("Le champs Nom de type test ne doit pas dépasser 50 caractère", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.objectifTypeTest.Length > 150)
            {
                MessageBox.Show("Le champs Objectif de type test ne doit pas dépasser 150 caractère", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.descTypeTest.Length > 250)
            {
                MessageBox.Show("Le champs Description de type test ne doit pas dépasser 250 caractère", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.commentaireTypeTest.Length > 250)
            {
                MessageBox.Show("Le champs Commentaire de type test ne doit pas dépasser 250 caractère", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public List<string[]> charger()
        {
            var lstbrut = rTypeTestSQL.getTypeTest();
            List<string[]> lstLigne = new List<string[]>();
            string[] ligne;

            foreach (tblTypeTest item in lstbrut)
            {
                ligne = new string[] { item.CodeTypeTest, item.NomTypeTest, item.ObjectifTypeTest, item.DescTypeTest, item.CommentaireTest };
                lstLigne.Add(ligne);
                lstTypeTest.Add(new TypeTest(item));
            }

            return lstLigne;
        }

        public List<TypeTest> recherche(string cle)
        {
            List<TypeTest> lstTT = new List<TypeTest>();

            foreach (var item in rTypeTestSQL.rechercheTypeTest(cle))
            {
                TypeTest tpt = new TypeTest(item);
                lstTT.Add(tpt);
            }
            return lstTT;
        }

        public int RowByCode(string _c, DataGridView data)
        {
            if (_c != "")
            {
                foreach (DataGridViewRow item in data.Rows)
                {
                    if (item.Cells[0].Value.ToString() == _c)
                        return item.Index;
                }
            }
            return 0;
        }

        public int DroitAcces(string user)
        {
            List<tblDroit> lstDrBrut = rGroupeUtilSQL.getDrByGroupUser(user);
            bool drLect = false;
            bool drEcr = false;
            foreach (tblDroit item in lstDrBrut)
            {
                if (item.CodeDroit == "RP13")
                    drLect = true;

                if (item.CodeDroit == "WP13")
                    drEcr = true;

                if (item.CodeDroit == "Admin")
                    return 3;
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
