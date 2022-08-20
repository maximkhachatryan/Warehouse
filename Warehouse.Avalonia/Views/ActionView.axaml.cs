using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Warehouse.Avalonia.ViewModels;

namespace Warehouse.Avalonia.Views
{
    public partial class ActionView : UserControl
    {
        public ActionView()
        {
            this.DataContext = new ActionViewModel();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
