using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SaleDbContext : DbContext
    {
        public SaleDbContext()
        {
        }
        public SaleDbContext(DbContextOptions<SaleDbContext> options) : base(options)
        {
        }
        public DbSet<MemberObject> MemberObjects => Set<MemberObject>();
        public DbSet<ProductObject> ProductObjects => Set<ProductObject>();
        public DbSet<OrderObject> OrderObjects => Set<OrderObject>();
        public DbSet<OrderDetailObject> OrderDetailObjects => Set<OrderDetailObject>();

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
            base.OnConfiguring(optionsBuilder);
        }

        public string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var str = config["ConnectionString:DefaultConnectionString"];
            return str;
        }
    }
}
