﻿using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class SupplierUpdateForm : Form
    {
        public Supplier Supplier { get; set; }
        public SupplierUpdateForm()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (CheckEmptyBoxes())
            {
                if (supplierBindingSource == null) return;
                Validate();
                supplierBindingSource.EndEdit();
                var iResult = SupplierManager.Save((Supplier) supplierBindingSource.Current);
                if (iResult > 0)
                {
                    MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    supplierCodeTextBox.Focus();
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

        private void supplierBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (supplierBindingSource != null)
                supplierBindingNavigatorSaveItem.Enabled = true;
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            if (Supplier !=null)
                supplierBindingSource.DataSource = Supplier;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            supplierCodeTextBox.Focus();
        }

        private bool CheckEmptyBoxes()
        {
            return (supplierCodeTextBox.Text.Length > 0) && (supplierNameTextBox.Text.Length > 0);
        }
    }
}
