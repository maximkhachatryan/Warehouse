using Avalonia.Controls;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Avalonia.Models;

namespace Warehouse.Avalonia.ViewModels
{
    public class SaleViewModel
    {


        public List<SaleSearchProductModel> AllProducts { get; private set; }

        //AutoCompleteFilterPredicate<object>
        //public ReactiveCommand<Unit, Unit> SearchProductsCommand { get; private set; }

        public SaleViewModel()
        {

            Initialize();
        }

        private void Initialize()
        {
            AllProducts = new List<SaleSearchProductModel>
            {
                new SaleSearchProductModel {Id=1, Name = "prod1" },
                new SaleSearchProductModel {Id=1, Name = "prod2" },
                new SaleSearchProductModel {Id=1, Name = "prod3" },
                new SaleSearchProductModel {Id=1, Name = "prod4" },
                new SaleSearchProductModel {Id=1, Name = "prod5" },
                new SaleSearchProductModel {Id=1, Name = "prod6" },
                new SaleSearchProductModel {Id=1, Name = "prod7" },
                new SaleSearchProductModel {Id=1, Name = "prod8" },
                new SaleSearchProductModel {Id=1, Name = "prod9" },
                new SaleSearchProductModel {Id=1, Name = "prod10" },
                new SaleSearchProductModel {Id=1, Name = "prod11" },
                new SaleSearchProductModel {Id=1, Name = "prod12" }
            };
        }
    }
}
