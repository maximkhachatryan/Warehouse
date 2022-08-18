﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.DAL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int WholesalePrice { get; set; }
        public int RetailPrice { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}
