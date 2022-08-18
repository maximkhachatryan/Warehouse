using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Warehouse.ViewModels
{
    public class ProductViewModel
    {
        [Browsable(false)]
        public Guid Id { get; set; }
        [DisplayName("Կոդ")]
        public int Code { get; set; }
        [DisplayName("Անվանում")]
        public string Name { get; set; }
        [DisplayName("Ունեցած քանակ")]
        public int Quantity { get; set; }
        [DisplayName("Գին 1")]
        public int WholesalePrice { get; set; }
        [DisplayName("Գին 2")]
        public int RetailPrice { get; set; }
        [DisplayName("Նշումներ")]
        public string Notes { get; set; }
    }
}
