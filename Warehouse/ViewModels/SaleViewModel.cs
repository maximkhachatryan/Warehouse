using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Warehouse.ViewModels
{
    public class SaleViewModel
    {
        [Browsable(false)]
        public Guid Id { get; set; }

        [Browsable(false)]
        public Guid ProductId { get; set; }

        [DisplayName("Կոդ")]
        [ReadOnly(true)]
        public int Code { get; set; }

        [DisplayName("Անվանում")]
        [ReadOnly(true)]
        public string Name { get; set; }

        [DisplayName("Քանակ")]
        public int Quantity { get; set; }

        [DisplayName("Գին")]
        public int Price { get; set; }

        [DisplayName("Պարտքով")]
        public bool ByLend { get; set; }

        [DisplayName("Շահույթ")]
        public int Profit { get; set; }

        [DisplayName("Նշումներ")]
        public string Notes { get; set; }
    }
}
