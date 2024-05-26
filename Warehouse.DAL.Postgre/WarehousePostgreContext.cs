using Microsoft.EntityFrameworkCore;
using Warehouse.DAL.Common.Entities;

namespace Warehouse.DAL.Postgre
{
    public class WarehousePostgreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost; Database=Warehouse; Username=postgres; Password=...");
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<Repayment> Repayments { get; set; }
    }
}
