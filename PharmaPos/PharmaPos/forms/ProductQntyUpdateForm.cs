using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPos.forms
{
    public partial class ProductQntyUpdateForm : Form
    {
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
    }
}
