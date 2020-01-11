using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationShip3
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.Supplier> Suppliers { get; set; }
        public DbSet<Models.OrderDetail> OrderDetails { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
    }
}
