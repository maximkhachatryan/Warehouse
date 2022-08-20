using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Avalonia.ViewModels
{
    public class ActionViewModel : ViewModelBase
    {
        

        public List<SaleItem> SaleItems => new()
        {
            new SaleItem { Code = 1, Name = "A1" },
            new SaleItem { Code = 2, Name = "A2" }
        };
    }

    public class SaleItem
    {
        public int Code { get; set; }
        public string? Name { get; set; }
    }
}
