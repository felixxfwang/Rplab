﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPLab
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class rpldbEntities : DbContext
    {
        public rpldbEntities()
            : base("name=rpldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Article> Articles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
    }
}