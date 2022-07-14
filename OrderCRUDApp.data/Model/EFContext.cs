using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderCRUD.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrderCRUD.DAL.EF
{
    public class EFContext : DbContext
    {
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Provider>? Providers { get; set; }

      public EFContext(DbContextOptions<EFContext> options) : base(options) { }

      
    }
    

    public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
    {
        public EFContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;User ID=SA;Password=WIN-O8APH0MLJCO;Initial Catalog=OrderCRUD;Integrated Security=True;Trusted_Connection=false;MultipleActiveResultSets=true", b => b.MigrationsAssembly("OrderCRUD.DAL"));
            return new EFContext(optionsBuilder.Options);

        }
    }
}
