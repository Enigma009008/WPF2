﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF2.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookdbEntities : DbContext
    {
        public BookdbEntities()
            : base("name=BookdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
    }
}
