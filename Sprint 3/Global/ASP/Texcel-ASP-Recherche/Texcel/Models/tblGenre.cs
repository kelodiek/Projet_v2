//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Texcel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblGenre
    {
        public tblGenre()
        {
            this.tblJeu = new HashSet<tblJeu>();
        }
    
        public int IdGenre { get; set; }
        public string NomGenre { get; set; }
        public string ComGenre { get; set; }
    
        public virtual ICollection<tblJeu> tblJeu { get; set; }
    }
}
