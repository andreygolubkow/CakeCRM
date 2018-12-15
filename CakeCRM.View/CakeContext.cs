using System;
using System.Collections.ObjectModel;
using CakeCRM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CakeCRM.View
{
    public class CakeContext : DbContext
    {
        public CakeContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Pack> Packs { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<SaleStatus> SaleStatuses { get; set; }

        public DbSet<SellVariant> SellVariants { get; set; }

        public DbSet<SellCountCollection> SellCountCollections { get; set; }

        public DbSet<SellCountPair> SellCountPairs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Cake.sqlite");
        }

        public void UndoChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

    }
}