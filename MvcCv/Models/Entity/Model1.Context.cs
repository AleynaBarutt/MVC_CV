﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblDeneyimlerim> tblDeneyimlerim { get; set; }
        public virtual DbSet<tblEgitim> tblEgitim { get; set; }
        public virtual DbSet<tblHakkimda> tblHakkimda { get; set; }
        public virtual DbSet<tblHobilerim> tblHobilerim { get; set; }
        public virtual DbSet<tblİletisim> tblİletisim { get; set; }
        public virtual DbSet<tblSertifikalarim> tblSertifikalarim { get; set; }
        public virtual DbSet<tblYeteneklerim> tblYeteneklerim { get; set; }
        public virtual DbSet<tblSosyalMedya> tblSosyalMedya { get; set; }
    }
}
