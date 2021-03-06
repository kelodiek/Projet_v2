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
    
    public partial class tblJeu
    {
        public tblJeu()
        {
            this.tblVersion = new HashSet<tblVersion>();
            this.tblJeu1 = new HashSet<tblJeu>();
            this.tblJeu2 = new HashSet<tblJeu>();
            this.tblPlateforme = new HashSet<tblPlateforme>();
            this.tblTheme = new HashSet<tblTheme>();
        }
    
        public int IdJeu { get; set; }
        public string NomJeu { get; set; }
        public string DescJeu { get; set; }
        public bool Actif { get; set; }
        public string InfoSupJeu { get; set; }
        public string Tag { get; set; }
        public string CoteESRB { get; set; }
        public Nullable<int> IdGenre { get; set; }
        public Nullable<int> IdMode { get; set; }
    
        public virtual tblClassification tblClassification { get; set; }
        public virtual tblGenre tblGenre { get; set; }
        public virtual tblMode tblMode { get; set; }
        public virtual ICollection<tblVersion> tblVersion { get; set; }
        public virtual ICollection<tblJeu> tblJeu1 { get; set; }
        public virtual ICollection<tblJeu> tblJeu2 { get; set; }
        public virtual ICollection<tblPlateforme> tblPlateforme { get; set; }
        public virtual ICollection<tblTheme> tblTheme { get; set; }
    }
}
