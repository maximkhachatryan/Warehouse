using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Warehouse.DAL.Common.Entities;

namespace Warehouse.DAL
{
    public class WarehouseMsSqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Warehouse; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<Repayment> Repayments { get; set; }
    }
}
