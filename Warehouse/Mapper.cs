using System;
using System.Collections.Generic;
using System.Text;
using Warehouse.DAL.Entities;
using Warehouse.ViewModels;

namespace Warehouse
{
    static class Mapper
    {
        public static ProductViewModel ToViewModel(this Product product)
        {
            return new ProductViewModel
            {
                Code = product.Code,
                Id = product.Id,
                Name = product.Name,
                Notes = product.Notes,
                Quantity = product.Quantity,
                Cost = product.Cost,
                RetailPrice = product.RetailPrice,
                WholesalePrice = product.WholesalePrice
            };
        }
    }
}
