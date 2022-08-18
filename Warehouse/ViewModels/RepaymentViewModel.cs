using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Warehouse.ViewModels
{
    public class RepaymentViewModel
    {
        [Browsable(false)]
        public Guid Id { get; set; }

        [DisplayName("Վճարող")]
        public string ByWhom { get; set; }

        [DisplayName("Գումար")]
        public int Amount { get; set; }

    }
}
