﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.WPF.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int WholesalePrice { get; set; }
        public int RetailPrice { get; set; }
        public int Quantity { get; set; }
    }
}
