﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polizas.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class polizasEntities : DbContext
    {
        public polizasEntities()
            : base("name=polizasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Automotor> Automotor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CoberturaPoliza> CoberturaPoliza { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
    }
}
