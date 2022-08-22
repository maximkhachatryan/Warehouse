using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Services;
using Warehouse.WPF.Models;

namespace Warehouse.WPF.ViewModels
{
    public class ProductsViewModel
    {
        public List<ProductModel> Products { get; set; }

        public ProductsViewModel()
        {
            using (var service = new WarehouseService())
            {
                Products = service.GetAllProducts().Select(p => p.ToUIModel()).ToList();
            }

            //Products = new List<ProductModel>
            //{
            //   new ProductModel{
            //       Code = 1,
            //       Name = "Մայկա Miami կլոր վիզ",
            //       Cost = 2500,
            //       Quantity = 34,
            //       RetailPrice = 3000,
            //       WholesalePrice = 4000
            //   },
            //   new ProductModel{
            //       Code = 2,
            //       Name = "Սարոչկա Ossiva ե-թև",
            //       Cost = 3200,
            //       Quantity = 25,
            //       RetailPrice = 4000,
            //       WholesalePrice = 6000
            //   },
            //   new ProductModel{
            //       Code = 3,
            //       Name = "Սարոչկա R-Port ե-թև",
            //       Cost = 2900,
            //       Quantity = 124,
            //       RetailPrice = 3500,
            //       WholesalePrice = 5000
            //   }
            //};
        }
    }
}
