﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalCountdown.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Raquels_FinalEntities : DbContext
    {
        public Raquels_FinalEntities()
            : base("name=Raquels_FinalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Project_ID> Project_IDs { get; set; }
        public virtual DbSet<ScreenshotsOfProject> ScreenshotsOfProjects { get; set; }
    }
}
