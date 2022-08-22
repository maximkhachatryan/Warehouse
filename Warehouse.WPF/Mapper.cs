using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Entities;
using Warehouse.WPF.Models;

namespace Warehouse.WPF
{
    static class Mapper
    {
        public static ProductModel ToUIModel(this Product product)
        {
            return new ProductModel
            {
                Code = product.Code,
                Id = product.Id,
                Name = product.Name,
                // Notes = product.Notes,
                Quantity = product.Quantity,
                Cost = product.Cost,
                RetailPrice = product.RetailPrice,
                WholesalePrice = product.WholesalePrice
            };
        }
    }
}
