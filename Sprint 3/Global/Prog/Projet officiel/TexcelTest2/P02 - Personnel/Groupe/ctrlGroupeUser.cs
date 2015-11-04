using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public class ctrlGroupeUser : IControle
    {
        private List<GroupeUtil> listGroupeUser;
        private List<Droit> lstDroit;

        public ctrlGroupeUser()
        {
            listGroupeUser = new List<GroupeUtil>();
            lstDroit = new List<Droit>();
        }

        public List<GroupeUtil> lstGroupeUtil 
        {
            get { return listGroupeUser; }
            set { listGroupeUser = value; }
        }

        public void ajouter(object o)
        {
            if(rGroupeUtilSQL.ajouterGroupe((GroupeUtil)o) == true)
                MessageBox.Show("Le groupe a été créé", "Ajout réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("Le groupe n'a pas été créé", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void modifier(object o)
        {
            if (rGroupeUtilSQL.setGroup((GroupeUtil)o) == true)
                MessageBox.Show("L'enregistrement a été effectué", "Enregistrement réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("L'enregistrement n'a pas été effectué", "Enregistrement échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void supprimer(object o)
        {
            if (rGroupeUtilSQL.supprimeGroupe((GroupeUtil)o) == true)
                MessageBox.Show("Le groupe été supprimé", "Suppresion réussie", MessageBoxButtons.OK);
            else
                MessageBox.Show("Le groupe n'a pas été supprimer, il existe encore des lien avec des utilisateur ou des droits", "Suppresion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public bool verifier(object o, object n)
        {
            GroupeUtil ancien, nouv;
            nouv = (GroupeUtil)o;


            if (nouv.nomGroupe.Length == 0)
            {
                MessageBox.Show("Nom de groupe ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.nomGroupe.Length > 30)
            {
                MessageBox.Show("Le nom de groupe est trop long", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nouv.lstGroupeDroit.Count == 0)
            {
                MessageBox.Show("un groupe doit avoir au minimum un droit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var lstBrut = rGroupeUtilSQL.getGroupUtil();

            if (n != null)
            {
                ancien = (GroupeUtil)n;

                if (nouv.nomGroupe == ancien.nomGroupe)
                {
                    bool chkDr = true;
                    int i = 0;
                    if (nouv.lstGroupeDroit.Count == ancien.lstGroupeDroit.Count)
                    {
                        foreach (Droit item in nouv.lstGroupeDroit)
                        {
                            if (item.codeDroit == ancien.lstGroupeDroit[i].codeDroit &&
                                item.descDroit == ancien.lstGroupeDroit[i].descDroit)
                                i++;
                            else
                            {
                                chkDr = false;
                                break;
                            }
                        }
                    }
                    else
                        chkDr = false;

                    if (chkDr == true)
                    {
                        MessageBox.Show("Vous ne pouvez pas enregistrer sans avoir effectuer de changement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (ancien.idGroupe == 0)
                    {
                        MessageBox.Show("vous devez changer le nom de groupe avant d'enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    foreach (tblGroupe item in lstBrut)
                    {
                        if (nouv.nomGroupe == item.NomGroupe)
                        {
                            MessageBox.Show("Ce nom de groupe existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            else
            {
                foreach (tblGroupe item in lstBrut)
                {
                    if (nouv.nomGroupe == item.NomGroupe)
                    {
                        MessageBox.Show("Ce nom de groupe existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        public List<string[]> charger()
        {
            var lstbrut = rGroupeUtilSQL.getGroupUtil();
            List<string[]> lstLigne = new List<string[]>();
            string[] ligne;

            foreach (tblGroupe item in lstbrut)
            {
                ligne = new string[] { item.IdGroupe.ToString(), item.NomGroupe };
                lstLigne.Add(ligne);
                lstGroupeUtil.Add(new GroupeUtil(item));
            }

            return lstLigne;
        }

        public List<GroupeUtil> recherche(string cle)
        {
            List<GroupeUtil> lstGr = new List<GroupeUtil>();

            foreach (var item in rGroupeUtilSQL.rechercheGroup(cle))
            {
                GroupeUtil gu = new GroupeUtil(item);
                lstGr.Add(gu);
            }
            return lstGr;
        }

        public int RowsById(int _id, DataGridView _grid)
        {
            if (_id != 0)
            {
                foreach (DataGridViewRow item in _grid.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == _id)
                        return item.Index;
                }
            }
            return 0;
        }

        public void chargeDr(TreeView _tvFull, TreeView _tvGr, GroupeUtil _gr)
        {
            var lstBrut = rGroupeUtilSQL.getAllDroit();

            foreach (tblDroit item in lstBrut)
            {
                Droit tmp = new Droit(item);
                TreeNode nod = new TreeNode(tmp.descDroit);
                nod.Name = tmp.codeDroit;
                nod.Tag = tmp;
                _tvFull.Nodes.Add(nod);

                lstDroit.Add(tmp);
            }
            _tvFull.Tag = lstDroit;

            if (_gr != null)
            {
                foreach (Droit monDr in _gr.lstGroupeDroit)
                {
                    TreeNode nod = new TreeNode(monDr.descDroit);
                    nod.Name = monDr.codeDroit;
                    nod.Tag = monDr;
                    
                    _tvGr.Nodes.Add(nod);
                    _tvFull.Nodes.RemoveByKey(monDr.codeDroit);
                }
                _tvGr.Tag = _gr.lstGroupeDroit;
            }
        }
    }
}
