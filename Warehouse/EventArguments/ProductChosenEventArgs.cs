using System;
using System.Collections.Generic;
using System.Text;
using Warehouse.ViewModels;

namespace Warehouse.EventArguments
{
    public class ProductChosenEventArgs : EventArgs
    {
        private ProductChosenEventArgs(ProductViewModel chosenProduct)
        {
            ChosenProduct = chosenProduct;
        }

        public static ProductChosenEventArgs Build(ProductViewModel product)
        {
            return new ProductChosenEventArgs(product);
        }

        public ProductViewModel ChosenProduct { get; private set; }
    }
}
