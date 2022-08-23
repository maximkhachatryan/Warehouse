using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Warehouse.BLL.Exceptions;
using Warehouse.BLL.Services;
using Warehouse.EventArguments;
using Warehouse.ViewModels;

namespace Warehouse
{
    public partial class AllProductsControl : UserControl
    {
        public event EventHandler<ProductChosenEventArgs> ProductChosen;

        private List<ProductViewModel> _allProducts;
        private List<ProductViewModel> _searchResult;
        private readonly NewProductForm _newProductForm;
        private readonly EditProductForm _editProductForm;
        private readonly InputOutputForm _inputOutputProductForm;

        public AllProductsControl()
        {
            InitializeComponent();
            _newProductForm = new NewProductForm();
            _newProductForm.ProductCreated += _newProductForm_ProductCreated;
            _newProductForm.FormClosed += _newProductForm_FormClosed;
            _editProductForm = new EditProductForm();
            _editProductForm.ProductUpdated += _editProductForm_ProductUpdated;
            _inputOutputProductForm = new InputOutputForm();
            _inputOutputProductForm.OperationPerformed += _inputOutputProductForm_OperationPerformed;
        }

        public void Reload()
        {
            txtSearch.Text = string.Empty;
            using (var service = new WarehouseService())
            {
                _allProducts = service.GetAllProducts().Select(p => p.ToViewModel()).ToList();
                _searchResult = _allProducts;
                this.dgvAllProducts.DataSource = _searchResult;
                dgvAllProducts.Refresh();
            }
        }

        private void _inputOutputProductForm_OperationPerformed(object sender, EventArgs e)
        {
            Reload();
        }

        private void _editProductForm_ProductUpdated(object sender, EventArgs e)
        {
            Reload();
        }

        private void _newProductForm_ProductCreated(object sender, EventArgs e)
        {
            Reload();
        }        

        private void _newProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _newProductForm.RefreshForm();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            _newProductForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                Reload();
                return;
            }
            var searchText = txtSearch.Text.ToLower();
            _searchResult = _allProducts.Where(p => p.Name.ToLower().Contains(searchText)).ToList();
            dgvAllProducts.DataSource = _searchResult;
            dgvAllProducts.Update();
            dgvAllProducts.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows != null &&
                dgvAllProducts.SelectedRows.Count != 0 &&
                dgvAllProducts.SelectedRows[0] != null)
            {
                var product = (ProductViewModel)dgvAllProducts.SelectedRows[0].DataBoundItem;
                var caption = "Ջնջել";
                var text = $"Վստա՞հ եք որ ցանկանում եք ջնջել {product.Code}։{product.Name} ապրանքատեսակը։";
                var decision = MessageBox.Show(this, text, caption, MessageBoxButtons.YesNo);
                if (decision == DialogResult.Yes)
                {
                    try
                    {
                        using (var service = new WarehouseService())
                        {
                            service.RemoveProduct(product.Id);
                        }
                        Reload();
                    }
                    catch (UnableToRemoveProductException ex)
                    {
                        if (ex.Reason == UnableToRemoveProductException.ReasonType.NonZeroQuantity)
                        {
                            MessageBox.Show(text = "Տվյալ ապրանքը հնարավոր չէ ջնջել առկա քանակի պատճառով",
                                caption = "Ձախողում",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows != null &&
                dgvAllProducts.SelectedRows.Count != 0 &&
                dgvAllProducts.SelectedRows[0] != null)
            {
                var product = (ProductViewModel)dgvAllProducts.SelectedRows[0].DataBoundItem;
                _editProductForm.RefreshForm(product);
                _editProductForm.ShowDialog(this);
            }
        }

        private void dgvAllProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var chosenProduct = (ProductViewModel)dgvAllProducts.Rows[e.RowIndex].DataBoundItem;
            ProductChosen.Invoke(this, ProductChosenEventArgs.Build(chosenProduct));
        }

        private void btnInputOutput_Click(object sender, EventArgs e)
        {
            if (dgvAllProducts.SelectedRows != null &&
                dgvAllProducts.SelectedRows.Count != 0 &&
                dgvAllProducts.SelectedRows[0] != null)
            {
                var product = (ProductViewModel)dgvAllProducts.SelectedRows[0].DataBoundItem;
                _inputOutputProductForm.RefreshForm(product);
                _inputOutputProductForm.ShowDialog();
            }
        }
    }
}
