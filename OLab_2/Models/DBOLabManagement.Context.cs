﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLab_2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBOLabManagementEntities : DbContext
    {
        public DBOLabManagementEntities()
            : base("name=DBOLabManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<SalaryLevel> SalaryLevels { get; set; }
        public virtual DbSet<SalaryPosition> SalaryPositions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}