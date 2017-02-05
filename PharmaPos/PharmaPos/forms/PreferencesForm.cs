using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class PreferencesForm : Form
    {

        enum Tabs
        {
            category,
            unit,
            drugType,
            packing,
            voidReason
        }

        Tabs _tabChoice;
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            InitRecords();
        }

        private void InitRecords()
        {
            Cursor.Current = Cursors.WaitCursor;
            categoryBindingSource.DataSource = CategoryManager.GetAll();
            unitBindingSource.DataSource = UnitManager.GetAll();
            drugTypeBindingSource.DataSource = DrugTypeManager.GetAll();
            packingBindingSource.DataSource = PackingManager.GetAll();
            voidReasonBindingSource.DataSource = VoidReasonManager.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    _tabChoice = Tabs.category;
                    toolStripStatusLabel1.Text = @"Category Tab";
                    categoryBindingNavigator.BindingSource = categoryBindingSource;
                    break;
                case 1:
                    _tabChoice = Tabs.unit;
                    toolStripStatusLabel1.Text = @"Unit Tab";
                    categoryBindingNavigator.BindingSource = unitBindingSource;
                    break;
                case 2:
                    _tabChoice = Tabs.drugType;
                    toolStripStatusLabel1.Text = @"Drug Type Tab";
                    categoryBindingNavigator.BindingSource = drugTypeBindingSource;
                    break;
                case 3:
                    _tabChoice = Tabs.packing;
                    toolStripStatusLabel1.Text = @"Packing Tab";
                    categoryBindingNavigator.BindingSource = packingBindingSource;
                    break;
                case 4:
                    _tabChoice = Tabs.voidReason;
                    toolStripStatusLabel1.Text = @"Void Reason Tab";
                    categoryBindingNavigator.BindingSource = voidReasonBindingSource;
                    break;
                default:
                    break;
            }
        }

        private void DeleteCategory()
        {
            if (categoryBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (CategoryManager.Delete(((Category)categoryBindingSource.Current).CategoryId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    categoryBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    categoryDataGridView.Focus();
                }
            }
        }

        private void DeleteUnit()
        {
            if (unitBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (UnitManager.Delete(((Unit)unitBindingSource.Current).UnitId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    unitBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    unitDataGridView.Focus();
                }
            }
        }
        private void DeleteDrugType()
        {
            if (categoryBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (DrugTypeManager.Delete(((DrugType)drugTypeBindingSource.Current).DrugTypeId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    drugTypeBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    drugTypeDataGridView.Focus();
                }
            }
        }

        private void DeletePacking()
        {
            if (packingBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (PackingManager.Delete(((Packing)packingBindingSource.Current).PackingId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    packingBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    packingDataGridView.Focus();
                }
            }
        }
        private void DeleteVoidReason()
        {
            if (categoryBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (VoidReasonManager.Delete(((VoidReason)drugTypeBindingSource.Current).VoidReasonId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    voidReasonBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    voidReasonDataGridView.Focus();
                }
            }
        }

        private void categoryDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryBindingSource == null) return;
            if (categoryDataGridView.Rows.Count <= 1) return;
            if (!categoryDataGridView.IsCurrentRowDirty) return;
            Validate();
            categoryBindingSource.EndEdit();
            var iResult = CategoryManager.Save((Category)categoryBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Category saved successfully." : @"Error occurred when saving Unit.";
        }

        private void unitDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (unitBindingSource == null) return;
            if (unitDataGridView.Rows.Count <= 1) return;
            if (!unitDataGridView.IsCurrentRowDirty) return;
            Validate();
            unitBindingSource.EndEdit();
            var iResult = UnitManager.Save((Unit)unitBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Unit saved successfully." : @"Error occurred when saving Unit.";
        }

        private void drugTypeDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (drugTypeBindingSource == null) return;
            if (drugTypeDataGridView.Rows.Count <= 1) return;
            if (!drugTypeDataGridView.IsCurrentRowDirty) return;
            Validate();
            drugTypeBindingSource.EndEdit();
            var iResult = DrugTypeManager.Save((DrugType)drugTypeBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Drug Type saved successfully." : @"Error occurred when saving Unit.";
        }

        private void packingDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (packingBindingSource == null) return;
            if (packingDataGridView.Rows.Count <= 1) return;
            if (!packingDataGridView.IsCurrentRowDirty) return;
            Validate();
            packingBindingSource.EndEdit();
            var iResult = PackingManager.Save((Packing)packingBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Packing saved successfully." : @"Error occurred when saving Unit.";
        }

        private void voidReasonDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (voidReasonBindingSource == null) return;
            if (voidReasonDataGridView.Rows.Count <= 1) return;
            if (!voidReasonDataGridView.IsCurrentRowDirty) return;
            Validate();
            voidReasonBindingSource.EndEdit();
            var iResult = VoidReasonManager.Save((VoidReason)voidReasonBindingSource.Current);
            toolStripStatusLabel1.Text = iResult > 0 ? @"Void Reason saved successfully." : @"Error occurred when saving Unit.";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    _tabChoice = Tabs.category;
                    toolStripStatusLabel1.Text = @"Category Tab";
                    DeleteCategory();
                    break;
                case 1:
                    _tabChoice = Tabs.unit;
                    toolStripStatusLabel1.Text = @"Unit Tab";
                    DeleteUnit();
                    break;
                case 2:
                    _tabChoice = Tabs.drugType;
                    toolStripStatusLabel1.Text = @"Drug Type Tab";
                    DeleteDrugType();
                    break;
                case 3:
                    _tabChoice = Tabs.packing;
                    toolStripStatusLabel1.Text = @"Packing Tab";
                    DeletePacking();
                    break;
                case 4:
                    _tabChoice = Tabs.voidReason;
                    toolStripStatusLabel1.Text = @"Void Reason Tab";
                    DeleteVoidReason();
                    break;
                default:
                    break;
            }
        }
    }
}
