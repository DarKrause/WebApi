﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiMachine.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MachineDrinksEntities : DbContext
    {
        public MachineDrinksEntities()
            : base("name=MachineDrinksEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Монета> Монета { get; set; }
        public virtual DbSet<Монета_в_торговом_автомате> Монета_в_торговом_автомате { get; set; }
        public virtual DbSet<Напиток> Напиток { get; set; }
        public virtual DbSet<Напиток_из_торгового_автомата> Напиток_из_торгового_автомата { get; set; }
        public virtual DbSet<Торговый_автомат> Торговый_автомат { get; set; }
    }
}
