using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.DAL.Entities
{
    public class Repayment
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public string ByWhom { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
