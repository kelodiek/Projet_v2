//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmploye
    {
        public tblEmploye()
        {
            this.tblUtilisateur = new HashSet<tblUtilisateur>();
            this.tblEquipe = new HashSet<tblEquipe>();
            this.tblTypeTest = new HashSet<tblTypeTest>();
            this.tblEquipe1 = new HashSet<tblEquipe>();
            this.tblProjet = new HashSet<tblProjet>();
        }
    
        public int IdEmp { get; set; }
        public string PrenomEmp { get; set; }
        public string NomEmp { get; set; }
        public string CourrielEmp { get; set; }
        public string NoTelPrincipal { get; set; }
        public string NoTelSecondaire { get; set; }
        public string AdressePostale { get; set; }
        public System.DateTime DateEmbaucheEmp { get; set; }
        public string CompetenceParticuliere { get; set; }
        public string Statut { get; set; }
        public string CommentaireEmp { get; set; }
    
        public virtual ICollection<tblUtilisateur> tblUtilisateur { get; set; }
        public virtual ICollection<tblEquipe> tblEquipe { get; set; }
        public virtual ICollection<tblTypeTest> tblTypeTest { get; set; }
        public virtual ICollection<tblEquipe> tblEquipe1 { get; set; }
        public virtual ICollection<tblProjet> tblProjet { get; set; }
    }
}
