﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBMvcCvEntities : DbContext
    {
        public DBMvcCvEntities()
            : base("name=DBMvcCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAbout> tblAbout { get; set; }
        public virtual DbSet<tblArticles> tblArticles { get; set; }
        public virtual DbSet<tblEducatıon> tblEducatıon { get; set; }
        public virtual DbSet<tblExperıence> tblExperıence { get; set; }
        public virtual DbSet<tblInterests> tblInterests { get; set; }
        public virtual DbSet<tblSkılls> tblSkılls { get; set; }
    }
}
