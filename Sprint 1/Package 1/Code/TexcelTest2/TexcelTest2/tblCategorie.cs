//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TexcelTest2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCategorie
    {
        public tblCategorie()
        {
            this.tblPlateforme = new HashSet<tblPlateforme>();
        }
    
        public string CodeCategorie { get; set; }
        public string DescCategorie { get; set; }
        public string ComCategorie { get; set; }
    
        public virtual ICollection<tblPlateforme> tblPlateforme { get; set; }
    }
}
