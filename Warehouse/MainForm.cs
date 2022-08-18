using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.EventArguments;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctrlAllProducts.Reload();
        }

        private void ctrlAllProducts_ProductChosen(object sender, ProductChosenEventArgs e)
        {
            ctrlTrade.AddToList(new TradeItemViewModel
            {
                Code = e.ChosenProduct.Code,
                ProductId = e.ChosenProduct.Id,
                Name = e.ChosenProduct.Name,
                Notes = string.Empty,
                Price = ctrlTrade.IsWholesale ? e.ChosenProduct.WholesalePrice : e.ChosenProduct.RetailPrice,
                Quantity = 1
            });
        }

        private void ctrlTrade_QuantitiesChanged(object sender, EventArgs e)
        {
            ctrlAllProducts.Reload();
        }

        private void ctrlTrade_Load(object sender, EventArgs e)
        {

        }
    }
}
