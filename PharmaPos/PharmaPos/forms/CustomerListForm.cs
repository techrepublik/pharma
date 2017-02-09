using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;


namespace PharmaPos.forms
{
    public partial class CustomerListForm : Form
    {

        private Customer _customer;
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = CustomerManager.GetAll();
            Cursor.Current = Cursors.Default;
        }
        void FindRecord()
        {
            if (toolStripTextBox1.Text.Length <= 0) return;
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = CustomerManager.GetAll(toolStripTextBox1.Text.ToUpper());
            Cursor.Current = Cursors.Default;
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void DeleteProduct()
        {
            if (customerBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (CustomerManager.Delete(((Customer)customerBindingSource.Current).CustomerId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    customerBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    customerDataGridView.Focus();
                }
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var f = new CustomerUpdateForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                Customer = _customer
            };
            f.ShowDialog();
        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (customerBindingSource != null)
                _customer = (Customer) customerBindingSource.Current;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            FindRecord();
        }
    }
}
