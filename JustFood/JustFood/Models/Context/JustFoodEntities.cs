﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustFood.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JustFoodDBEntities : DbContext
    {
        public JustFoodDBEntities()
            : base("name=JustFoodDBEntities")
        {
            
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            throw new UnintentionalCodeFirstException();
        }


        public DbSet<CategoryWiseSold> CategoryWiseSolds { get; set; }


        public DbSet<AccountBalance> AccountBalances { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<DailyStock> DailyStocks { get; set; }
        public DbSet<DetailedSale> DetailedSales { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationSeen> NotificationSeens { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryIn> InventoryIns { get; set; }
        public DbSet<InventoryOut> InventoryOuts { get; set; }
        public DbSet<InventoryOutConfig> InventoryOutConfigs { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public DbSet<TimeZone> TimeZones { get; set; }

        public DbSet<Requisition> Requisitions { get; set; }
        public DbSet<SalaryPaid> SalaryPaids { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        public DbSet<ViewAccountBalance> ViewAccountBalances { get; set; }
        public DbSet<ViewSummaryAccountBalance> ViewSummaryAccountBalances { get; set; }
        public DbSet<ViewInventoryIn> ViewInventoryIns { get; set; }
        public DbSet<ViewInventoryInOutSummary> ViewInventoryInOutSummaries { get; set; }
        public DbSet<ViewInventoryOut> ViewInventoryOuts { get; set; }
        public DbSet<ViewInventorySalable> ViewInventorySalables { get; set; }
        public DbSet<ViewSummarySale> ViewSummarySales { get; set; }

        public DbSet<QuantityType> QuantityTypes { get; set; }


        public DbSet<Config> Configs { get; set; }

        public DbSet<QuantityConversation> QuantityConversations { get; set; }

    }
}
