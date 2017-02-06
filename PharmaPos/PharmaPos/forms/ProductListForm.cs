using System;
using System.Windows.Forms;
using PharmaPos.data;
using PharmaPos.dal.man;

namespace PharmaPos.forms
{
    public partial class ProductListForm : Form
    {
        Product _product = new Product();
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var f = new ProductUpdateForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            if (productBindingSource != null)
                f.Product = (Product) productBindingSource.Current;

            f.ShowDialog();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            supplierBindingSource.DataSource = SupplierManager.GetAll();
            categoryBindingSource.DataSource = CategoryManager.GetAll();
            unitBindingSource.DataSource = UnitManager.GetAll();
            drugTypeBindingSource.DataSource = DrugTypeManager.GetAll();
            packingBindingSource.DataSource = PackingManager.GetAll();

            productBindingSource.DataSource = ProductManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void productDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void toolStripButtonAddUpdateQnty_Click(object sender, EventArgs e)
        {
            if (_product == null) return;
            var f = new ProductQntyUpdateForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            if (productQuantityBindingSource != null)
                f.ProductQuantity = (ProductQuantity) productQuantityBindingSource.Current;
            f.Product = _product;
            f.ShowDialog();
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (productBindingSource == null) return;
            {
                _product = (Product) productBindingSource.Current;
                if (_product != null)
                {
                    LoadProductQuantityRecord();
                }
                else
                {
                    MessageBox.Show(@"Please select a product first.", @"Product information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void LoadProductQuantityRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            productQuantityBindingSource.DataSource = ProductQuantityManager.GetAll(_product.ProductId);
            Cursor.Current = Cursors.Default;
        }

        private void productQuantityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void DeleteProduct()
        {
            if (productBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (ProductManager.Delete(((Product)productBindingSource.Current).ProductId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    productBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    productDataGridView.Focus();
                }
            }
        }
    }
}
