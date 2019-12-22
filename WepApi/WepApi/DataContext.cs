using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
                for (int i = 1; i <= 1000; i++)
                {
                modelBuilder.Entity<Model.Book>().HasData(new Model.Book()
                {
                    Id = i,
                Name = "Kitap Adı-" + i,
                Desription = "Kitap Açıklaması..." + i,
                PageCount = 300 + i
                });
                }
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Model.Book> Books { get; set; }
    }
}
