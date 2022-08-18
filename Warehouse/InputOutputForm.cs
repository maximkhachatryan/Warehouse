using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Warehouse.DAL.Services;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class InputOutputForm : Form
    {
        private ProductViewModel _product;

        public event EventHandler OperationPerformed;

        public InputOutputForm()
        {
            InitializeComponent();
        }

        public void RefreshForm(ProductViewModel product)
        {
            this._product = product;
            this.lblProductName.Text = product.Name;
            this.txtQuantity.Text = "";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                var notes = txtNotes.Text;
                using (var service = new WarehouseService())
                {
                    service.InputProduct(_product.Id, quantity, notes);
                }
                this.Close();
                this.OperationPerformed.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                var notes = txtNotes.Text;
                using (var service = new WarehouseService())
                {
                    service.OutputProduct(_product.Id, quantity, notes);
                }
                this.Close();
                this.OperationPerformed.Invoke(this, EventArgs.Empty);
            }
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
