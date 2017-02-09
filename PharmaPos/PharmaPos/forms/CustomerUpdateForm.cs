using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class CustomerUpdateForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerUpdateForm()
        {
            InitializeComponent();
        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (customerBindingSource != null)
                customerBindingNavigatorSaveItem.Enabled = true;
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (CheckEmptyBoxes())
            {
                if (customerBindingSource == null) return;
                Validate();
                customerBindingSource.EndEdit();
                var iResult = CustomerManager.Save((Customer)customerBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    customerCodeTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Don't leave the Supplier Code and Supplier Name empty.", @"Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            customerCodeTextBox.Focus();
        }

        bool CheckEmptyBoxes()
        {
            return (customerCodeTextBox.Text.Length > 0) && (customerNameTextBox.Text.Length > 0);
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            if (Customer != null)
                customerBindingSource.DataSource = Customer;
        }
    }
}
