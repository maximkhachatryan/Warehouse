using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.DAL.Entities
{
    public class Input
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Notes { get; set; }
    }
}
