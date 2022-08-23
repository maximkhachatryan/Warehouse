using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.BLL.Models
{
    public class SellInput
    {
        public string Notes { get; set; }
        public int Price { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
