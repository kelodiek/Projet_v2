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
    
    public partial class tblCasTest
    {
        public string CodeCas { get; set; }
        public string TitreCas { get; set; }
        public string ObjectifCas { get; set; }
        public Nullable<System.DateTime> DateCreation { get; set; }
        public Nullable<System.DateTime> DateEcheance { get; set; }
        public string DescCas { get; set; }
        public string StatutCas { get; set; }
        public string CodeProjet { get; set; }
        public string CodeTypeTest { get; set; }
    
        public virtual tblProjet tblProjet { get; set; }
        public virtual tblTypeTest tblTypeTest { get; set; }
    }
}
