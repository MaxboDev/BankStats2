﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankStats
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankStatsDBEntities2 : DbContext
    {
        public BankStatsDBEntities2()
            : base("name=BankStatsDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<TransactionCategory> TransactionCategories { get; set; }
    }
}
