﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.DAL.Services;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class EditProductForm : Form
    {
        private ProductViewModel _product;

        public event EventHandler ProductUpdated;

        public EditProductForm()
        {
            InitializeComponent();
        }

        public void RefreshForm(ProductViewModel product)
        {
            this._product = product;
            this.txtName.Text = product.Name;
            this.txtWholesalePrice.Text = product.WholesalePrice.ToString();
            this.txtRetailPrice.Text = product.RetailPrice.ToString();
            this.txtNotes.Text = product.Notes;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var wholesalePrice = int.Parse(this.txtWholesalePrice.Text);
            var retailPrice = int.Parse(this.txtRetailPrice.Text);
            var notes = this.txtNotes.Text;
            using (WarehouseService service = new WarehouseService())
            {
                service.EditProduct(_product.Id, name, wholesalePrice, retailPrice, notes);
            }
            this.Close();
            ProductUpdated.Invoke(this, EventArgs.Empty);
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
