﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbProjetE2ProdEntities : DbContext
    {
        public dbProjetE2ProdEntities()
            : base("name=dbProjetE2ProdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCategorie> tblCategorie { get; set; }
        public virtual DbSet<tblClassification> tblClassification { get; set; }
        public virtual DbSet<tblGenre> tblGenre { get; set; }
        public virtual DbSet<tblJeu> tblJeu { get; set; }
        public virtual DbSet<tblMode> tblMode { get; set; }
        public virtual DbSet<tblPlateforme> tblPlateforme { get; set; }
        public virtual DbSet<tblSysExp> tblSysExp { get; set; }
        public virtual DbSet<tblTheme> tblTheme { get; set; }
        public virtual DbSet<tblVersion> tblVersion { get; set; }
    }
}
