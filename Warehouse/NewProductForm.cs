using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.DAL.Services;

namespace Warehouse
{
    public partial class NewProductForm : Form
    {
        public event EventHandler ProductCreated;

        public NewProductForm()
        {
            InitializeComponent();
        }

        public void RefreshForm()
        {
            this.txtName.Text = string.Empty;
            this.txtCost.Text = string.Empty;
            this.txtWholesalePrice.Text = string.Empty;
            this.txtRetailPrice.Text = string.Empty;
            this.txtNotes.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var cost = int.Parse(this.txtCost.Text);
            var wholesalePrice = int.Parse(this.txtWholesalePrice.Text);
            var retailPrice = int.Parse(this.txtRetailPrice.Text);
            var notes = this.txtNotes.Text;
            using (WarehouseService service = new WarehouseService())
            {
                service.CreateProduct(name, cost, wholesalePrice, retailPrice, notes);
            }
            this.Close();
            ProductCreated.Invoke(this, EventArgs.Empty);
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
