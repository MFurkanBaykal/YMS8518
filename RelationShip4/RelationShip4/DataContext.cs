using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip4
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.CustomerCustomerDemo>().HasKey(l => new { l.CustomerId, l.CustomerTypeId });
        }

        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public DbSet<Models.CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.OrderDetail> OrderDetails { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Region> Regions { get; set; }
        public DbSet<Models.Shipper> Shippers { get; set; }
        public DbSet<Models.Supplier> Suppliers { get; set; }
        public DbSet<Models.Territory> Territories { get; set; }
    }
}
