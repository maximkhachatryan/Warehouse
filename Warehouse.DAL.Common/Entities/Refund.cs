using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.DAL.Common.Entities
{
    public class Refund
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Notes { get; set; }
        public virtual Product Product { get; set; }
    }
}
