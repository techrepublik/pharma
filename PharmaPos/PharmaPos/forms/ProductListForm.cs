using System;
using System.Windows.Forms;
using PharmaPos.data;
using PharmaPos.dal.man;

namespace PharmaPos.forms
{
    public partial class ProductListForm : Form
    {
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

            productBindingSource.DataSource = ProductManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void productDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
