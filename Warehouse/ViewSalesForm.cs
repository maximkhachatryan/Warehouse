using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.BLL.Services;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class ViewSalesForm : Form
    {
        private List<SaleViewModel> _sales;
        private List<RepaymentViewModel> _repayments;

        public ViewSalesForm()
        {
            InitializeComponent();
        }

        public void OpenSales(DateTime date)
        {
            this.lblDate.Text = date.ToString("dd/MM/yyyy");
            using (var service = new WarehouseService())
            {
                _sales = service.GetSales(date).Select(s => new SaleViewModel
                {
                    ByLend = s.ByLend,
                    Code = s.Product.Code,
                    Id = s.Id,
                    Name = s.Product.Name,
                    Notes = s.Notes,
                    Price = s.Price,
                    ProductId = s.Product.Id,
                    Quantity = s.Quantity,
                    Profit = s.Quantity * (s.Price - s.Product.Cost)
                }).ToList();
            }
            dgvSales.DataSource = _sales;
            dgvSales.Refresh();

            var salesSum = _sales.Where(s => s.ByLend == false).Select(s => s.Quantity * s.Price).Sum();
            var salesProfitSum = _sales.Where(s => s.ByLend == false).Select(s => s.Profit).Sum();
            lblSalesSum.Text = $"{salesSum.ToString()} ({salesProfitSum.ToString()})";

            using (var service = new WarehouseService())
            {
                _repayments = service.GetRepayments(date).Select(r => new RepaymentViewModel
                {
                    Id = r.Id,
                    Amount = r.Amount,
                    ByWhom = r.ByWhom
                }).ToList();
            }
            dgvRepayments.DataSource = _repayments;
            dgvRepayments.Refresh();

            var repaymentsSum = _repayments.Select(s => s.Amount).Sum();

            decimal revenueParcentOfUnpaidSales;
            using (var service = new WarehouseService())
            {
                revenueParcentOfUnpaidSales = service.GetRevenuePortionOfUnpaidSales(date);
            }
            var repaymentProfit = repaymentsSum * revenueParcentOfUnpaidSales;

            lblRepaymentSum.Text = $"{repaymentsSum.ToString()} ({repaymentProfit})";

            lblOverallSum.Text = $"Ընդհանուր ։ {salesSum + repaymentsSum} ({salesProfitSum + repaymentProfit})";

            this.ShowDialog();
        }

    }
}
