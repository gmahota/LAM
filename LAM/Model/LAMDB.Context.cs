﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAM.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LAMEntities : DbContext
    {
        public LAMEntities()
            : base("name=LAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chegada> Chegada { get; set; }
        public virtual DbSet<Companhia> Companhia { get; set; }
        public virtual DbSet<Balcao> Balcaos { get; set; }
        public virtual DbSet<Partida> Partidas { get; set; }
    }
}
