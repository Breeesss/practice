﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab4_entity_framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdIlinEntities : DbContext
    {
        public bdIlinEntities()
            : base("name=bdIlinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Оценки> Оценки { get; set; }
        public virtual DbSet<Предметы> Предметы { get; set; }
        public virtual DbSet<Специальности> Специальности { get; set; }
        public virtual DbSet<Студенты> Студенты { get; set; }
    }
}
