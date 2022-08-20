using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Warehouse.Avalonia.Models;
using Warehouse.Avalonia.ViewModels;

namespace Warehouse.Avalonia.Views
{
    public partial class SaleView : UserControl
    {
        public SaleView()
        {
            this.DataContext = new SaleViewModel();            
            InitializeComponent();

            this.Get<AutoCompleteBox>("searchbox").ItemFilter = Filter;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private bool Filter(string search, object item)
        {
            var product = (SaleSearchProductModel)item;
            if (product != null &&
                (product.Id.ToString() == search || product.Name.ToLower().Contains(search.ToLower())))
                return true;
            return false;
        }
    }
}
