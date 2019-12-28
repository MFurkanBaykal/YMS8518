using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi3
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }
        public DbSet<Model.Pet>Pets { get; set; }
    }
}
