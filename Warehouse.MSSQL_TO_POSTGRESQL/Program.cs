using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Warehouse.DAL;
using Warehouse.DAL.Common.Entities;
using Warehouse.DAL.Postgre;

namespace Warehouse.MSSQL_TO_POSTGRESQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //public virtual DbSet<Product> Products { get; set; }
            //public virtual DbSet<Input> Inputs { get; set; }
            //public virtual DbSet<Output> Outputs { get; set; }
            //public virtual DbSet<Sale> Sales { get; set; }
            //public virtual DbSet<Refund> Refunds { get; set; }
            //public virtual DbSet<Repayment> Repayments { get; set; }

           
            


            var mssqlContext = new WarehouseMsSqlContext();

            var products = mssqlContext.Products.AsNoTracking().ToList();
            var inputs = mssqlContext.Inputs.AsNoTracking().Include(x => x.Product).ToList();
            var outputs = mssqlContext.Outputs.AsNoTracking().Include(x => x.Product).ToList();
            var sales = mssqlContext.Sales.AsNoTracking().Include(x => x.Product).ToList();
            var refunds = mssqlContext.Refunds.AsNoTracking().Include(x => x.Product).ToList();
            var repayments = mssqlContext.Repayments.AsNoTracking().ToList();

            mssqlContext.Dispose();


            foreach(var x in inputs)
            {
                x.Product = products.FirstOrDefault(p => p.Id == x.Product.Id);
            }
            foreach (var x in outputs)
            {
                x.Product = products.FirstOrDefault(p => p.Id == x.Product.Id);
            }
            foreach (var x in sales)
            {
                x.Product = products.FirstOrDefault(p => p.Id == x.Product.Id);
            }
            foreach (var x in refunds)
            {
                x.Product = products.FirstOrDefault(p => p.Id == x.Product.Id);
            }


            var postgresqlContext = new WarehousePostgreContext();

            postgresqlContext.Products.AddRange(products);
            postgresqlContext.Inputs.AddRange(inputs);
            postgresqlContext.Outputs.AddRange(outputs);
            postgresqlContext.Sales.AddRange(sales);
            postgresqlContext.Refunds.AddRange(refunds);
            postgresqlContext.Repayments.AddRange(repayments);


            postgresqlContext.SaveChanges();

            //var inputs = mssqlContext.Inputs.AsNoTracking().Include(x => x.Product).ToList();
            //var newInputs = inputs.Select(x => new Input
            //{
            //    Id = x.Id,
            //    Notes = x.Notes,
            //    Product = postgresqlContext.Products.First(y => y.Id == x.Product.Id),
            //    Quantity = x.Quantity,
            //    TimeStamp = x.TimeStamp
            //});
            //postgresqlContext.Inputs.AddRange(newInputs);
            //postgresqlContext.SaveChanges();

            //var outputs = mssqlContext.Outputs.AsNoTracking().Include(x => x.Product).ToList();
            //postgresqlContext.Outputs.AddRange(outputs);
            ////postgresqlContext.SaveChanges();

            //var sales = mssqlContext.Sales.AsNoTracking().Include(x => x.Product).ToList();
            //postgresqlContext.Sales.AddRange(sales);
            ////postgresqlContext.SaveChanges();

            //var refunds = mssqlContext.Refunds.AsNoTracking().Include(x => x.Product).ToList();
            //postgresqlContext.Refunds.AddRange(refunds);
            ////postgresqlContext.SaveChanges();

            //var repayments = mssqlContext.Repayments.AsNoTracking().ToList();
            //postgresqlContext.Repayments.AddRange(repayments);
            //postgresqlContext.SaveChanges();
        }
    }
}
