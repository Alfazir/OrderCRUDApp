using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrderCRUDApp.data.Entities
{
    public partial class EFContext : DbContext
    {
        public EFContext()
        { }
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public virtual DbSet<Order>? Orders { get; set; }
        public virtual DbSet<OrderItem>? OrderItems { get; set; }
        public virtual DbSet<Provider>? Providers { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;User ID=SA;Password=WIN-O8APH0MLJCO;Initial Catalog=OrderCRUDApp;Integrated Security=True;Trusted_Connection=false;MultipleActiveResultSets=true", b => b.MigrationsAssembly("OrderCRUDApp.data"));
            }
        }
      
    }
    

  /*  public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
    {
        public EFContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;User ID=SA;Password=WIN-O8APH0MLJCO;Initial Catalog=OrderCRUDApp;Integrated Security=True;Trusted_Connection=false;MultipleActiveResultSets=true", b => b.MigrationsAssembly("OrderCRUDApp.data"));
            return new EFContext(optionsBuilder.Options);

        }
    } */
}
