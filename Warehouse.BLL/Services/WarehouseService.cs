using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.BLL.Exceptions;
using Warehouse.BLL.Models;
using Warehouse.DAL;
using Warehouse.DAL.Common.Entities;

namespace Warehouse.BLL.Services
{
    public class WarehouseService : IDisposable
    {
        readonly WarehouseContext _context;

        public WarehouseService()
        {
            _context = new WarehouseContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.AsNoTracking()
                .Where(p => !p.IsRemoved)
                .OrderBy(p => p.Code).ToList();
        }

        public List<Sale> GetSales(DateTime date)
        {
            return _context.Sales.AsNoTracking()
                .Include(x=>x.Product)
                .Where(s => s.TimeStamp.Date == date)
                .OrderByDescending(o=>o.TimeStamp)
                .ToList();
        }

        public decimal GetRevenuePortionOfUnpaidSales(DateTime date)
        {
            var unpaidSales = _context.Sales.AsNoTracking()
                .Where(s => s.TimeStamp.Date <= date && s.ByLend == true);
            var revenue = unpaidSales.Select(s => s.Quantity * (s.Price - s.CurrentCost)).Sum();
            var unpaidAmount = unpaidSales.Select(s => s.Quantity * s.Price).Sum();
            return revenue / unpaidAmount;
        }

        public void CreateProduct(string name, int cost, int wholesalePrice, int retailPrice, string notes)
        {
            _context.Products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = GenerateProductCode(),
                Cost = cost,
                CreateDate = DateTime.Now,
                IsRemoved = false,
                Name = name,
                Notes = notes,
                Quantity = 0,
                RetailPrice = retailPrice,
                WholesalePrice = wholesalePrice
            });
            _context.SaveChanges();
        }

        public List<Repayment> GetRepayments(DateTime date)
        {
            return _context.Repayments.AsNoTracking()
                .Where(s => s.Timestamp.Date == date)
                .OrderByDescending(o => o.Timestamp)
                .ToList();
        }

        public void InputProduct(Guid id, int quantity, string notes)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Inputs.Add(new Input
                {
                    Id = Guid.NewGuid(),
                    Notes = notes,
                    Product = product,
                    Quantity = quantity,
                    TimeStamp = DateTime.Now
                });
                product.Quantity += quantity;
                _context.SaveChanges();
            }
        }

        public void OutputProduct(Guid id, int quantity, string notes)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Outputs.Add(new Output
                {
                    Id = Guid.NewGuid(),
                    Notes = notes,
                    Product = product,
                    Quantity = quantity,
                    TimeStamp = DateTime.Now
                });
                product.Quantity -= quantity;
                _context.SaveChanges();
            }
        }

        public void EditProduct(Guid id, string name, int cost, int wholesalePrice, int retailPrice, string notes)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Name = name;
                product.Cost = cost;
                product.WholesalePrice = wholesalePrice;
                product.RetailPrice = retailPrice;
                product.Notes = notes;

                _context.SaveChanges();
            }
        }


        private int GenerateProductCode()
        {
            var existingCodes = _context.Products.AsNoTracking()
                .Select(p => p.Code)
                .OrderBy(x => x).ToList();
            var candidateId = 1;
            foreach (var id in existingCodes)
            {
                if (id != candidateId)
                    return candidateId;
                candidateId++;
            }
            return candidateId;
        }

        public void StoreSales(List<SellInput> sellInputs, bool byLend)
        {
            var products = _context.Products.ToList();
            var sales = sellInputs.Select(s =>
            {
                var product = products.FirstOrDefault(p => p.Id == s.ProductId);
                return new Sale
                {
                    Id = Guid.NewGuid(),
                    Notes = s.Notes,
                    Price = s.Price,
                    CurrentCost = product.Cost,
                    Product = product,
                    Quantity = s.Quantity,
                    ByLend = byLend,
                    TimeStamp = DateTime.Now
                };
            });

            foreach (var sale in sales)
            {
                sale.Product.Quantity -= sale.Quantity;
            }
            _context.Sales.AddRange(sales);
            _context.SaveChanges();
        }

        public void RemoveProduct(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id && p.IsRemoved != true);

            if (product == null)
                throw new UnableToRemoveProductException(UnableToRemoveProductException.ReasonType.ProductDoesntExist);
            if (product.Quantity > 0)
                throw new UnableToRemoveProductException(UnableToRemoveProductException.ReasonType.NonZeroQuantity);

            product.IsRemoved = true;
            _context.SaveChanges();
        }

        public void AddRepayment(int amount, string byWhom)
        {
            var rep = new Repayment
            {
                Id = Guid.NewGuid(),
                Amount = amount,
                ByWhom = byWhom,
                Timestamp = DateTime.Now
            };

            _context.Repayments.Add(rep);

            _context.SaveChanges();
        }
    }
}
