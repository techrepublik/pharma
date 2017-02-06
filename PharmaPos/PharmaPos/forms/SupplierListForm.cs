using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var f = new SupplierUpdateForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            if (supplierBindingSource != null)
                f.Supplier = (Supplier)supplierBindingSource.Current;
            f.ShowDialog();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            supplierBindingSource.DataSource = SupplierManager.GetAll();
            Cursor.Current = Cursors.Default;
        }
    }
}
