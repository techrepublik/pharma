using System;
using System.Windows.Forms;
using PharmaPos.dal.man;
using PharmaPos.data;

namespace PharmaPos.forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (userBindingSource != null)
                userBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            userNoTextBox.Focus();
            userLevelComboBox.SelectedIndex = 0;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            InitRecord();
        }

        private void InitRecord()
        {
            Cursor.Current = Cursors.WaitCursor;
            userBindingSource.DataSource = UserManager.GetAll();
            Cursor.Current = Cursors.Default;

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (userLevelComboBox.SelectedIndex <= 0) return;
            if (userBindingSource == null) return;
            Validate();
            userBindingSource.EndEdit();
            var iResult = UserManager.Save((User) userBindingSource.Current);
            if (iResult > 0)
            {
                MessageBox.Show(@"Record was successfully saved.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                userNoTextBox.Focus();
            }
            else
            {
                MessageBox.Show(@"Error occurred in saving.", @"Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void DeleteUser()
        {
            if (userBindingSource == null) return;
            var dResult = MessageBox.Show(@"Delete current record?", @"Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dResult == DialogResult.Yes)
            {
                if (UserManager.Delete(((User) userBindingSource.Current).UserId))
                {
                    MessageBox.Show(@"Record was deleted successfully.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    userBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(@"Error on delete operation.", @"Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
