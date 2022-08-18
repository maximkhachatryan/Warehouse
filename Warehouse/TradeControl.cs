using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.DAL.Entities;
using Warehouse.DAL.Models;
using Warehouse.DAL.Services;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class TradeControl : UserControl
    {
        public event EventHandler QuantitiesChanged;

        private List<TradeItemViewModel> _tradeItems = new List<TradeItemViewModel>();

        private readonly ViewSalesForm _viewSalesForm;

        public TradeControl()
        {
            InitializeComponent();
            _viewSalesForm = new ViewSalesForm();
        }

        public bool IsWholesale => radWholesale.Checked;

        public void AddToList(TradeItemViewModel tradeItem)
        {
            var tradeItemFound = _tradeItems.FirstOrDefault(t => t.ProductId == tradeItem.ProductId);
            if (tradeItemFound != null)
            {
                tradeItemFound.Quantity += tradeItem.Quantity;
            }
            else
            {
                var newTradeItem = new TradeItemViewModel
                {
                    Code = tradeItem.Code,
                    ProductId = tradeItem.ProductId,
                    Name = tradeItem.Name,
                    Notes = tradeItem.Notes,
                    Price = tradeItem.Price,
                    Quantity = tradeItem.Quantity
                };
                _tradeItems.Add(newTradeItem);
            }
            Reload();
        }

        private void Reload()
        {
            _tradeItems = _tradeItems.Where(t => true).ToList();
            this.dgvTrade.DataSource = _tradeItems;
            this.dgvTrade.Refresh();
            this.lblPrice.Text = _tradeItems.Select(t => t.Quantity * t.Price).Sum().ToString();
        }

        private void dgvTrade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var chosenProduct = (TradeItemViewModel)dgvTrade.Rows[e.RowIndex].DataBoundItem;
            //var prop_name = dgvTrade.Columns[e.ColumnIndex].DataPropertyName;
            ////var propertyInfo = chosenProduct.GetType().GetProperty(prop_name);
            //if (prop_name == nameof(TradeItemViewModel.Quantity))
            //    if (chosenProduct.Quantity <= 0)
            //        _tradeItems.Remove(chosenProduct);
            Reload();
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dgvTrade.SelectedRows != null &&
                dgvTrade.SelectedRows.Count != 0 &&
                dgvTrade.SelectedRows[0] != null)
            {
                var chosenTradeItem = (TradeItemViewModel)dgvTrade.SelectedRows[0].DataBoundItem;
                _tradeItems.Remove(chosenTradeItem);
                Reload();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            var sales = _tradeItems.Select(t => new SellInput
            {
                Notes = t.Notes,
                Price = t.Price,
                ProductId = t.ProductId,
                Quantity = t.Quantity
            });
            using (var service = new WarehouseService())
            {
                service.StoreSales(sales.ToList(), chkLend.Checked);
            }
            _tradeItems.Clear();
            Reload();
            this.QuantitiesChanged.Invoke(this, EventArgs.Empty);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value.Date;
            _viewSalesForm.OpenSales(date);
        }

        private void btnRepay_Click(object sender, EventArgs e)
        {
            var amount = int.Parse(txtAmount.Text);
            var byWhom = txtByWhom.Text;
            if (amount == 0)
                return;
            if (string.IsNullOrEmpty(byWhom))
                return;
            using (var service = new WarehouseService())
            {
                service.AddRepayment(amount, byWhom);
            }
            txtAmount.Clear();
            txtByWhom.Clear();
        }


        private void numberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
