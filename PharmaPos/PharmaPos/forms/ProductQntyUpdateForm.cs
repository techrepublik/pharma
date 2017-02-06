using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class ProductQntyUpdateForm : Form
    {
        public Product Product { get; set; }
        public ProductQuantity ProductQuantity { get; set; }
        public ProductQntyUpdateForm()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productQuantityDateDateTimePicker.Focus();
        }

        private void productQuantityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (productQuantityBindingSource != null)
                productQuantityBindingNavigatorSaveItem.Enabled = true;
        }

        private void ProductQntyUpdateForm_Load(object sender, EventArgs e)
        {
            InitProduct();
            InitRecord();
            if (ProductQuantity != null)
            productQuantityBindingSource.DataSource = ProductQuantity;

        }

        private void InitProduct()
        {
            if (Product != null)
                labelProductName.Text = Product.ProductGenericName.ToUpper();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            packingBindingSource.DataSource = PackingManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void productQuantityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (productQuantityBindingSource == null) return;
            if (Product == null) return;
            Validate();
            ((ProductQuantity) productQuantityBindingSource.Current).ProductId = Product.ProductId;
            productQuantityBindingSource.EndEdit();
            var iResult = ProductQuantityManager.Save((ProductQuantity)productQuantityBindingSource.Current);
            if (iResult > 0)
            {
                MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                productQuantityDateDateTimePicker.Focus();
            }
            else
            {
                MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteProductQuantity();
        }

        private void DeleteProductQuantity()
        {
            if (productQuantityBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (ProductQuantityManager.Delete(((ProductQuantity) productQuantityBindingSource.Current).ProductQuantityId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    productQuantityBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    productQuantityDateDateTimePicker.Focus();
                }
            }
        }
    }
}
