using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class ProductUpdateForm : Form
    {
        public Product Product { get; set; }
        public ProductUpdateForm()
        {
            InitializeComponent();
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            InitRecord();
            if (Product != null)
                productBindingSource.DataSource = Product;
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            supplierBindingSource.DataSource = SupplierManager.GetAll();
            categoryBindingSource.DataSource = CategoryManager.GetAll();
            drugTypeBindingSource.DataSource = DrugTypeManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (productBindingSource != null)
                productBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            supplierIdComboBox.SelectedIndex = 0;
            categoryIdComboBox.SelectedItem = 0;
            drugTypeIdComboBox.SelectedIndex = 0;

            productCodeTextBox.Focus();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (productBindingSource == null) return;
            Validate();
            productBindingSource.EndEdit();
            var iResult = ProductManager.Save((Product)productBindingSource.Current);
            if (iResult > 0)
            {
                MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                productCodeTextBox.Focus();
            }
            else
            {
                MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
